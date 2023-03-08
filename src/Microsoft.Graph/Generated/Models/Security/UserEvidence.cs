using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models.Security {
    public class UserEvidence : AlertEvidence, IParsable {
        /// <summary>The user account details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Security.UserAccount? UserAccount {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.UserAccount?>("userAccount"); }
            set { BackingStore?.Set("userAccount", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Security.UserAccount UserAccount {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Security.UserAccount>("userAccount"); }
            set { BackingStore?.Set("userAccount", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new UserEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"userAccount", n => { UserAccount = n.GetObjectValue<Microsoft.Graph.Models.Security.UserAccount>(Microsoft.Graph.Models.Security.UserAccount.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Models.Security.UserAccount>("userAccount", UserAccount);
        }
    }
}