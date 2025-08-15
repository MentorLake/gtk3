namespace MentorLake.PangoCairo;

public class PangoCairoGlobalFunctions
{
/// <summary>
/// <para>
/// Retrieves any font rendering options previously set with
/// [func@PangoCairo.context_set_font_options].
/// </para>
/// <para>
/// This function does not report options that are derived from
/// the target surface by [func@update_context].
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`, from a pangocairo font map
/// </param>
/// <return>
/// the font options previously set on the
///   context, or %NULL if no options have been set. This value is
///   owned by the context and must not be modified or freed.
/// </return>

	public static MentorLake.cairo.cairo_font_options_tHandle ContextGetFontOptions(MentorLake.Pango.PangoContextHandle context)
	{
		return PangoCairoGlobalFunctionsExterns.pango_cairo_context_get_font_options(context);
	}

/// <summary>
/// <para>
/// Gets the resolution for the context.
/// </para>
/// <para>
/// See [func@PangoCairo.context_set_resolution]
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`, from a pangocairo font map
/// </param>
/// <return>
/// the resolution in &quot;dots per inch&quot;. A negative value will
///   be returned if no resolution has previously been set.
/// </return>

	public static double ContextGetResolution(MentorLake.Pango.PangoContextHandle context)
	{
		return PangoCairoGlobalFunctionsExterns.pango_cairo_context_get_resolution(context);
	}

/// <summary>
/// <para>
/// Sets callback function for context to use for rendering attributes
/// of type %PANGO_ATTR_SHAPE.
/// </para>
/// <para>
/// See `PangoCairoShapeRendererFunc` for details.
/// </para>
/// <para>
/// Retrieves callback function and associated user data for rendering
/// attributes of type %PANGO_ATTR_SHAPE as set by
/// [func@PangoCairo.context_set_shape_renderer], if any.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`, from a pangocairo font map
/// </param>
/// <param name="data">
/// Pointer to `gpointer` to return user data
/// </param>
/// <return>
/// the shape rendering callback
///   previously set on the context, or %NULL if no shape rendering callback
///   have been set.
/// </return>

	public static MentorLake.PangoCairo.PangoCairoShapeRendererFunc ContextGetShapeRenderer(MentorLake.Pango.PangoContextHandle context, IntPtr data)
	{
		return PangoCairoGlobalFunctionsExterns.pango_cairo_context_get_shape_renderer(context, data);
	}

/// <summary>
/// <para>
/// Sets the font options used when rendering text with this context.
/// </para>
/// <para>
/// These options override any options that [func@update_context]
/// derives from the target surface.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`, from a pangocairo font map
/// </param>
/// <param name="options">
/// a `cairo_font_options_t`, or %NULL to unset
///   any previously set options. A copy is made.
/// </param>

	public static void ContextSetFontOptions(MentorLake.Pango.PangoContextHandle context, MentorLake.cairo.cairo_font_options_tHandle options)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_context_set_font_options(context, options);
	}

