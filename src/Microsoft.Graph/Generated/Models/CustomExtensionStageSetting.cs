using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class CustomExtensionStageSetting : Entity, IParsable {
        /// <summary>Indicates the custom workflow extension that will be executed at this stage. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CustomCalloutExtension? CustomExtension {
            get { return BackingStore?.Get<CustomCalloutExtension?>("customExtension"); }
            set { BackingStore?.Set("customExtension", value); }
        }
#nullable restore
#else
        public CustomCalloutExtension CustomExtension {
            get { return BackingStore?.Get<CustomCalloutExtension>("customExtension"); }
            set { BackingStore?.Set("customExtension", value); }
        }
#endif
        /// <summary>The stage property</summary>
        public AccessPackageCustomExtensionStage? Stage {
            get { return BackingStore?.Get<AccessPackageCustomExtensionStage?>("stage"); }
            set { BackingStore?.Set("stage", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new CustomExtensionStageSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomExtensionStageSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"customExtension", n => { CustomExtension = n.GetObjectValue<CustomCalloutExtension>(CustomCalloutExtension.CreateFromDiscriminatorValue); } },
                {"stage", n => { Stage = n.GetEnumValue<AccessPackageCustomExtensionStage>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<CustomCalloutExtension>("customExtension", CustomExtension);
            writer.WriteEnumValue<AccessPackageCustomExtensionStage>("stage", Stage);
        }
    }
}