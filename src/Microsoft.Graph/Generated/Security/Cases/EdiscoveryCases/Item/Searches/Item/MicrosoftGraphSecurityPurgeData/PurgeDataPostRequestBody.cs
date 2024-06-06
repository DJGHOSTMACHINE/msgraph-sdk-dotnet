// <auto-generated/>
using Microsoft.Graph.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Searches.Item.MicrosoftGraphSecurityPurgeData
{
    #pragma warning disable CS1591
    public class PurgeDataPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData
        {
            get { return BackingStore.Get<IDictionary<string, object>>("AdditionalData") ?? new Dictionary<string, object>(); }
            set { BackingStore.Set("AdditionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The purgeAreas property</summary>
        public Microsoft.Graph.Models.Security.PurgeAreas? PurgeAreas
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.PurgeAreas?>("purgeAreas"); }
            set { BackingStore?.Set("purgeAreas", value); }
        }
        /// <summary>The purgeType property</summary>
        public Microsoft.Graph.Models.Security.PurgeType? PurgeType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.PurgeType?>("purgeType"); }
            set { BackingStore?.Set("purgeType", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Searches.Item.MicrosoftGraphSecurityPurgeData.PurgeDataPostRequestBody"/> and sets the default values.
        /// </summary>
        public PurgeDataPostRequestBody()
        {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Searches.Item.MicrosoftGraphSecurityPurgeData.PurgeDataPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Searches.Item.MicrosoftGraphSecurityPurgeData.PurgeDataPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Security.Cases.EdiscoveryCases.Item.Searches.Item.MicrosoftGraphSecurityPurgeData.PurgeDataPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "purgeAreas", n => { PurgeAreas = n.GetEnumValue<Microsoft.Graph.Models.Security.PurgeAreas>(); } },
                { "purgeType", n => { PurgeType = n.GetEnumValue<Microsoft.Graph.Models.Security.PurgeType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<Microsoft.Graph.Models.Security.PurgeAreas>("purgeAreas", PurgeAreas);
            writer.WriteEnumValue<Microsoft.Graph.Models.Security.PurgeType>("purgeType", PurgeType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
