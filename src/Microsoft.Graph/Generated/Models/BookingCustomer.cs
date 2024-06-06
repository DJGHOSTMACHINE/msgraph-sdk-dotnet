// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    /// <summary>
    /// Represents a customer of the business.
    /// </summary>
    public class BookingCustomer : Microsoft.Graph.Models.BookingCustomerBase, IParsable
    {
        /// <summary>Addresses associated with the customer. The attribute type of physicalAddress is not supported in v1.0. Internally we map the addresses to the type others.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.PhysicalAddress>? Addresses
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PhysicalAddress>?>("addresses"); }
            set { BackingStore?.Set("addresses", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.PhysicalAddress> Addresses
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.PhysicalAddress>>("addresses"); }
            set { BackingStore?.Set("addresses", value); }
        }
#endif
        /// <summary>The name of the customer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName
        {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName
        {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The SMTP address of the customer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailAddress
        {
            get { return BackingStore?.Get<string?>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#nullable restore
#else
        public string EmailAddress
        {
            get { return BackingStore?.Get<string>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
#endif
        /// <summary>Phone numbers associated with the customer, including home, business and mobile numbers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.Phone>? Phones
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Phone>?>("phones"); }
            set { BackingStore?.Set("phones", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.Phone> Phones
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.Phone>>("phones"); }
            set { BackingStore?.Set("phones", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.BookingCustomer"/> and sets the default values.
        /// </summary>
        public BookingCustomer() : base()
        {
            OdataType = "#microsoft.graph.bookingCustomer";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.BookingCustomer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.BookingCustomer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.BookingCustomer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "addresses", n => { Addresses = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.PhysicalAddress>(Microsoft.Graph.Models.PhysicalAddress.CreateFromDiscriminatorValue)?.ToList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                { "phones", n => { Phones = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.Phone>(Microsoft.Graph.Models.Phone.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.PhysicalAddress>("addresses", Addresses);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.Phone>("phones", Phones);
        }
    }
}
