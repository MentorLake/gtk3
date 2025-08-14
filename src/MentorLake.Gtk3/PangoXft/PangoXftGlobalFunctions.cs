namespace MentorLake.PangoXft;

public class PangoXftGlobalFunctions
{
/// <summary>
/// <para>
/// Retrieves a `PangoContext` appropriate for rendering with
/// Xft fonts on the given screen of the given display.
/// </para>
/// </summary>

/// <param name="display">
/// an X display.
/// </param>
/// <param name="screen">
/// an X screen.
/// </param>
/// <return>
/// the new `PangoContext`.
/// </return>

	public static MentorLake.Pango.PangoContextHandle GetContext(MentorLake.xlib.DisplayHandle display, int screen)
	{
		return PangoXftGlobalFunctionsExterns.pango_xft_get_context(display, screen);
	}

/// <summary>
/// <para>
/// Returns the `PangoXftFontMap` for the given display and screen.
/// The fontmap is owned by Pango and will be valid until
/// the display is closed.
/// </para>
/// </summary>

/// <param name="display">
/// an X display
/// </param>
/// <param name="screen">
/// the screen number of a screen within @display
/// </param>
/// <return>
/// a `PangoFontMap` object, owned by Pango.
/// </return>

	public static MentorLake.Pango.PangoFontMapHandle GetFontMap(MentorLake.xlib.DisplayHandle display, int screen)
	{
		return PangoXftGlobalFunctionsExterns.pango_xft_get_font_map(display, screen);
	}

/// <summary>
/// <para>
/// Renders a `PangoGlyphString` onto an Xrender Picture object.
/// </para>
/// </summary>

/// <param name="display">
/// an X display
/// </param>
/// <param name="src_picture">
/// the source picture to draw the string with
/// </param>
/// <param name="dest_picture">
/// the destination picture to draw the string onto
/// </param>
/// <param name="font">
/// the font in which to draw the string
/// </param>
/// <param name="glyphs">
/// the glyph string to draw
/// </param>
/// <param name="x">
/// the x position of start of string (in pixels)
/// </param>
/// <param name="y">
/// the y position of baseline (in pixels)
/// </param>

	public static void PictureRender(MentorLake.xlib.DisplayHandle display, MentorLake.xlib.Picture src_picture, MentorLake.xlib.Picture dest_picture, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y)
	{
		PangoXftGlobalFunctionsExterns.pango_xft_picture_render(display, src_picture, dest_picture, font, glyphs, x, y);
	}

/// <summary>
/// <para>
/// Renders a `PangoGlyphString` onto an XftDraw object wrapping an X drawable.
/// </para>
/// </summary>

/// <param name="draw">
/// the XftDraw object.
/// </param>
/// <param name="color">
/// the color in which to draw the string
/// </param>
/// <param name="font">
/// the font in which to draw the string
/// </param>
/// <param name="glyphs">
/// the glyph string to draw
/// </param>
/// <param name="x">
/// the x position of start of string (in pixels)
/// </param>
/// <param name="y">
/// the y position of baseline (in pixels)
/// </param>

	public static void Render(MentorLake.xft.XftDrawHandle draw, MentorLake.xft.XftColorHandle color, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y)
	{
		PangoXftGlobalFunctionsExterns.pango_xft_render(draw, color, font, glyphs, x, y);
	}

/// <summary>
/// <para>
/// Render a `PangoLayout` onto a XftDraw
/// </para>
/// </summary>

/// <param name="draw">
/// an XftDraw
/// </param>
/// <param name="color">
/// the foreground color in which to draw the layout
///   (may be overridden by color attributes)
/// </param>
/// <param name="layout">
/// a `PangoLayout`
/// </param>
/// <param name="x">
/// the X position of the left of the layout (in Pango units)
/// </param>
/// <param name="y">
/// the Y position of the top of the layout (in Pango units)
/// </param>

	public static void RenderLayout(MentorLake.xft.XftDrawHandle draw, MentorLake.xft.XftColorHandle color, MentorLake.Pango.PangoLayoutHandle layout, int x, int y)
	{
		PangoXftGlobalFunctionsExterns.pango_xft_render_layout(draw, color, layout, x, y);
	}

/// <summary>
/// <para>
/// Render a `PangoLayoutLine` onto a XftDraw
/// </para>
/// </summary>

/// <param name="draw">
/// an XftDraw
/// </param>
/// <param name="color">
/// the foreground color in which to draw the layout line
///   (may be overridden by color attributes)
/// </param>
/// <param name="line">
/// a `PangoLayoutLine`
/// </param>
/// <param name="x">
/// the x position of start of string (in Pango units)
/// </param>
/// <param name="y">
/// the y position of baseline (in Pango units)
/// </param>

