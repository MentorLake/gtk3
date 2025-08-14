namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Represents a scope for loading IO modules. A scope can be used for blocking
/// duplicate modules, or blocking a module you don't want to load.
/// </para>
/// <para>
/// The scope can be used with g_io_modules_load_all_in_directory_with_scope()
/// or g_io_modules_scan_all_in_directory_with_scope().
/// </para>
/// </summary>

public class GIOModuleScopeHandle : BaseSafeHandle
{
}


public static class GIOModuleScopeExtensions
{
/// <summary>
/// <para>
/// Block modules with the given @basename from being loaded when
/// this scope is used with g_io_modules_scan_all_in_directory_with_scope()
/// or g_io_modules_load_all_in_directory_with_scope().
/// </para>
/// </summary>

/// <param name="scope">
/// a module loading scope
/// </param>
/// <param name="basename">
/// the basename to block
/// </param>

	public static void Block(this MentorLake.Gio.GIOModuleScopeHandle scope, string basename)
	{
		if (scope.IsInvalid) throw new Exception("Invalid handle (GIOModuleScope)");
		GIOModuleScopeExterns.g_io_module_scope_block(scope, basename);
	}

/// <summary>
/// <para>
/// Free a module scope.
/// </para>
/// </summary>

/// <param name="scope">
/// a module loading scope
/// </param>

	public static void Free(this MentorLake.Gio.GIOModuleScopeHandle scope)
	{
		if (scope.IsInvalid) throw new Exception("Invalid handle (GIOModuleScope)");
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOModuleScopeHandle>))]
	internal static extern MentorLake.Gio.GIOModuleScopeHandle g_io_module_scope_new(MentorLake.Gio.GIOModuleScopeFlags flags);

}

/// <summary>
/// <para>
/// Represents a scope for loading IO modules. A scope can be used for blocking
/// duplicate modules, or blocking a module you don't want to load.
/// </para>
/// <para>
/// The scope can be used with g_io_modules_load_all_in_directory_with_scope()
/// or g_io_modules_scan_all_in_directory_with_scope().
/// </para>
/// </summary>

public struct GIOModuleScope
{
/// <summary>
/// <para>
/// Create a new scope for loading of IO modules. A scope can be used for
/// blocking duplicate modules, or blocking a module you don't want to load.
/// </para>
/// <para>
/// Specify the %G_IO_MODULE_SCOPE_BLOCK_DUPLICATES flag to block modules
/// which have the same base name as a module that has already been seen
/// in this scope.
/// </para>
/// </summary>

/// <param name="flags">
/// flags for the new scope
/// </param>
/// <return>
/// the new module scope
/// </return>

	public static MentorLake.Gio.GIOModuleScopeHandle New(MentorLake.Gio.GIOModuleScopeFlags flags)
	{
		return GIOModuleScopeExterns.g_io_module_scope_new(flags);
	}

}
