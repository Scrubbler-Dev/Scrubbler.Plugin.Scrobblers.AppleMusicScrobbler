using Scrubbler.Abstractions.Settings;

namespace Scrubbler.Plugin.Scrobblers.AppleMusicScrobbler;

internal class PluginSettings : IPluginSettings
{
    public bool AutoConnect { get; set; } = false;
}
