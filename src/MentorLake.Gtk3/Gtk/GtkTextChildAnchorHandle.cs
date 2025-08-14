namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkTextChildAnchor is a spot in the buffer where child widgets can
/// be “anchored” (inserted inline, as if they were characters). The anchor
/// can have multiple widgets anchored, to allow for multiple views.
/// </para>
/// </summary>

public class GtkTextChildAnchorHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkTextChildAnchor. Usually you would then insert
/// it into a #GtkTextBuffer with gtk_text_buffer_insert_child_anchor().
/// To perform the creation and insertion in one step, use the
/// convenience function gtk_text_buffer_create_child_anchor().
/// </para>
/// </summary>

/// <return>
/// a new #GtkTextChildAnchor
/// </return>

	public static MentorLake.Gtk.GtkTextChildAnchorHandle New()
	{
		return GtkTextChildAnchorHandleExterns.gtk_text_child_anchor_new();
	}

}

public static class GtkTextChildAnchorHandleExtensions
{
/// <summary>
/// <para>
/// Determines whether a child anchor has been deleted from
/// the buffer. Keep in mind that the child anchor will be
/// unreferenced when removed from the buffer, so you need to
/// hold your own reference (with g_object_ref()) if you plan
/// to use this function — otherwise all deleted child anchors
/// will also be finalized.
/// </para>
/// </summary>

/// <param name="anchor">
/// a #GtkTextChildAnchor
/// </param>
/// <return>
/// %TRUE if the child anchor has been deleted from its buffer
/// </return>

	public static bool GetDeleted(this MentorLake.Gtk.GtkTextChildAnchorHandle anchor)
	{
		if (anchor.IsInvalid) throw new Exception("Invalid handle (GtkTextChildAnchorHandle)");
		return GtkTextChildAnchorHandleExterns.gtk_text_child_anchor_get_deleted(anchor);
	}

/// <summary>
/// <para>
/// Gets a list of all widgets anchored at this child anchor.
/// The returned list should be freed with g_list_free().
/// </para>
/// </summary>

/// <param name="anchor">
/// a #GtkTextChildAnchor
/// </param>
/// <return>
/// list of widgets anchored at @anchor
/// </return>

	public static MentorLake.GLib.GListHandle GetWidgets(this MentorLake.Gtk.GtkTextChildAnchorHandle anchor)
	{
		if (anchor.IsInvalid) throw new Exception("Invalid handle (GtkTextChildAnchorHandle)");
		return GtkTextChildAnchorHandleExterns.gtk_text_child_anchor_get_widgets(anchor);
	}

}

internal class GtkTextChildAnchorHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTextChildAnchorHandle>))]
	internal static extern MentorLake.Gtk.GtkTextChildAnchorHandle gtk_text_child_anchor_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_child_anchor_get_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextChildAnchorHandle>))] MentorLake.Gtk.GtkTextChildAnchorHandle anchor);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle gtk_text_child_anchor_get_widgets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextChildAnchorHandle>))] MentorLake.Gtk.GtkTextChildAnchorHandle anchor);

}
