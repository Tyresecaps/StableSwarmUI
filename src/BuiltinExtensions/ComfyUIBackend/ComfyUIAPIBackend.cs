﻿
using FreneticUtilities.FreneticDataSyntax;
using StableSwarmUI.DataHolders;

namespace StableSwarmUI.Builtin_ComfyUIBackend;

public class ComfyUIAPIBackend : ComfyUIAPIAbstractBackend
{
    public class ComfyUIAPISettings : AutoConfiguration
    {
        /// <summary>Base web address of the ComfyUI instance.</summary>
        [SuggestionPlaceholder(Text = "ComfyUI's address...")]
        [ConfigComment("The address of the ComfyUI instance, eg 'http://localhost:8188'.")]
        public string Address = "";
    }

    public override string Address => (SettingsRaw as ComfyUIAPISettings).Address;

    public override Task Init()
    {
        return InitInternal(false);
    }
}
