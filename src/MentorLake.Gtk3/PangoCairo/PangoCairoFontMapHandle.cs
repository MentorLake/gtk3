namespace MentorLake.PangoCairo;

public interface PangoCairoFontMapHandle
{
}

internal class PangoCairoFontMapHandleImpl : BaseSafeHandle, PangoCairoFontMapHandle
{
}

public static class PangoCairoFontMapHandleExtensions
{
	public static MentorLake.Pango.PangoContextHandle CreateContext(this MentorLake.PangoCairo.PangoCairoFontMapHandle fontmap)
	{
		return PangoCairoFontMapHandleExterns.pango_cairo_font_map_create_context(fontmap);
	}

	public static MentorLake.cairo.cairo_font_type_t GetFontType(this MentorLake.PangoCairo.PangoCairoFontMapHandle fontmap)
	{
		return PangoCairoFontMapHandleExterns.pango_cairo_font_map_get_font_type(fontmap);
	}

	public static double GetResolution(this MentorLake.PangoCairo.PangoCairoFontMapHandle fontmap)
	{
		return PangoCairoFontMapHandleExterns.pango_cairo_font_map_get_resolution(fontmap);
	}

	public static T SetDefault<T>(this T fontmap) where T : PangoCairoFontMapHandle
	{
		PangoCairoFontMapHandleExterns.pango_cairo_font_map_set_default(fontmap);
		return fontmap;
	}

	public static T SetResolution<T>(this T fontmap, double dpi) where T : PangoCairoFontMapHandle
	{
		PangoCairoFontMapHandleExterns.pango_cairo_font_map_set_resolution(fontmap, dpi);
		return fontmap;
	}

	public static MentorLake.Pango.PangoFontMapHandle GetDefault()
	{
		return PangoCairoFontMapHandleExterns.pango_cairo_font_map_get_default();
	}

	public static MentorLake.Pango.PangoFontMapHandle New()
	{
		return PangoCairoFontMapHandleExterns.pango_cairo_font_map_new();
	}

	public static MentorLake.Pango.PangoFontMapHandle NewForFontType(MentorLake.cairo.cairo_font_type_t fonttype)
	{
		return PangoCairoFontMapHandleExterns.pango_cairo_font_map_new_for_font_type(fonttype);
	}

}

internal class PangoCairoFontMapHandleExterns
{
	[DllImport(PangoCairoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoContextHandle pango_cairo_font_map_create_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoCairo.PangoCairoFontMapHandleImpl>))] MentorLake.PangoCairo.PangoCairoFontMapHandle fontmap);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_font_type_t pango_cairo_font_map_get_font_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoCairo.PangoCairoFontMapHandleImpl>))] MentorLake.PangoCairo.PangoCairoFontMapHandle fontmap);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern double pango_cairo_font_map_get_resolution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoCairo.PangoCairoFontMapHandleImpl>))] MentorLake.PangoCairo.PangoCairoFontMapHandle fontmap);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_font_map_set_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoCairo.PangoCairoFontMapHandleImpl>))] MentorLake.PangoCairo.PangoCairoFontMapHandle fontmap);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_font_map_set_resolution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoCairo.PangoCairoFontMapHandleImpl>))] MentorLake.PangoCairo.PangoCairoFontMapHandle fontmap, double dpi);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_cairo_font_map_get_default();

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_cairo_font_map_new();

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_cairo_font_map_new_for_font_type(MentorLake.cairo.cairo_font_type_t fonttype);

}
