using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class Subscription : Entity, IParsable {
        /// <summary>Optional. Identifier of the application used to create the subscription. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationId {
            get { return BackingStore?.Get<string?>("applicationId"); }
            set { BackingStore?.Set("applicationId", value); }
        }
#nullable restore
#else
        public string ApplicationId {
            get { return BackingStore?.Get<string>("applicationId"); }
            set { BackingStore?.Set("applicationId", value); }
        }
#endif
        /// <summary>Required. Indicates the type of change in the subscribed resource that will raise a change notification. The supported values are: created, updated, deleted. Multiple values can be combined using a comma-separated list. Note:  Drive root item and list change notifications support only the updated changeType. User and group change notifications support updated and deleted changeType. Use updated to receive notifications when user or group is created, updated or soft deleted.  Use deleted to receive notifications when user or group is permanently deleted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChangeType {
            get { return BackingStore?.Get<string?>("changeType"); }
            set { BackingStore?.Set("changeType", value); }
        }
#nullable restore
#else
        public string ChangeType {
            get { return BackingStore?.Get<string>("changeType"); }
            set { BackingStore?.Set("changeType", value); }
        }
#endif
        /// <summary>Required. Specifies the value of the clientState property sent by the service in each change notification. The maximum length is 128 characters. The client can check that the change notification came from the service by comparing the value of the clientState property sent with the subscription with the value of the clientState property received with each change notification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClientState {
            get { return BackingStore?.Get<string?>("clientState"); }
            set { BackingStore?.Set("clientState", value); }
        }
#nullable restore
#else
        public string ClientState {
            get { return BackingStore?.Get<string>("clientState"); }
            set { BackingStore?.Set("clientState", value); }
        }
#endif
        /// <summary>Optional. Identifier of the user or service principal that created the subscription. If the app used delegated permissions to create the subscription, this field contains the id of the signed-in user the app called on behalf of. If the app used application permissions, this field contains the id of the service principal corresponding to the app. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatorId {
            get { return BackingStore?.Get<string?>("creatorId"); }
            set { BackingStore?.Set("creatorId", value); }
        }
#nullable restore
#else
        public string CreatorId {
            get { return BackingStore?.Get<string>("creatorId"); }
            set { BackingStore?.Set("creatorId", value); }
        }
#endif
        /// <summary>Optional. A base64-encoded representation of a certificate with a public key used to encrypt resource data in change notifications. Optional but required when includeResourceData is true.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EncryptionCertificate {
            get { return BackingStore?.Get<string?>("encryptionCertificate"); }
            set { BackingStore?.Set("encryptionCertificate", value); }
        }
#nullable restore
#else
        public string EncryptionCertificate {
            get { return BackingStore?.Get<string>("encryptionCertificate"); }
            set { BackingStore?.Set("encryptionCertificate", value); }
        }
#endif
        /// <summary>Optional. A custom app-provided identifier to help identify the certificate needed to decrypt resource data.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EncryptionCertificateId {
            get { return BackingStore?.Get<string?>("encryptionCertificateId"); }
            set { BackingStore?.Set("encryptionCertificateId", value); }
        }
#nullable restore
#else
        public string EncryptionCertificateId {
            get { return BackingStore?.Get<string>("encryptionCertificateId"); }
            set { BackingStore?.Set("encryptionCertificateId", value); }
        }
#endif
        /// <summary>Required. Specifies the date and time when the webhook subscription expires. The time is in UTC, and can be an amount of time from subscription creation that varies for the resource subscribed to. For the maximum supported subscription length of time, see the table below.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>Optional. When set to true, change notifications include resource data (such as content of a chat message).</summary>
        public bool? IncludeResourceData {
            get { return BackingStore?.Get<bool?>("includeResourceData"); }
            set { BackingStore?.Set("includeResourceData", value); }
        }
        /// <summary>Optional. Specifies the latest version of Transport Layer Security (TLS) that the notification endpoint, specified by notificationUrl, supports. The possible values are: v10, v11, v12, v13. For subscribers whose notification endpoint supports a version lower than the currently recommended version (TLS 1.2), specifying this property by a set timeline allows them to temporarily use their deprecated version of TLS before completing their upgrade to TLS 1.2. For these subscribers, not setting this property per the timeline would result in subscription operations failing. For subscribers whose notification endpoint already supports TLS 1.2, setting this property is optional. In such cases, Microsoft Graph defaults the property to v1_2.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LatestSupportedTlsVersion {
            get { return BackingStore?.Get<string?>("latestSupportedTlsVersion"); }
            set { BackingStore?.Set("latestSupportedTlsVersion", value); }
        }
#nullable restore
#else
        public string LatestSupportedTlsVersion {
            get { return BackingStore?.Get<string>("latestSupportedTlsVersion"); }
            set { BackingStore?.Set("latestSupportedTlsVersion", value); }
        }
