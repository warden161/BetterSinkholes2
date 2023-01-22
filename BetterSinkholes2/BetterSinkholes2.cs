using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Hazards;
using UnityEngine;
using CustomPlayerEffects;
using System;

namespace BetterSinkholes2
{
    public class BetterSinkholes2 : Plugin<Config>
    {
        public override string Author { get; } = "warden161 (original by blackruby)";
        public override string Name { get; } = "BetterSinkholes2";
        public override Version Version { get; } = new(1, 1, 0);
        public override Version RequiredExiledVersion { get; } = new(6, 0, 0);

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
