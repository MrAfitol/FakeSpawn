using Exiled.API.Features;
using System;

namespace FakeSpawn
{
    public class FakeSpawn : Plugin<Config>
    {
        public override string Name => "FakeSpawn";

        public override string Author => "MrAfitol";

        public override Version Version => new Version(1, 0, 0);

        public override Version RequiredExiledVersion => new Version(2, 10, 0);

        public override void OnEnabled()
        {
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
        }

    }
}
