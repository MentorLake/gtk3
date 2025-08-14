namespace MentorLake.GModule;

public class GModuleGlobalFunctions
{
/// <summary>
/// <para>
/// A portable way to build the filename of a module. The platform-specific
/// prefix and suffix are added to the filename, if needed, and the result
/// is added to the directory, using the correct separator character.
/// </para>
/// <para>
/// The directory should specify the directory where the module can be found.
/// It can be %NULL or an empty string to indicate that the module is in a
/// standard platform-specific directory, though this is not recommended
/// since the wrong module may be found.
/// </para>
/// <para>
/// For example, calling g_module_build_path() on a Linux system with a
/// @directory of `/lib` and a @module_name of "mylibrary" will return
/// `/lib/libmylibrary.so`. On a Windows system, using `\Windows` as the
/// directory it will return `\Windows\mylibrary.dll`.
/// </para>
/// </summary>

/// <param name="directory">
/// the directory where the module is. This can be
///     %NULL or the empty string to indicate that the standard platform-specific
///     directories will be used, though that is not recommended
/// </param>
/// <param name="module_name">
/// the name of the module
/// </param>
/// <return>
/// the complete path of the module, including the standard library
///     prefix and suffix. This should be freed when no longer needed
/// </return>

	public static string ModuleBuildPath(string directory, string module_name)
	{
		return GModuleGlobalFunctionsExterns.g_module_build_path(directory, module_name);
	}

/// <summary>
/// <para>
/// Gets a string describing the last module error.
/// </para>
/// </summary>

/// <return>
/// a string describing the last module error
/// </return>

	public static string ModuleError()
	{
		return GModuleGlobalFunctionsExterns.g_module_error();
	}



	public static MentorLake.GLib.GQuark ModuleErrorQuark()
	{
		return GModuleGlobalFunctionsExterns.g_module_error_quark();
	}

/// <summary>
/// <para>
/// Checks if modules are supported on the current platform.
/// </para>
/// </summary>

/// <return>
/// %TRUE if modules are supported
/// </return>

	public static bool ModuleSupported()
	{
		return GModuleGlobalFunctionsExterns.g_module_supported();
	}

}

internal class GModuleGlobalFunctionsExterns
{
	[DllImport(GModuleLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_module_build_path(string directory, string module_name);

	[DllImport(GModuleLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_module_error();

	[DllImport(GModuleLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_module_error_quark();

	[DllImport(GModuleLibrary.Name)]
	internal static extern bool g_module_supported();

}
