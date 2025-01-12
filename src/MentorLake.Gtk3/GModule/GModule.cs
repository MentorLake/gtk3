namespace MentorLake.Gtk3.GModule;

public class GModuleHandle : BaseSafeHandle
{
}


public static class GModuleHandleExtensions
{
	public static bool Close(this GModuleHandle module)
	{
		return GModuleExterns.g_module_close(module);
	}

	public static GModuleHandle MakeResident(this GModuleHandle module)
	{
		GModuleExterns.g_module_make_resident(module);
		return module;
	}

	public static string Name(this GModuleHandle module)
	{
		return GModuleExterns.g_module_name(module);
	}

	public static bool Symbol(this GModuleHandle module, string symbol_name, out IntPtr symbol)
	{
		return GModuleExterns.g_module_symbol(module, symbol_name, out symbol);
	}

	public static string BuildPath(string directory, string module_name)
	{
		return GModuleExterns.g_module_build_path(directory, module_name);
	}

	public static string Error()
	{
		return GModuleExterns.g_module_error();
	}

	public static GQuark ErrorQuark()
	{
		return GModuleExterns.g_module_error_quark();
	}

	public static GModuleHandle Open(string file_name, GModuleFlags flags)
	{
		return GModuleExterns.g_module_open(file_name, flags);
	}

	public static GModuleHandle OpenFull(string file_name, GModuleFlags flags, out GErrorHandle error)
	{
		return GModuleExterns.g_module_open_full(file_name, flags, out error);
	}

	public static bool Supported()
	{
		return GModuleExterns.g_module_supported();
	}

}
internal class GModuleExterns
{
	[DllImport(Libraries.GModule)]
	internal static extern bool g_module_close(GModuleHandle module);

	[DllImport(Libraries.GModule)]
	internal static extern void g_module_make_resident(GModuleHandle module);

	[DllImport(Libraries.GModule)]
	internal static extern string g_module_name(GModuleHandle module);

	[DllImport(Libraries.GModule)]
	internal static extern bool g_module_symbol(GModuleHandle module, string symbol_name, out IntPtr symbol);

	[DllImport(Libraries.GModule)]
	internal static extern string g_module_build_path(string directory, string module_name);

	[DllImport(Libraries.GModule)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_module_error();

	[DllImport(Libraries.GModule)]
	internal static extern GQuark g_module_error_quark();

	[DllImport(Libraries.GModule)]
	internal static extern GModuleHandle g_module_open(string file_name, GModuleFlags flags);

	[DllImport(Libraries.GModule)]
	internal static extern GModuleHandle g_module_open_full(string file_name, GModuleFlags flags, out GErrorHandle error);

	[DllImport(Libraries.GModule)]
	internal static extern bool g_module_supported();

}

public struct GModule
{
}
