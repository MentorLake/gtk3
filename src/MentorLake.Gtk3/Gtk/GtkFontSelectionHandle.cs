namespace MentorLake.Gtk;

public class GtkFontSelectionHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkFontSelectionHandle New()
	{
		return GtkFontSelectionHandleExterns.gtk_font_selection_new();
	}

}

public static class GtkFontSelectionHandleExtensions
{
	public static MentorLake.Pango.PangoFontFaceHandle GetFace(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_face(fontsel);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetFaceList(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_face_list(fontsel);
	}

	public static MentorLake.Pango.PangoFontFamilyHandle GetFamily(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_family(fontsel);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetFamilyList(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_family_list(fontsel);
	}

	public static string GetFontName(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_font_name(fontsel);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetPreviewEntry(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_preview_entry(fontsel);
	}

	public static string GetPreviewText(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_preview_text(fontsel);
	}

	public static int GetSize(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_size(fontsel);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetSizeEntry(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_size_entry(fontsel);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetSizeList(this MentorLake.Gtk.GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionHandleExterns.gtk_font_selection_get_size_list(fontsel);
	}

	public static bool SetFontName(this MentorLake.Gtk.GtkFontSelectionHandle fontsel, string fontname)
	{
		return GtkFontSelectionHandleExterns.gtk_font_selection_set_font_name(fontsel, fontname);
	}

	public static T SetPreviewText<T>(this T fontsel, string text) where T : GtkFontSelectionHandle
	{
		GtkFontSelectionHandleExterns.gtk_font_selection_set_preview_text(fontsel, text);
		return fontsel;
	}

}

internal class GtkFontSelectionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFontSelectionHandle gtk_font_selection_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontFaceHandle gtk_font_selection_get_face([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_font_selection_get_face_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontFamilyHandle gtk_font_selection_get_family([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_font_selection_get_family_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_selection_get_font_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_font_selection_get_preview_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_selection_get_preview_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_font_selection_get_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_font_selection_get_size_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_font_selection_get_size_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_font_selection_set_font_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel, string fontname);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_font_selection_set_preview_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFontSelectionHandle>))] MentorLake.Gtk.GtkFontSelectionHandle fontsel, string text);

}
