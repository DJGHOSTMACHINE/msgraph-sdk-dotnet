using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class PhysicalAddress : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The city.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? City {
            get { return BackingStore?.Get<string?>("city"); }
            set { BackingStore?.Set("city", value); }
        }
#nullable restore
#else
        public string City {
            get { return BackingStore?.Get<string>("city"); }
            set { BackingStore?.Set("city", value); }
        }
#endif
        /// <summary>The country or region. It&apos;s a free-format string value, for example, &apos;United States&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CountryOrRegion {
            get { return BackingStore?.Get<string?>("countryOrRegion"); }
            set { BackingStore?.Set("countryOrRegion", value); }
        }
#nullable restore
#else
        public string CountryOrRegion {
            get { return BackingStore?.Get<string>("countryOrRegion"); }
            set { BackingStore?.Set("countryOrRegion", value); }
        }
#endif
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
        /// <summary>The postal code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PostalCode {
            get { return BackingStore?.Get<string?>("postalCode"); }
            set { BackingStore?.Set("postalCode", value); }
        }
#nullable restore
#else
        public string PostalCode {
            get { return BackingStore?.Get<string>("postalCode"); }
            set { BackingStore?.Set("postalCode", value); }
        }
#endif
        /// <summary>The state.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? State {
            get { return BackingStore?.Get<string?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#nullable restore
#else
        public string State {
            get { return BackingStore?.Get<string>("state"); }
            set { BackingStore?.Set("state", value); }
        }
#endif
        /// <summary>The street.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Street {
            get { return BackingStore?.Get<string?>("street"); }
            set { BackingStore?.Set("street", value); }
        }
#nullable restore
#else
        public string Street {
            get { return BackingStore?.Get<string>("street"); }
            set { BackingStore?.Set("street", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new physicalAddress and sets the default values.
        /// </summary>
        public PhysicalAddress() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PhysicalAddress CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PhysicalAddress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"city", n => { City = n.GetStringValue(); } },
                {"countryOrRegion", n => { CountryOrRegion = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"postalCode", n => { PostalCode = n.GetStringValue(); } },
                {"state", n => { State = n.GetStringValue(); } },
                {"street", n => { Street = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("countryOrRegion", CountryOrRegion);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("street", Street);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}