#endif
        /// <summary>Required for Teams resources if  the expirationDateTime value is more than 1 hour from now; optional otherwise. The URL of the endpoint that receives lifecycle notifications, including subscriptionRemoved, reauthorizationRequired, and missed notifications. This URL must make use of the HTTPS protocol. For more information, see Reduce missing subscriptions and change notifications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LifecycleNotificationUrl {
            get { return BackingStore?.Get<string?>("lifecycleNotificationUrl"); }
            set { BackingStore?.Set("lifecycleNotificationUrl", value); }
        }
#nullable restore
#else
        public string LifecycleNotificationUrl {
            get { return BackingStore?.Get<string>("lifecycleNotificationUrl"); }
            set { BackingStore?.Set("lifecycleNotificationUrl", value); }
        }
#endif
        /// <summary>Optional. OData query options for specifying value for the targeting resource. Clients receive notifications when resource reaches the state matching the query options provided here. With this new property in the subscription creation payload along with all existing properties, Webhooks will deliver notifications whenever a resource reaches the desired state mentioned in the notificationQueryOptions property. For example, when the print job is completed or when a print job resource isFetchable property value becomes true etc.  Supported only for Universal Print Service. For more information, see Subscribe to change notifications from cloud printing APIs using Microsoft Graph.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationQueryOptions {
            get { return BackingStore?.Get<string?>("notificationQueryOptions"); }
            set { BackingStore?.Set("notificationQueryOptions", value); }
        }
#nullable restore
#else
        public string NotificationQueryOptions {
            get { return BackingStore?.Get<string>("notificationQueryOptions"); }
            set { BackingStore?.Set("notificationQueryOptions", value); }
        }
#endif
        /// <summary>Required. The URL of the endpoint that will receive the change notifications. This URL must make use of the HTTPS protocol. Any query string parameter included in the notificationUrl property will be included in the HTTP POST request when Microsoft Graph sends the change notifications.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationUrl {
            get { return BackingStore?.Get<string?>("notificationUrl"); }
            set { BackingStore?.Set("notificationUrl", value); }
        }
#nullable restore
#else
        public string NotificationUrl {
            get { return BackingStore?.Get<string>("notificationUrl"); }
            set { BackingStore?.Set("notificationUrl", value); }
        }
#endif
        /// <summary>Optional. The app ID that the subscription service can use to generate the validation token. This allows the client to validate the authenticity of the notification received.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationUrlAppId {
            get { return BackingStore?.Get<string?>("notificationUrlAppId"); }
            set { BackingStore?.Set("notificationUrlAppId", value); }
        }
#nullable restore
#else
        public string NotificationUrlAppId {
            get { return BackingStore?.Get<string>("notificationUrlAppId"); }
            set { BackingStore?.Set("notificationUrlAppId", value); }
        }
#endif
        /// <summary>Required. Specifies the resource that will be monitored for changes. Do not include the base URL (https://graph.microsoft.com/v1.0/). See the possible resource path values for each supported resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Resource {
            get { return BackingStore?.Get<string?>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#nullable restore
#else
        public string Resource {
            get { return BackingStore?.Get<string>("resource"); }
            set { BackingStore?.Set("resource", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Subscription CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Subscription();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationId", n => { ApplicationId = n.GetStringValue(); } },
                {"changeType", n => { ChangeType = n.GetStringValue(); } },
                {"clientState", n => { ClientState = n.GetStringValue(); } },
                {"creatorId", n => { CreatorId = n.GetStringValue(); } },
                {"encryptionCertificate", n => { EncryptionCertificate = n.GetStringValue(); } },
                {"encryptionCertificateId", n => { EncryptionCertificateId = n.GetStringValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"includeResourceData", n => { IncludeResourceData = n.GetBoolValue(); } },
                {"latestSupportedTlsVersion", n => { LatestSupportedTlsVersion = n.GetStringValue(); } },
                {"lifecycleNotificationUrl", n => { LifecycleNotificationUrl = n.GetStringValue(); } },
                {"notificationQueryOptions", n => { NotificationQueryOptions = n.GetStringValue(); } },
                {"notificationUrl", n => { NotificationUrl = n.GetStringValue(); } },
                {"notificationUrlAppId", n => { NotificationUrlAppId = n.GetStringValue(); } },
                {"resource", n => { Resource = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("applicationId", ApplicationId);
            writer.WriteStringValue("changeType", ChangeType);
            writer.WriteStringValue("clientState", ClientState);
            writer.WriteStringValue("creatorId", CreatorId);
            writer.WriteStringValue("encryptionCertificate", EncryptionCertificate);
            writer.WriteStringValue("encryptionCertificateId", EncryptionCertificateId);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteBoolValue("includeResourceData", IncludeResourceData);
            writer.WriteStringValue("latestSupportedTlsVersion", LatestSupportedTlsVersion);
            writer.WriteStringValue("lifecycleNotificationUrl", LifecycleNotificationUrl);
            writer.WriteStringValue("notificationQueryOptions", NotificationQueryOptions);
            writer.WriteStringValue("notificationUrl", NotificationUrl);
            writer.WriteStringValue("notificationUrlAppId", NotificationUrlAppId);
            writer.WriteStringValue("resource", Resource);
        }
    }
}
