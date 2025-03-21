namespace MentorLake.GdkX11;

public class GdkX11CursorHandle : GdkCursorHandle
{
}

public static class GdkX11CursorHandleExtensions
{
	public static MentorLake.xlib.Cursor GetXcursor(this MentorLake.GdkX11.GdkX11CursorHandle cursor)
	{
		return GdkX11CursorHandleExterns.gdk_x11_cursor_get_xcursor(cursor);
	}

	public static MentorLake.xlib.DisplayHandle GetXdisplay(this MentorLake.GdkX11.GdkX11CursorHandle cursor)
	{
		return GdkX11CursorHandleExterns.gdk_x11_cursor_get_xdisplay(cursor);
	}

}

internal class GdkX11CursorHandleExterns
{
	[DllImport(GdkX11Library.Name)]
	internal static extern MentorLake.xlib.Cursor gdk_x11_cursor_get_xcursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11CursorHandle>))] MentorLake.GdkX11.GdkX11CursorHandle cursor);

	[DllImport(GdkX11Library.Name)]
	internal static extern MentorLake.xlib.DisplayHandle gdk_x11_cursor_get_xdisplay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11CursorHandle>))] MentorLake.GdkX11.GdkX11CursorHandle cursor);

}
