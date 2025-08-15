namespace MentorLake.GModule;

/// <summary>
/// <para>
/// The #GModule struct is an opaque data structure to represent a
/// [dynamically-loaded module][glib-Dynamic-Loading-of-Modules].
/// It should only be accessed via the following functions.
/// </para>
/// </summary>

public class GModuleHandle : BaseSafeHandle
{
}


public static class GModuleExtensions
{
/// <summary>
/// <para>
/// Closes a module.
/// </para>
/// </summary>

/// <param name="module">
/// a #GModule to close
/// </param>
/// <return>
/// %TRUE on success
/// </return>

	public static bool Close(this MentorLake.GModule.GModuleHandle module)
	{
		if (module.IsInvalid) throw new Exception("Invalid handle (GModule)");
		return GModuleExterns.g_module_close(module);
	}

/// <summary>
/// <para>
/// Ensures that a module will never be unloaded.
/// Any future g_module_close() calls on the module will be ignored.
/// </para>
/// </summary>

/// <param name="module">
/// a #GModule to make permanently resident
/// </param>

	public static void MakeResident(this MentorLake.GModule.GModuleHandle module)
	{
		if (module.IsInvalid) throw new Exception("Invalid handle (GModule)");
		GModuleExterns.g_module_make_resident(module);
	}

/// <summary>
/// <para>
/// Returns the filename that the module was opened with.
/// </para>
/// <para>
/// If @module refers to the application itself, &quot;main&quot; is returned.
/// </para>
/// </summary>

/// <param name="module">
/// a #GModule
/// </param>
/// <return>
/// the filename of the module
/// </return>

	public static string Name(this MentorLake.GModule.GModuleHandle module)
	{
		if (module.IsInvalid) throw new Exception("Invalid handle (GModule)");
		return GModuleExterns.g_module_name(module);
	}

/// <summary>
/// <para>
/// Gets a symbol pointer from a module, such as one exported
/// by %G_MODULE_EXPORT. Note that a valid symbol can be %NULL.
/// </para>
/// </summary>

/// <param name="module">
/// a #GModule
/// </param>
/// <param name="symbol_name">
/// the name of the symbol to find
/// </param>
/// <param name="symbol">
/// returns the pointer to the symbol value
/// </param>
/// <return>
/// %TRUE on success
/// </return>

	public static bool Symbol(this MentorLake.GModule.GModuleHandle module, string symbol_name, out IntPtr symbol)
	{
		if (module.IsInvalid) throw new Exception("Invalid handle (GModule)");
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GModule.GModuleHandle>))]
	internal static extern MentorLake.GModule.GModuleHandle g_module_open(string file_name, MentorLake.GModule.GModuleFlags flags);

	[DllImport(GModuleLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GModule.GModuleHandle>))]
	internal static extern MentorLake.GModule.GModuleHandle g_module_open_full(string file_name, MentorLake.GModule.GModuleFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GModuleLibrary.Name)]
	internal static extern bool g_module_supported();

}

/// <summary>
/// <para>
/// The #GModule struct is an opaque data structure to represent a
/// [dynamically-loaded module][glib-Dynamic-Loading-of-Modules].
/// It should only be accessed via the following functions.
/// </para>
/// </summary>

public struct GModule
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
/// @directory of `/lib` and a @module_name of &quot;mylibrary&quot; will return
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

	public static string BuildPath(string directory, string module_name)
	{
		return GModuleExterns.g_module_build_path(directory, module_name);
	}

/// <summary>
/// <para>
/// Gets a string describing the last module error.
/// </para>
/// </summary>

/// <return>
/// a string describing the last module error
/// </return>

	public static string Error()
	{
		return GModuleExterns.g_module_error();
	}



	public static MentorLake.GLib.GQuark ErrorQuark()
	{
		return GModuleExterns.g_module_error_quark();
	}

/// <summary>
/// <para>
/// A thin wrapper function around g_module_open_full()
/// </para>
/// </summary>

/// <param name="file_name">
/// the name or path to the file containing the module,
///     or %NULL to obtain a #GModule representing the main program itself
/// </param>
/// <param name="flags">
/// the flags used for opening the module. This can be the
///     logical OR of any of the #GModuleFlags.
/// </param>
/// <return>
/// a #GModule on success, or %NULL on failure
/// </return>

	public static MentorLake.GModule.GModuleHandle Open(string file_name, MentorLake.GModule.GModuleFlags flags)
	{
		return GModuleExterns.g_module_open(file_name, flags);
	}

/// <summary>
/// <para>
/// Opens a module. If the module has already been opened, its reference count
/// is incremented. If not, the module is searched using @file_name.
/// </para>
/// <para>
/// Since 2.76, the search order/behavior is as follows:
/// </para>
/// <para>
/// 1. If @file_name exists as a regular file, it is used as-is; else
/// 2. If @file_name doesn&apos;t have the correct suffix and/or prefix for the
///    platform, then possible suffixes and prefixes will be added to the
///    basename till a file is found and whatever is found will be used; else
/// 3. If @file_name doesn&apos;t have the &quot;.la&quot;-suffix, &quot;.la&quot; is appended. Either
///    way, if a matching .la file exists (and is a libtool archive) the
///    libtool archive is parsed to find the actual file name, and that is
///    used.
/// </para>
/// <para>
/// If, at the end of all this, we have a file path that we can access on disk,
/// it is opened as a module. If not, @file_name is attempted to be opened as a
/// module verbatim in the hopes that the system implementation will somehow be
/// able to access it. If that is not possible, %NULL is returned.
/// </para>
/// <para>
/// Note that this behaviour was different prior to 2.76, but there is some
/// overlap in functionality. If backwards compatibility is an issue, kindly
/// consult earlier #GModule documentation for the prior search order/behavior
/// of @file_name.
/// </para>
/// </summary>

/// <param name="file_name">
/// the name or path to the file containing the module,
///     or %NULL to obtain a #GModule representing the main program itself
/// </param>
/// <param name="flags">
/// the flags used for opening the module. This can be the
///     logical OR of any of the #GModuleFlags
/// </param>
/// <return>
/// a #GModule on success, or %NULL on failure
/// </return>

	public static MentorLake.GModule.GModuleHandle OpenFull(string file_name, MentorLake.GModule.GModuleFlags flags)
	{
		var externCallResult = GModuleExterns.g_module_open_full(file_name, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Checks if modules are supported on the current platform.
/// </para>
/// </summary>

/// <return>
/// %TRUE if modules are supported
/// </return>

	public static bool Supported()
	{
		return GModuleExterns.g_module_supported();
	}

}
