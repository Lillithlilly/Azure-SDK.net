// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The CompressionCodec. </summary>
    public readonly partial struct CompressionCodec : IEquatable<CompressionCodec>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CompressionCodec"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CompressionCodec(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string Bzip2Value = "bzip2";
        private const string GzipValue = "gzip";
        private const string DeflateValue = "deflate";
        private const string ZipDeflateValue = "zipDeflate";
        private const string SnappyValue = "snappy";
        private const string Lz4Value = "lz4";
        private const string TarValue = "tar";
        private const string TarGZipValue = "tarGZip";

        /// <summary> bzip2. </summary>
        public static CompressionCodec Bzip2 { get; } = new CompressionCodec(Bzip2Value);
        /// <summary> gzip. </summary>
        public static CompressionCodec Gzip { get; } = new CompressionCodec(GzipValue);
        /// <summary> deflate. </summary>
        public static CompressionCodec Deflate { get; } = new CompressionCodec(DeflateValue);
        /// <summary> zipDeflate. </summary>
        public static CompressionCodec ZipDeflate { get; } = new CompressionCodec(ZipDeflateValue);
        /// <summary> snappy. </summary>
        public static CompressionCodec Snappy { get; } = new CompressionCodec(SnappyValue);
        /// <summary> lz4. </summary>
        public static CompressionCodec Lz4 { get; } = new CompressionCodec(Lz4Value);
        /// <summary> tar. </summary>
        public static CompressionCodec Tar { get; } = new CompressionCodec(TarValue);
        /// <summary> tarGZip. </summary>
        public static CompressionCodec TarGZip { get; } = new CompressionCodec(TarGZipValue);
        /// <summary> Determines if two <see cref="CompressionCodec"/> values are the same. </summary>
        public static bool operator ==(CompressionCodec left, CompressionCodec right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CompressionCodec"/> values are not the same. </summary>
        public static bool operator !=(CompressionCodec left, CompressionCodec right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CompressionCodec"/>. </summary>
        public static implicit operator CompressionCodec(string value) => new CompressionCodec(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CompressionCodec other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CompressionCodec other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}