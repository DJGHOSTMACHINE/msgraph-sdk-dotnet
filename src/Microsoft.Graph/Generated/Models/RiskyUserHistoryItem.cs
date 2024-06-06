// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class RiskyUserHistoryItem : Microsoft.Graph.Models.RiskyUser, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The activity related to user risk level change.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.RiskUserActivity? Activity
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.RiskUserActivity?>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.RiskUserActivity Activity
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.RiskUserActivity>("activity"); }
            set { BackingStore?.Set("activity", value); }
        }
#endif
        /// <summary>The ID of actor that does the operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InitiatedBy
        {
            get { return BackingStore?.Get<string?>("initiatedBy"); }
            set { BackingStore?.Set("initiatedBy", value); }
        }
#nullable restore
#else
        public string InitiatedBy
        {
            get { return BackingStore?.Get<string>("initiatedBy"); }
            set { BackingStore?.Set("initiatedBy", value); }
        }
#endif
        /// <summary>The ID of the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId
        {
            get { return BackingStore?.Get<string?>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#nullable restore
#else
        public string UserId
        {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.RiskyUserHistoryItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.RiskyUserHistoryItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.RiskyUserHistoryItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activity", n => { Activity = n.GetObjectValue<Microsoft.Graph.Models.RiskUserActivity>(Microsoft.Graph.Models.RiskUserActivity.CreateFromDiscriminatorValue); } },
                { "initiatedBy", n => { InitiatedBy = n.GetStringValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.RiskUserActivity>("activity", Activity);
            writer.WriteStringValue("initiatedBy", InitiatedBy);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
