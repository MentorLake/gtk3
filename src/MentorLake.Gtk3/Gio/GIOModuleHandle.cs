namespace MentorLake.Gio;

public class GIOModuleHandle : GTypeModuleHandle, GTypePluginHandle
{
	public static MentorLake.Gio.GIOModuleHandle New(char filename)
	{
		return GIOModuleHandleExterns.g_io_module_new(filename);
	}

	public static string[] Query()
	{
		return GIOModuleHandleExterns.g_io_module_query();
	}

}

public static class GIOModuleHandleExtensions
{
	public static T Load<T>(this T module) where T : GIOModuleHandle
	{
		GIOModuleHandleExterns.g_io_module_load(module);
		return module;
	}

	public static T Unload<T>(this T module) where T : GIOModuleHandle
	{
		GIOModuleHandleExterns.g_io_module_unload(module);
		return module;
	}

}

internal class GIOModuleHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOModuleHandle g_io_module_new(char filename);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_module_load([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOModuleHandle>))] MentorLake.Gio.GIOModuleHandle module);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_module_unload([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOModuleHandle>))] MentorLake.Gio.GIOModuleHandle module);

	[DllImport(GioLibrary.Name)]
	internal static extern string[] g_io_module_query();

}
