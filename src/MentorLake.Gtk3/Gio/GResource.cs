namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Applications and libraries often contain binary or textual data that is
/// really part of the application, rather than user data. For instance
/// &amp;lt;see href=&quot;https://docs.gtk.org/gtk4/class.Builder.html&quot;&amp;gt;GtkBuilder&amp;lt;/see&amp;gt; `.ui` files,
/// splashscreen images, [class@Gio.Menu] markup XML, CSS files, icons, etc.
/// These are often shipped as files in `$datadir/appname`, or manually
/// included as literal strings in the code.
/// </para>
/// <para>
/// The `GResource` API and the
/// &amp;lt;see href=&quot;glib-compile-resources.html&quot;&amp;gt;glib-compile-resources&amp;lt;/see&amp;gt; program provide a
/// convenient and efficient alternative to this which has some nice properties.
/// You maintain the files as normal files, so it’s easy to edit them, but during
/// the build the files are combined into a binary bundle that is linked into the
/// executable. This means that loading the resource files are efficient (as they
/// are already in memory, shared with other instances) and simple (no need to
/// check for things like I/O errors or locate the files in the filesystem). It
/// also makes it easier to create relocatable applications.
/// </para>
/// <para>
/// Resource files can also be marked as compressed. Such files will be included
/// in the resource bundle in a compressed form, but will be automatically
/// uncompressed when the resource is used. This is very useful e.g. for larger
/// text files that are parsed once (or rarely) and then thrown away.
/// </para>
/// <para>
/// Resource files can also be marked to be preprocessed, by setting the value of the
/// `preprocess` attribute to a comma-separated list of preprocessing options.
/// The only options currently supported are:
/// </para>
/// <para>
///  - `xml-stripblanks` which will use the &amp;lt;see href=&quot;man:xmllint(1&quot;&amp;gt;xmllint&amp;lt;/see&amp;gt;) command
///    to strip ignorable whitespace from the XML file. For this to work,
///    the `XMLLINT` environment variable must be set to the full path to
///    the xmllint executable, or xmllint must be in the `PATH`; otherwise
///    the preprocessing step is skipped.
/// </para>
/// <para>
///  - `to-pixdata` (deprecated since gdk-pixbuf 2.32) which will use the
///    `gdk-pixbuf-pixdata` command to convert images to the &amp;lt;see href=&quot;https://docs.gtk.org/gdk-pixbuf/class.Pixdata.html&quot;&amp;gt;GdkPixdata&amp;lt;/see&amp;gt;
///    format, which allows you to create pixbufs directly using the data inside
///    the resource file, rather than an (uncompressed) copy of it. For this, the
///    `gdk-pixbuf-pixdata` program must be in the `PATH`, or the
///    `GDK_PIXBUF_PIXDATA` environment variable must be set to the full path to
///    the `gdk-pixbuf-pixdata` executable; otherwise the resource compiler will
///    abort. `to-pixdata` has been deprecated since gdk-pixbuf 2.32, as
///    `GResource` supports embedding modern image formats just as well. Instead
///    of using it, embed a PNG or SVG file in your `GResource`.
/// </para>
/// <para>
///  - `json-stripblanks` which will use the
///    &amp;lt;see href=&quot;man:json-glib-format(1&quot;&amp;gt;json-glib-format&amp;lt;/see&amp;gt;) command to strip ignorable
///    whitespace from the JSON file. For this to work, the `JSON_GLIB_FORMAT`
///    environment variable must be set to the full path to the
///    `json-glib-format` executable, or it must be in the `PATH`; otherwise the
///    preprocessing step is skipped. In addition, at least version 1.6 of
///    `json-glib-format` is required.
/// </para>
/// <para>
/// Resource files will be exported in the `GResource` namespace using the
/// combination of the given `prefix` and the filename from the `file` element.
/// The `alias` attribute can be used to alter the filename to expose them at a
/// different location in the resource namespace. Typically, this is used to
/// include files from a different source directory without exposing the source
/// directory in the resource namespace, as in the example below.
/// </para>
/// <para>
/// Resource bundles are created by the
/// &amp;lt;see href=&quot;glib-compile-resources.html&quot;&amp;gt;glib-compile-resources&amp;lt;/see&amp;gt; program
/// which takes an XML file that describes the bundle, and a set of files that
/// the XML references. These are combined into a binary resource bundle.
/// </para>
/// <para>
/// An example resource description:
/// ```xml
/// &amp;lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&amp;gt;
/// &amp;lt;gresources&amp;gt;
///   &amp;lt;gresource prefix=&quot;/org/gtk/Example&quot;&amp;gt;
///     &amp;lt;file&amp;gt;data/splashscreen.png&amp;lt;/file&amp;gt;
///     &amp;lt;file compressed=&quot;true&quot;&amp;gt;dialog.ui&amp;lt;/file&amp;gt;
///     &amp;lt;file preprocess=&quot;xml-stripblanks&quot;&amp;gt;menumarkup.xml&amp;lt;/file&amp;gt;
///     &amp;lt;file alias=&quot;example.css&quot;&amp;gt;data/example.css&amp;lt;/file&amp;gt;
///   &amp;lt;/gresource&amp;gt;
/// &amp;lt;/gresources&amp;gt;
/// ```
/// </para>
/// <para>
/// This will create a resource bundle with the following files:
/// ```
/// /org/gtk/Example/data/splashscreen.png
/// /org/gtk/Example/dialog.ui
/// /org/gtk/Example/menumarkup.xml
/// /org/gtk/Example/example.css
/// ```
/// </para>
/// <para>
/// Note that all resources in the process share the same namespace, so use
/// Java-style path prefixes (like in the above example) to avoid conflicts.
/// </para>
/// <para>
/// You can then use &amp;lt;see href=&quot;glib-compile-resources.html&quot;&amp;gt;glib-compile-resources&amp;lt;/see&amp;gt; to
/// compile the XML to a binary bundle that you can load with
/// [func@Gio.Resource.load]. However, it’s more common to use the
/// `--generate-source` and `--generate-header` arguments to create a source file
/// and header to link directly into your application.
/// This will generate `get_resource()`, `register_resource()` and
/// `unregister_resource()` functions, prefixed by the `--c-name` argument passed
/// to &amp;lt;see href=&quot;glib-compile-resources.html&quot;&amp;gt;glib-compile-resources&amp;lt;/see&amp;gt;. `get_resource()`
/// returns the generated `GResource` object. The register and unregister
/// functions register the resource so its files can be accessed using
/// [func@Gio.resources_lookup_data].
/// </para>
/// <para>
/// Once a `GResource` has been created and registered all the data in it can be
/// accessed globally in the process by using API calls like
/// [func@Gio.resources_open_stream] to stream the data or
/// [func@Gio.resources_lookup_data] to get a direct pointer to the data. You can
/// also use URIs like `resource:///org/gtk/Example/data/splashscreen.png` with
/// [iface@Gio.File] to access the resource data.
/// </para>
/// <para>
/// Some higher-level APIs, such as &amp;lt;see href=&quot;https://docs.gtk.org/gtk4/class.Application.html&quot;&amp;gt;GtkApplication&amp;lt;/see&amp;gt;,
/// will automatically load resources from certain well-known paths in the
/// resource namespace as a convenience. See the documentation for those APIs
/// for details.
/// </para>
/// <para>
/// There are two forms of the generated source, the default version uses the
/// compiler support for constructor and destructor functions (where available)
/// to automatically create and register the `GResource` on startup or library
/// load time. If you pass `--manual-register`, two functions to
/// register/unregister the resource are created instead. This requires an
/// explicit initialization call in your application/library, but it works on all
/// platforms, even on the minor ones where constructors are not supported.
/// (Constructor support is available for at least Win32, Mac OS and Linux.)
/// </para>
/// <para>
/// Note that resource data can point directly into the data segment of e.g. a
/// library, so if you are unloading libraries during runtime you need to be very
/// careful with keeping around pointers to data from a resource, as this goes
/// away when the library is unloaded. However, in practice this is not generally
/// a problem, since most resource accesses are for your own resources, and
/// resource data is often used once, during parsing, and then released.
/// </para>
/// <para>
/// # Overlays
/// </para>
/// <para>
/// When debugging a program or testing a change to an installed version, it is
/// often useful to be able to replace resources in the program or library,
/// without recompiling, for debugging or quick hacking and testing purposes.
/// Since GLib 2.50, it is possible to use the `G_RESOURCE_OVERLAYS` environment
/// variable to selectively overlay resources with replacements from the
/// filesystem.  It is a `G_SEARCHPATH_SEPARATOR`-separated list of substitutions
/// to perform during resource lookups. It is ignored when running in a setuid
/// process.
/// </para>
/// <para>
/// A substitution has the form
/// </para>
/// <para>
/// ```
/// /org/gtk/libgtk=/home/desrt/gtk-overlay
/// ```
/// </para>
/// <para>
/// The part before the `=` is the resource subpath for which the overlay
/// applies.  The part after is a filesystem path which contains files and
/// subdirectories as you would like to be loaded as resources with the
/// equivalent names.
/// </para>
/// <para>
/// In the example above, if an application tried to load a resource with the
/// resource path `/org/gtk/libgtk/ui/gtkdialog.ui` then `GResource` would check
/// the filesystem path `/home/desrt/gtk-overlay/ui/gtkdialog.ui`.  If a file was
/// found there, it would be used instead.  This is an overlay, not an outright
/// replacement, which means that if a file is not found at that path, the
/// built-in version will be used instead.  Whiteouts are not currently
/// supported.
/// </para>
/// <para>
/// Substitutions must start with a slash, and must not contain a trailing slash
/// before the `=`.  The path after the slash should ideally be absolute, but
/// this is not strictly required.  It is possible to overlay the location of a
/// single resource with an individual file.
/// </para>
/// </summary>

