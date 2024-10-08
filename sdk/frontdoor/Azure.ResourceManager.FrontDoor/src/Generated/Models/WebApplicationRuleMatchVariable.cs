// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Request variable to compare with. </summary>
    public readonly partial struct WebApplicationRuleMatchVariable : IEquatable<WebApplicationRuleMatchVariable>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WebApplicationRuleMatchVariable"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WebApplicationRuleMatchVariable(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string RemoteAddrValue = "RemoteAddr";
        private const string RequestMethodValue = "RequestMethod";
        private const string QueryStringValue = "QueryString";
        private const string PostArgsValue = "PostArgs";
        private const string RequestUriValue = "RequestUri";
        private const string RequestHeaderValue = "RequestHeader";
        private const string RequestBodyValue = "RequestBody";
        private const string CookiesValue = "Cookies";
        private const string SocketAddrValue = "SocketAddr";

        /// <summary> RemoteAddr. </summary>
        public static WebApplicationRuleMatchVariable RemoteAddr { get; } = new WebApplicationRuleMatchVariable(RemoteAddrValue);
        /// <summary> RequestMethod. </summary>
        public static WebApplicationRuleMatchVariable RequestMethod { get; } = new WebApplicationRuleMatchVariable(RequestMethodValue);
        /// <summary> QueryString. </summary>
        public static WebApplicationRuleMatchVariable QueryString { get; } = new WebApplicationRuleMatchVariable(QueryStringValue);
        /// <summary> PostArgs. </summary>
        public static WebApplicationRuleMatchVariable PostArgs { get; } = new WebApplicationRuleMatchVariable(PostArgsValue);
        /// <summary> RequestUri. </summary>
        public static WebApplicationRuleMatchVariable RequestUri { get; } = new WebApplicationRuleMatchVariable(RequestUriValue);
        /// <summary> RequestHeader. </summary>
        public static WebApplicationRuleMatchVariable RequestHeader { get; } = new WebApplicationRuleMatchVariable(RequestHeaderValue);
        /// <summary> RequestBody. </summary>
        public static WebApplicationRuleMatchVariable RequestBody { get; } = new WebApplicationRuleMatchVariable(RequestBodyValue);
        /// <summary> Cookies. </summary>
        public static WebApplicationRuleMatchVariable Cookies { get; } = new WebApplicationRuleMatchVariable(CookiesValue);
        /// <summary> SocketAddr. </summary>
        public static WebApplicationRuleMatchVariable SocketAddr { get; } = new WebApplicationRuleMatchVariable(SocketAddrValue);
        /// <summary> Determines if two <see cref="WebApplicationRuleMatchVariable"/> values are the same. </summary>
        public static bool operator ==(WebApplicationRuleMatchVariable left, WebApplicationRuleMatchVariable right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebApplicationRuleMatchVariable"/> values are not the same. </summary>
        public static bool operator !=(WebApplicationRuleMatchVariable left, WebApplicationRuleMatchVariable right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="WebApplicationRuleMatchVariable"/>. </summary>
        public static implicit operator WebApplicationRuleMatchVariable(string value) => new WebApplicationRuleMatchVariable(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebApplicationRuleMatchVariable other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebApplicationRuleMatchVariable other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
