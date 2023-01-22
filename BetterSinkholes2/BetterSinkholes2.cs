using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Hazards;
using UnityEngine;
using CustomPlayerEffects;

namespace BetterSinkholes2
{
    public class BetterSinkholes2 : Plugin<Config>
    {
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.StayingOnEnvironmentalHazard += OnStayingOnSinkhole;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.StayingOnEnvironmentalHazard -= OnStayingOnSinkhole;
            base.OnDisabled();
        }

        public void OnStayingOnSinkhole(StayingOnEnvironmentalHazardEventArgs ev)
        {
            if (ev.EnvironmentalHazard is not SinkholeEnvironmentalHazard sinkhole)
                return;

            if (ev.Player.IsScp || ev.Player.IsGodModeEnabled)
                return;

            if ((double)Vector3.Distance(ev.Player.Position, sinkhole.transform.position) > (double)sinkhole.MaxDistance * Config.TeleportDistance)
                return;

            ev.Player.DisableEffect<Sinkhole>();
            ev.Player.EnableEffect<Corroding>();
            ev.Player.Broadcast(Config.TeleportMessageDuration, Config.TeleportMessage);
        }
    }
}
