// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class FilterClause : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Name of the operator to be applied to the source and target operands. Must be one of the supported operators. Supported operators can be discovered.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatorName {
            get { return BackingStore?.Get<string?>("operatorName"); }
            set { BackingStore?.Set("operatorName", value); }
        }
#nullable restore
#else
        public string OperatorName {
            get { return BackingStore?.Get<string>("operatorName"); }
            set { BackingStore?.Set("operatorName", value); }
        }
#endif
        /// <summary>Name of source operand (the operand being tested). The source operand name must match one of the attribute names on the source object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceOperandName {
            get { return BackingStore?.Get<string?>("sourceOperandName"); }
            set { BackingStore?.Set("sourceOperandName", value); }
        }
#nullable restore
#else
        public string SourceOperandName {
            get { return BackingStore?.Get<string>("sourceOperandName"); }
            set { BackingStore?.Set("sourceOperandName", value); }
        }
#endif
        /// <summary>Values that the source operand will be tested against.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public FilterOperand? TargetOperand {
            get { return BackingStore?.Get<FilterOperand?>("targetOperand"); }
            set { BackingStore?.Set("targetOperand", value); }
        }
#nullable restore
#else
        public FilterOperand TargetOperand {
            get { return BackingStore?.Get<FilterOperand>("targetOperand"); }
            set { BackingStore?.Set("targetOperand", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new filterClause and sets the default values.
        /// </summary>
        public FilterClause() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FilterClause CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FilterClause();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"operatorName", n => { OperatorName = n.GetStringValue(); } },
                {"sourceOperandName", n => { SourceOperandName = n.GetStringValue(); } },
                {"targetOperand", n => { TargetOperand = n.GetObjectValue<FilterOperand>(FilterOperand.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("operatorName", OperatorName);
            writer.WriteStringValue("sourceOperandName", SourceOperandName);
            writer.WriteObjectValue<FilterOperand>("targetOperand", TargetOperand);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
