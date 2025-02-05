namespace MentorLake.Gtk3.Pango;

public class PangoFontMapHandle : GObjectHandle, GListModelHandle
{
}

public static class PangoFontMapHandleExtensions
{
	public static T Changed<T>(this T fontmap) where T : PangoFontMapHandle
	{
		PangoFontMapExterns.pango_font_map_changed(fontmap);
		return fontmap;
	}

	public static PangoContextHandle CreateContext(this PangoFontMapHandle fontmap)
	{
		return PangoFontMapExterns.pango_font_map_create_context(fontmap);
	}

	public static PangoFontFamilyHandle GetFamily(this PangoFontMapHandle fontmap, string name)
	{
		return PangoFontMapExterns.pango_font_map_get_family(fontmap, name);
	}

	public static uint GetSerial(this PangoFontMapHandle fontmap)
	{
		return PangoFontMapExterns.pango_font_map_get_serial(fontmap);
	}

	public static T ListFamilies<T>(this T fontmap, out PangoFontFamilyHandle[] families, out int n_families) where T : PangoFontMapHandle
	{
		PangoFontMapExterns.pango_font_map_list_families(fontmap, out families, out n_families);
		return fontmap;
	}

	public static PangoFontHandle LoadFont(this PangoFontMapHandle fontmap, PangoContextHandle context, PangoFontDescriptionHandle desc)
	{
		return PangoFontMapExterns.pango_font_map_load_font(fontmap, context, desc);
	}

	public static PangoFontsetHandle LoadFontset(this PangoFontMapHandle fontmap, PangoContextHandle context, PangoFontDescriptionHandle desc, PangoLanguageHandle language)
	{
		return PangoFontMapExterns.pango_font_map_load_fontset(fontmap, context, desc, language);
	}

	public static PangoFontHandle ReloadFont(this PangoFontMapHandle fontmap, PangoFontHandle font, double scale, PangoContextHandle context, string variations)
	{
		return PangoFontMapExterns.pango_font_map_reload_font(fontmap, font, scale, context, variations);
	}

}

internal class PangoFontMapExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_map_changed(PangoFontMapHandle fontmap);

	[DllImport(Libraries.Pango)]
	internal static extern PangoContextHandle pango_font_map_create_context(PangoFontMapHandle fontmap);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontFamilyHandle pango_font_map_get_family(PangoFontMapHandle fontmap, string name);

	[DllImport(Libraries.Pango)]
	internal static extern uint pango_font_map_get_serial(PangoFontMapHandle fontmap);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_font_map_list_families(PangoFontMapHandle fontmap, out PangoFontFamilyHandle[] families, out int n_families);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontHandle pango_font_map_load_font(PangoFontMapHandle fontmap, PangoContextHandle context, PangoFontDescriptionHandle desc);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontsetHandle pango_font_map_load_fontset(PangoFontMapHandle fontmap, PangoContextHandle context, PangoFontDescriptionHandle desc, PangoLanguageHandle language);

	[DllImport(Libraries.Pango)]
	internal static extern PangoFontHandle pango_font_map_reload_font(PangoFontMapHandle fontmap, PangoFontHandle font, double scale, PangoContextHandle context, string variations);

}
