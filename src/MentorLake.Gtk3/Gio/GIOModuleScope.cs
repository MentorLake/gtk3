namespace MentorLake.Gtk3.Gio;

public class GIOModuleScopeHandle : BaseSafeHandle
{
}


public static class GIOModuleScopeHandleExtensions
{
	public static GIOModuleScopeHandle GIoModuleScopeBlock(this GIOModuleScopeHandle scope, string basename)
	{
		GIOModuleScopeExterns.g_io_module_scope_block(scope, basename);
		return scope;
	}

	public static GIOModuleScopeHandle GIoModuleScopeFree(this GIOModuleScopeHandle scope)
	{
		GIOModuleScopeExterns.g_io_module_scope_free(scope);
		return scope;
	}

	public static GIOModuleScopeHandle GIoModuleScopeNew(GIOModuleScopeFlags flags)
	{
		return GIOModuleScopeExterns.g_io_module_scope_new(flags);
	}

}
internal class GIOModuleScopeExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_io_module_scope_block(GIOModuleScopeHandle scope, string basename);

	[DllImport(Libraries.Gio)]
	internal static extern void g_io_module_scope_free(GIOModuleScopeHandle scope);

	[DllImport(Libraries.Gio)]
	internal static extern GIOModuleScopeHandle g_io_module_scope_new(GIOModuleScopeFlags flags);

}

public struct GIOModuleScope
{
}
