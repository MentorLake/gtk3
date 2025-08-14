namespace MentorLake.PangoXft;

/// <summary>
/// <para>
/// `PangoXftRenderer` is a subclass of `PangoRenderer` used for rendering
/// with Pango's Xft backend. It can be used directly, or it can be
/// further subclassed to modify exactly how drawing of individual
/// elements occurs.
/// </para>
/// </summary>

public class PangoXftRendererHandle : PangoRendererHandle
{
/// <summary>
/// <para>
/// Create a new `PangoXftRenderer` to allow rendering Pango objects
/// with the Xft library.
/// </para>
/// <para>
/// You must call pango_xft_renderer_set_draw() before
/// using the renderer.
/// </para>
/// </summary>

/// <param name="display">
/// an X display
/// </param>
/// <param name="screen">
/// the index of the screen for @display to which rendering will be done
/// </param>
/// <return>
/// the newly created `PangoXftRenderer`
/// </return>

	public static MentorLake.PangoXft.PangoXftRendererHandle New(MentorLake.xlib.DisplayHandle display, int screen)
	{
		return PangoXftRendererHandleExterns.pango_xft_renderer_new(display, screen);
	}

}

public static class PangoXftRendererHandleExtensions
{
/// <summary>
/// <para>
/// Sets the default foreground color for a XftRenderer.
/// </para>
/// </summary>

/// <param name="xftrenderer">
/// a XftRenderer
/// </param>
/// <param name="default_color">
/// the default foreground color
/// </param>

	public static T SetDefaultColor<T>(this T xftrenderer, MentorLake.Pango.PangoColorHandle default_color) where T : PangoXftRendererHandle
	{
		if (xftrenderer.IsInvalid) throw new Exception("Invalid handle (PangoXftRendererHandle)");
		PangoXftRendererHandleExterns.pango_xft_renderer_set_default_color(xftrenderer, default_color);
		return xftrenderer;
	}

/// <summary>
/// <para>
/// Sets the XftDraw object that the renderer is drawing to.
/// The renderer must not be currently active.
/// </para>
/// </summary>

/// <param name="xftrenderer">
/// a `PangoXftRenderer`
/// </param>
/// <param name="draw">
/// a XftDraw
/// </param>

	public static T SetDraw<T>(this T xftrenderer, MentorLake.xft.XftDrawHandle draw) where T : PangoXftRendererHandle
	{
		if (xftrenderer.IsInvalid) throw new Exception("Invalid handle (PangoXftRendererHandle)");
		PangoXftRendererHandleExterns.pango_xft_renderer_set_draw(xftrenderer, draw);
		return xftrenderer;
	}

}

internal class PangoXftRendererHandleExterns
{
	[DllImport(PangoXftLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.PangoXft.PangoXftRendererHandle>))]
	internal static extern MentorLake.PangoXft.PangoXftRendererHandle pango_xft_renderer_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xlib.DisplayHandle>))] MentorLake.xlib.DisplayHandle display, int screen);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern void pango_xft_renderer_set_default_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoXft.PangoXftRendererHandle>))] MentorLake.PangoXft.PangoXftRendererHandle xftrenderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoColorHandle>))] MentorLake.Pango.PangoColorHandle default_color);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern void pango_xft_renderer_set_draw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoXft.PangoXftRendererHandle>))] MentorLake.PangoXft.PangoXftRendererHandle xftrenderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xft.XftDrawHandle>))] MentorLake.xft.XftDrawHandle draw);

}
