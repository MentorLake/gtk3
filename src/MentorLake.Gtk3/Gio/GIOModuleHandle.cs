namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Provides an interface and default functions for loading and unloading
/// modules. This is used internally to make GIO extensible, but can also
/// be used by others to implement module loading.
/// </para>
/// </summary>

public class GIOModuleHandle : GTypeModuleHandle, GTypePluginHandle
{
/// <summary>
/// <para>
/// Creates a new GIOModule that will load the specific
/// shared library when in use.
/// </para>
/// </summary>

/// <param name="filename">
/// filename of the shared library module.
/// </param>
/// <return>
/// a #GIOModule from given @filename,
/// or %NULL on error.
/// </return>

	public static MentorLake.Gio.GIOModuleHandle New(string filename)
	{
		return GIOModuleHandleExterns.g_io_module_new(filename);
	}

/// <summary>
/// <para>
/// Optional API for GIO modules to implement.
/// </para>
/// <para>
/// Should return a list of all the extension points that may be
/// implemented in this module.
/// </para>
/// <para>
/// This method will not be called in normal use, however it may be
/// called when probing existing modules and recording which extension
/// points that this model is used for. This means we won&apos;t have to
/// load and initialize this module unless its needed.
/// </para>
/// <para>
/// If this function is not implemented by the module the module will
/// always be loaded, initialized and then unloaded on application
/// startup so that it can register its extension points during init.
/// </para>
/// <para>
/// Note that a module need not actually implement all the extension
/// points that g_io_module_query() returns, since the exact list of
/// extension may depend on runtime issues. However all extension
/// points actually implemented must be returned by g_io_module_query()
/// (if defined).
/// </para>
/// <para>
/// When installing a module that implements g_io_module_query() you must
/// run gio-querymodules in order to build the cache files required for
/// lazy loading.
/// </para>
/// <para>
/// Since 2.56, this function should be named `g_io_&amp;lt;modulename&amp;gt;_query`, where
/// `modulename` is the plugin’s filename with the `lib` or `libgio` prefix and
/// everything after the first dot removed, and with `-` replaced with `_`
/// throughout. For example, `libgiognutls-helper.so` becomes `gnutls_helper`.
/// Using the new symbol names avoids name clashes when building modules
/// statically. The old symbol names continue to be supported, but cannot be used
/// for static builds.
/// </para>
/// </summary>

/// <return>
/// A %NULL-terminated array of strings,
///     listing the supported extension points of the module. The array
///     must be suitable for freeing with g_strfreev().
/// </return>

	public static string[] Query()
	{
		return GIOModuleHandleExterns.g_io_module_query();
	}

}

public static class GIOModuleHandleExtensions
{
/// <summary>
/// <para>
/// Required API for GIO modules to implement.
/// </para>
/// <para>
/// This function is run after the module has been loaded into GIO,
/// to initialize the module. Typically, this function will call
/// g_io_extension_point_implement().
/// </para>
/// <para>
/// Since 2.56, this function should be named `g_io_&amp;lt;modulename&amp;gt;_load`, where
/// `modulename` is the plugin’s filename with the `lib` or `libgio` prefix and
/// everything after the first dot removed, and with `-` replaced with `_`
/// throughout. For example, `libgiognutls-helper.so` becomes `gnutls_helper`.
/// Using the new symbol names avoids name clashes when building modules
/// statically. The old symbol names continue to be supported, but cannot be used
/// for static builds.
/// </para>
/// </summary>

/// <param name="module">
/// a #GIOModule.
/// </param>

	public static T Load<T>(this T module) where T : GIOModuleHandle
	{
		if (module.IsInvalid) throw new Exception("Invalid handle (GIOModuleHandle)");
		GIOModuleHandleExterns.g_io_module_load(module);
		return module;
	}

/// <summary>
/// <para>
/// Required API for GIO modules to implement.
/// </para>
/// <para>
/// This function is run when the module is being unloaded from GIO,
/// to finalize the module.
/// </para>
/// <para>
/// Since 2.56, this function should be named `g_io_&amp;lt;modulename&amp;gt;_unload`, where
/// `modulename` is the plugin’s filename with the `lib` or `libgio` prefix and
/// everything after the first dot removed, and with `-` replaced with `_`
/// throughout. For example, `libgiognutls-helper.so` becomes `gnutls_helper`.
/// Using the new symbol names avoids name clashes when building modules
/// statically. The old symbol names continue to be supported, but cannot be used
/// for static builds.
/// </para>
/// </summary>

/// <param name="module">
/// a #GIOModule.
/// </param>

	public static T Unload<T>(this T module) where T : GIOModuleHandle
	{
		if (module.IsInvalid) throw new Exception("Invalid handle (GIOModuleHandle)");
		GIOModuleHandleExterns.g_io_module_unload(module);
		return module;
	}

}

internal class GIOModuleHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GIOModuleHandle>))]
	internal static extern MentorLake.Gio.GIOModuleHandle g_io_module_new(string filename);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_module_load([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOModuleHandle>))] MentorLake.Gio.GIOModuleHandle module);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_module_unload([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOModuleHandle>))] MentorLake.Gio.GIOModuleHandle module);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_io_module_query();

}
