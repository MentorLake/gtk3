namespace MentorLake.GdkX11;


public class GdkX11CursorHandle : GdkCursorHandle
{
}

public static class GdkX11CursorHandleExtensions
{
/// <summary>
/// <para>
/// Returns the X cursor belonging to a #GdkCursor.
/// </para>
/// </summary>

/// <param name="cursor">
/// a #GdkCursor.
/// </param>
/// <return>
/// an Xlib Cursor.
/// </return>

	public static MentorLake.xlib.Cursor GetXcursor(this MentorLake.GdkX11.GdkX11CursorHandle cursor)
	{
		if (cursor.IsInvalid) throw new Exception("Invalid handle (GdkX11CursorHandle)");
		return GdkX11CursorHandleExterns.gdk_x11_cursor_get_xcursor(cursor);
	}

/// <summary>
/// <para>
/// Returns the display of a #GdkCursor.
/// </para>
/// </summary>

/// <param name="cursor">
/// a #GdkCursor.
/// </param>
/// <return>
/// an Xlib Display*.
/// </return>

	public static MentorLake.xlib.DisplayHandle GetXdisplay(this MentorLake.GdkX11.GdkX11CursorHandle cursor)
	{
		if (cursor.IsInvalid) throw new Exception("Invalid handle (GdkX11CursorHandle)");
		return GdkX11CursorHandleExterns.gdk_x11_cursor_get_xdisplay(cursor);
	}

}

internal class GdkX11CursorHandleExterns
{
	[DllImport(GdkX11Library.Name)]
	internal static extern MentorLake.xlib.Cursor gdk_x11_cursor_get_xcursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11CursorHandle>))] MentorLake.GdkX11.GdkX11CursorHandle cursor);

	[DllImport(GdkX11Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.xlib.DisplayHandle>))]
	internal static extern MentorLake.xlib.DisplayHandle gdk_x11_cursor_get_xdisplay([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkX11.GdkX11CursorHandle>))] MentorLake.GdkX11.GdkX11CursorHandle cursor);

}
