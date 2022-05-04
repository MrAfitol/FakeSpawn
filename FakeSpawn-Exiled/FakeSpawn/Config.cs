using Exiled.API.Interfaces;
using System.ComponentModel;

namespace FakeSpawn
{
    public class Config : IConfig
    {
        [Description("Whether or not this plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;
    }
}
