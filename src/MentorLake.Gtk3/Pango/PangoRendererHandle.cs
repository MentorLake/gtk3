namespace MentorLake.Pango;

/// <summary>
/// <para>
/// `PangoRenderer` is a base class for objects that can render text
/// provided as `PangoGlyphString` or `PangoLayout`.
/// </para>
/// <para>
/// By subclassing `PangoRenderer` and overriding operations such as
/// @draw_glyphs and @draw_rectangle, renderers for particular font
/// backends and destinations can be created.
/// </para>
/// </summary>

public class PangoRendererHandle : GObjectHandle
{
}

public static class PangoRendererHandleExtensions
{
/// <summary>
/// <para>
/// Does initial setup before rendering operations on @renderer.
/// </para>
/// <para>
/// [method@Pango.Renderer.deactivate] should be called when done drawing.
/// Calls such as [method@Pango.Renderer.draw_layout] automatically
/// activate the layout before drawing on it.
/// </para>
/// <para>
/// Calls to [method@Pango.Renderer.activate] and
/// [method@Pango.Renderer.deactivate] can be nested and the
/// renderer will only be initialized and deinitialized once.
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>

	public static T Activate<T>(this T renderer) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_activate(renderer);
		return renderer;
	}

/// <summary>
/// <para>
/// Cleans up after rendering operations on @renderer.
/// </para>
/// <para>
/// See docs for [method@Pango.Renderer.activate].
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>

	public static T Deactivate<T>(this T renderer) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_deactivate(renderer);
		return renderer;
	}

/// <summary>
/// <para>
/// Draw a squiggly line that approximately covers the given rectangle
/// in the style of an underline used to indicate a spelling error.
/// </para>
/// <para>
/// The width of the underline is rounded to an integer number
/// of up/down segments and the resulting rectangle is centered
/// in the original rectangle.
/// </para>
/// <para>
/// This should be called while @renderer is already active.
/// Use [method@Pango.Renderer.activate] to activate a renderer.
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <param name="x">
/// X coordinate of underline, in Pango units in user coordinate system
/// </param>
/// <param name="y">
/// Y coordinate of underline, in Pango units in user coordinate system
/// </param>
/// <param name="width">
/// width of underline, in Pango units in user coordinate system
/// </param>
/// <param name="height">
/// height of underline, in Pango units in user coordinate system
/// </param>

	public static T DrawErrorUnderline<T>(this T renderer, int x, int y, int width, int height) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_draw_error_underline(renderer, x, y, width, height);
		return renderer;
	}

/// <summary>
/// <para>
/// Draws a single glyph with coordinates in device space.
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <param name="font">
/// a `PangoFont`
/// </param>
/// <param name="glyph">
/// the glyph index of a single glyph
/// </param>
/// <param name="x">
/// X coordinate of left edge of baseline of glyph
/// </param>
/// <param name="y">
/// Y coordinate of left edge of baseline of glyph
/// </param>

	public static T DrawGlyph<T>(this T renderer, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyph glyph, double x, double y) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_draw_glyph(renderer, font, glyph, x, y);
		return renderer;
	}

/// <summary>
/// <para>
/// Draws the glyphs in @glyph_item with the specified `PangoRenderer`,
/// embedding the text associated with the glyphs in the output if the
/// output format supports it.
/// </para>
/// <para>
/// This is useful for rendering text in PDF.
/// </para>
/// <para>
/// Note that this method does not handle attributes in @glyph_item.
/// If you want colors, shapes and lines handled automatically according
/// to those attributes, you need to use pango_renderer_draw_layout_line()
/// or pango_renderer_draw_layout().
/// </para>
/// <para>
/// Note that @text is the start of the text for layout, which is then
/// indexed by `glyph_item-&amp;gt;item-&amp;gt;offset`.
/// </para>
/// <para>
/// If @text is %NULL, this simply calls [method@Pango.Renderer.draw_glyphs].
/// </para>
/// <para>
/// The default implementation of this method simply falls back to
/// [method@Pango.Renderer.draw_glyphs].
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <param name="text">
/// the UTF-8 text that @glyph_item refers to
/// </param>
/// <param name="glyph_item">
/// a `PangoGlyphItem`
/// </param>
/// <param name="x">
/// X position of left edge of baseline, in user space coordinates
///   in Pango units
/// </param>
/// <param name="y">
/// Y position of left edge of baseline, in user space coordinates
///   in Pango units
/// </param>

	public static T DrawGlyphItem<T>(this T renderer, string text, MentorLake.Pango.PangoGlyphItemHandle glyph_item, int x, int y) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_draw_glyph_item(renderer, text, glyph_item, x, y);
		return renderer;
	}

