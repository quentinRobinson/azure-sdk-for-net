﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Azure.Core.Serialization;
using Azure.Core.TestFramework;
using Azure.Messaging.EventGrid.SystemEvents;
using NUnit.Framework;

namespace Azure.Messaging.EventGrid.Tests.Samples
{
    public partial class EventGridSamples : SamplesBase<EventGridTestEnvironment>
    {
        // Example JSON payloads
        private readonly string jsonPayloadSampleOne = "[{ \"id\": \"2d1781af-3a4c\", \"topic\": \"/examples/test/payload\", \"subject\": \"\",  \"data\": { \"Name\": \"example\",\"Age\": 20 },\"eventType\": \"MyApp.Models.CustomEventType\",\"eventTime\": \"2018-01-25T22:12:19.4556811Z\",\"dataVersion\": \"1\"}]";

        private readonly string jsonPayloadSampleTwo = "[{ \"id\": \"2d1781af-3a4c\", \"source\": \"/examples/test/payload\", \"data\": { \"name\": \"example\",\"age\": 20 },\"type\": \"MyApp.Models.CustomEventType\",\"time\": \"2018-01-25T22:12:19.4556811Z\",\"specversion\": \"1.0\"}]";

        // This sample demonstrates how to parse EventGridEvents from JSON and access event data using TryGetSystemEventData
        [Test]
        public void NonGenericReceiveAndDeserializeEventGridEvents()
        {
            var httpContent = new BinaryData(jsonPayloadSampleOne).ToStream();
            #region Snippet:EGEventParseJson
            // Parse the JSON payload into a list of events
            EventGridEvent[] egEvents = EventGridEvent.ParseMany(BinaryData.FromStream(httpContent));
            #endregion

            // Iterate over each event to access event properties and data
            #region Snippet:DeserializePayloadUsingAsSystemEventData
            foreach (EventGridEvent egEvent in egEvents)
            {
                // If the event is a system event, TryGetSystemEventData will return the deserialized system event
                if (egEvent.TryGetSystemEventData(out object systemEvent))
                {
                    switch (systemEvent)
                    {
                        case SubscriptionValidationEventData subscriptionValidated:
                            Console.WriteLine(subscriptionValidated.ValidationCode);
                            break;
                        case StorageBlobCreatedEventData blobCreated:
                            Console.WriteLine(blobCreated.BlobType);
                            break;
                        // Handle any other system event type
                        default:
                            Console.WriteLine(egEvent.EventType);
                            // we can get the raw Json for the event using Data
                            Console.WriteLine(egEvent.Data.ToString());
                            break;
                    }
                }
                else
                {
                    switch (egEvent.EventType)
                    {
                        case "MyApp.Models.CustomEventType":
                            TestPayload deserializedEventData = egEvent.Data.ToObjectFromJson<TestPayload>();
                            Console.WriteLine(deserializedEventData.Name);
                            break;
                        // Handle any other custom event type
                        default:
                            Console.Write(egEvent.EventType);
                            Console.WriteLine(egEvent.Data.ToString());
                            break;
                    }
                }
            }
            #endregion
        }

        // This sample demonstrates how to parse CloudEvents from JSON and access event data using ToObjectFromJson
        [Test]
        public async Task GenericReceiveAndDeserializeEventGridEvents()
        {
            // Example of a custom ObjectSerializer used to deserialize the event payload
            JsonObjectSerializer myCustomSerializer = new JsonObjectSerializer(
            new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            });

            var httpContent = new StreamContent(new BinaryData(jsonPayloadSampleTwo).ToStream());
            #region Snippet:CloudEventParseJson
            var bytes = await httpContent.ReadAsByteArrayAsync();
            // Parse the JSON payload into a list of events
            CloudEvent[] cloudEvents = CloudEvent.ParseMany(new BinaryData(bytes));
            #endregion

            // Iterate over each event to access event properties and data
            #region Snippet:DeserializePayloadUsingGenericGetData
            foreach (CloudEvent cloudEvent in cloudEvents)
            {
                switch (cloudEvent.Type)
                {
                    case "Contoso.Items.ItemReceived":
                        // By default, ToObjectFromJson<T> uses System.Text.Json to deserialize the payload
                        ContosoItemReceivedEventData itemReceived = cloudEvent.Data.ToObjectFromJson<ContosoItemReceivedEventData>();
                        Console.WriteLine(itemReceived.ItemSku);
                        break;
                    case "MyApp.Models.CustomEventType":
                        // One can also specify a custom ObjectSerializer as needed to deserialize the payload correctly
                        TestPayload testPayload = cloudEvent.Data.ToObject<TestPayload>(myCustomSerializer);
                        Console.WriteLine(testPayload.Name);
                        break;
                    case SystemEventNames.StorageBlobDeleted:
                        // Example for deserializing system events using ToObjectFromJson<T>
                        StorageBlobDeletedEventData blobDeleted = cloudEvent.Data.ToObjectFromJson<StorageBlobDeletedEventData>();
                        Console.WriteLine(blobDeleted.BlobType);
                        break;
                }
            }
            #endregion
        }
    }
}
