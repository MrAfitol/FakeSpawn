using CommandSystem;
using Exiled.Permissions.Extensions;
using Respawning;
using System;

namespace FakeSpawn.Commands
{
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    [CommandHandler(typeof(GameConsoleCommandHandler))]
    public class Spawn : ICommand
    {
        public string Command { get; } = "fakespawn";

        public string[] Aliases { get; } = new string[] { "fakes" };

        public string Description { get; } = "Summons an untruthful MTF/CI squad";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            string action;

            if (!((CommandSender)sender).CheckPermission("s.fake"))
            {
                response = "You do not have permission to use this command";
                return false;
            }

            if (arguments.Count != 1)
            {
                response = "Usage:\nfakespawn <grouping mtf/ci>\nfakespawn list";
                return false;
            }

            switch (action = arguments.At(0).ToLower())
            {
                case "mtf":
                    {
                        RespawnEffectsController.ExecuteAllEffects(RespawnEffectsController.EffectType.Selection, SpawnableTeamType.NineTailedFox);

                        response = "Command completed successfully!";
                        return true;

                    }

                case "ci":
                    {
                        RespawnEffectsController.ExecuteAllEffects(RespawnEffectsController.EffectType.Selection, SpawnableTeamType.ChaosInsurgency);

                        response = "Command completed successfully!";
                        return true;

                    }

                case "list":
                    {
                        response = "List of groupings: \n1. mtf \n2. ci";
                        return true;
                    }
                default:
                    {
                        response = "Incorrect second argument! \nCorrectly: \nfakespawn <grouping mtf/ci>\nfakespawn list";
                        return false;
                    }
            }
        }
    }
}
