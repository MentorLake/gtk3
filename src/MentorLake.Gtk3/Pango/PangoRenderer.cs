namespace MentorLake.Gtk3.Pango;

public class PangoRendererHandle : GObjectHandle
{
}

public static class PangoRendererHandleExtensions
{
	public static T Activate<T>(this T renderer) where T : PangoRendererHandle
	{
		PangoRendererExterns.pango_renderer_activate(renderer);
		return renderer;
	}

	public static T Deactivate<T>(this T renderer) where T : PangoRendererHandle
	{
		PangoRendererExterns.pango_renderer_deactivate(renderer);
		return renderer;
	}

	public static T DrawErrorUnderline<T>(this T renderer, int x, int y, int width, int height) where T : PangoRendererHandle
	{
		PangoRendererExterns.pango_renderer_draw_error_underline(renderer, x, y, width, height);
		return renderer;
	}

	public static T DrawGlyph<T>(this T renderer, PangoFontHandle font, PangoGlyph glyph, double x, double y) where T : PangoRendererHandle
	{
		PangoRendererExterns.pango_renderer_draw_glyph(renderer, font, glyph, x, y);
		return renderer;
	}

	public static T DrawGlyphItem<T>(this T renderer, string text, PangoGlyphItemHandle glyph_item, int x, int y) where T : PangoRendererHandle
	{
		PangoRendererExterns.pango_renderer_draw_glyph_item(renderer, text, glyph_item, x, y);
		return renderer;
	}

	public static T DrawGlyphs<T>(this T renderer, PangoFontHandle font, PangoGlyphStringHandle glyphs, int x, int y) where T : PangoRendererHandle
	{
		PangoRendererExterns.pango_renderer_draw_glyphs(renderer, font, glyphs, x, y);
		return renderer;
	}

	public static T DrawLayout<T>(this T renderer, PangoLayoutHandle layout, int x, int y) where T : PangoRendererHandle
	{
		PangoRendererExterns.pango_renderer_draw_layout(renderer, layout, x, y);
		return renderer;
	}

	public static T DrawLayoutLine<T>(this T renderer, PangoLayoutLineHandle line, int x, int y) where T : PangoRendererHandle
	{
		PangoRendererExterns.pango_renderer_draw_layout_line(renderer, line, x, y);
		return renderer;
	}

	public static T DrawRectangle<T>(this T renderer, PangoRenderPart part, int x, int y, int width, int height) where T : PangoRendererHandle
	{
		PangoRendererExterns.pango_renderer_draw_rectangle(renderer, part, x, y, width, height);
		return renderer;
	}

	public static T DrawTrapezoid<T>(this T renderer, PangoRenderPart part, double y1_, double x11, double x21, double y2, double x12, double x22) where T : PangoRendererHandle
	{
		PangoRendererExterns.pango_renderer_draw_trapezoid(renderer, part, y1_, x11, x21, y2, x12, x22);
		return renderer;
	}

	public static ushort GetAlpha(this PangoRendererHandle renderer, PangoRenderPart part)
	{
		return PangoRendererExterns.pango_renderer_get_alpha(renderer, part);
	}

	public static PangoColorHandle GetColor(this PangoRendererHandle renderer, PangoRenderPart part)
	{
		return PangoRendererExterns.pango_renderer_get_color(renderer, part);
	}

	public static PangoLayoutHandle GetLayout(this PangoRendererHandle renderer)
	{
		return PangoRendererExterns.pango_renderer_get_layout(renderer);
	}

	public static PangoLayoutLineHandle GetLayoutLine(this PangoRendererHandle renderer)
	{
		return PangoRendererExterns.pango_renderer_get_layout_line(renderer);
	}

	public static PangoMatrixHandle GetMatrix(this PangoRendererHandle renderer)
	{
		return PangoRendererExterns.pango_renderer_get_matrix(renderer);
	}

	public static T PartChanged<T>(this T renderer, PangoRenderPart part) where T : PangoRendererHandle
	{
		PangoRendererExterns.pango_renderer_part_changed(renderer, part);
		return renderer;
	}

	public static T SetAlpha<T>(this T renderer, PangoRenderPart part, ushort alpha) where T : PangoRendererHandle
	{
		PangoRendererExterns.pango_renderer_set_alpha(renderer, part, alpha);
		return renderer;
	}

	public static T SetColor<T>(this T renderer, PangoRenderPart part, PangoColorHandle color) where T : PangoRendererHandle
	{
		PangoRendererExterns.pango_renderer_set_color(renderer, part, color);
		return renderer;
	}

	public static T SetMatrix<T>(this T renderer, PangoMatrixHandle matrix) where T : PangoRendererHandle
	{
		PangoRendererExterns.pango_renderer_set_matrix(renderer, matrix);
		return renderer;
	}

}

internal class PangoRendererExterns
{
	[DllImport(Libraries.Pango)]
	internal static extern void pango_renderer_activate(PangoRendererHandle renderer);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_renderer_deactivate(PangoRendererHandle renderer);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_renderer_draw_error_underline(PangoRendererHandle renderer, int x, int y, int width, int height);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_renderer_draw_glyph(PangoRendererHandle renderer, PangoFontHandle font, PangoGlyph glyph, double x, double y);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_renderer_draw_glyph_item(PangoRendererHandle renderer, string text, PangoGlyphItemHandle glyph_item, int x, int y);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_renderer_draw_glyphs(PangoRendererHandle renderer, PangoFontHandle font, PangoGlyphStringHandle glyphs, int x, int y);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_renderer_draw_layout(PangoRendererHandle renderer, PangoLayoutHandle layout, int x, int y);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_renderer_draw_layout_line(PangoRendererHandle renderer, PangoLayoutLineHandle line, int x, int y);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_renderer_draw_rectangle(PangoRendererHandle renderer, PangoRenderPart part, int x, int y, int width, int height);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_renderer_draw_trapezoid(PangoRendererHandle renderer, PangoRenderPart part, double y1_, double x11, double x21, double y2, double x12, double x22);

	[DllImport(Libraries.Pango)]
	internal static extern ushort pango_renderer_get_alpha(PangoRendererHandle renderer, PangoRenderPart part);

	[DllImport(Libraries.Pango)]
	internal static extern PangoColorHandle pango_renderer_get_color(PangoRendererHandle renderer, PangoRenderPart part);

	[DllImport(Libraries.Pango)]
	internal static extern PangoLayoutHandle pango_renderer_get_layout(PangoRendererHandle renderer);

	[DllImport(Libraries.Pango)]
	internal static extern PangoLayoutLineHandle pango_renderer_get_layout_line(PangoRendererHandle renderer);

	[DllImport(Libraries.Pango)]
	internal static extern PangoMatrixHandle pango_renderer_get_matrix(PangoRendererHandle renderer);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_renderer_part_changed(PangoRendererHandle renderer, PangoRenderPart part);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_renderer_set_alpha(PangoRendererHandle renderer, PangoRenderPart part, ushort alpha);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_renderer_set_color(PangoRendererHandle renderer, PangoRenderPart part, PangoColorHandle color);

	[DllImport(Libraries.Pango)]
	internal static extern void pango_renderer_set_matrix(PangoRendererHandle renderer, PangoMatrixHandle matrix);

}
