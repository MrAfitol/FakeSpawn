using Exiled.API.Features;
using System;

namespace FakeSpawn
{
    public class FakeSpawn : Plugin<Config>
    {
        public override string Name => "FakeSpawn";
        public override string Prefix => "fake_spawn";
        public override string Author => "MrAfitol";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(3, 0, 0);

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