/// <summary>
/// <para>
/// Draws the glyphs in @glyphs with the specified `PangoRenderer`.
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <param name="font">
/// a `PangoFont`
/// </param>
/// <param name="glyphs">
/// a `PangoGlyphString`
/// </param>
/// <param name="x">
/// X position of left edge of baseline, in user space coordinates
///   in Pango units.
/// </param>
/// <param name="y">
/// Y position of left edge of baseline, in user space coordinates
///   in Pango units.
/// </param>

	public static T DrawGlyphs<T>(this T renderer, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_draw_glyphs(renderer, font, glyphs, x, y);
		return renderer;
	}

/// <summary>
/// <para>
/// Draws @layout with the specified `PangoRenderer`.
/// </para>
/// <para>
/// This is equivalent to drawing the lines of the layout, at their
/// respective positions relative to @x, @y.
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="x">
/// X position of left edge of baseline, in user space coordinates
///   in Pango units.
/// </param>
/// <param name="y">
/// Y position of left edge of baseline, in user space coordinates
///   in Pango units.
/// </param>

	public static T DrawLayout<T>(this T renderer, MentorLake.Pango.PangoLayoutHandle layout, int x, int y) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_draw_layout(renderer, layout, x, y);
		return renderer;
	}

/// <summary>
/// <para>
/// Draws @line with the specified `PangoRenderer`.
/// </para>
/// <para>
/// This draws the glyph items that make up the line, as well as
/// shapes, backgrounds and lines that are specified by the attributes
/// of those items.
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <param name="line">
/// a `PangoLayoutLine`
/// </param>
/// <param name="x">
/// X position of left edge of baseline, in user space coordinates
///   in Pango units.
/// </param>
/// <param name="y">
/// Y position of left edge of baseline, in user space coordinates
///   in Pango units.
/// </param>

	public static T DrawLayoutLine<T>(this T renderer, MentorLake.Pango.PangoLayoutLineHandle line, int x, int y) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_draw_layout_line(renderer, line, x, y);
		return renderer;
	}

/// <summary>
/// <para>
/// Draws an axis-aligned rectangle in user space coordinates with the
/// specified `PangoRenderer`.
/// </para>
/// <para>
/// This should be called while @renderer is already active.
/// Use [method@Pango.Renderer.activate] to activate a renderer.
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <param name="part">
/// type of object this rectangle is part of
/// </param>
/// <param name="x">
/// X position at which to draw rectangle, in user space coordinates
///   in Pango units
/// </param>
/// <param name="y">
/// Y position at which to draw rectangle, in user space coordinates
///   in Pango units
/// </param>
/// <param name="width">
/// width of rectangle in Pango units
/// </param>
/// <param name="height">
/// height of rectangle in Pango units
/// </param>

	public static T DrawRectangle<T>(this T renderer, MentorLake.Pango.PangoRenderPart part, int x, int y, int width, int height) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_draw_rectangle(renderer, part, x, y, width, height);
		return renderer;
	}

