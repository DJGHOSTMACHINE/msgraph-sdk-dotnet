// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class PrivilegedAccessGroupAssignmentScheduleInstance : Microsoft.Graph.Models.PrivilegedAccessScheduleInstance, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The identifier of the membership or ownership assignment relationship to the group. Required. The possible values are: owner, member,  unknownFutureValue. Supports $filter (eq).</summary>
        public Microsoft.Graph.Models.PrivilegedAccessGroupRelationships? AccessId
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PrivilegedAccessGroupRelationships?>("accessId"); }
            set { BackingStore?.Set("accessId", value); }
        }
        /// <summary>When the request activates a membership or ownership in PIM for groups, this object represents the eligibility request for the group. Otherwise, it is null.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance? ActivatedUsing
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance?>("activatedUsing"); }
            set { BackingStore?.Set("activatedUsing", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance ActivatedUsing
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance>("activatedUsing"); }
            set { BackingStore?.Set("activatedUsing", value); }
        }
#endif
        /// <summary>The identifier of the privilegedAccessGroupAssignmentSchedule from which this instance was created. Required. Supports $filter (eq, ne).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssignmentScheduleId
        {
            get { return BackingStore?.Get<string?>("assignmentScheduleId"); }
            set { BackingStore?.Set("assignmentScheduleId", value); }
        }
#nullable restore
#else
        public string AssignmentScheduleId
        {
            get { return BackingStore?.Get<string>("assignmentScheduleId"); }
            set { BackingStore?.Set("assignmentScheduleId", value); }
        }
#endif
        /// <summary>Indicates whether the membership or ownership assignment is granted through activation of an eligibility or through direct assignment. Required. The possible values are: assigned, activated, unknownFutureValue. Supports $filter (eq).</summary>
        public Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentType? AssignmentType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentType?>("assignmentType"); }
            set { BackingStore?.Set("assignmentType", value); }
        }
        /// <summary>References the group that is the scope of the membership or ownership assignment through PIM for groups. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.Group? Group
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Group?>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.Group Group
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.Group>("group"); }
            set { BackingStore?.Set("group", value); }
        }
#endif
        /// <summary>The identifier of the group representing the scope of the membership or ownership assignment through PIM for groups. Optional. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupId
        {
            get { return BackingStore?.Get<string?>("groupId"); }
            set { BackingStore?.Set("groupId", value); }
        }
#nullable restore
#else
        public string GroupId
        {
            get { return BackingStore?.Get<string>("groupId"); }
            set { BackingStore?.Set("groupId", value); }
        }
#endif
        /// <summary>Indicates whether the assignment is derived from a group assignment. It can further imply whether the caller can manage the assignment schedule. Required. The possible values are: direct, group, unknownFutureValue. Supports $filter (eq).</summary>
        public Microsoft.Graph.Models.PrivilegedAccessGroupMemberType? MemberType
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.PrivilegedAccessGroupMemberType?>("memberType"); }
            set { BackingStore?.Set("memberType", value); }
        }
        /// <summary>References the principal that&apos;s in the scope of the membership or ownership assignment request through the group that&apos;s governed by PIM. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.DirectoryObject? Principal
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DirectoryObject?>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.DirectoryObject Principal
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.DirectoryObject>("principal"); }
            set { BackingStore?.Set("principal", value); }
        }
#endif
        /// <summary>The identifier of the principal whose membership or ownership assignment to the group is managed through PIM for groups. Required. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrincipalId
        {
            get { return BackingStore?.Get<string?>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#nullable restore
#else
        public string PrincipalId
        {
            get { return BackingStore?.Get<string>("principalId"); }
            set { BackingStore?.Set("principalId", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleInstance"/> and sets the default values.
        /// </summary>
        public PrivilegedAccessGroupAssignmentScheduleInstance() : base()
        {
            OdataType = "#microsoft.graph.privilegedAccessGroupAssignmentScheduleInstance";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleInstance"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleInstance CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentScheduleInstance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessId", n => { AccessId = n.GetEnumValue<Microsoft.Graph.Models.PrivilegedAccessGroupRelationships>(); } },
                { "activatedUsing", n => { ActivatedUsing = n.GetObjectValue<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance>(Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance.CreateFromDiscriminatorValue); } },
                { "assignmentScheduleId", n => { AssignmentScheduleId = n.GetStringValue(); } },
                { "assignmentType", n => { AssignmentType = n.GetEnumValue<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentType>(); } },
                { "group", n => { Group = n.GetObjectValue<Microsoft.Graph.Models.Group>(Microsoft.Graph.Models.Group.CreateFromDiscriminatorValue); } },
                { "groupId", n => { GroupId = n.GetStringValue(); } },
                { "memberType", n => { MemberType = n.GetEnumValue<Microsoft.Graph.Models.PrivilegedAccessGroupMemberType>(); } },
                { "principal", n => { Principal = n.GetObjectValue<Microsoft.Graph.Models.DirectoryObject>(Microsoft.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue); } },
                { "principalId", n => { PrincipalId = n.GetStringValue(); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Models.PrivilegedAccessGroupRelationships>("accessId", AccessId);
            writer.WriteObjectValue<Microsoft.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance>("activatedUsing", ActivatedUsing);
            writer.WriteStringValue("assignmentScheduleId", AssignmentScheduleId);
            writer.WriteEnumValue<Microsoft.Graph.Models.PrivilegedAccessGroupAssignmentType>("assignmentType", AssignmentType);
            writer.WriteObjectValue<Microsoft.Graph.Models.Group>("group", Group);
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteEnumValue<Microsoft.Graph.Models.PrivilegedAccessGroupMemberType>("memberType", MemberType);
            writer.WriteObjectValue<Microsoft.Graph.Models.DirectoryObject>("principal", Principal);
            writer.WriteStringValue("principalId", PrincipalId);
        }
    }
}
