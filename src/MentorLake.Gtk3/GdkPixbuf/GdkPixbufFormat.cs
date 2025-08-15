namespace MentorLake.GdkPixbuf;

/// <summary>
/// <para>
/// A `GdkPixbufFormat` contains information about the image format accepted
/// by a module.
/// </para>
/// <para>
/// Only modules should access the fields directly, applications should
/// use the `gdk_pixbuf_format_*` family of functions.
/// </para>
/// </summary>

public class GdkPixbufFormatHandle : BaseSafeHandle
{
}


public static class GdkPixbufFormatExtensions
{
/// <summary>
/// <para>
/// Creates a copy of `format`.
/// </para>
/// </summary>

/// <param name="format">
/// a pixbuf format
/// </param>
/// <return>
/// the newly allocated copy of a `GdkPixbufFormat`. Use
///   gdk_pixbuf_format_free() to free the resources when done
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufFormatHandle Copy(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid) throw new Exception("Invalid handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_copy(format);
	}

/// <summary>
/// <para>
/// Frees the resources allocated when copying a `GdkPixbufFormat`
/// using gdk_pixbuf_format_copy()
/// </para>
/// </summary>

/// <param name="format">
/// a pixbuf format
/// </param>

	public static void Free(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid) throw new Exception("Invalid handle (GdkPixbufFormat)");
		GdkPixbufFormatExterns.gdk_pixbuf_format_free(format);
	}

/// <summary>
/// <para>
/// Returns a description of the format.
/// </para>
/// </summary>

/// <param name="format">
/// a `GdkPixbufFormat`
/// </param>
/// <return>
/// a description of the format.
/// </return>

	public static string GetDescription(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid) throw new Exception("Invalid handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_get_description(format);
	}

/// <summary>
/// <para>
/// Returns the filename extensions typically used for files in the
/// given format.
/// </para>
/// </summary>

/// <param name="format">
/// a `GdkPixbufFormat`
/// </param>
/// <return>
/// an array of
///   filename extensions
/// </return>

	public static string[] GetExtensions(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid) throw new Exception("Invalid handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_get_extensions(format);
	}

/// <summary>
/// <para>
/// Returns information about the license of the image loader for the format.
/// </para>
/// <para>
/// The returned string should be a shorthand for a well known license, e.g.
/// &quot;LGPL&quot;, &quot;GPL&quot;, &quot;QPL&quot;, &quot;GPL/QPL&quot;, or &quot;other&quot; to indicate some other license.
/// </para>
/// </summary>

/// <param name="format">
/// a pixbuf format
/// </param>
/// <return>
/// a string describing the license of the pixbuf format
/// </return>

	public static string GetLicense(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid) throw new Exception("Invalid handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_get_license(format);
	}

/// <summary>
/// <para>
/// Returns the mime types supported by the format.
/// </para>
/// </summary>

/// <param name="format">
/// a `GdkPixbufFormat`
/// </param>
/// <return>
/// an array of mime types
/// </return>

	public static string[] GetMimeTypes(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid) throw new Exception("Invalid handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_get_mime_types(format);
	}

/// <summary>
/// <para>
/// Returns the name of the format.
/// </para>
/// </summary>

/// <param name="format">
/// a `GdkPixbufFormat`
/// </param>
/// <return>
/// the name of the format.
/// </return>

	public static string GetName(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid) throw new Exception("Invalid handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_get_name(format);
	}

/// <summary>
/// <para>
/// Returns whether this image format is disabled.
/// </para>
/// <para>
/// See gdk_pixbuf_format_set_disabled().
/// </para>
/// </summary>

/// <param name="format">
/// a `GdkPixbufFormat`
/// </param>
/// <return>
/// whether this image format is disabled.
/// </return>

	public static bool IsDisabled(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid) throw new Exception("Invalid handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_is_disabled(format);
	}

/// <summary>
/// <para>
/// Returns `TRUE` if the save option specified by @option_key is supported when
/// saving a pixbuf using the module implementing @format.
/// </para>
/// <para>
/// See gdk_pixbuf_save() for more information about option keys.
/// </para>
/// </summary>