/// <summary>
/// <para>
/// Draws a trapezoid with the parallel sides aligned with the X axis
/// using the given `PangoRenderer`; coordinates are in device space.
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <param name="part">
/// type of object this trapezoid is part of
/// </param>
/// <param name="y1_">
/// Y coordinate of top of trapezoid
/// </param>
/// <param name="x11">
/// X coordinate of left end of top of trapezoid
/// </param>
/// <param name="x21">
/// X coordinate of right end of top of trapezoid
/// </param>
/// <param name="y2">
/// Y coordinate of bottom of trapezoid
/// </param>
/// <param name="x12">
/// X coordinate of left end of bottom of trapezoid
/// </param>
/// <param name="x22">
/// X coordinate of right end of bottom of trapezoid
/// </param>

	public static T DrawTrapezoid<T>(this T renderer, MentorLake.Pango.PangoRenderPart part, double y1_, double x11, double x21, double y2, double x12, double x22) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_draw_trapezoid(renderer, part, y1_, x11, x21, y2, x12, x22);
		return renderer;
	}

/// <summary>
/// <para>
/// Gets the current alpha for the specified part.
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <param name="part">
/// the part to get the alpha for
/// </param>
/// <return>
/// the alpha for the specified part,
///   or 0 if it hasn&apos;t been set and should be
///   inherited from the environment.
/// </return>

	public static ushort GetAlpha(this MentorLake.Pango.PangoRendererHandle renderer, MentorLake.Pango.PangoRenderPart part)
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		return PangoRendererHandleExterns.pango_renderer_get_alpha(renderer, part);
	}

/// <summary>
/// <para>
/// Gets the current rendering color for the specified part.
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <param name="part">
/// the part to get the color for
/// </param>
/// <return>
/// the color for the
///   specified part, or %NULL if it hasn&apos;t been set and should be
///   inherited from the environment.
/// </return>

	public static MentorLake.Pango.PangoColorHandle GetColor(this MentorLake.Pango.PangoRendererHandle renderer, MentorLake.Pango.PangoRenderPart part)
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		return PangoRendererHandleExterns.pango_renderer_get_color(renderer, part);
	}

/// <summary>
/// <para>
/// Gets the layout currently being rendered using @renderer.
/// </para>
/// <para>
/// Calling this function only makes sense from inside a subclass&apos;s
/// methods, like in its draw_shape vfunc, for example.
/// </para>
/// <para>
/// The returned layout should not be modified while still being
/// rendered.
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <return>
/// the layout, or %NULL if
///   no layout is being rendered using @renderer at this time.
/// </return>

	public static MentorLake.Pango.PangoLayoutHandle GetLayout(this MentorLake.Pango.PangoRendererHandle renderer)
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		return PangoRendererHandleExterns.pango_renderer_get_layout(renderer);
	}

/// <summary>
/// <para>
/// Gets the layout line currently being rendered using @renderer.
/// </para>
/// <para>
/// Calling this function only makes sense from inside a subclass&apos;s
/// methods, like in its draw_shape vfunc, for example.
/// </para>
/// <para>
/// The returned layout line should not be modified while still being
/// rendered.
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <return>
/// the layout line, or %NULL
///   if no layout line is being rendered using @renderer at this time.
/// </return>

	public static MentorLake.Pango.PangoLayoutLineHandle GetLayoutLine(this MentorLake.Pango.PangoRendererHandle renderer)
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		return PangoRendererHandleExterns.pango_renderer_get_layout_line(renderer);
	}

/// <summary>
/// <para>
/// Gets the transformation matrix that will be applied when
/// rendering.
/// </para>
/// <para>
/// See [method@Pango.Renderer.set_matrix].
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <return>
/// the matrix, or %NULL if no matrix has
///   been set (which is the same as the identity matrix). The returned
///   matrix is owned by Pango and must not be modified or freed.
/// </return>

	public static MentorLake.Pango.PangoMatrixHandle GetMatrix(this MentorLake.Pango.PangoRendererHandle renderer)
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		return PangoRendererHandleExterns.pango_renderer_get_matrix(renderer);
	}

