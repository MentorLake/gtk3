namespace MentorLake.Gtk;

public class GtkPaperSizeHandle : BaseSafeHandle
{
	public static MentorLake.Gtk.GtkPaperSizeHandle New(string name)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new(name);
	}

	public static MentorLake.Gtk.GtkPaperSizeHandle NewCustom(string name, string display_name, double width, double height, MentorLake.Gtk.GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_custom(name, display_name, width, height, unit);
	}

	public static MentorLake.Gtk.GtkPaperSizeHandle NewFromGvariant(MentorLake.GLib.GVariantHandle variant)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_gvariant(variant);
	}

	public static MentorLake.Gtk.GtkPaperSizeHandle NewFromIpp(string ipp_name, double width, double height)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_ipp(ipp_name, width, height);
	}

	public static MentorLake.Gtk.GtkPaperSizeHandle NewFromKeyFile(MentorLake.GLib.GKeyFileHandle key_file, string group_name, IntPtr error)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_key_file(key_file, group_name, error);
	}

	public static MentorLake.Gtk.GtkPaperSizeHandle NewFromPpd(string ppd_name, string ppd_display_name, double width, double height)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_ppd(ppd_name, ppd_display_name, width, height);
	}

}


public static class GtkPaperSizeExtensions
{
	public static MentorLake.Gtk.GtkPaperSizeHandle Copy(this MentorLake.Gtk.GtkPaperSizeHandle other)
	{
		return GtkPaperSizeExterns.gtk_paper_size_copy(other);
	}

	public static void Free(this MentorLake.Gtk.GtkPaperSizeHandle size)
	{
		GtkPaperSizeExterns.gtk_paper_size_free(size);
	}

	public static double GetDefaultBottomMargin(this MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_default_bottom_margin(size, unit);
	}

	public static double GetDefaultLeftMargin(this MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_default_left_margin(size, unit);
	}

	public static double GetDefaultRightMargin(this MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_default_right_margin(size, unit);
	}

	public static double GetDefaultTopMargin(this MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_default_top_margin(size, unit);
	}

	public static string GetDisplayName(this MentorLake.Gtk.GtkPaperSizeHandle size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_display_name(size);
	}

	public static double GetHeight(this MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_height(size, unit);
	}

	public static string GetName(this MentorLake.Gtk.GtkPaperSizeHandle size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_name(size);
	}

	public static string GetPpdName(this MentorLake.Gtk.GtkPaperSizeHandle size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_ppd_name(size);
	}

	public static double GetWidth(this MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_width(size, unit);
	}

	public static bool IsCustom(this MentorLake.Gtk.GtkPaperSizeHandle size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_is_custom(size);
	}

	public static bool IsEqual(this MentorLake.Gtk.GtkPaperSizeHandle size1, MentorLake.Gtk.GtkPaperSizeHandle size2)
	{
		return GtkPaperSizeExterns.gtk_paper_size_is_equal(size1, size2);
	}

	public static bool IsIpp(this MentorLake.Gtk.GtkPaperSizeHandle size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_is_ipp(size);
	}

	public static void SetSize(this MentorLake.Gtk.GtkPaperSizeHandle size, double width, double height, MentorLake.Gtk.GtkUnit unit)
	{
		GtkPaperSizeExterns.gtk_paper_size_set_size(size, width, height, unit);
	}

	public static MentorLake.GLib.GVariantHandle ToGvariant(this MentorLake.Gtk.GtkPaperSizeHandle paper_size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_to_gvariant(paper_size);
	}

	public static void ToKeyFile(this MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.GLib.GKeyFileHandle key_file, string group_name)
	{
		GtkPaperSizeExterns.gtk_paper_size_to_key_file(size, key_file, group_name);
	}


	public static GtkPaperSize Dereference(this GtkPaperSizeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkPaperSize>(x.DangerousGetHandle());
}
internal class GtkPaperSizeExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPaperSizeHandle gtk_paper_size_new(string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPaperSizeHandle gtk_paper_size_new_custom(string name, string display_name, double width, double height, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPaperSizeHandle gtk_paper_size_new_from_gvariant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle variant);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPaperSizeHandle gtk_paper_size_new_from_ipp(string ipp_name, double width, double height);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPaperSizeHandle gtk_paper_size_new_from_key_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, IntPtr error);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPaperSizeHandle gtk_paper_size_new_from_ppd(string ppd_name, string ppd_display_name, double width, double height);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPaperSizeHandle gtk_paper_size_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle other);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paper_size_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_paper_size_get_default_bottom_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_paper_size_get_default_left_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_paper_size_get_default_right_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_paper_size_get_default_top_margin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_paper_size_get_display_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_paper_size_get_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_paper_size_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_paper_size_get_ppd_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_paper_size_get_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_paper_size_is_custom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_paper_size_is_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size2);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_paper_size_is_ipp([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paper_size_set_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size, double width, double height, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle gtk_paper_size_to_gvariant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle paper_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_paper_size_to_key_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPaperSizeHandle>))] MentorLake.Gtk.GtkPaperSizeHandle size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_paper_size_get_default();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gtk_paper_size_get_paper_sizes(bool include_custom);

}

public struct GtkPaperSize
{
	public static string GetDefault()
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_default();
	}

	public static MentorLake.GLib.GListHandle GetPaperSizes(bool include_custom)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_paper_sizes(include_custom);
	}

}