/// <summary>
/// <para>
/// Sets the resolution for the context.
/// </para>
/// <para>
/// This is a scale factor between points specified in a `PangoFontDescription`
/// and Cairo units. The default value is 96, meaning that a 10 point font will
/// be 13 units high. (10 * 96. / 72. = 13.3).
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`, from a pangocairo font map
/// </param>
/// <param name="dpi">
/// the resolution in &quot;dots per inch&quot;. (Physical inches aren&apos;t actually
///   involved; the terminology is conventional.) A 0 or negative value
///   means to use the resolution from the font map.
/// </param>

	public static void ContextSetResolution(MentorLake.Pango.PangoContextHandle context, double dpi)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_context_set_resolution(context, dpi);
	}

/// <summary>
/// <para>
/// Sets callback function for context to use for rendering attributes
/// of type %PANGO_ATTR_SHAPE.
/// </para>
/// <para>
/// See `PangoCairoShapeRendererFunc` for details.
/// </para>
/// </summary>

/// <param name="context">
/// a `PangoContext`, from a pangocairo font map
/// </param>
/// <param name="func">
/// Callback function for rendering attributes of
///   type %PANGO_ATTR_SHAPE, or %NULL to disable shape rendering.
/// </param>
/// <param name="data">
/// User data that will be passed to @func.
/// </param>
/// <param name="dnotify">
/// Callback that will be called when the
///   context is freed to release @data
/// </param>

	public static void ContextSetShapeRenderer(MentorLake.Pango.PangoContextHandle context, MentorLake.PangoCairo.PangoCairoShapeRendererFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify dnotify)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_context_set_shape_renderer(context, func, data, dnotify);
	}

/// <summary>
/// <para>
/// Creates a context object set up to match the current transformation
/// and target surface of the Cairo context.
/// </para>
/// <para>
/// This context can then be
/// used to create a layout using [ctor@Pango.Layout.new].
/// </para>
/// <para>
/// This function is a convenience function that creates a context using
/// the default font map, then updates it to @cr. If you just need to
/// create a layout for use with @cr and do not need to access `PangoContext`
/// directly, you can use [func@create_layout] instead.
/// </para>
/// </summary>

/// <param name="cr">
/// a Cairo context
/// </param>
/// <return>
/// the newly created `PangoContext`
/// </return>

	public static MentorLake.Pango.PangoContextHandle CreateContext(MentorLake.cairo.cairo_tHandle cr)
	{
		return PangoCairoGlobalFunctionsExterns.pango_cairo_create_context(cr);
	}

/// <summary>
/// <para>
/// Creates a layout object set up to match the current transformation
/// and target surface of the Cairo context.
/// </para>
/// <para>
/// This layout can then be used for text measurement with functions
/// like [method@Pango.Layout.get_size] or drawing with functions like
/// [func@show_layout]. If you change the transformation or target
/// surface for @cr, you need to call [func@update_layout].
/// </para>
/// <para>
/// This function is the most convenient way to use Cairo with Pango,
/// however it is slightly inefficient since it creates a separate
/// `PangoContext` object for each layout. This might matter in an
/// application that was laying out large amounts of text.
/// </para>
/// </summary>

/// <param name="cr">
/// a Cairo context
/// </param>
/// <return>
/// the newly created `PangoLayout`
/// </return>

	public static MentorLake.Pango.PangoLayoutHandle CreateLayout(MentorLake.cairo.cairo_tHandle cr)
	{
		return PangoCairoGlobalFunctionsExterns.pango_cairo_create_layout(cr);
	}

/// <summary>
/// <para>
/// Add a squiggly line to the current path in the specified cairo context that
/// approximately covers the given rectangle in the style of an underline used
/// to indicate a spelling error.
/// </para>
/// <para>
/// The width of the underline is rounded to an integer number of up/down
/// segments and the resulting rectangle is centered in the original rectangle.
/// </para>
/// </summary>

/// <param name="cr">
/// a Cairo context
/// </param>
/// <param name="x">
/// The X coordinate of one corner of the rectangle
/// </param>
/// <param name="y">
/// The Y coordinate of one corner of the rectangle
/// </param>
/// <param name="width">
/// Non-negative width of the rectangle
/// </param>
/// <param name="height">
/// Non-negative height of the rectangle
/// </param>

	public static void ErrorUnderlinePath(MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_error_underline_path(cr, x, y, width, height);
	}

/// <summary>
/// <para>
/// Gets a default `PangoCairoFontMap` to use with Cairo.
/// </para>
/// <para>
/// Note that the type of the returned object will depend on the
/// particular font backend Cairo was compiled to use; you generally
/// should only use the `PangoFontMap` and `PangoCairoFontMap`
/// interfaces on the returned object.
/// </para>
/// <para>
/// The default Cairo fontmap can be changed by using
/// [method@PangoCairo.FontMap.set_default]. This can be used to
/// change the Cairo font backend that the default fontmap uses
/// for example.
/// </para>
/// <para>
/// Note that since Pango 1.32.6, the default fontmap is per-thread.
/// Each thread gets its own default fontmap. In this way, PangoCairo
/// can be used safely from multiple threads.
/// </para>
/// </summary>

/// <return>
/// the default PangoCairo fontmap
///  for the current thread. This object is owned by Pango and must
///  not be freed.
/// </return>

	public static MentorLake.Pango.PangoFontMapHandle FontMapGetDefault()
	{
		return PangoCairoGlobalFunctionsExterns.pango_cairo_font_map_get_default();
	}

/// <summary>
/// <para>
/// Creates a new `PangoCairoFontMap` object.
/// </para>
/// <para>
/// A fontmap is used to cache information about available fonts,
/// and holds certain global parameters such as the resolution.
/// In most cases, you can use `func@PangoCairo.font_map_get_default]
/// instead.
/// </para>
/// <para>
/// Note that the type of the returned object will depend
/// on the particular font backend Cairo was compiled to use;
/// You generally should only use the `PangoFontMap` and
/// `PangoCairoFontMap` interfaces on the returned object.
/// </para>
/// <para>
/// You can override the type of backend returned by using an
/// environment variable %PANGOCAIRO_BACKEND. Supported types,
/// based on your build, are fc (fontconfig), win32, and coretext.
/// If requested type is not available, NULL is returned. Ie.
/// this is only useful for testing, when at least two backends
/// are compiled in.
/// </para>
/// </summary>

