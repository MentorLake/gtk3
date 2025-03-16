namespace MentorLake.Gio;

public class GIOModuleScopeHandle : BaseSafeHandle
{
}


public static class GIOModuleScopeExtensions
{
	public static void Block(this MentorLake.Gio.GIOModuleScopeHandle scope, string basename)
	{
		GIOModuleScopeExterns.g_io_module_scope_block(scope, basename);
	}

	public static void Free(this MentorLake.Gio.GIOModuleScopeHandle scope)
	{
		GIOModuleScopeExterns.g_io_module_scope_free(scope);
	}


	public static GIOModuleScope Dereference(this GIOModuleScopeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GIOModuleScope>(x.DangerousGetHandle());
}
internal class GIOModuleScopeExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_module_scope_block([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOModuleScopeHandle>))] MentorLake.Gio.GIOModuleScopeHandle scope, string basename);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_module_scope_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOModuleScopeHandle>))] MentorLake.Gio.GIOModuleScopeHandle scope);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GIOModuleScopeHandle g_io_module_scope_new(MentorLake.Gio.GIOModuleScopeFlags flags);

}

public struct GIOModuleScope
{
	public static MentorLake.Gio.GIOModuleScopeHandle New(MentorLake.Gio.GIOModuleScopeFlags flags)
	{
		return GIOModuleScopeExterns.g_io_module_scope_new(flags);
	}

}
