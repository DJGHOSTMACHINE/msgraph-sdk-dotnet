using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Models {
    public class OnlineMeeting : Entity, IParsable {
        /// <summary>Indicates whether attendees can turn on their camera.</summary>
        public bool? AllowAttendeeToEnableCamera {
            get { return BackingStore?.Get<bool?>("allowAttendeeToEnableCamera"); }
            set { BackingStore?.Set("allowAttendeeToEnableCamera", value); }
        }
        /// <summary>Indicates whether attendees can turn on their microphone.</summary>
        public bool? AllowAttendeeToEnableMic {
            get { return BackingStore?.Get<bool?>("allowAttendeeToEnableMic"); }
            set { BackingStore?.Set("allowAttendeeToEnableMic", value); }
        }
        /// <summary>Indicates whether Teams reactions are enabled for the meeting.</summary>
        public bool? AllowTeamworkReactions {
            get { return BackingStore?.Get<bool?>("allowTeamworkReactions"); }
            set { BackingStore?.Set("allowTeamworkReactions", value); }
        }
        /// <summary>The attendance reports of an online meeting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<MeetingAttendanceReport>? AttendanceReports {
            get { return BackingStore?.Get<List<MeetingAttendanceReport>?>("attendanceReports"); }
            set { BackingStore?.Set("attendanceReports", value); }
        }
#nullable restore
#else
        public List<MeetingAttendanceReport> AttendanceReports {
            get { return BackingStore?.Get<List<MeetingAttendanceReport>>("attendanceReports"); }
            set { BackingStore?.Set("attendanceReports", value); }
        }
#endif
        /// <summary>The content stream of the attendee report of a Microsoft Teams live event. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? AttendeeReport {
            get { return BackingStore?.Get<byte[]?>("attendeeReport"); }
            set { BackingStore?.Set("attendeeReport", value); }
        }
#nullable restore
#else
        public byte[] AttendeeReport {
            get { return BackingStore?.Get<byte[]>("attendeeReport"); }
            set { BackingStore?.Set("attendeeReport", value); }
        }
#endif
        /// <summary>The phone access (dial-in) information for an online meeting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.AudioConferencing? AudioConferencing {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AudioConferencing?>("audioConferencing"); }
            set { BackingStore?.Set("audioConferencing", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.AudioConferencing AudioConferencing {
            get { return BackingStore?.Get<Microsoft.Graph.Models.AudioConferencing>("audioConferencing"); }
            set { BackingStore?.Set("audioConferencing", value); }
        }
#endif
        /// <summary>Settings related to a live event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public BroadcastMeetingSettings? BroadcastSettings {
            get { return BackingStore?.Get<BroadcastMeetingSettings?>("broadcastSettings"); }
            set { BackingStore?.Set("broadcastSettings", value); }
        }
#nullable restore
#else
        public BroadcastMeetingSettings BroadcastSettings {
            get { return BackingStore?.Get<BroadcastMeetingSettings>("broadcastSettings"); }
            set { BackingStore?.Set("broadcastSettings", value); }
        }
#endif
        /// <summary>The chat information associated with this online meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.ChatInfo? ChatInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ChatInfo?>("chatInfo"); }
            set { BackingStore?.Set("chatInfo", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.ChatInfo ChatInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Models.ChatInfo>("chatInfo"); }
            set { BackingStore?.Set("chatInfo", value); }
        }
#endif
        /// <summary>The meeting creation time in UTC. Read-only.</summary>
        public DateTimeOffset? CreationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("creationDateTime"); }
            set { BackingStore?.Set("creationDateTime", value); }
        }
        /// <summary>The meeting end time in UTC.</summary>
        public DateTimeOffset? EndDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("endDateTime"); }
            set { BackingStore?.Set("endDateTime", value); }
        }
        /// <summary>The externalId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ExternalId {
            get { return BackingStore?.Get<string?>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#nullable restore
#else
        public string ExternalId {
            get { return BackingStore?.Get<string>("externalId"); }
            set { BackingStore?.Set("externalId", value); }
        }
#endif
        /// <summary>Indicates if this is a Teams live event.</summary>
        public bool? IsBroadcast {
            get { return BackingStore?.Get<bool?>("isBroadcast"); }
            set { BackingStore?.Set("isBroadcast", value); }
        }
        /// <summary>Indicates whether to announce when callers join or leave.</summary>
        public bool? IsEntryExitAnnounced {
            get { return BackingStore?.Get<bool?>("isEntryExitAnnounced"); }
            set { BackingStore?.Set("isEntryExitAnnounced", value); }
        }
        /// <summary>The join information in the language and locale variant specified in the Accept-Language request HTTP header. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ItemBody? JoinInformation {
            get { return BackingStore?.Get<ItemBody?>("joinInformation"); }
            set { BackingStore?.Set("joinInformation", value); }
        }
