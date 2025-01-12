namespace MentorLake.Gtk3.Gtk3;

public interface GtkFontChooserHandle
{
}

internal class GtkFontChooserHandleImpl : BaseSafeHandle, GtkFontChooserHandle
{
}

public static class GtkFontChooserHandleExtensions
{
	public static string GetFont(this GtkFontChooserHandle fontchooser)
	{
		return GtkFontChooserExterns.gtk_font_chooser_get_font(fontchooser);
	}

	public static PangoFontDescriptionHandle GetFontDesc(this GtkFontChooserHandle fontchooser)
	{
		return GtkFontChooserExterns.gtk_font_chooser_get_font_desc(fontchooser);
	}

	public static PangoFontFaceHandle GetFontFace(this GtkFontChooserHandle fontchooser)
	{
		return GtkFontChooserExterns.gtk_font_chooser_get_font_face(fontchooser);
	}

	public static PangoFontFamilyHandle GetFontFamily(this GtkFontChooserHandle fontchooser)
	{
		return GtkFontChooserExterns.gtk_font_chooser_get_font_family(fontchooser);
	}

	public static string GetFontFeatures(this GtkFontChooserHandle fontchooser)
	{
		return GtkFontChooserExterns.gtk_font_chooser_get_font_features(fontchooser);
	}

	public static PangoFontMapHandle GetFontMap(this GtkFontChooserHandle fontchooser)
	{
		return GtkFontChooserExterns.gtk_font_chooser_get_font_map(fontchooser);
	}

	public static int GetFontSize(this GtkFontChooserHandle fontchooser)
	{
		return GtkFontChooserExterns.gtk_font_chooser_get_font_size(fontchooser);
	}

	public static string GetLanguage(this GtkFontChooserHandle fontchooser)
	{
		return GtkFontChooserExterns.gtk_font_chooser_get_language(fontchooser);
	}

	public static GtkFontChooserLevel GetLevel(this GtkFontChooserHandle fontchooser)
	{
		return GtkFontChooserExterns.gtk_font_chooser_get_level(fontchooser);
	}

	public static string GetPreviewText(this GtkFontChooserHandle fontchooser)
	{
		return GtkFontChooserExterns.gtk_font_chooser_get_preview_text(fontchooser);
	}

	public static bool GetShowPreviewEntry(this GtkFontChooserHandle fontchooser)
	{
		return GtkFontChooserExterns.gtk_font_chooser_get_show_preview_entry(fontchooser);
	}

	public static T SetFilterFunc<T>(this T fontchooser, GtkFontFilterFunc filter, IntPtr user_data, GDestroyNotify destroy) where T : GtkFontChooserHandle
	{
		GtkFontChooserExterns.gtk_font_chooser_set_filter_func(fontchooser, filter, user_data, destroy);
		return fontchooser;
	}

	public static T SetFont<T>(this T fontchooser, string fontname) where T : GtkFontChooserHandle
	{
		GtkFontChooserExterns.gtk_font_chooser_set_font(fontchooser, fontname);
		return fontchooser;
	}

	public static T SetFontDesc<T>(this T fontchooser, PangoFontDescriptionHandle font_desc) where T : GtkFontChooserHandle
	{
		GtkFontChooserExterns.gtk_font_chooser_set_font_desc(fontchooser, font_desc);
		return fontchooser;
	}

	public static T SetFontMap<T>(this T fontchooser, PangoFontMapHandle fontmap) where T : GtkFontChooserHandle
	{
		GtkFontChooserExterns.gtk_font_chooser_set_font_map(fontchooser, fontmap);
		return fontchooser;
	}

	public static T SetLanguage<T>(this T fontchooser, string language) where T : GtkFontChooserHandle
	{
		GtkFontChooserExterns.gtk_font_chooser_set_language(fontchooser, language);
		return fontchooser;
	}

	public static T SetLevel<T>(this T fontchooser, GtkFontChooserLevel level) where T : GtkFontChooserHandle
	{
		GtkFontChooserExterns.gtk_font_chooser_set_level(fontchooser, level);
		return fontchooser;
	}

	public static T SetPreviewText<T>(this T fontchooser, string text) where T : GtkFontChooserHandle
	{
		GtkFontChooserExterns.gtk_font_chooser_set_preview_text(fontchooser, text);
		return fontchooser;
	}

	public static T SetShowPreviewEntry<T>(this T fontchooser, bool show_preview_entry) where T : GtkFontChooserHandle
	{
		GtkFontChooserExterns.gtk_font_chooser_set_show_preview_entry(fontchooser, show_preview_entry);
		return fontchooser;
	}

}

internal class GtkFontChooserExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_font_chooser_get_font(GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoFontDescriptionHandle gtk_font_chooser_get_font_desc(GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoFontFaceHandle gtk_font_chooser_get_font_face(GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoFontFamilyHandle gtk_font_chooser_get_font_family(GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_font_chooser_get_font_features(GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoFontMapHandle gtk_font_chooser_get_font_map(GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_font_chooser_get_font_size(GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_font_chooser_get_language(GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFontChooserLevel gtk_font_chooser_get_level(GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_font_chooser_get_preview_text(GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_font_chooser_get_show_preview_entry(GtkFontChooserHandle fontchooser);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_font_chooser_set_filter_func(GtkFontChooserHandle fontchooser, GtkFontFilterFunc filter, IntPtr user_data, GDestroyNotify destroy);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_font_chooser_set_font(GtkFontChooserHandle fontchooser, string fontname);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_font_chooser_set_font_desc(GtkFontChooserHandle fontchooser, PangoFontDescriptionHandle font_desc);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_font_chooser_set_font_map(GtkFontChooserHandle fontchooser, PangoFontMapHandle fontmap);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_font_chooser_set_language(GtkFontChooserHandle fontchooser, string language);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_font_chooser_set_level(GtkFontChooserHandle fontchooser, GtkFontChooserLevel level);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_font_chooser_set_preview_text(GtkFontChooserHandle fontchooser, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_font_chooser_set_show_preview_entry(GtkFontChooserHandle fontchooser, bool show_preview_entry);

}
