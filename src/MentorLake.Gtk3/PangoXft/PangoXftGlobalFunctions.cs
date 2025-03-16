namespace MentorLake.PangoXft;

public class PangoXftGlobalFunctions
{
	public static MentorLake.Pango.PangoContextHandle GetContext(MentorLake.xlib.DisplayHandle display, int screen)
	{
		return PangoXftGlobalFunctionsExterns.pango_xft_get_context(display, screen);
	}

	public static MentorLake.Pango.PangoFontMapHandle GetFontMap(MentorLake.xlib.DisplayHandle display, int screen)
	{
		return PangoXftGlobalFunctionsExterns.pango_xft_get_font_map(display, screen);
	}

	public static void PictureRender(MentorLake.xlib.DisplayHandle display, MentorLake.xlib.Picture src_picture, MentorLake.xlib.Picture dest_picture, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y)
	{
		PangoXftGlobalFunctionsExterns.pango_xft_picture_render(display, src_picture, dest_picture, font, glyphs, x, y);
	}

	public static void Render(MentorLake.xft.XftDrawHandle draw, MentorLake.xft.XftColorHandle color, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y)
	{
		PangoXftGlobalFunctionsExterns.pango_xft_render(draw, color, font, glyphs, x, y);
	}

	public static void RenderLayout(MentorLake.xft.XftDrawHandle draw, MentorLake.xft.XftColorHandle color, MentorLake.Pango.PangoLayoutHandle layout, int x, int y)
	{
		PangoXftGlobalFunctionsExterns.pango_xft_render_layout(draw, color, layout, x, y);
	}

	public static void RenderLayoutLine(MentorLake.xft.XftDrawHandle draw, MentorLake.xft.XftColorHandle color, MentorLake.Pango.PangoLayoutLineHandle line, int x, int y)
	{
		PangoXftGlobalFunctionsExterns.pango_xft_render_layout_line(draw, color, line, x, y);
	}

	public static void RenderTransformed(MentorLake.xft.XftDrawHandle draw, MentorLake.xft.XftColorHandle color, MentorLake.Pango.PangoMatrixHandle matrix, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y)
	{
		PangoXftGlobalFunctionsExterns.pango_xft_render_transformed(draw, color, matrix, font, glyphs, x, y);
	}

	public static void SetDefaultSubstitute(MentorLake.xlib.DisplayHandle display, int screen, MentorLake.PangoXft.PangoXftSubstituteFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		PangoXftGlobalFunctionsExterns.pango_xft_set_default_substitute(display, screen, func, data, notify);
	}

	public static void ShutdownDisplay(MentorLake.xlib.DisplayHandle display, int screen)
	{
		PangoXftGlobalFunctionsExterns.pango_xft_shutdown_display(display, screen);
	}

	public static void SubstituteChanged(MentorLake.xlib.DisplayHandle display, int screen)
	{
		PangoXftGlobalFunctionsExterns.pango_xft_substitute_changed(display, screen);
	}

}

internal class PangoXftGlobalFunctionsExterns
{
	[DllImport(PangoXftLibrary.Name)]
	internal static extern MentorLake.Pango.PangoContextHandle pango_xft_get_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xlib.DisplayHandle>))] MentorLake.xlib.DisplayHandle display, int screen);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontMapHandle pango_xft_get_font_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xlib.DisplayHandle>))] MentorLake.xlib.DisplayHandle display, int screen);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern void pango_xft_picture_render([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xlib.DisplayHandle>))] MentorLake.xlib.DisplayHandle display, MentorLake.xlib.Picture src_picture, MentorLake.xlib.Picture dest_picture, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern void pango_xft_render([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xft.XftDrawHandle>))] MentorLake.xft.XftDrawHandle draw, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xft.XftColorHandle>))] MentorLake.xft.XftColorHandle color, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern void pango_xft_render_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xft.XftDrawHandle>))] MentorLake.xft.XftDrawHandle draw, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xft.XftColorHandle>))] MentorLake.xft.XftColorHandle color, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutHandle>))] MentorLake.Pango.PangoLayoutHandle layout, int x, int y);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern void pango_xft_render_layout_line([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xft.XftDrawHandle>))] MentorLake.xft.XftDrawHandle draw, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xft.XftColorHandle>))] MentorLake.xft.XftColorHandle color, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoLayoutLineHandle>))] MentorLake.Pango.PangoLayoutLineHandle line, int x, int y);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern void pango_xft_render_transformed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xft.XftDrawHandle>))] MentorLake.xft.XftDrawHandle draw, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xft.XftColorHandle>))] MentorLake.xft.XftColorHandle color, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoMatrixHandle>))] MentorLake.Pango.PangoMatrixHandle matrix, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontHandle>))] MentorLake.Pango.PangoFontHandle font, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoGlyphStringHandle>))] MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern void pango_xft_set_default_substitute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xlib.DisplayHandle>))] MentorLake.xlib.DisplayHandle display, int screen, MentorLake.PangoXft.PangoXftSubstituteFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern void pango_xft_shutdown_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xlib.DisplayHandle>))] MentorLake.xlib.DisplayHandle display, int screen);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern void pango_xft_substitute_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xlib.DisplayHandle>))] MentorLake.xlib.DisplayHandle display, int screen);

}
