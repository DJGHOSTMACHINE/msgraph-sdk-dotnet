using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models {
    public class AuthenticationMethodsRoot : Entity, IParsable {
        /// <summary>Represents the state of a user&apos;s authentication methods, including which methods are registered and which features the user is registered and capable of (such as multi-factor authentication, self-service password reset, and passwordless authentication).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Microsoft.Graph.Models.UserRegistrationDetails>? UserRegistrationDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserRegistrationDetails>?>("userRegistrationDetails"); }
            set { BackingStore?.Set("userRegistrationDetails", value); }
        }
#nullable restore
#else
        public List<Microsoft.Graph.Models.UserRegistrationDetails> UserRegistrationDetails {
            get { return BackingStore?.Get<List<Microsoft.Graph.Models.UserRegistrationDetails>>("userRegistrationDetails"); }
            set { BackingStore?.Set("userRegistrationDetails", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new AuthenticationMethodsRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationMethodsRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"userRegistrationDetails", n => { UserRegistrationDetails = n.GetCollectionOfObjectValues<Microsoft.Graph.Models.UserRegistrationDetails>(Microsoft.Graph.Models.UserRegistrationDetails.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Models.UserRegistrationDetails>("userRegistrationDetails", UserRegistrationDetails);
        }
    }
}