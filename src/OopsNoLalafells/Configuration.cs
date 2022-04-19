using Dalamud.Configuration;
using Dalamud.Plugin;
using Newtonsoft.Json;
using System;

namespace PotatoFamine
{
    public class Configuration : IPluginConfiguration {
        [NonSerialized]
        private DalamudPluginInterface pluginInterface;

        public int Version { get; set; } = 1;

        public bool OnlyChangeLalafells { get; set; } = true;

        public Race ChangeOthersTargetRace { get; set; } = Race.HYUR;

        public bool ChangeSelf { get; set; } = false;

        public Race ChangeSelfTargetRace { get; set; } = Race.ROEGADYN;

        public bool ShouldChangeOthers { get; set; } = false;
        
        [JsonIgnore] // Experimental feature - do not load/save
        public bool ImmersiveMode { get; set; } = false;

        public void Initialize(DalamudPluginInterface pluginInterface) {
            this.pluginInterface = pluginInterface;
        }

        public void Save() {
            this.pluginInterface.SavePluginConfig(this);
        }
    }
}
