namespace MentorLake.Pango;

public class PangoRendererHandle : GObjectHandle
{
}

public static class PangoRendererHandleExtensions
{
	public static T Activate<T>(this T renderer) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_activate(renderer);
		return renderer;
	}

	public static T Deactivate<T>(this T renderer) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_deactivate(renderer);
		return renderer;
	}

	public static T DrawErrorUnderline<T>(this T renderer, int x, int y, int width, int height) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_draw_error_underline(renderer, x, y, width, height);
		return renderer;
	}

	public static T DrawGlyph<T>(this T renderer, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyph glyph, double x, double y) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_draw_glyph(renderer, font, glyph, x, y);
		return renderer;
	}

	public static T DrawGlyphItem<T>(this T renderer, string text, MentorLake.Pango.PangoGlyphItemHandle glyph_item, int x, int y) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_draw_glyph_item(renderer, text, glyph_item, x, y);
		return renderer;
	}

	public static T DrawGlyphs<T>(this T renderer, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_draw_glyphs(renderer, font, glyphs, x, y);
		return renderer;
	}

	public static T DrawLayout<T>(this T renderer, MentorLake.Pango.PangoLayoutHandle layout, int x, int y) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_draw_layout(renderer, layout, x, y);
		return renderer;
	}

	public static T DrawLayoutLine<T>(this T renderer, MentorLake.Pango.PangoLayoutLineHandle line, int x, int y) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_draw_layout_line(renderer, line, x, y);
		return renderer;
	}

	public static T DrawRectangle<T>(this T renderer, MentorLake.Pango.PangoRenderPart part, int x, int y, int width, int height) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_draw_rectangle(renderer, part, x, y, width, height);
		return renderer;
	}

	public static T DrawTrapezoid<T>(this T renderer, MentorLake.Pango.PangoRenderPart part, double y1_, double x11, double x21, double y2, double x12, double x22) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_draw_trapezoid(renderer, part, y1_, x11, x21, y2, x12, x22);
		return renderer;
	}

	public static ushort GetAlpha(this MentorLake.Pango.PangoRendererHandle renderer, MentorLake.Pango.PangoRenderPart part)
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		return PangoRendererHandleExterns.pango_renderer_get_alpha(renderer, part);
	}

	public static MentorLake.Pango.PangoColorHandle GetColor(this MentorLake.Pango.PangoRendererHandle renderer, MentorLake.Pango.PangoRenderPart part)
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		return PangoRendererHandleExterns.pango_renderer_get_color(renderer, part);
	}

	public static MentorLake.Pango.PangoLayoutHandle GetLayout(this MentorLake.Pango.PangoRendererHandle renderer)
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		return PangoRendererHandleExterns.pango_renderer_get_layout(renderer);
	}

	public static MentorLake.Pango.PangoLayoutLineHandle GetLayoutLine(this MentorLake.Pango.PangoRendererHandle renderer)
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		return PangoRendererHandleExterns.pango_renderer_get_layout_line(renderer);
	}

	public static MentorLake.Pango.PangoMatrixHandle GetMatrix(this MentorLake.Pango.PangoRendererHandle renderer)
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		return PangoRendererHandleExterns.pango_renderer_get_matrix(renderer);
	}

	public static T PartChanged<T>(this T renderer, MentorLake.Pango.PangoRenderPart part) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_part_changed(renderer, part);
		return renderer;
	}

	public static T SetAlpha<T>(this T renderer, MentorLake.Pango.PangoRenderPart part, ushort alpha) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_set_alpha(renderer, part, alpha);
		return renderer;
	}

	public static T SetColor<T>(this T renderer, MentorLake.Pango.PangoRenderPart part, MentorLake.Pango.PangoColorHandle color) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
		PangoRendererHandleExterns.pango_renderer_set_color(renderer, part, color);
		return renderer;
	}

	public static T SetMatrix<T>(this T renderer, MentorLake.Pango.PangoMatrixHandle matrix) where T : PangoRendererHandle
	{
		if (renderer.IsInvalid || renderer.IsClosed) throw new Exception("Invalid or closed handle (PangoRendererHandle)");
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
	internal static extern MentorLake.Pango.PangoColorHandle pango_renderer_get_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer, MentorLake.Pango.PangoRenderPart part);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLayoutHandle pango_renderer_get_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer);

	[DllImport(PangoLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLayoutLineHandle pango_renderer_get_layout_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoRendererHandle>))] MentorLake.Pango.PangoRendererHandle renderer);

	[DllImport(PangoLibrary.Name)]
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
