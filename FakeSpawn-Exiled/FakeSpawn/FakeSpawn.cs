using Exiled.API.Features;
using System;

namespace FakeSpawn
{
    public class FakeSpawn : Plugin<Config>
    {
        public override string Name => "FakeSpawn";
        public override string Prefix => "fake_spawn";
        public override string Author => "MrAfitol, fixed by wety_FoE";
        public override Version Version => new Version(1, 0, 1);
        public override Version RequiredExiledVersion => new Version(5, 2, 1);

        public static FakeSpawn Singleton;

        public override void OnEnabled()
        {
            Singleton = this;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Singleton = null;

            base.OnDisabled();
        }

    }
}
