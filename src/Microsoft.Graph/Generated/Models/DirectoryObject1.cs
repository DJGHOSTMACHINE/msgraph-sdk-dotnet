// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class DirectoryObject1 : Microsoft.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Conceptual container for user and group directory objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.AdministrativeUnit>? AdministrativeUnits
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.AdministrativeUnit>?>("administrativeUnits"); }
            set { BackingStore?.Set("administrativeUnits", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.AdministrativeUnit> AdministrativeUnits
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.AdministrativeUnit>>("administrativeUnits"); }
            set { BackingStore?.Set("administrativeUnits", value); }
        }
#endif
        /// <summary>Group of related custom security attribute definitions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.AttributeSet>? AttributeSets
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.AttributeSet>?>("attributeSets"); }
            set { BackingStore?.Set("attributeSets", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.AttributeSet> AttributeSets
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.AttributeSet>>("attributeSets"); }
            set { BackingStore?.Set("attributeSets", value); }
        }
#endif
        /// <summary>Schema of a custom security attributes (key-value pairs).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.CustomSecurityAttributeDefinition>? CustomSecurityAttributeDefinitions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CustomSecurityAttributeDefinition>?>("customSecurityAttributeDefinitions"); }
            set { BackingStore?.Set("customSecurityAttributeDefinitions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.CustomSecurityAttributeDefinition> CustomSecurityAttributeDefinitions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CustomSecurityAttributeDefinition>>("customSecurityAttributeDefinitions"); }
            set { BackingStore?.Set("customSecurityAttributeDefinitions", value); }
        }
#endif
        /// <summary>Recently deleted items. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.DirectoryObject>? DeletedItems
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.DirectoryObject>?>("deletedItems"); }
            set { BackingStore?.Set("deletedItems", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.DirectoryObject> DeletedItems
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.DirectoryObject>>("deletedItems"); }
            set { BackingStore?.Set("deletedItems", value); }
        }
#endif
        /// <summary>The credentials of the device&apos;s local administrator account backed up to Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.DeviceLocalCredentialInfo>? DeviceLocalCredentials
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.DeviceLocalCredentialInfo>?>("deviceLocalCredentials"); }
            set { BackingStore?.Set("deviceLocalCredentials", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.DeviceLocalCredentialInfo> DeviceLocalCredentials
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.DeviceLocalCredentialInfo>>("deviceLocalCredentials"); }
            set { BackingStore?.Set("deviceLocalCredentials", value); }
        }
#endif
        /// <summary>Configure domain federation with organizations whose identity provider (IdP) supports either the SAML or WS-Fed protocol.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.IdentityProviderBase>? FederationConfigurations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.IdentityProviderBase>?>("federationConfigurations"); }
            set { BackingStore?.Set("federationConfigurations", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.IdentityProviderBase> FederationConfigurations
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.IdentityProviderBase>>("federationConfigurations"); }
            set { BackingStore?.Set("federationConfigurations", value); }
        }
#endif
        /// <summary>A container for on-premises directory synchronization functionalities that are available for the organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.OnPremisesDirectorySynchronization>? OnPremisesSynchronization
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.OnPremisesDirectorySynchronization>?>("onPremisesSynchronization"); }
            set { BackingStore?.Set("onPremisesSynchronization", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.OnPremisesDirectorySynchronization> OnPremisesSynchronization
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.OnPremisesDirectorySynchronization>>("onPremisesSynchronization"); }
            set { BackingStore?.Set("onPremisesSynchronization", value); }
        }
#endif
        /// <summary>The subscriptions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.CompanySubscription>? Subscriptions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CompanySubscription>?>("subscriptions"); }
            set { BackingStore?.Set("subscriptions", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.CompanySubscription> Subscriptions
        {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.CompanySubscription>>("subscriptions"); }
            set { BackingStore?.Set("subscriptions", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.DirectoryObject1"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.DirectoryObject1 CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.DirectoryObject1();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "administrativeUnits", n => { AdministrativeUnits = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.AdministrativeUnit>(Microsoft.Graph.Models.AdministrativeUnit.CreateFromDiscriminatorValue)?.ToList(); } },
                { "attributeSets", n => { AttributeSets = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.AttributeSet>(Microsoft.Graph.Models.AttributeSet.CreateFromDiscriminatorValue)?.ToList(); } },
                { "customSecurityAttributeDefinitions", n => { CustomSecurityAttributeDefinitions = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.CustomSecurityAttributeDefinition>(Microsoft.Graph.Models.CustomSecurityAttributeDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                { "deletedItems", n => { DeletedItems = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.DirectoryObject>(Microsoft.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue)?.ToList(); } },
                { "deviceLocalCredentials", n => { DeviceLocalCredentials = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.DeviceLocalCredentialInfo>(Microsoft.Graph.Models.DeviceLocalCredentialInfo.CreateFromDiscriminatorValue)?.ToList(); } },
                { "federationConfigurations", n => { FederationConfigurations = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.IdentityProviderBase>(Microsoft.Graph.Models.IdentityProviderBase.CreateFromDiscriminatorValue)?.ToList(); } },
                { "onPremisesSynchronization", n => { OnPremisesSynchronization = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.OnPremisesDirectorySynchronization>(Microsoft.Graph.Models.OnPremisesDirectorySynchronization.CreateFromDiscriminatorValue)?.ToList(); } },
                { "subscriptions", n => { Subscriptions = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.CompanySubscription>(Microsoft.Graph.Models.CompanySubscription.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.AdministrativeUnit>("administrativeUnits", AdministrativeUnits);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.AttributeSet>("attributeSets", AttributeSets);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.CustomSecurityAttributeDefinition>("customSecurityAttributeDefinitions", CustomSecurityAttributeDefinitions);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.DirectoryObject>("deletedItems", DeletedItems);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.DeviceLocalCredentialInfo>("deviceLocalCredentials", DeviceLocalCredentials);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.IdentityProviderBase>("federationConfigurations", FederationConfigurations);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.OnPremisesDirectorySynchronization>("onPremisesSynchronization", OnPremisesSynchronization);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.CompanySubscription>("subscriptions", Subscriptions);
        }
    }
}