	public static void RenderLayoutLine(MentorLake.xft.XftDrawHandle draw, MentorLake.xft.XftColorHandle color, MentorLake.Pango.PangoLayoutLineHandle line, int x, int y)
	{
		PangoXftGlobalFunctionsExterns.pango_xft_render_layout_line(draw, color, line, x, y);
	}

/// <summary>
/// <para>
/// Renders a `PangoGlyphString` onto a XftDraw, possibly
/// transforming the layed-out coordinates through a transformation
/// matrix.
/// </para>
/// <para>
/// Note that the transformation matrix for @font is not
/// changed, so to produce correct rendering results, the @font
/// must have been loaded using a `PangoContext` with an identical
/// transformation matrix to that passed in to this function.
/// </para>
/// </summary>

/// <param name="draw">
/// an XftDraw
/// </param>
/// <param name="color">
/// the color in which to draw the glyphs
/// </param>
/// <param name="matrix">
/// a `PangoMatrix`
/// </param>
/// <param name="font">
/// the font in which to draw the string
/// </param>
/// <param name="glyphs">
/// the glyph string to draw
/// </param>
/// <param name="x">
/// the x position of the start of the string (in Pango
///   units in user space coordinates)
/// </param>
/// <param name="y">
/// the y position of the baseline (in Pango units
///   in user space coordinates)
/// </param>

	public static void RenderTransformed(MentorLake.xft.XftDrawHandle draw, MentorLake.xft.XftColorHandle color, MentorLake.Pango.PangoMatrixHandle matrix, MentorLake.Pango.PangoFontHandle font, MentorLake.Pango.PangoGlyphStringHandle glyphs, int x, int y)
	{
		PangoXftGlobalFunctionsExterns.pango_xft_render_transformed(draw, color, matrix, font, glyphs, x, y);
	}

/// <summary>
/// <para>
/// Sets a function that will be called to do final configuration
/// substitution on a #FcPattern before it is used to load
/// the font. This function can be used to do things like set
/// hinting and antialiasing options.
/// </para>
/// </summary>

/// <param name="display">
/// an X Display
/// </param>
/// <param name="screen">
/// the screen number of a screen within @display
/// </param>
/// <param name="func">
/// function to call to to do final config tweaking
///        on #FcPattern objects.
/// </param>
/// <param name="data">
/// data to pass to @func
/// </param>
/// <param name="notify">
/// function to call when @data is no longer used.
/// </param>

	public static void SetDefaultSubstitute(MentorLake.xlib.DisplayHandle display, int screen, MentorLake.PangoXft.PangoXftSubstituteFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		PangoXftGlobalFunctionsExterns.pango_xft_set_default_substitute(display, screen, func, data, notify);
	}

/// <summary>
/// <para>
/// Release any resources that have been cached for the
/// combination of @display and @screen. Note that when the
/// X display is closed, resources are released automatically,
/// without needing to call this function.
/// </para>
/// </summary>

/// <param name="display">
/// an X display
/// </param>
/// <param name="screen">
/// the screen number of a screen within @display
/// </param>

	public static void ShutdownDisplay(MentorLake.xlib.DisplayHandle display, int screen)
	{
		PangoXftGlobalFunctionsExterns.pango_xft_shutdown_display(display, screen);
	}

/// <summary>
/// <para>
/// Call this function any time the results of the
/// default substitution function set with
/// pango_xft_set_default_substitute() change.
/// That is, if your substitution function will return different
/// results for the same input pattern, you must call this function.
/// </para>
/// </summary>

/// <param name="display">
/// an X Display
/// </param>
/// <param name="screen">
/// the screen number of a screen within @display
/// </param>

	public static void SubstituteChanged(MentorLake.xlib.DisplayHandle display, int screen)
	{
		PangoXftGlobalFunctionsExterns.pango_xft_substitute_changed(display, screen);
	}

}

internal class PangoXftGlobalFunctionsExterns
{
	[DllImport(PangoXftLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoContextHandle>))]
	internal static extern MentorLake.Pango.PangoContextHandle pango_xft_get_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xlib.DisplayHandle>))] MentorLake.xlib.DisplayHandle display, int screen);

	[DllImport(PangoXftLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))]
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
