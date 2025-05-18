namespace MentorLake.PangoCairo;

public class PangoCairoGlobalFunctions
{
	public static MentorLake.cairo.cairo_font_options_tHandle ContextGetFontOptions(MentorLake.Pango.PangoContextHandle context)
	{
		return PangoCairoGlobalFunctionsExterns.pango_cairo_context_get_font_options(context);
	}

	public static double ContextGetResolution(MentorLake.Pango.PangoContextHandle context)
	{
		return PangoCairoGlobalFunctionsExterns.pango_cairo_context_get_resolution(context);
	}

	public static MentorLake.PangoCairo.PangoCairoShapeRendererFunc ContextGetShapeRenderer(MentorLake.Pango.PangoContextHandle context, IntPtr data)
	{
		return PangoCairoGlobalFunctionsExterns.pango_cairo_context_get_shape_renderer(context, data);
	}

	public static void ContextSetFontOptions(MentorLake.Pango.PangoContextHandle context, MentorLake.cairo.cairo_font_options_tHandle options)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_context_set_font_options(context, options);
	}

	public static void ContextSetResolution(MentorLake.Pango.PangoContextHandle context, double dpi)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_context_set_resolution(context, dpi);
	}

	public static void ContextSetShapeRenderer(MentorLake.Pango.PangoContextHandle context, MentorLake.PangoCairo.PangoCairoShapeRendererFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify dnotify)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_context_set_shape_renderer(context, func, data, dnotify);
	}

	public static MentorLake.Pango.PangoContextHandle CreateContext(MentorLake.cairo.cairo_tHandle cr)
	{
		return PangoCairoGlobalFunctionsExterns.pango_cairo_create_context(cr);
	}

	public static MentorLake.Pango.PangoLayoutHandle CreateLayout(MentorLake.cairo.cairo_tHandle cr)
	{
		return PangoCairoGlobalFunctionsExterns.pango_cairo_create_layout(cr);
	}

	public static void ErrorUnderlinePath(MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_error_underline_path(cr, x, y, width, height);
	}

	public static MentorLake.Pango.PangoFontMapHandle FontMapGetDefault()
	{
		return PangoCairoGlobalFunctionsExterns.pango_cairo_font_map_get_default();
	}

	public static MentorLake.Pango.PangoFontMapHandle FontMapNew()
	{
		return PangoCairoGlobalFunctionsExterns.pango_cairo_font_map_new();
	}

	public static MentorLake.Pango.PangoFontMapHandle FontMapNewForFontType(MentorLake.cairo.cairo_font_type_t fonttype)
	{
		return PangoCairoGlobalFunctionsExterns.pango_cairo_font_map_new_for_font_type(fonttype);
	}

	public static void GlyphStringPath(MentorLake.cairo.cairo_tHandle cr, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyphStringHandle glyphs)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_glyph_string_path(cr, font, glyphs);
	}

	public static void LayoutLinePath(MentorLake.cairo.cairo_tHandle cr, MentorLake.Pango.PangoLayoutLineHandle line)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_layout_line_path(cr, line);
	}

	public static void LayoutPath(MentorLake.cairo.cairo_tHandle cr, MentorLake.Pango.PangoLayoutHandle layout)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_layout_path(cr, layout);
	}

	public static void ShowErrorUnderline(MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_show_error_underline(cr, x, y, width, height);
	}

	public static void ShowGlyphItem(MentorLake.cairo.cairo_tHandle cr, string text, MentorLake.Pango.PangoGlyphItemHandle glyph_item)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_show_glyph_item(cr, text, glyph_item);
	}

	public static void ShowGlyphString(MentorLake.cairo.cairo_tHandle cr, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyphStringHandle glyphs)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_show_glyph_string(cr, font, glyphs);
	}

	public static void ShowLayout(MentorLake.cairo.cairo_tHandle cr, MentorLake.Pango.PangoLayoutHandle layout)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_show_layout(cr, layout);
	}

	public static void ShowLayoutLine(MentorLake.cairo.cairo_tHandle cr, MentorLake.Pango.PangoLayoutLineHandle line)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_show_layout_line(cr, line);
	}

	public static void UpdateContext(MentorLake.cairo.cairo_tHandle cr, MentorLake.Pango.PangoContextHandle context)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_update_context(cr, context);
	}

	public static void UpdateLayout(MentorLake.cairo.cairo_tHandle cr, MentorLake.Pango.PangoLayoutHandle layout)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_update_layout(cr, layout);
	}

}

internal class PangoCairoGlobalFunctionsExterns
{
	[DllImport(PangoCairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))]
	internal static extern MentorLake.cairo.cairo_font_options_tHandle pango_cairo_context_get_font_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern double pango_cairo_context_get_resolution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern MentorLake.PangoCairo.PangoCairoShapeRendererFunc pango_cairo_context_get_shape_renderer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, IntPtr data);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_context_set_font_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_context_set_resolution([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, double dpi);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_context_set_shape_renderer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context, MentorLake.PangoCairo.PangoCairoShapeRendererFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify dnotify);

	[DllImport(PangoCairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle pango_cairo_create_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(PangoCairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutHandle pango_cairo_create_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_error_underline_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(PangoCairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_cairo_font_map_get_default();

	[DllImport(PangoCairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_cairo_font_map_new();

	[DllImport(PangoCairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_cairo_font_map_new_for_font_type(MentorLake.cairo.cairo_font_type_t fonttype);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_glyph_string_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_layout_line_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_layout_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_show_error_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_show_glyph_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, string text, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))] MentorLake.Pango.PangoGlyphItemHandle glyph_item);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_show_glyph_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_show_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_show_layout_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_update_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))] MentorLake.Pango.PangoContextHandle context);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_update_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout);

}
