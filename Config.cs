using Exiled.API.Interfaces;
using System.ComponentModel;

namespace BetterSinkholes2
{
    public class Config : IConfig
    {
        [Description("Enable/disable BetterSinkholes")]
        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; }

        [Description("Distance from the center of a sinkhole where you get teleported")]
        public float TeleportDistance { get; set; } = 0.6f;

        [Description("Distance from the center of a sinkhole where you start getting slowed")]
        public float SlowDistance { get; set; } = 1.2f;

        [Description("Broadcasted message duration. Default: 0")]
        public ushort TeleportMessageDuration { get; set; } = 0;

        [Description("Message broadcasted to the player upon falling into a sinkhole. Default: nothing")]
        public string TeleportMessage { get; set; } = "";
    }
}