/// <summary>
/// <para>
/// Informs Pango that the way that the rendering is done
/// for @part has changed.
/// </para>
/// <para>
/// This should be called if the rendering changes in a way that would
/// prevent multiple pieces being joined together into one drawing call.
/// For instance, if a subclass of `PangoRenderer` was to add a stipple
/// option for drawing underlines, it needs to call
/// </para>
/// <para>
/// ```
/// pango_renderer_part_changed (render, PANGO_RENDER_PART_UNDERLINE);
/// ```
/// </para>
/// <para>
/// When the stipple changes or underlines with different stipples
/// might be joined together. Pango automatically calls this for
/// changes to colors. (See [method@Pango.Renderer.set_color])
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <param name="part">
/// the part for which rendering has changed.
/// </param>

	public static T PartChanged<T>(this T renderer, MentorLake.Pango.PangoRenderPart part) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_part_changed(renderer, part);
		return renderer;
	}

/// <summary>
/// <para>
/// Sets the alpha for part of the rendering.
/// </para>
/// <para>
/// Note that the alpha may only be used if a color is
/// specified for @part as well.
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <param name="part">
/// the part to set the alpha for
/// </param>
/// <param name="alpha">
/// an alpha value between 1 and 65536, or 0 to unset the alpha
/// </param>

	public static T SetAlpha<T>(this T renderer, MentorLake.Pango.PangoRenderPart part, ushort alpha) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_set_alpha(renderer, part, alpha);
		return renderer;
	}

/// <summary>
/// <para>
/// Sets the color for part of the rendering.
/// </para>
/// <para>
/// Also see [method@Pango.Renderer.set_alpha].
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <param name="part">
/// the part to change the color of
/// </param>
/// <param name="color">
/// the new color or %NULL to unset the current color
/// </param>

	public static T SetColor<T>(this T renderer, MentorLake.Pango.PangoRenderPart part, MentorLake.Pango.PangoColorHandle color) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_set_color(renderer, part, color);
		return renderer;
	}

/// <summary>
/// <para>
/// Sets the transformation matrix that will be applied when rendering.
/// </para>
/// </summary>

/// <param name="renderer">
/// a `PangoRenderer`
/// </param>
/// <param name="matrix">
/// a `PangoMatrix`, or %NULL to unset any existing matrix
///  (No matrix set is the same as setting the identity matrix.)
/// </param>

	public static T SetMatrix<T>(this T renderer, MentorLake.Pango.PangoMatrixHandle matrix) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid) throw new Exception("Invalid handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_set_matrix(renderer, matrix);
		return renderer;
	}

}

internal class PangoRendererHandleExterns
{
	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_renderer_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_renderer_deactivate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_renderer_draw_error_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer, int x, int y, int width, int height);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_renderer_draw_glyph([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyph glyph, double x, double y);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_renderer_draw_glyph_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer, string text, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphItemHandle>))] MentorLake.Pango.PangoGlyphItemHandle glyph_item, int x, int y);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_renderer_draw_glyphs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_renderer_draw_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int x, int y);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_renderer_draw_layout_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line, int x, int y);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_renderer_draw_rectangle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer, MentorLake.Pango.PangoRenderPart part, int x, int y, int width, int height);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_renderer_draw_trapezoid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer, MentorLake.Pango.PangoRenderPart part, double y1_, double x11, double x21, double y2, double x12, double x22);

	[DllImport(PangoLibrary.Name)]
	internal static extern ushort pango_renderer_get_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer, MentorLake.Pango.PangoRenderPart part);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoColorHandle>))]
	internal static extern MentorLake.Pango.PangoColorHandle pango_renderer_get_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer, MentorLake.Pango.PangoRenderPart part);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutHandle pango_renderer_get_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))]
	internal static extern MentorLake.Pango.PangoLayoutLineHandle pango_renderer_get_layout_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer);

	[DllImport(PangoLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))]
	internal static extern MentorLake.Pango.PangoMatrixHandle pango_renderer_get_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_renderer_part_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer, MentorLake.Pango.PangoRenderPart part);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_renderer_set_alpha([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer, MentorLake.Pango.PangoRenderPart part, ushort alpha);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_renderer_set_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer, MentorLake.Pango.PangoRenderPart part, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoColorHandle>))] MentorLake.Pango.PangoColorHandle color);

	[DllImport(PangoLibrary.Name)]
	internal static extern void pango_renderer_set_matrix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix);

}
