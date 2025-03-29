namespace MentorLake.GModule;

public class GModuleHandle : BaseSafeHandle
{
}


public static class GModuleExtensions
{
	public static bool Close(this MentorLake.GModule.GModuleHandle module)
	{
		return GModuleExterns.g_module_close(module);
	}

	public static void MakeResident(this MentorLake.GModule.GModuleHandle module)
	{
		GModuleExterns.g_module_make_resident(module);
	}

	public static string Name(this MentorLake.GModule.GModuleHandle module)
	{
		return GModuleExterns.g_module_name(module);
	}

	public static bool Symbol(this MentorLake.GModule.GModuleHandle module, string symbol_name, out IntPtr symbol)
	{
		return GModuleExterns.g_module_symbol(module, symbol_name, out symbol);
	}


	public static GModule Dereference(this GModuleHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GModule>(x.DangerousGetHandle());
}
internal class GModuleExterns
{
	[DllImport(GModuleLibrary.Name)]
	internal static extern bool g_module_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GModule.GModuleHandle>))] MentorLake.GModule.GModuleHandle module);

	[DllImport(GModuleLibrary.Name)]
	internal static extern void g_module_make_resident([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GModule.GModuleHandle>))] MentorLake.GModule.GModuleHandle module);

	[DllImport(GModuleLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_module_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GModule.GModuleHandle>))] MentorLake.GModule.GModuleHandle module);

	[DllImport(GModuleLibrary.Name)]
	internal static extern bool g_module_symbol([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GModule.GModuleHandle>))] MentorLake.GModule.GModuleHandle module, string symbol_name, out IntPtr symbol);

	[DllImport(GModuleLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_module_build_path(string directory, string module_name);

	[DllImport(GModuleLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_module_error();

	[DllImport(GModuleLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_module_error_quark();

	[DllImport(GModuleLibrary.Name)]
	internal static extern MentorLake.GModule.GModuleHandle g_module_open(string file_name, MentorLake.GModule.GModuleFlags flags);

	[DllImport(GModuleLibrary.Name)]
	internal static extern MentorLake.GModule.GModuleHandle g_module_open_full(string file_name, MentorLake.GModule.GModuleFlags flags, IntPtr error);

	[DllImport(GModuleLibrary.Name)]
	internal static extern bool g_module_supported();

}

public struct GModule
{
	public static string BuildPath(string directory, string module_name)
	{
		return GModuleExterns.g_module_build_path(directory, module_name);
	}

	public static string Error()
	{
		return GModuleExterns.g_module_error();
	}

	public static MentorLake.GLib.GQuark ErrorQuark()
	{
		return GModuleExterns.g_module_error_quark();
	}

	public static MentorLake.GModule.GModuleHandle Open(string file_name, MentorLake.GModule.GModuleFlags flags)
	{
		return GModuleExterns.g_module_open(file_name, flags);
	}

	public static MentorLake.GModule.GModuleHandle OpenFull(string file_name, MentorLake.GModule.GModuleFlags flags, IntPtr error)
	{
		return GModuleExterns.g_module_open_full(file_name, flags, error);
	}

	public static bool Supported()
	{
		return GModuleExterns.g_module_supported();
	}

}
