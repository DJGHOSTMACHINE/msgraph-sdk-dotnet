using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Drives.Item.Items.Item.Workbook.Functions.ReplaceB {
    public class ReplaceBPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The newText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? NewText {
            get { return BackingStore?.Get<Json?>("newText"); }
            set { BackingStore?.Set("newText", value); }
        }
#nullable restore
#else
        public Json NewText {
            get { return BackingStore?.Get<Json>("newText"); }
            set { BackingStore?.Set("newText", value); }
        }
#endif
        /// <summary>The numBytes property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? NumBytes {
            get { return BackingStore?.Get<Json?>("numBytes"); }
            set { BackingStore?.Set("numBytes", value); }
        }
#nullable restore
#else
        public Json NumBytes {
            get { return BackingStore?.Get<Json>("numBytes"); }
            set { BackingStore?.Set("numBytes", value); }
        }
#endif
        /// <summary>The oldText property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? OldText {
            get { return BackingStore?.Get<Json?>("oldText"); }
            set { BackingStore?.Set("oldText", value); }
        }
#nullable restore
#else
        public Json OldText {
            get { return BackingStore?.Get<Json>("oldText"); }
            set { BackingStore?.Set("oldText", value); }
        }
#endif
        /// <summary>The startNum property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Json? StartNum {
            get { return BackingStore?.Get<Json?>("startNum"); }
            set { BackingStore?.Set("startNum", value); }
        }
#nullable restore
#else
        public Json StartNum {
            get { return BackingStore?.Get<Json>("startNum"); }
            set { BackingStore?.Set("startNum", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new replaceBPostRequestBody and sets the default values.
        /// </summary>
        public ReplaceBPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ReplaceBPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ReplaceBPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"newText", n => { NewText = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"numBytes", n => { NumBytes = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"oldText", n => { OldText = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
                {"startNum", n => { StartNum = n.GetObjectValue<Json>(Json.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Json>("newText", NewText);
            writer.WriteObjectValue<Json>("numBytes", NumBytes);
            writer.WriteObjectValue<Json>("oldText", OldText);
            writer.WriteObjectValue<Json>("startNum", StartNum);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}