public class GResourceHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a [struct@Gio.Resource] from a reference to the binary resource bundle.
/// </para>
/// <para>
/// This will keep a reference to @data while the resource lives, so
/// the data should not be modified or freed.
/// </para>
/// <para>
/// If you want to use this resource in the global resource namespace you need
/// to register it with [func@Gio.resources_register].
/// </para>
/// <para>
/// Note: @data must be backed by memory that is at least pointer aligned.
/// Otherwise this function will internally create a copy of the memory since
/// GLib 2.56, or in older versions fail and exit the process.
/// </para>
/// <para>
/// If @data is empty or corrupt, %G_RESOURCE_ERROR_INTERNAL will be returned.
/// </para>
/// </summary>

/// <param name="data">
/// A [struct@GLib.Bytes]
/// </param>
/// <return>
/// a new [struct@Gio.Resource], or `NULL` on error
/// </return>

	public static MentorLake.Gio.GResourceHandle NewFromData(MentorLake.GLib.GBytesHandle data)
	{
		var externCallResult = GResourceExterns.g_resource_new_from_data(data, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}


public static class GResourceExtensions
{
/// <summary>
/// <para>
/// Registers the resource with the process-global set of resources.
/// </para>
/// <para>
/// Once a resource is registered the files in it can be accessed
/// with the global resource lookup functions like
/// [func@Gio.resources_lookup_data].
/// </para>
/// </summary>

/// <param name="resource">
/// A [struct@Gio.Resource]
/// </param>

	public static void Register(this MentorLake.Gio.GResourceHandle resource)
	{
		if (resource.IsInvalid) throw new Exception("Invalid handle (GResource)");
		GResourceExterns.g_resources_register(resource);
	}

/// <summary>
/// <para>
/// Unregisters the resource from the process-global set of resources.
/// </para>
/// </summary>

/// <param name="resource">
/// A [struct@Gio.Resource]
/// </param>

	public static void Unregister(this MentorLake.Gio.GResourceHandle resource)
	{
		if (resource.IsInvalid) throw new Exception("Invalid handle (GResource)");
		GResourceExterns.g_resources_unregister(resource);
	}

/// <summary>
/// <para>
/// Returns all the names of children at the specified @path in the resource.
/// </para>
/// <para>
/// The return result is a `NULL` terminated list of strings which should
/// be released with [func@GLib.strfreev].
/// </para>
/// <para>
/// If @path is invalid or does not exist in the [struct@Gio.Resource],
/// %G_RESOURCE_ERROR_NOT_FOUND will be returned.
/// </para>
/// <para>
/// @lookup_flags controls the behaviour of the lookup.
/// </para>
/// </summary>

/// <param name="resource">
/// A [struct@Gio.Resource]
/// </param>
/// <param name="path">
/// A path name inside the resource
/// </param>
/// <param name="lookup_flags">
/// A [flags@Gio.ResourceLookupFlags]
/// </param>
/// <return>
/// an array of constant strings
/// </return>

	public static string[] EnumerateChildren(this MentorLake.Gio.GResourceHandle resource, string path, MentorLake.Gio.GResourceLookupFlags lookup_flags)
	{
		if (resource.IsInvalid) throw new Exception("Invalid handle (GResource)");
		var externCallResult = GResourceExterns.g_resource_enumerate_children(resource, path, lookup_flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Looks for a file at the specified @path in the resource and
/// if found returns information about it.
/// </para>
/// <para>
/// @lookup_flags controls the behaviour of the lookup.
/// </para>
/// <para>
/// The only error this can return is %G_RESOURCE_ERROR_NOT_FOUND, if @path was
/// not found in @resource.
/// </para>
/// </summary>

/// <param name="resource">
/// A [struct@Gio.Resource]
/// </param>
/// <param name="path">
/// A path name inside the resource
/// </param>
/// <param name="lookup_flags">
/// A [flags@Gio.ResourceLookupFlags]
/// </param>
/// <param name="size">
/// a location to place the length of the contents of the file,
///    or `NULL` if the length is not needed
/// </param>
/// <param name="flags">
/// a location to place the flags about the file,
///    or `NULL` if the length is not needed
/// </param>
/// <return>
/// `TRUE` if the file was found, `FALSE` if there were errors
/// </return>

	public static bool GetInfo(this MentorLake.Gio.GResourceHandle resource, string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out UIntPtr size, out uint flags)
	{
		if (resource.IsInvalid) throw new Exception("Invalid handle (GResource)");
		var externCallResult = GResourceExterns.g_resource_get_info(resource, path, lookup_flags, out size, out flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns whether the specified @path in the resource
/// has children.
/// </para>
/// </summary>

/// <param name="resource">
/// A #GResource
/// </param>
/// <param name="path">
/// A pathname inside the resource
/// </param>
/// <return>
/// %TRUE if @path has children
/// </return>

	public static bool HasChildren(this MentorLake.Gio.GResourceHandle resource, string path)
	{
		if (resource.IsInvalid) throw new Exception("Invalid handle (GResource)");
		return GResourceExterns.g_resource_has_children(resource, path);
	}

/// <summary>
/// <para>
/// Looks for a file at the specified @path in the resource and
/// returns a [struct@GLib.Bytes] that lets you directly access the data in
/// memory.
/// </para>
/// <para>
/// The data is always followed by a zero byte, so you
/// can safely use the data as a C string. However, that byte
/// is not included in the size of the [struct@GLib.Bytes].
/// </para>
/// <para>
/// For uncompressed resource files this is a pointer directly into
/// the resource bundle, which is typically in some read-only data section
/// in the program binary. For compressed files, memory is allocated on
/// the heap and the data is automatically uncompressed.
/// </para>
/// <para>
/// @lookup_flags controls the behaviour of the lookup.
/// </para>
/// <para>
/// This can return error %G_RESOURCE_ERROR_NOT_FOUND if @path was not found in
/// @resource, or %G_RESOURCE_ERROR_INTERNAL if decompression of a compressed
/// resource failed.
/// </para>
/// </summary>

/// <param name="resource">
/// A [struct@Gio.Resource]
/// </param>
/// <param name="path">
/// A path name inside the resource
/// </param>
/// <param name="lookup_flags">
/// A [flags@Gio.ResourceLookupFlags]
/// </param>
/// <return>
/// [struct@GLib.Bytes] or `NULL` on error
/// </return>

	public static MentorLake.GLib.GBytesHandle LookupData(this MentorLake.Gio.GResourceHandle resource, string path, MentorLake.Gio.GResourceLookupFlags lookup_flags)
	{
		if (resource.IsInvalid) throw new Exception("Invalid handle (GResource)");
		var externCallResult = GResourceExterns.g_resource_lookup_data(resource, path, lookup_flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Looks for a file at the specified @path in the resource and
/// returns a [class@Gio.InputStream] that lets you read the data.
/// </para>
/// <para>
/// @lookup_flags controls the behaviour of the lookup.
/// </para>
/// <para>
/// The only error this can return is %G_RESOURCE_ERROR_NOT_FOUND, if @path was
/// not found in @resource.
/// </para>
/// </summary>

/// <param name="resource">
/// A [struct@Gio.Resource]
/// </param>
/// <param name="path">
/// A path name inside the resource
/// </param>
/// <param name="lookup_flags">
/// A [flags@Gio.ResourceLookupFlags]
/// </param>
/// <return>
/// [class@Gio.InputStream] or `NULL` on error
/// </return>

	public static MentorLake.Gio.GInputStreamHandle OpenStream(this MentorLake.Gio.GResourceHandle resource, string path, MentorLake.Gio.GResourceLookupFlags lookup_flags)
	{
		if (resource.IsInvalid) throw new Exception("Invalid handle (GResource)");
		var externCallResult = GResourceExterns.g_resource_open_stream(resource, path, lookup_flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @resource by one.
/// </para>
/// <para>
/// This function is threadsafe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="resource">
/// A [struct@Gio.Resource]
/// </param>
/// <return>
/// The passed in [struct@Gio.Resource]
/// </return>

	public static MentorLake.Gio.GResourceHandle Ref(this MentorLake.Gio.GResourceHandle resource)
	{
		if (resource.IsInvalid) throw new Exception("Invalid handle (GResource)");
		return GResourceExterns.g_resource_ref(resource);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @resource by one.
/// </para>
/// <para>
/// If the reference count drops to 0, all memory allocated by the resource is
/// released. This function is threadsafe and may be called from any
/// thread.
/// </para>
/// </summary>

/// <param name="resource">
/// A [struct@Gio.Resource]
/// </param>

	public static void Unref(this MentorLake.Gio.GResourceHandle resource)
	{
		if (resource.IsInvalid) throw new Exception("Invalid handle (GResource)");
		GResourceExterns.g_resource_unref(resource);
	}


	public static GResource Dereference(this GResourceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GResource>(x.DangerousGetHandle());
}
internal class GResourceExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))]
	internal static extern MentorLake.Gio.GResourceHandle g_resource_new_from_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle data, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resources_register([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resources_unregister([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_resource_enumerate_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource, string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_resource_get_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource, string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out UIntPtr size, out uint flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_resource_has_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource, string path);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle g_resource_lookup_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource, string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle g_resource_open_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource, string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))]
	internal static extern MentorLake.Gio.GResourceHandle g_resource_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resource_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))]
	internal static extern MentorLake.Gio.GResourceHandle g_resource_load(string filename, out MentorLake.GLib.GErrorHandle error);

}

/// <summary>
/// <para>
/// Applications and libraries often contain binary or textual data that is
/// really part of the application, rather than user data. For instance
/// &amp;lt;see href=&quot;https://docs.gtk.org/gtk4/class.Builder.html&quot;&amp;gt;GtkBuilder&amp;lt;/see&amp;gt; `.ui` files,
/// splashscreen images, [class@Gio.Menu] markup XML, CSS files, icons, etc.
/// These are often shipped as files in `$datadir/appname`, or manually
/// included as literal strings in the code.
/// </para>
/// <para>
/// The `GResource` API and the
/// &amp;lt;see href=&quot;glib-compile-resources.html&quot;&amp;gt;glib-compile-resources&amp;lt;/see&amp;gt; program provide a
/// convenient and efficient alternative to this which has some nice properties.
/// You maintain the files as normal files, so it’s easy to edit them, but during
/// the build the files are combined into a binary bundle that is linked into the
/// executable. This means that loading the resource files are efficient (as they
/// are already in memory, shared with other instances) and simple (no need to
/// check for things like I/O errors or locate the files in the filesystem). It
/// also makes it easier to create relocatable applications.
/// </para>
/// <para>
/// Resource files can also be marked as compressed. Such files will be included
/// in the resource bundle in a compressed form, but will be automatically
/// uncompressed when the resource is used. This is very useful e.g. for larger
/// text files that are parsed once (or rarely) and then thrown away.
/// </para>
/// <para>
/// Resource files can also be marked to be preprocessed, by setting the value of the
/// `preprocess` attribute to a comma-separated list of preprocessing options.
/// The only options currently supported are:
/// </para>
/// <para>
///  - `xml-stripblanks` which will use the &amp;lt;see href=&quot;man:xmllint(1&quot;&amp;gt;xmllint&amp;lt;/see&amp;gt;) command
///    to strip ignorable whitespace from the XML file. For this to work,
///    the `XMLLINT` environment variable must be set to the full path to
///    the xmllint executable, or xmllint must be in the `PATH`; otherwise
///    the preprocessing step is skipped.
/// </para>
/// <para>
///  - `to-pixdata` (deprecated since gdk-pixbuf 2.32) which will use the
///    `gdk-pixbuf-pixdata` command to convert images to the &amp;lt;see href=&quot;https://docs.gtk.org/gdk-pixbuf/class.Pixdata.html&quot;&amp;gt;GdkPixdata&amp;lt;/see&amp;gt;
///    format, which allows you to create pixbufs directly using the data inside
///    the resource file, rather than an (uncompressed) copy of it. For this, the
///    `gdk-pixbuf-pixdata` program must be in the `PATH`, or the
///    `GDK_PIXBUF_PIXDATA` environment variable must be set to the full path to
///    the `gdk-pixbuf-pixdata` executable; otherwise the resource compiler will
///    abort. `to-pixdata` has been deprecated since gdk-pixbuf 2.32, as
///    `GResource` supports embedding modern image formats just as well. Instead
///    of using it, embed a PNG or SVG file in your `GResource`.
/// </para>
/// <para>
///  - `json-stripblanks` which will use the
///    &amp;lt;see href=&quot;man:json-glib-format(1&quot;&amp;gt;json-glib-format&amp;lt;/see&amp;gt;) command to strip ignorable
///    whitespace from the JSON file. For this to work, the `JSON_GLIB_FORMAT`
///    environment variable must be set to the full path to the
///    `json-glib-format` executable, or it must be in the `PATH`; otherwise the
///    preprocessing step is skipped. In addition, at least version 1.6 of
///    `json-glib-format` is required.
/// </para>
/// <para>
/// Resource files will be exported in the `GResource` namespace using the
/// combination of the given `prefix` and the filename from the `file` element.
/// The `alias` attribute can be used to alter the filename to expose them at a
/// different location in the resource namespace. Typically, this is used to
/// include files from a different source directory without exposing the source
/// directory in the resource namespace, as in the example below.
/// </para>
/// <para>
/// Resource bundles are created by the
/// &amp;lt;see href=&quot;glib-compile-resources.html&quot;&amp;gt;glib-compile-resources&amp;lt;/see&amp;gt; program
/// which takes an XML file that describes the bundle, and a set of files that
/// the XML references. These are combined into a binary resource bundle.
/// </para>
/// <para>
/// An example resource description:
/// ```xml
/// &amp;lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&amp;gt;
/// &amp;lt;gresources&amp;gt;
///   &amp;lt;gresource prefix=&quot;/org/gtk/Example&quot;&amp;gt;
///     &amp;lt;file&amp;gt;data/splashscreen.png&amp;lt;/file&amp;gt;
///     &amp;lt;file compressed=&quot;true&quot;&amp;gt;dialog.ui&amp;lt;/file&amp;gt;
///     &amp;lt;file preprocess=&quot;xml-stripblanks&quot;&amp;gt;menumarkup.xml&amp;lt;/file&amp;gt;
///     &amp;lt;file alias=&quot;example.css&quot;&amp;gt;data/example.css&amp;lt;/file&amp;gt;
///   &amp;lt;/gresource&amp;gt;
/// &amp;lt;/gresources&amp;gt;
/// ```
/// </para>
/// <para>
/// This will create a resource bundle with the following files:
/// ```
/// /org/gtk/Example/data/splashscreen.png
/// /org/gtk/Example/dialog.ui
/// /org/gtk/Example/menumarkup.xml
/// /org/gtk/Example/example.css
/// ```
/// </para>
/// <para>
/// Note that all resources in the process share the same namespace, so use
/// Java-style path prefixes (like in the above example) to avoid conflicts.
/// </para>
/// <para>
/// You can then use &amp;lt;see href=&quot;glib-compile-resources.html&quot;&amp;gt;glib-compile-resources&amp;lt;/see&amp;gt; to
/// compile the XML to a binary bundle that you can load with
/// [func@Gio.Resource.load]. However, it’s more common to use the
/// `--generate-source` and `--generate-header` arguments to create a source file
/// and header to link directly into your application.
/// This will generate `get_resource()`, `register_resource()` and
/// `unregister_resource()` functions, prefixed by the `--c-name` argument passed
/// to &amp;lt;see href=&quot;glib-compile-resources.html&quot;&amp;gt;glib-compile-resources&amp;lt;/see&amp;gt;. `get_resource()`
/// returns the generated `GResource` object. The register and unregister
/// functions register the resource so its files can be accessed using
/// [func@Gio.resources_lookup_data].
/// </para>
/// <para>
/// Once a `GResource` has been created and registered all the data in it can be
/// accessed globally in the process by using API calls like
/// [func@Gio.resources_open_stream] to stream the data or
/// [func@Gio.resources_lookup_data] to get a direct pointer to the data. You can
/// also use URIs like `resource:///org/gtk/Example/data/splashscreen.png` with
/// [iface@Gio.File] to access the resource data.
/// </para>
/// <para>
/// Some higher-level APIs, such as &amp;lt;see href=&quot;https://docs.gtk.org/gtk4/class.Application.html&quot;&amp;gt;GtkApplication&amp;lt;/see&amp;gt;,
/// will automatically load resources from certain well-known paths in the
/// resource namespace as a convenience. See the documentation for those APIs
/// for details.
/// </para>
/// <para>
/// There are two forms of the generated source, the default version uses the
/// compiler support for constructor and destructor functions (where available)
/// to automatically create and register the `GResource` on startup or library
/// load time. If you pass `--manual-register`, two functions to
/// register/unregister the resource are created instead. This requires an
/// explicit initialization call in your application/library, but it works on all
/// platforms, even on the minor ones where constructors are not supported.
/// (Constructor support is available for at least Win32, Mac OS and Linux.)
/// </para>
/// <para>
/// Note that resource data can point directly into the data segment of e.g. a
/// library, so if you are unloading libraries during runtime you need to be very
/// careful with keeping around pointers to data from a resource, as this goes
/// away when the library is unloaded. However, in practice this is not generally
/// a problem, since most resource accesses are for your own resources, and
/// resource data is often used once, during parsing, and then released.
/// </para>
/// <para>
/// # Overlays
/// </para>
/// <para>
/// When debugging a program or testing a change to an installed version, it is
/// often useful to be able to replace resources in the program or library,
/// without recompiling, for debugging or quick hacking and testing purposes.
/// Since GLib 2.50, it is possible to use the `G_RESOURCE_OVERLAYS` environment
/// variable to selectively overlay resources with replacements from the
/// filesystem.  It is a `G_SEARCHPATH_SEPARATOR`-separated list of substitutions
/// to perform during resource lookups. It is ignored when running in a setuid
/// process.
/// </para>
/// <para>
/// A substitution has the form
/// </para>
/// <para>
/// ```
/// /org/gtk/libgtk=/home/desrt/gtk-overlay
/// ```
/// </para>
/// <para>
/// The part before the `=` is the resource subpath for which the overlay
/// applies.  The part after is a filesystem path which contains files and
/// subdirectories as you would like to be loaded as resources with the
/// equivalent names.
/// </para>
/// <para>
/// In the example above, if an application tried to load a resource with the
/// resource path `/org/gtk/libgtk/ui/gtkdialog.ui` then `GResource` would check
/// the filesystem path `/home/desrt/gtk-overlay/ui/gtkdialog.ui`.  If a file was
/// found there, it would be used instead.  This is an overlay, not an outright
/// replacement, which means that if a file is not found at that path, the
/// built-in version will be used instead.  Whiteouts are not currently
/// supported.
/// </para>
/// <para>
/// Substitutions must start with a slash, and must not contain a trailing slash
/// before the `=`.  The path after the slash should ideally be absolute, but
/// this is not strictly required.  It is possible to overlay the location of a
/// single resource with an individual file.
/// </para>
/// </summary>

public struct GResource
{
/// <summary>
/// <para>
/// Loads a binary resource bundle and creates a [struct@Gio.Resource]
/// representation of it, allowing you to query it for data.
/// </para>
/// <para>
/// If you want to use this resource in the global resource namespace you need
/// to register it with [func@Gio.resources_register].
/// </para>
/// <para>
/// If @filename is empty or the data in it is corrupt,
/// %G_RESOURCE_ERROR_INTERNAL will be returned. If @filename doesn’t exist, or
/// there is an error in reading it, an error from [ctor@GLib.MappedFile.new]
/// will be returned.
/// </para>
/// </summary>

/// <param name="filename">
/// the path of a filename to load, in the GLib filename encoding
/// </param>
/// <return>
/// a new [struct@Gio.Resource], or `NULL` on error
/// </return>

	public static MentorLake.Gio.GResourceHandle Load(string filename)
	{
		var externCallResult = GResourceExterns.g_resource_load(filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}
