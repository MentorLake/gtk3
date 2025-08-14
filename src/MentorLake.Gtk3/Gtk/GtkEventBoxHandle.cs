namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkEventBox widget is a subclass of #GtkBin which also has its
/// own window. It is useful since it allows you to catch events for widgets
/// which do not have their own window.
/// </para>
/// </summary>

public class GtkEventBoxHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkEventBox.
/// </para>
/// </summary>

/// <return>
/// a new #GtkEventBox
/// </return>

	public static MentorLake.Gtk.GtkEventBoxHandle New()
	{
		return GtkEventBoxHandleExterns.gtk_event_box_new();
	}

}

public static class GtkEventBoxHandleExtensions
{
/// <summary>
/// <para>
/// Returns whether the event box window is above or below the
/// windows of its child. See gtk_event_box_set_above_child()
/// for details.
/// </para>
/// </summary>

/// <param name="event_box">
/// a #GtkEventBox
/// </param>
/// <return>
/// %TRUE if the event box window is above the
///     window of its child
/// </return>

	public static bool GetAboveChild(this MentorLake.Gtk.GtkEventBoxHandle event_box)
	{
		if (event_box.IsInvalid) throw new Exception("Invalid handle (GtkEventBoxHandle)");
		return GtkEventBoxHandleExterns.gtk_event_box_get_above_child(event_box);
	}

/// <summary>
/// <para>
/// Returns whether the event box has a visible window.
/// See gtk_event_box_set_visible_window() for details.
/// </para>
/// </summary>

/// <param name="event_box">
/// a #GtkEventBox
/// </param>
/// <return>
/// %TRUE if the event box window is visible
/// </return>

	public static bool GetVisibleWindow(this MentorLake.Gtk.GtkEventBoxHandle event_box)
	{
		if (event_box.IsInvalid) throw new Exception("Invalid handle (GtkEventBoxHandle)");
		return GtkEventBoxHandleExterns.gtk_event_box_get_visible_window(event_box);
	}

/// <summary>
/// <para>
/// Set whether the event box window is positioned above the windows
/// of its child, as opposed to below it. If the window is above, all
/// events inside the event box will go to the event box. If the window
/// is below, events in windows of child widgets will first got to that
/// widget, and then to its parents.
/// </para>
/// <para>
/// The default is to keep the window below the child.
/// </para>
/// </summary>

/// <param name="event_box">
/// a #GtkEventBox
/// </param>
/// <param name="above_child">
/// %TRUE if the event box window is above its child
/// </param>

	public static T SetAboveChild<T>(this T event_box, bool above_child) where T : GtkEventBoxHandle
	{
		if (event_box.IsInvalid) throw new Exception("Invalid handle (GtkEventBoxHandle)");
		GtkEventBoxHandleExterns.gtk_event_box_set_above_child(event_box, above_child);
		return event_box;
	}

/// <summary>
/// <para>
/// Set whether the event box uses a visible or invisible child
/// window. The default is to use visible windows.
/// </para>
/// <para>
/// In an invisible window event box, the window that the
/// event box creates is a %GDK_INPUT_ONLY window, which
/// means that it is invisible and only serves to receive
/// events.
/// </para>
/// <para>
/// A visible window event box creates a visible (%GDK_INPUT_OUTPUT)
/// window that acts as the parent window for all the widgets
/// contained in the event box.
/// </para>
/// <para>
/// You should generally make your event box invisible if
/// you just want to trap events. Creating a visible window
/// may cause artifacts that are visible to the user, especially
/// if the user is using a theme with gradients or pixmaps.
/// </para>
/// <para>
/// The main reason to create a non input-only event box is if
/// you want to set the background to a different color or
/// draw on it.
/// </para>
/// <para>
/// There is one unexpected issue for an invisible event box that has its
/// window below the child. (See gtk_event_box_set_above_child().)
/// Since the input-only window is not an ancestor window of any windows
/// that descendent widgets of the event box create, events on these
/// windows aren’t propagated up by the windowing system, but only by GTK+.
/// The practical effect of this is if an event isn’t in the event
/// mask for the descendant window (see gtk_widget_add_events()),
/// it won’t be received by the event box.
/// </para>
/// <para>
/// This problem doesn’t occur for visible event boxes, because in
/// that case, the event box window is actually the ancestor of the
/// descendant windows, not just at the same place on the screen.
/// </para>
/// </summary>

/// <param name="event_box">
/// a #GtkEventBox
/// </param>
/// <param name="visible_window">
/// %TRUE to make the event box have a visible window
/// </param>

	public static T SetVisibleWindow<T>(this T event_box, bool visible_window) where T : GtkEventBoxHandle
	{
		if (event_box.IsInvalid) throw new Exception("Invalid handle (GtkEventBoxHandle)");
		GtkEventBoxHandleExterns.gtk_event_box_set_visible_window(event_box, visible_window);
		return event_box;
	}

}

internal class GtkEventBoxHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkEventBoxHandle>))]
	internal static extern MentorLake.Gtk.GtkEventBoxHandle gtk_event_box_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_event_box_get_above_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventBoxHandle>))] MentorLake.Gtk.GtkEventBoxHandle event_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_event_box_get_visible_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventBoxHandle>))] MentorLake.Gtk.GtkEventBoxHandle event_box);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_event_box_set_above_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventBoxHandle>))] MentorLake.Gtk.GtkEventBoxHandle event_box, bool above_child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_event_box_set_visible_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventBoxHandle>))] MentorLake.Gtk.GtkEventBoxHandle event_box, bool visible_window);

}