/// <param name="format">
/// a pixbuf format
/// </param>
/// <param name="option_key">
/// the name of an option
/// </param>
/// <return>
/// `TRUE` if the specified option is supported
/// </return>

	public static bool IsSaveOptionSupported(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format, string option_key)
	{
		if (format.IsInvalid) throw new Exception("Invalid handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_is_save_option_supported(format, option_key);
	}

/// <summary>
/// <para>
/// Returns whether this image format is scalable.
/// </para>
/// <para>
/// If a file is in a scalable format, it is preferable to load it at
/// the desired size, rather than loading it at the default size and
/// scaling the resulting pixbuf to the desired size.
/// </para>
/// </summary>

/// <param name="format">
/// a `GdkPixbufFormat`
/// </param>
/// <return>
/// whether this image format is scalable.
/// </return>

	public static bool IsScalable(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid) throw new Exception("Invalid handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_is_scalable(format);
	}

/// <summary>
/// <para>
/// Returns whether pixbufs can be saved in the given format.
/// </para>
/// </summary>

/// <param name="format">
/// a `GdkPixbufFormat`
/// </param>
/// <return>
/// whether pixbufs can be saved in the given format.
/// </return>

	public static bool IsWritable(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid) throw new Exception("Invalid handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_is_writable(format);
	}

/// <summary>
/// <para>
/// Disables or enables an image format.
/// </para>
/// <para>
/// If a format is disabled, GdkPixbuf won&apos;t use the image loader for
/// this format to load images.
/// </para>
/// <para>
/// Applications can use this to avoid using image loaders with an
/// inappropriate license, see gdk_pixbuf_format_get_license().
/// </para>
/// </summary>

/// <param name="format">
/// a `GdkPixbufFormat`
/// </param>
/// <param name="disabled">
/// `TRUE` to disable the format @format
/// </param>

	public static void SetDisabled(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format, bool disabled)
	{
		if (format.IsInvalid) throw new Exception("Invalid handle (GdkPixbufFormat)");
		GdkPixbufFormatExterns.gdk_pixbuf_format_set_disabled(format, disabled);
	}


	public static GdkPixbufFormat Dereference(this GdkPixbufFormatHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkPixbufFormat>(x.DangerousGetHandle());
}
internal class GdkPixbufFormatExterns
{
	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufFormatHandle gdk_pixbuf_format_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))] MentorLake.GdkPixbuf.GdkPixbufFormatHandle format);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_format_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))] MentorLake.GdkPixbuf.GdkPixbufFormatHandle format);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_pixbuf_format_get_description([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))] MentorLake.GdkPixbuf.GdkPixbufFormatHandle format);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gdk_pixbuf_format_get_extensions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))] MentorLake.GdkPixbuf.GdkPixbufFormatHandle format);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_pixbuf_format_get_license([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))] MentorLake.GdkPixbuf.GdkPixbufFormatHandle format);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gdk_pixbuf_format_get_mime_types([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))] MentorLake.GdkPixbuf.GdkPixbufFormatHandle format);

	[DllImport(GdkPixbufLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gdk_pixbuf_format_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))] MentorLake.GdkPixbuf.GdkPixbufFormatHandle format);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_format_is_disabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))] MentorLake.GdkPixbuf.GdkPixbufFormatHandle format);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_format_is_save_option_supported([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))] MentorLake.GdkPixbuf.GdkPixbufFormatHandle format, string option_key);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_format_is_scalable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))] MentorLake.GdkPixbuf.GdkPixbufFormatHandle format);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern bool gdk_pixbuf_format_is_writable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))] MentorLake.GdkPixbuf.GdkPixbufFormatHandle format);

	[DllImport(GdkPixbufLibrary.Name)]
	internal static extern void gdk_pixbuf_format_set_disabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufFormatHandle>))] MentorLake.GdkPixbuf.GdkPixbufFormatHandle format, bool disabled);

}

/// <summary>
/// <para>
/// A `GdkPixbufFormat` contains information about the image format accepted
/// by a module.
/// </para>
/// <para>
/// Only modules should access the fields directly, applications should
/// use the `gdk_pixbuf_format_*` family of functions.
/// </para>
/// </summary>

public struct GdkPixbufFormat
{
	/// <summary>
/// <para>
/// the name of the image format
/// </para>
/// </summary>

public string name;
	/// <summary>
/// <para>
/// the signature of the module
/// </para>
/// </summary>

public IntPtr signature;
	/// <summary>
/// <para>
/// the message domain for the `description`
/// </para>
/// </summary>

public string domain;
	/// <summary>
/// <para>
/// a description of the image format
/// </para>
/// </summary>

public string description;
	/// <summary>
/// <para>
/// the MIME types for the image format
/// </para>
/// </summary>

[MarshalAs(UnmanagedType.ByValArray)] public string[] mime_types;
	/// <summary>
/// <para>
/// typical filename extensions for the
///   image format
/// </para>
/// </summary>

[MarshalAs(UnmanagedType.ByValArray)] public string[] extensions;
	/// <summary>
/// <para>
/// a combination of `GdkPixbufFormatFlags`
/// </para>
/// </summary>

public uint flags;
	/// <summary>
/// <para>
/// a boolean determining whether the loader is disabled`
/// </para>
/// </summary>

public bool disabled;
	/// <summary>
/// <para>
/// a string containing license information, typically set to
///   shorthands like &quot;GPL&quot;, &quot;LGPL&quot;, etc.
/// </para>
/// </summary>

public string license;
}
