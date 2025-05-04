namespace MentorLake.GdkPixbuf;

public class GdkPixbufFormatHandle : BaseSafeHandle
{
}


public static class GdkPixbufFormatExtensions
{
	public static MentorLake.GdkPixbuf.GdkPixbufFormatHandle Copy(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid || format.IsClosed) throw new Exception("Invalid or closed handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_copy(format);
	}

	public static void Free(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid || format.IsClosed) throw new Exception("Invalid or closed handle (GdkPixbufFormat)");
		GdkPixbufFormatExterns.gdk_pixbuf_format_free(format);
	}

	public static string GetDescription(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid || format.IsClosed) throw new Exception("Invalid or closed handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_get_description(format);
	}

	public static string[] GetExtensions(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid || format.IsClosed) throw new Exception("Invalid or closed handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_get_extensions(format);
	}

	public static string GetLicense(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid || format.IsClosed) throw new Exception("Invalid or closed handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_get_license(format);
	}

	public static string[] GetMimeTypes(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid || format.IsClosed) throw new Exception("Invalid or closed handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_get_mime_types(format);
	}

	public static string GetName(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid || format.IsClosed) throw new Exception("Invalid or closed handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_get_name(format);
	}

	public static bool IsDisabled(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid || format.IsClosed) throw new Exception("Invalid or closed handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_is_disabled(format);
	}

	public static bool IsSaveOptionSupported(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format, string option_key)
	{
		if (format.IsInvalid || format.IsClosed) throw new Exception("Invalid or closed handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_is_save_option_supported(format, option_key);
	}

	public static bool IsScalable(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid || format.IsClosed) throw new Exception("Invalid or closed handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_is_scalable(format);
	}

	public static bool IsWritable(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format)
	{
		if (format.IsInvalid || format.IsClosed) throw new Exception("Invalid or closed handle (GdkPixbufFormat)");
		return GdkPixbufFormatExterns.gdk_pixbuf_format_is_writable(format);
	}

	public static void SetDisabled(this MentorLake.GdkPixbuf.GdkPixbufFormatHandle format, bool disabled)
	{
		if (format.IsInvalid || format.IsClosed) throw new Exception("Invalid or closed handle (GdkPixbufFormat)");
		GdkPixbufFormatExterns.gdk_pixbuf_format_set_disabled(format, disabled);
	}


	public static GdkPixbufFormat Dereference(this GdkPixbufFormatHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkPixbufFormat>(x.DangerousGetHandle());
}
internal class GdkPixbufFormatExterns
{
	[DllImport(GdkPixbufLibrary.Name)]
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

public struct GdkPixbufFormat
{
	public string name;
	public IntPtr signature;
	public string domain;
	public string description;
	[MarshalAs(UnmanagedType.ByValArray)] public string[] mime_types;
	[MarshalAs(UnmanagedType.ByValArray)] public string[] extensions;
	public uint flags;
	public bool disabled;
	public string license;
}
