namespace MentorLake.GModule;

/// <summary>
/// <para>
/// Errors returned by g_module_open_full().
/// </para>
/// </summary>

[Flags]
public enum GModuleError
{
/// <summary>
/// <para>
/// there was an error loading or opening a module file
/// </para>
/// </summary>

	G_MODULE_ERROR_FAILED = 0,
/// <summary>
/// <para>
/// a module returned an error from its `g_module_check_init()` function
/// </para>
/// </summary>

	G_MODULE_ERROR_CHECK_FAILED = 1
}
