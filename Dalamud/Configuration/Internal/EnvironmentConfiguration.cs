using System;

namespace Dalamud.Configuration.Internal;

/// <summary>
/// Environmental configuration settings.
/// </summary>
internal class EnvironmentConfiguration
{
    /// <summary>
    /// Gets a value indicating whether the XL_WINEONLINUX setting has been enabled.
    /// </summary>
    public static bool XlWineOnLinux { get; } = GetEnvironmentVariable("XL_WINEONLINUX");

    /// <summary>
    /// Gets a value indicating whether the DALAMUD_NOT_HAVE_PLUGINS setting has been enabled.
    /// </summary>
    public static bool DalamudNoPlugins { get; } = GetEnvironmentVariable("DALAMUD_NOT_HAVE_PLUGINS");

    /// <summary>
    /// Gets a value indicating whether the DalamudForceReloaded setting has been enabled.
    /// </summary>
    public static bool DalamudForceReloaded { get; } = GetEnvironmentVariable("DALAMUD_FORCE_RELOADED");

    /// <summary>
    /// Gets a value indicating whether the DalamudForceMinHook setting has been enabled.
    /// </summary>
    public static bool DalamudForceMinHook { get; } = GetEnvironmentVariable("DALAMUD_FORCE_MINHOOK");

    /// <summary>
    /// Gets a value indicating whether or not Dalamud should wait for a debugger to be attached when initializing.
    /// </summary>
    public static bool DalamudWaitForDebugger { get; } = GetEnvironmentVariable("DALAMUD_WAIT_DEBUGGER");

    private static bool GetEnvironmentVariable(string name)
        => bool.Parse(Environment.GetEnvironmentVariable(name) ?? "false");
}
