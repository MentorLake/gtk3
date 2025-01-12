namespace MentorLake.Gtk3.Gtk3;

public class GtkPaperSizeHandle : BaseSafeHandle
{
	public static GtkPaperSizeHandle New(string name)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new(name);
	}

	public static GtkPaperSizeHandle NewCustom(string name, string display_name, double width, double height, GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_custom(name, display_name, width, height, unit);
	}

	public static GtkPaperSizeHandle NewFromGvariant(GVariantHandle variant)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_gvariant(variant);
	}

	public static GtkPaperSizeHandle NewFromIpp(string ipp_name, double width, double height)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_ipp(ipp_name, width, height);
	}

	public static GtkPaperSizeHandle NewFromKeyFile(GKeyFileHandle key_file, string group_name, out GErrorHandle error)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_key_file(key_file, group_name, out error);
	}

	public static GtkPaperSizeHandle NewFromPpd(string ppd_name, string ppd_display_name, double width, double height)
	{
		return GtkPaperSizeExterns.gtk_paper_size_new_from_ppd(ppd_name, ppd_display_name, width, height);
	}

}


public static class GtkPaperSizeHandleExtensions
{
	public static GtkPaperSizeHandle Copy(this GtkPaperSizeHandle other)
	{
		return GtkPaperSizeExterns.gtk_paper_size_copy(other);
	}

	public static T Free<T>(this T size) where T : GtkPaperSizeHandle
	{
		GtkPaperSizeExterns.gtk_paper_size_free(size);
		return size;
	}

	public static double GetDefaultBottomMargin(this GtkPaperSizeHandle size, GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_default_bottom_margin(size, unit);
	}

	public static double GetDefaultLeftMargin(this GtkPaperSizeHandle size, GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_default_left_margin(size, unit);
	}

	public static double GetDefaultRightMargin(this GtkPaperSizeHandle size, GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_default_right_margin(size, unit);
	}

	public static double GetDefaultTopMargin(this GtkPaperSizeHandle size, GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_default_top_margin(size, unit);
	}

	public static string GetDisplayName(this GtkPaperSizeHandle size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_display_name(size);
	}

	public static double GetHeight(this GtkPaperSizeHandle size, GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_height(size, unit);
	}

	public static string GetName(this GtkPaperSizeHandle size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_name(size);
	}

	public static string GetPpdName(this GtkPaperSizeHandle size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_ppd_name(size);
	}

	public static double GetWidth(this GtkPaperSizeHandle size, GtkUnit unit)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_width(size, unit);
	}

	public static bool IsCustom(this GtkPaperSizeHandle size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_is_custom(size);
	}

	public static bool IsEqual(this GtkPaperSizeHandle size1, GtkPaperSizeHandle size2)
	{
		return GtkPaperSizeExterns.gtk_paper_size_is_equal(size1, size2);
	}

	public static bool IsIpp(this GtkPaperSizeHandle size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_is_ipp(size);
	}

	public static T SetSize<T>(this T size, double width, double height, GtkUnit unit) where T : GtkPaperSizeHandle
	{
		GtkPaperSizeExterns.gtk_paper_size_set_size(size, width, height, unit);
		return size;
	}

	public static GVariantHandle ToGvariant(this GtkPaperSizeHandle paper_size)
	{
		return GtkPaperSizeExterns.gtk_paper_size_to_gvariant(paper_size);
	}

	public static T ToKeyFile<T>(this T size, GKeyFileHandle key_file, string group_name) where T : GtkPaperSizeHandle
	{
		GtkPaperSizeExterns.gtk_paper_size_to_key_file(size, key_file, group_name);
		return size;
	}

	public static string GetDefault()
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_default();
	}

	public static GListHandle GetPaperSizes(bool include_custom)
	{
		return GtkPaperSizeExterns.gtk_paper_size_get_paper_sizes(include_custom);
	}

}
internal class GtkPaperSizeExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPaperSizeHandle gtk_paper_size_new(string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPaperSizeHandle gtk_paper_size_new_custom(string name, string display_name, double width, double height, GtkUnit unit);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPaperSizeHandle gtk_paper_size_new_from_gvariant(GVariantHandle variant);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPaperSizeHandle gtk_paper_size_new_from_ipp(string ipp_name, double width, double height);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPaperSizeHandle gtk_paper_size_new_from_key_file(GKeyFileHandle key_file, string group_name, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPaperSizeHandle gtk_paper_size_new_from_ppd(string ppd_name, string ppd_display_name, double width, double height);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPaperSizeHandle gtk_paper_size_copy(GtkPaperSizeHandle other);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paper_size_free(GtkPaperSizeHandle size);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_paper_size_get_default_bottom_margin(GtkPaperSizeHandle size, GtkUnit unit);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_paper_size_get_default_left_margin(GtkPaperSizeHandle size, GtkUnit unit);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_paper_size_get_default_right_margin(GtkPaperSizeHandle size, GtkUnit unit);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_paper_size_get_default_top_margin(GtkPaperSizeHandle size, GtkUnit unit);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_paper_size_get_display_name(GtkPaperSizeHandle size);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_paper_size_get_height(GtkPaperSizeHandle size, GtkUnit unit);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_paper_size_get_name(GtkPaperSizeHandle size);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_paper_size_get_ppd_name(GtkPaperSizeHandle size);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_paper_size_get_width(GtkPaperSizeHandle size, GtkUnit unit);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_paper_size_is_custom(GtkPaperSizeHandle size);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_paper_size_is_equal(GtkPaperSizeHandle size1, GtkPaperSizeHandle size2);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_paper_size_is_ipp(GtkPaperSizeHandle size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paper_size_set_size(GtkPaperSizeHandle size, double width, double height, GtkUnit unit);

	[DllImport(Libraries.Gtk3)]
	internal static extern GVariantHandle gtk_paper_size_to_gvariant(GtkPaperSizeHandle paper_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_paper_size_to_key_file(GtkPaperSizeHandle size, GKeyFileHandle key_file, string group_name);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_paper_size_get_default();

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_paper_size_get_paper_sizes(bool include_custom);

}

public struct GtkPaperSize
{
}
