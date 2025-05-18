namespace MentorLake.GdkX11;

public class GdkX11VisualHandle : GdkVisualHandle
{
}

public static class GdkX11VisualHandleExtensions
{
	public static MentorLake.xlib.VisualHandle GetXvisual(this MentorLake.GdkX11.GdkX11VisualHandle visual)
	{
		if (visual.IsInvalid) throw new Exception("Invalid handle (GdkX11VisualHandle)");
		return GdkX11VisualHandleExterns.gdk_x11_visual_get_xvisual(visual);
	}

}

internal class GdkX11VisualHandleExterns
{
	[DllImport(GdkX11Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xlib.VisualHandle>))]
	internal static extern MentorLake.xlib.VisualHandle gdk_x11_visual_get_xvisual([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11VisualHandle>))] MentorLake.GdkX11.GdkX11VisualHandle visual);

}
