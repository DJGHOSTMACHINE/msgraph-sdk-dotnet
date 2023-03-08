using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class Endpoint : DirectoryObject, IParsable {
        /// <summary>The capability property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Capability {
            get { return BackingStore?.Get<string?>("capability"); }
            set { BackingStore?.Set("capability", value); }
        }
#nullable restore
#else
        public string Capability {
            get { return BackingStore?.Get<string>("capability"); }
            set { BackingStore?.Set("capability", value); }
        }
#endif
        /// <summary>The providerId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProviderId {
            get { return BackingStore?.Get<string?>("providerId"); }
            set { BackingStore?.Set("providerId", value); }
        }
#nullable restore
#else
        public string ProviderId {
            get { return BackingStore?.Get<string>("providerId"); }
            set { BackingStore?.Set("providerId", value); }
        }
#endif
        /// <summary>The providerName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProviderName {
            get { return BackingStore?.Get<string?>("providerName"); }
            set { BackingStore?.Set("providerName", value); }
        }
#nullable restore
#else
        public string ProviderName {
            get { return BackingStore?.Get<string>("providerName"); }
            set { BackingStore?.Set("providerName", value); }
        }
#endif
        /// <summary>The providerResourceId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProviderResourceId {
            get { return BackingStore?.Get<string?>("providerResourceId"); }
            set { BackingStore?.Set("providerResourceId", value); }
        }
#nullable restore
#else
        public string ProviderResourceId {
            get { return BackingStore?.Get<string>("providerResourceId"); }
            set { BackingStore?.Set("providerResourceId", value); }
        }
#endif
        /// <summary>The uri property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uri {
            get { return BackingStore?.Get<string?>("uri"); }
            set { BackingStore?.Set("uri", value); }
        }
#nullable restore
#else
        public string Uri {
            get { return BackingStore?.Get<string>("uri"); }
            set { BackingStore?.Set("uri", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new endpoint and sets the default values.
        /// </summary>
        public Endpoint() : base() {
            OdataType = "#microsoft.graph.endpoint";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Endpoint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Endpoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"capability", n => { Capability = n.GetStringValue(); } },
                {"providerId", n => { ProviderId = n.GetStringValue(); } },
                {"providerName", n => { ProviderName = n.GetStringValue(); } },
                {"providerResourceId", n => { ProviderResourceId = n.GetStringValue(); } },
                {"uri", n => { Uri = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("capability", Capability);
            writer.WriteStringValue("providerId", ProviderId);
            writer.WriteStringValue("providerName", ProviderName);
            writer.WriteStringValue("providerResourceId", ProviderResourceId);
            writer.WriteStringValue("uri", Uri);
        }
    }
}