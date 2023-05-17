using System.Runtime.Serialization;
using System;
namespace Microsoft.Graph.Models.ExternalConnectors {
    public enum ExternalActivityType {
        [EnumMember(Value = "viewed")]
        Viewed,
        [EnumMember(Value = "modified")]
        Modified,
        [EnumMember(Value = "created")]
        Created,
        [EnumMember(Value = "commented")]
        Commented,
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