/// <return>
/// the newly allocated `PangoFontMap`,
///   which should be freed with g_object_unref().
/// </return>

	public static MentorLake.Pango.PangoFontMapHandle FontMapNew()
	{
		return PangoCairoGlobalFunctionsExterns.pango_cairo_font_map_new();
	}

/// <summary>
/// <para>
/// Creates a new `PangoCairoFontMap` object of the type suitable
/// to be used with cairo font backend of type @fonttype.
/// </para>
/// <para>
/// In most cases one should simply use [func@PangoCairo.FontMap.new], or
/// in fact in most of those cases, just use [func@PangoCairo.FontMap.get_default].
/// </para>
/// </summary>

/// <param name="fonttype">
/// desired #cairo_font_type_t
/// </param>
/// <return>
/// the newly allocated
///   `PangoFontMap` of suitable type which should be freed with
///   g_object_unref(), or %NULL if the requested cairo font backend
///   is not supported / compiled in.
/// </return>

	public static MentorLake.Pango.PangoFontMapHandle FontMapNewForFontType(MentorLake.cairo.cairo_font_type_t fonttype)
	{
		return PangoCairoGlobalFunctionsExterns.pango_cairo_font_map_new_for_font_type(fonttype);
	}

/// <summary>
/// <para>
/// Adds the glyphs in @glyphs to the current path in the specified
/// cairo context.
/// </para>
/// <para>
/// The origin of the glyphs (the left edge of the baseline)
/// will be at the current point of the cairo context.
/// </para>
/// </summary>

/// <param name="cr">
/// a Cairo context
/// </param>
/// <param name="font">
/// a `PangoFont` from a `PangoCairoFontMap`
/// </param>
/// <param name="glyphs">
/// a `PangoGlyphString`
/// </param>

	public static void GlyphStringPath(MentorLake.cairo.cairo_tHandle cr, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyphStringHandle glyphs)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_glyph_string_path(cr, font, glyphs);
	}

/// <summary>
/// <para>
/// Adds the text in `PangoLayoutLine` to the current path in the
/// specified cairo context.
/// </para>
/// <para>
/// The origin of the glyphs (the left edge of the line) will be
/// at the current point of the cairo context.
/// </para>
/// </summary>

/// <param name="cr">
/// a Cairo context
/// </param>
/// <param name="line">
/// a `PangoLayoutLine`
/// </param>

	public static void LayoutLinePath(MentorLake.cairo.cairo_tHandle cr, MentorLake.Pango.PangoLayoutLineHandle line)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_layout_line_path(cr, line);
	}

/// <summary>
/// <para>
/// Adds the text in a `PangoLayout` to the current path in the
/// specified cairo context.
/// </para>
/// <para>
/// The top-left corner of the `PangoLayout` will be at the
/// current point of the cairo context.
/// </para>
/// </summary>

/// <param name="cr">
/// a Cairo context
/// </param>
/// <param name="layout">
/// a Pango layout
/// </param>

	public static void LayoutPath(MentorLake.cairo.cairo_tHandle cr, MentorLake.Pango.PangoLayoutHandle layout)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_layout_path(cr, layout);
	}

/// <summary>
/// <para>
/// Draw a squiggly line in the specified cairo context that approximately
/// covers the given rectangle in the style of an underline used to indicate a
/// spelling error.
/// </para>
/// <para>
/// The width of the underline is rounded to an integer
/// number of up/down segments and the resulting rectangle is centered in the
/// original rectangle.
/// </para>
/// </summary>

/// <param name="cr">
/// a Cairo context
/// </param>
/// <param name="x">
/// The X coordinate of one corner of the rectangle
/// </param>
/// <param name="y">
/// The Y coordinate of one corner of the rectangle
/// </param>
/// <param name="width">
/// Non-negative width of the rectangle
/// </param>
/// <param name="height">
/// Non-negative height of the rectangle
/// </param>

	public static void ShowErrorUnderline(MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_show_error_underline(cr, x, y, width, height);
	}

