namespace MentorLake.PangoXft;

public class PangoXftRendererHandle : PangoRendererHandle
{
	public static MentorLake.PangoXft.PangoXftRendererHandle New(MentorLake.xlib.DisplayHandle display, int screen)
	{
		return PangoXftRendererHandleExterns.pango_xft_renderer_new(display, screen);
	}

}

public static class PangoXftRendererHandleExtensions
{
	public static T SetDefaultColor<T>(this T xftrenderer, MentorLake.Pango.PangoColorHandle default_color) where T : PangoXftRendererHandle
	{
		PangoXftRendererHandleExterns.pango_xft_renderer_set_default_color(xftrenderer, default_color);
		return xftrenderer;
	}

	public static T SetDraw<T>(this T xftrenderer, MentorLake.xft.XftDrawHandle draw) where T : PangoXftRendererHandle
	{
		PangoXftRendererHandleExterns.pango_xft_renderer_set_draw(xftrenderer, draw);
		return xftrenderer;
	}

}

internal class PangoXftRendererHandleExterns
{
	[DllImport(PangoXftLibrary.Name)]
	internal static extern MentorLake.PangoXft.PangoXftRendererHandle pango_xft_renderer_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xlib.DisplayHandle>))] MentorLake.xlib.DisplayHandle display, int screen);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern void pango_xft_renderer_set_default_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoXft.PangoXftRendererHandle>))] MentorLake.PangoXft.PangoXftRendererHandle xftrenderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoColorHandle>))] MentorLake.Pango.PangoColorHandle default_color);

	[DllImport(PangoXftLibrary.Name)]
	internal static extern void pango_xft_renderer_set_draw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.PangoXft.PangoXftRendererHandle>))] MentorLake.PangoXft.PangoXftRendererHandle xftrenderer, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xft.XftDrawHandle>))] MentorLake.xft.XftDrawHandle draw);

}
