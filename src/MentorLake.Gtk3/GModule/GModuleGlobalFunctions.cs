namespace MentorLake.GModule;

public class GModuleGlobalFunctions
{
	public static string ModuleBuildPath(string directory, string module_name)
	{
		return GModuleGlobalFunctionsExterns.g_module_build_path(directory, module_name);
	}

	public static string ModuleError()
	{
		return GModuleGlobalFunctionsExterns.g_module_error();
	}

	public static MentorLake.GLib.GQuark ModuleErrorQuark()
	{
		return GModuleGlobalFunctionsExterns.g_module_error_quark();
	}

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
