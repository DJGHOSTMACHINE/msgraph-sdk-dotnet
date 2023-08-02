using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models.Security {
    public class KubernetesPodEvidence : AlertEvidence, IParsable {
        /// <summary>The containers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ContainerEvidence>? Containers {
            get { return BackingStore?.Get<List<ContainerEvidence>?>("containers"); }
            set { BackingStore?.Set("containers", value); }
        }
#nullable restore
#else
        public List<ContainerEvidence> Containers {
            get { return BackingStore?.Get<List<ContainerEvidence>>("containers"); }
            set { BackingStore?.Set("containers", value); }
        }
#endif
        /// <summary>The controller property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KubernetesControllerEvidence? Controller {
            get { return BackingStore?.Get<KubernetesControllerEvidence?>("controller"); }
            set { BackingStore?.Set("controller", value); }
        }
#nullable restore
#else
        public KubernetesControllerEvidence Controller {
            get { return BackingStore?.Get<KubernetesControllerEvidence>("controller"); }
            set { BackingStore?.Set("controller", value); }
        }
#endif
        /// <summary>The ephemeralContainers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ContainerEvidence>? EphemeralContainers {
            get { return BackingStore?.Get<List<ContainerEvidence>?>("ephemeralContainers"); }
            set { BackingStore?.Set("ephemeralContainers", value); }
        }
#nullable restore
#else
        public List<ContainerEvidence> EphemeralContainers {
            get { return BackingStore?.Get<List<ContainerEvidence>>("ephemeralContainers"); }
            set { BackingStore?.Set("ephemeralContainers", value); }
        }
#endif
        /// <summary>The initContainers property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ContainerEvidence>? InitContainers {
            get { return BackingStore?.Get<List<ContainerEvidence>?>("initContainers"); }
            set { BackingStore?.Set("initContainers", value); }
        }
#nullable restore
#else
        public List<ContainerEvidence> InitContainers {
            get { return BackingStore?.Get<List<ContainerEvidence>>("initContainers"); }
            set { BackingStore?.Set("initContainers", value); }
        }
#endif
        /// <summary>The labels property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Dictionary? Labels {
            get { return BackingStore?.Get<Dictionary?>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
#nullable restore
#else
        public Dictionary Labels {
            get { return BackingStore?.Get<Dictionary>("labels"); }
            set { BackingStore?.Set("labels", value); }
        }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name {
            get { return BackingStore?.Get<string?>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#nullable restore
#else
        public string Name {
            get { return BackingStore?.Get<string>("name"); }
            set { BackingStore?.Set("name", value); }
        }
#endif
        /// <summary>The namespace property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KubernetesNamespaceEvidence? Namespace {
            get { return BackingStore?.Get<KubernetesNamespaceEvidence?>("namespace"); }
            set { BackingStore?.Set("namespace", value); }
        }
#nullable restore
#else
        public KubernetesNamespaceEvidence Namespace {
            get { return BackingStore?.Get<KubernetesNamespaceEvidence>("namespace"); }
            set { BackingStore?.Set("namespace", value); }
        }
#endif
        /// <summary>The podIp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IpEvidence? PodIp {
            get { return BackingStore?.Get<IpEvidence?>("podIp"); }
            set { BackingStore?.Set("podIp", value); }
        }
#nullable restore
#else
        public IpEvidence PodIp {
            get { return BackingStore?.Get<IpEvidence>("podIp"); }
            set { BackingStore?.Set("podIp", value); }
        }
#endif
        /// <summary>The serviceAccount property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public KubernetesServiceAccountEvidence? ServiceAccount {
            get { return BackingStore?.Get<KubernetesServiceAccountEvidence?>("serviceAccount"); }
            set { BackingStore?.Set("serviceAccount", value); }
        }
#nullable restore
#else
        public KubernetesServiceAccountEvidence ServiceAccount {
            get { return BackingStore?.Get<KubernetesServiceAccountEvidence>("serviceAccount"); }
            set { BackingStore?.Set("serviceAccount", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new kubernetesPodEvidence and sets the default values.
        /// </summary>
        public KubernetesPodEvidence() : base() {
            OdataType = "#microsoft.graph.security.kubernetesPodEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new KubernetesPodEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new KubernetesPodEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"containers", n => { Containers = n.GetCollectionOfObjectValues<ContainerEvidence>(ContainerEvidence.CreateFromDiscriminatorValue)?.ToList(); } },
                {"controller", n => { Controller = n.GetObjectValue<KubernetesControllerEvidence>(KubernetesControllerEvidence.CreateFromDiscriminatorValue); } },
                {"ephemeralContainers", n => { EphemeralContainers = n.GetCollectionOfObjectValues<ContainerEvidence>(ContainerEvidence.CreateFromDiscriminatorValue)?.ToList(); } },
                {"initContainers", n => { InitContainers = n.GetCollectionOfObjectValues<ContainerEvidence>(ContainerEvidence.CreateFromDiscriminatorValue)?.ToList(); } },
                {"labels", n => { Labels = n.GetObjectValue<Dictionary>(Dictionary.CreateFromDiscriminatorValue); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"namespace", n => { Namespace = n.GetObjectValue<KubernetesNamespaceEvidence>(KubernetesNamespaceEvidence.CreateFromDiscriminatorValue); } },
                {"podIp", n => { PodIp = n.GetObjectValue<IpEvidence>(IpEvidence.CreateFromDiscriminatorValue); } },
                {"serviceAccount", n => { ServiceAccount = n.GetObjectValue<KubernetesServiceAccountEvidence>(KubernetesServiceAccountEvidence.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ContainerEvidence>("containers", Containers);
            writer.WriteObjectValue<KubernetesControllerEvidence>("controller", Controller);
            writer.WriteCollectionOfObjectValues<ContainerEvidence>("ephemeralContainers", EphemeralContainers);
            writer.WriteCollectionOfObjectValues<ContainerEvidence>("initContainers", InitContainers);
            writer.WriteObjectValue<Dictionary>("labels", Labels);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<KubernetesNamespaceEvidence>("namespace", Namespace);
            writer.WriteObjectValue<IpEvidence>("podIp", PodIp);
            writer.WriteObjectValue<KubernetesServiceAccountEvidence>("serviceAccount", ServiceAccount);
        }
    }
}