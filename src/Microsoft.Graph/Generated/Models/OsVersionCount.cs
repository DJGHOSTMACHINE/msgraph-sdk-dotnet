// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Count of devices with malware for each OS version
    /// </summary>
    public class OsVersionCount : IAdditionalDataHolder, IBackedModel, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Count of devices with malware for the OS version</summary>
        public int? DeviceCount
        {
            get { return BackingStore?.Get<int?>("deviceCount"); }
            set { BackingStore?.Set("deviceCount", value); }
        }
        /// <summary>The Timestamp of the last update for the device count in UTC</summary>
        public DateTimeOffset? LastUpdateDateTime
        {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdateDateTime"); }
            set { BackingStore?.Set("lastUpdateDateTime", value); }
        }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType
        {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType
        {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>OS version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsVersion
        {
            get { return BackingStore?.Get<string?>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#nullable restore
#else
        public string OsVersion
        {
            get { return BackingStore?.Get<string>("osVersion"); }
            set { BackingStore?.Set("osVersion", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.OsVersionCount"/> and sets the default values.
        /// </summary>
        public OsVersionCount()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.OsVersionCount"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Models.OsVersionCount CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.OsVersionCount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "deviceCount", n => { DeviceCount = n.GetIntValue(); } },
                { "lastUpdateDateTime", n => { LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "osVersion", n => { OsVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("deviceCount", DeviceCount);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