/// <summary>
/// <para>
/// Draws the glyphs in @glyph_item in the specified cairo context,
/// </para>
/// <para>
/// embedding the text associated with the glyphs in the output if the
/// output format supports it (PDF for example), otherwise it acts
/// similar to [func@show_glyph_string].
/// </para>
/// <para>
/// The origin of the glyphs (the left edge of the baseline) will
/// be drawn at the current point of the cairo context.
/// </para>
/// <para>
/// Note that @text is the start of the text for layout, which is then
/// indexed by `glyph_item-&amp;gt;item-&amp;gt;offset`.
/// </para>
/// </summary>

/// <param name="cr">
/// a Cairo context
/// </param>
/// <param name="text">
/// the UTF-8 text that @glyph_item refers to
/// </param>
/// <param name="glyph_item">
/// a `PangoGlyphItem`
/// </param>

	public static void ShowGlyphItem(MentorLake.cairo.cairo_tHandle cr, string text, MentorLake.Pango.PangoGlyphItemHandle glyph_item)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_show_glyph_item(cr, text, glyph_item);
	}

/// <summary>
/// <para>
/// Draws the glyphs in @glyphs in the specified cairo context.
/// </para>
/// <para>
/// The origin of the glyphs (the left edge of the baseline) will
/// be drawn at the current point of the cairo context.
/// </para>
/// </summary>

/// <param name="cr">
/// a Cairo context
/// </param>
/// <param name="font">
/// a `PangoFont` from a `PangoCairoFontMap`
/// </param>
/// <param name="glyphs">
/// a `PangoGlyphString`
/// </param>

	public static void ShowGlyphString(MentorLake.cairo.cairo_tHandle cr, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyphStringHandle glyphs)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_show_glyph_string(cr, font, glyphs);
	}

/// <summary>
/// <para>
/// Draws a `PangoLayout` in the specified cairo context.
/// </para>
/// <para>
/// The top-left corner of the `PangoLayout` will be drawn
/// at the current point of the cairo context.
/// </para>
/// </summary>

/// <param name="cr">
/// a Cairo context
/// </param>
/// <param name="layout">
/// a Pango layout
/// </param>

	public static void ShowLayout(MentorLake.cairo.cairo_tHandle cr, MentorLake.Pango.PangoLayoutHandle layout)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_show_layout(cr, layout);
	}

/// <summary>
/// <para>
/// Draws a `PangoLayoutLine` in the specified cairo context.
/// </para>
/// <para>
/// The origin of the glyphs (the left edge of the line) will
/// be drawn at the current point of the cairo context.
/// </para>
/// </summary>

/// <param name="cr">
/// a Cairo context
/// </param>
/// <param name="line">
/// a `PangoLayoutLine`
/// </param>

	public static void ShowLayoutLine(MentorLake.cairo.cairo_tHandle cr, MentorLake.Pango.PangoLayoutLineHandle line)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_show_layout_line(cr, line);
	}

/// <summary>
/// <para>
/// Updates a `PangoContext` previously created for use with Cairo to
/// match the current transformation and target surface of a Cairo
/// context.
/// </para>
/// <para>
/// If any layouts have been created for the context, it&apos;s necessary
/// to call [method@Pango.Layout.context_changed] on those layouts.
/// </para>
/// </summary>

/// <param name="cr">
/// a Cairo context
/// </param>
/// <param name="context">
/// a `PangoContext`, from a pangocairo font map
/// </param>

	public static void UpdateContext(MentorLake.cairo.cairo_tHandle cr, MentorLake.Pango.PangoContextHandle context)
	{
		PangoCairoGlobalFunctionsExterns.pango_cairo_update_context(cr, context);
	}

/// <summary>
/// <para>
/// Updates the private `PangoContext` of a `PangoLayout` created with
/// [func@create_layout] to match the current transformation and target
/// surface of a Cairo context.
/// </para>
/// </summary>

/// <param name="cr">
/// a Cairo context
/// </param>
/// <param name="layout">
/// a `PangoLayout`, from [func@create_layout]
/// </param>

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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle pango_cairo_create_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(PangoCairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutHandle pango_cairo_create_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(PangoCairoLibrary.Name)]
	internal static extern void pango_cairo_error_underline_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, double x, double y, double width, double height);

	[DllImport(PangoCairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_cairo_font_map_get_default();

	[DllImport(PangoCairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_cairo_font_map_new();

	[DllImport(PangoCairoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))]
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
