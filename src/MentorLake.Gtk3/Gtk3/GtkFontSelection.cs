namespace MentorLake.Gtk3.Gtk3;

public class GtkFontSelectionHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkFontSelectionHandle New()
	{
		return GtkFontSelectionExterns.gtk_font_selection_new();
	}

}

public static class GtkFontSelectionHandleExtensions
{
	public static PangoFontFaceHandle GetFace(this GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionExterns.gtk_font_selection_get_face(fontsel);
	}

	public static GtkWidgetHandle GetFaceList(this GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionExterns.gtk_font_selection_get_face_list(fontsel);
	}

	public static PangoFontFamilyHandle GetFamily(this GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionExterns.gtk_font_selection_get_family(fontsel);
	}

	public static GtkWidgetHandle GetFamilyList(this GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionExterns.gtk_font_selection_get_family_list(fontsel);
	}

	public static string GetFontName(this GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionExterns.gtk_font_selection_get_font_name(fontsel);
	}

	public static GtkWidgetHandle GetPreviewEntry(this GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionExterns.gtk_font_selection_get_preview_entry(fontsel);
	}

	public static string GetPreviewText(this GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionExterns.gtk_font_selection_get_preview_text(fontsel);
	}

	public static int GetSize(this GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionExterns.gtk_font_selection_get_size(fontsel);
	}

	public static GtkWidgetHandle GetSizeEntry(this GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionExterns.gtk_font_selection_get_size_entry(fontsel);
	}

	public static GtkWidgetHandle GetSizeList(this GtkFontSelectionHandle fontsel)
	{
		return GtkFontSelectionExterns.gtk_font_selection_get_size_list(fontsel);
	}

	public static bool SetFontName(this GtkFontSelectionHandle fontsel, string fontname)
	{
		return GtkFontSelectionExterns.gtk_font_selection_set_font_name(fontsel, fontname);
	}

	public static GtkFontSelectionHandle SetPreviewText(this GtkFontSelectionHandle fontsel, string text)
	{
		GtkFontSelectionExterns.gtk_font_selection_set_preview_text(fontsel, text);
		return fontsel;
	}

}

internal class GtkFontSelectionExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFontSelectionHandle gtk_font_selection_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoFontFaceHandle gtk_font_selection_get_face(GtkFontSelectionHandle fontsel);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_font_selection_get_face_list(GtkFontSelectionHandle fontsel);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoFontFamilyHandle gtk_font_selection_get_family(GtkFontSelectionHandle fontsel);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_font_selection_get_family_list(GtkFontSelectionHandle fontsel);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_font_selection_get_font_name(GtkFontSelectionHandle fontsel);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_font_selection_get_preview_entry(GtkFontSelectionHandle fontsel);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_font_selection_get_preview_text(GtkFontSelectionHandle fontsel);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_font_selection_get_size(GtkFontSelectionHandle fontsel);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_font_selection_get_size_entry(GtkFontSelectionHandle fontsel);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_font_selection_get_size_list(GtkFontSelectionHandle fontsel);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_font_selection_set_font_name(GtkFontSelectionHandle fontsel, string fontname);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_font_selection_set_preview_text(GtkFontSelectionHandle fontsel, string text);

}
