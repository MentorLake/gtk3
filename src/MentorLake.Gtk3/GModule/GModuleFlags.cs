namespace MentorLake.GModule;

/// <summary>
/// <para>
/// Flags passed to g_module_open().
/// Note that these flags are not supported on all platforms.
/// </para>
/// </summary>

[Flags]
public enum GModuleFlags : uint
{
/// <summary>
/// <para>
/// specifies that symbols are only resolved when
///     needed. The default action is to bind all symbols when the module
///     is loaded.
/// </para>
/// </summary>

	G_MODULE_BIND_LAZY = 1,
/// <summary>
/// <para>
/// specifies that symbols in the module should
///     not be added to the global name space. The default action on most
///     platforms is to place symbols in the module in the global name space,
///     which may cause conflicts with existing symbols.
/// </para>
/// </summary>

	G_MODULE_BIND_LOCAL = 2,
/// <summary>
/// <para>
/// mask for all flags.
/// </para>
/// </summary>

	G_MODULE_BIND_MASK = 3
}
