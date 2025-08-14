namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkOffscreenWindow is strictly intended to be used for obtaining
/// snapshots of widgets that are not part of a normal widget hierarchy.
/// Since #GtkOffscreenWindow is a toplevel widget you cannot obtain
/// snapshots of a full window with it since you cannot pack a toplevel
/// widget in another toplevel.
/// </para>
/// <para>
/// The idea is to take a widget and manually set the state of it,
/// add it to a GtkOffscreenWindow and then retrieve the snapshot
/// as a #cairo_surface_t or #GdkPixbuf.
/// </para>
/// <para>
/// GtkOffscreenWindow derives from #GtkWindow only as an implementation
/// detail.  Applications should not use any API specific to #GtkWindow
/// to operate on this object.  It should be treated as a #GtkBin that
/// has no parent widget.
/// </para>
/// <para>
/// When contained offscreen widgets are redrawn, GtkOffscreenWindow
/// will emit a #GtkWidget::damage-event signal.
/// </para>
/// </summary>

public class GtkOffscreenWindowHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a toplevel container widget that is used to retrieve
/// snapshots of widgets without showing them on the screen.
/// </para>
/// </summary>

/// <return>
/// A pointer to a #GtkWidget
/// </return>

	public static MentorLake.Gtk.GtkOffscreenWindowHandle New()
	{
		return GtkOffscreenWindowHandleExterns.gtk_offscreen_window_new();
	}

}

public static class GtkOffscreenWindowHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves a snapshot of the contained widget in the form of
/// a #GdkPixbuf.  This is a new pixbuf with a reference count of 1,
/// and the application should unreference it once it is no longer
/// needed.
/// </para>
/// </summary>

/// <param name="offscreen">
/// the #GtkOffscreenWindow contained widget.
/// </param>
/// <return>
/// A #GdkPixbuf pointer, or %NULL.
/// </return>

	public static MentorLake.GdkPixbuf.GdkPixbufHandle GetPixbuf(this MentorLake.Gtk.GtkOffscreenWindowHandle offscreen)
	{
		if (offscreen.IsInvalid) throw new Exception("Invalid handle (GtkOffscreenWindowHandle)");
		return GtkOffscreenWindowHandleExterns.gtk_offscreen_window_get_pixbuf(offscreen);
	}

/// <summary>
/// <para>
/// Retrieves a snapshot of the contained widget in the form of
/// a #cairo_surface_t.  If you need to keep this around over window
/// resizes then you should add a reference to it.
/// </para>
/// </summary>

/// <param name="offscreen">
/// the #GtkOffscreenWindow contained widget.
/// </param>
/// <return>
/// A #cairo_surface_t pointer to the offscreen
///     surface, or %NULL.
/// </return>

	public static MentorLake.cairo.cairo_surface_tHandle GetSurface(this MentorLake.Gtk.GtkOffscreenWindowHandle offscreen)
	{
		if (offscreen.IsInvalid) throw new Exception("Invalid handle (GtkOffscreenWindowHandle)");
		return GtkOffscreenWindowHandleExterns.gtk_offscreen_window_get_surface(offscreen);
	}

}

internal class GtkOffscreenWindowHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkOffscreenWindowHandle>))]
	internal static extern MentorLake.Gtk.GtkOffscreenWindowHandle gtk_offscreen_window_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_offscreen_window_get_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOffscreenWindowHandle>))] MentorLake.Gtk.GtkOffscreenWindowHandle offscreen);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_surface_tHandle>))]
	internal static extern MentorLake.cairo.cairo_surface_tHandle gtk_offscreen_window_get_surface([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkOffscreenWindowHandle>))] MentorLake.Gtk.GtkOffscreenWindowHandle offscreen);

}
