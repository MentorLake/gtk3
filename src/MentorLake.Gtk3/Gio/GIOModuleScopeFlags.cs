namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Flags for use with g_io_module_scope_new().
/// </para>
/// </summary>

[Flags]
public enum GIOModuleScopeFlags
{
/// <summary>
/// <para>
/// No module scan flags
/// </para>
/// </summary>

	G_IO_MODULE_SCOPE_NONE = 0,
/// <summary>
/// <para>
/// When using this scope to load or
///     scan modules, automatically block a modules which has the same base
///     basename as previously loaded module.
/// </para>
/// </summary>

	G_IO_MODULE_SCOPE_BLOCK_DUPLICATES = 1
}
