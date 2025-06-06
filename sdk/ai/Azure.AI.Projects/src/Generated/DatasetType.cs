// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Projects
{
    /// <summary> Enum to determine the type of data. </summary>
    internal readonly partial struct DatasetType : IEquatable<DatasetType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DatasetType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DatasetType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UriFileValue = "uri_file";
        private const string UriFolderValue = "uri_folder";

        /// <summary> URI file. </summary>
        public static DatasetType UriFile { get; } = new DatasetType(UriFileValue);
        /// <summary> URI folder. </summary>
        public static DatasetType UriFolder { get; } = new DatasetType(UriFolderValue);
        /// <summary> Determines if two <see cref="DatasetType"/> values are the same. </summary>
        public static bool operator ==(DatasetType left, DatasetType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DatasetType"/> values are not the same. </summary>
        public static bool operator !=(DatasetType left, DatasetType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DatasetType"/>. </summary>
        public static implicit operator DatasetType(string value) => new DatasetType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DatasetType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DatasetType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