#nullable restore
#else
        public ItemBody JoinInformation {
            get { return BackingStore?.Get<ItemBody>("joinInformation"); }
            set { BackingStore?.Set("joinInformation", value); }
        }
#endif
        /// <summary>Specifies the joinMeetingId, the meeting passcode, and the requirement for the passcode. Once an onlineMeeting is created, the joinMeetingIdSettings cannot be modified. To make any changes to this property, the meeting needs to be canceled and a new one needs to be created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.JoinMeetingIdSettings? JoinMeetingIdSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.JoinMeetingIdSettings?>("joinMeetingIdSettings"); }
            set { BackingStore?.Set("joinMeetingIdSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.JoinMeetingIdSettings JoinMeetingIdSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.JoinMeetingIdSettings>("joinMeetingIdSettings"); }
            set { BackingStore?.Set("joinMeetingIdSettings", value); }
        }
#endif
        /// <summary>The join URL of the online meeting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JoinWebUrl {
            get { return BackingStore?.Get<string?>("joinWebUrl"); }
            set { BackingStore?.Set("joinWebUrl", value); }
        }
#nullable restore
#else
        public string JoinWebUrl {
            get { return BackingStore?.Get<string>("joinWebUrl"); }
            set { BackingStore?.Set("joinWebUrl", value); }
        }
#endif
        /// <summary>Specifies which participants can bypass the meeting   lobby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Models.LobbyBypassSettings? LobbyBypassSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.LobbyBypassSettings?>("lobbyBypassSettings"); }
            set { BackingStore?.Set("lobbyBypassSettings", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Models.LobbyBypassSettings LobbyBypassSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Models.LobbyBypassSettings>("lobbyBypassSettings"); }
            set { BackingStore?.Set("lobbyBypassSettings", value); }
        }
#endif
        /// <summary>The participants associated with the online meeting.  This includes the organizer and the attendees.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public MeetingParticipants? Participants {
            get { return BackingStore?.Get<MeetingParticipants?>("participants"); }
            set { BackingStore?.Set("participants", value); }
        }
#nullable restore
#else
        public MeetingParticipants Participants {
            get { return BackingStore?.Get<MeetingParticipants>("participants"); }
            set { BackingStore?.Set("participants", value); }
        }
#endif
        /// <summary>Indicates whether to record the meeting automatically.</summary>
        public bool? RecordAutomatically {
            get { return BackingStore?.Get<bool?>("recordAutomatically"); }
            set { BackingStore?.Set("recordAutomatically", value); }
        }
        /// <summary>The meeting start time in UTC.</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>The subject of the online meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject {
            get { return BackingStore?.Get<string?>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#nullable restore
#else
        public string Subject {
            get { return BackingStore?.Get<string>("subject"); }
            set { BackingStore?.Set("subject", value); }
        }
#endif
        /// <summary>The video teleconferencing ID. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VideoTeleconferenceId {
            get { return BackingStore?.Get<string?>("videoTeleconferenceId"); }
            set { BackingStore?.Set("videoTeleconferenceId", value); }
        }
