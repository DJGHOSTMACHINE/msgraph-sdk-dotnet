// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Models
{
    #pragma warning disable CS1591
    public class WindowsUpdateScheduledInstall : Microsoft.Graph.Models.WindowsUpdateInstallScheduleType, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Possible values for a weekly schedule.</summary>
        public Microsoft.Graph.Models.WeeklySchedule? ScheduledInstallDay
        {
            get { return BackingStore?.Get<Microsoft.Graph.Models.WeeklySchedule?>("scheduledInstallDay"); }
            set { BackingStore?.Set("scheduledInstallDay", value); }
        }
        /// <summary>Scheduled Install Time during day</summary>
        public Time? ScheduledInstallTime
        {
            get { return BackingStore?.Get<Time?>("scheduledInstallTime"); }
            set { BackingStore?.Set("scheduledInstallTime", value); }
        }
        /// <summary>
        /// Instantiates a new <see cref="Microsoft.Graph.Models.WindowsUpdateScheduledInstall"/> and sets the default values.
        /// </summary>
        public WindowsUpdateScheduledInstall() : base()
        {
            OdataType = "#microsoft.graph.windowsUpdateScheduledInstall";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="Microsoft.Graph.Models.WindowsUpdateScheduledInstall"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Microsoft.Graph.Models.WindowsUpdateScheduledInstall CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Microsoft.Graph.Models.WindowsUpdateScheduledInstall();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "scheduledInstallDay", n => { ScheduledInstallDay = n.GetEnumValue<Microsoft.Graph.Models.WeeklySchedule>(); } },
                { "scheduledInstallTime", n => { ScheduledInstallTime = n.GetTimeValue(); } },
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
            writer.WriteEnumValue<Microsoft.Graph.Models.WeeklySchedule>("scheduledInstallDay", ScheduledInstallDay);
            writer.WriteTimeValue("scheduledInstallTime", ScheduledInstallTime);
        }
    }
}
