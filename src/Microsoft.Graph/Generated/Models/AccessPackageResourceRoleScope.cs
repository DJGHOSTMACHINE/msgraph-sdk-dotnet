using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class AccessPackageResourceRoleScope : Entity, IParsable {
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>The role property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessPackageResourceRole? Role {
            get { return BackingStore?.Get<AccessPackageResourceRole?>("role"); }
            set { BackingStore?.Set("role", value); }
        }
#nullable restore
#else
        public AccessPackageResourceRole Role {
            get { return BackingStore?.Get<AccessPackageResourceRole>("role"); }
            set { BackingStore?.Set("role", value); }
        }
#endif
        /// <summary>The scope property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AccessPackageResourceScope? Scope {
            get { return BackingStore?.Get<AccessPackageResourceScope?>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#nullable restore
#else
        public AccessPackageResourceScope Scope {
            get { return BackingStore?.Get<AccessPackageResourceScope>("scope"); }
            set { BackingStore?.Set("scope", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AccessPackageResourceRoleScope CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessPackageResourceRoleScope();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"role", n => { Role = n.GetObjectValue<AccessPackageResourceRole>(AccessPackageResourceRole.CreateFromDiscriminatorValue); } },
                {"scope", n => { Scope = n.GetObjectValue<AccessPackageResourceScope>(AccessPackageResourceScope.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<AccessPackageResourceRole>("role", Role);
            writer.WriteObjectValue<AccessPackageResourceScope>("scope", Scope);
        }
    }
}