#nullable restore
#else
        public string VideoTeleconferenceId {
            get { return BackingStore?.Get<string>("videoTeleconferenceId"); }
            set { BackingStore?.Set("videoTeleconferenceId", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new OnlineMeeting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OnlineMeeting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowAttendeeToEnableCamera", n => { AllowAttendeeToEnableCamera = n.GetBoolValue(); } },
                {"allowAttendeeToEnableMic", n => { AllowAttendeeToEnableMic = n.GetBoolValue(); } },
                {"allowTeamworkReactions", n => { AllowTeamworkReactions = n.GetBoolValue(); } },
                {"attendanceReports", n => { AttendanceReports = n.GetCollectionOfObjectValues<MeetingAttendanceReport>(MeetingAttendanceReport.CreateFromDiscriminatorValue)?.ToList(); } },
                {"attendeeReport", n => { AttendeeReport = n.GetByteArrayValue(); } },
                {"audioConferencing", n => { AudioConferencing = n.GetObjectValue<Microsoft.Graph.Models.AudioConferencing>(Microsoft.Graph.Models.AudioConferencing.CreateFromDiscriminatorValue); } },
                {"broadcastSettings", n => { BroadcastSettings = n.GetObjectValue<BroadcastMeetingSettings>(BroadcastMeetingSettings.CreateFromDiscriminatorValue); } },
                {"chatInfo", n => { ChatInfo = n.GetObjectValue<Microsoft.Graph.Models.ChatInfo>(Microsoft.Graph.Models.ChatInfo.CreateFromDiscriminatorValue); } },
                {"creationDateTime", n => { CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"externalId", n => { ExternalId = n.GetStringValue(); } },
                {"isBroadcast", n => { IsBroadcast = n.GetBoolValue(); } },
                {"isEntryExitAnnounced", n => { IsEntryExitAnnounced = n.GetBoolValue(); } },
                {"joinInformation", n => { JoinInformation = n.GetObjectValue<ItemBody>(ItemBody.CreateFromDiscriminatorValue); } },
                {"joinMeetingIdSettings", n => { JoinMeetingIdSettings = n.GetObjectValue<Microsoft.Graph.Models.JoinMeetingIdSettings>(Microsoft.Graph.Models.JoinMeetingIdSettings.CreateFromDiscriminatorValue); } },
                {"joinWebUrl", n => { JoinWebUrl = n.GetStringValue(); } },
                {"lobbyBypassSettings", n => { LobbyBypassSettings = n.GetObjectValue<Microsoft.Graph.Models.LobbyBypassSettings>(Microsoft.Graph.Models.LobbyBypassSettings.CreateFromDiscriminatorValue); } },
                {"participants", n => { Participants = n.GetObjectValue<MeetingParticipants>(MeetingParticipants.CreateFromDiscriminatorValue); } },
                {"recordAutomatically", n => { RecordAutomatically = n.GetBoolValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
                {"videoTeleconferenceId", n => { VideoTeleconferenceId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("allowAttendeeToEnableCamera", AllowAttendeeToEnableCamera);
            writer.WriteBoolValue("allowAttendeeToEnableMic", AllowAttendeeToEnableMic);
            writer.WriteBoolValue("allowTeamworkReactions", AllowTeamworkReactions);
            writer.WriteCollectionOfObjectValues<MeetingAttendanceReport>("attendanceReports", AttendanceReports);
            writer.WriteByteArrayValue("attendeeReport", AttendeeReport);
            writer.WriteObjectValue<Microsoft.Graph.Models.AudioConferencing>("audioConferencing", AudioConferencing);
            writer.WriteObjectValue<BroadcastMeetingSettings>("broadcastSettings", BroadcastSettings);
            writer.WriteObjectValue<Microsoft.Graph.Models.ChatInfo>("chatInfo", ChatInfo);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteStringValue("externalId", ExternalId);
            writer.WriteBoolValue("isBroadcast", IsBroadcast);
            writer.WriteBoolValue("isEntryExitAnnounced", IsEntryExitAnnounced);
            writer.WriteObjectValue<ItemBody>("joinInformation", JoinInformation);
            writer.WriteObjectValue<Microsoft.Graph.Models.JoinMeetingIdSettings>("joinMeetingIdSettings", JoinMeetingIdSettings);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
            writer.WriteObjectValue<Microsoft.Graph.Models.LobbyBypassSettings>("lobbyBypassSettings", LobbyBypassSettings);
            writer.WriteObjectValue<MeetingParticipants>("participants", Participants);
            writer.WriteBoolValue("recordAutomatically", RecordAutomatically);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("videoTeleconferenceId", VideoTeleconferenceId);
        }
    }
}