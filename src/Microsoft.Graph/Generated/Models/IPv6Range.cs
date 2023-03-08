using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class IPv6Range : IpRange, IParsable {
        /// <summary>Lower address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LowerAddress {
            get { return BackingStore?.Get<string?>("lowerAddress"); }
            set { BackingStore?.Set("lowerAddress", value); }
        }
#nullable restore
#else
        public string LowerAddress {
            get { return BackingStore?.Get<string>("lowerAddress"); }
            set { BackingStore?.Set("lowerAddress", value); }
        }
#endif
        /// <summary>Upper address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UpperAddress {
            get { return BackingStore?.Get<string?>("upperAddress"); }
            set { BackingStore?.Set("upperAddress", value); }
        }
#nullable restore
#else
        public string UpperAddress {
            get { return BackingStore?.Get<string>("upperAddress"); }
            set { BackingStore?.Set("upperAddress", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new IPv6Range and sets the default values.
        /// </summary>
        public IPv6Range() : base() {
            OdataType = "#microsoft.graph.iPv6Range";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new IPv6Range CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IPv6Range();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lowerAddress", n => { LowerAddress = n.GetStringValue(); } },
                {"upperAddress", n => { UpperAddress = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("lowerAddress", LowerAddress);
            writer.WriteStringValue("upperAddress", UpperAddress);
        }
    }
}