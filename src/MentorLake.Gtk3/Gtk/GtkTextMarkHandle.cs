namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// You may wish to begin by reading the
/// [text widget conceptual overview](TextWidget.html)
/// which gives an overview of all the objects and data
/// types related to the text widget and how they work together.
/// </para>
/// <para>
/// A #GtkTextMark is like a bookmark in a text buffer; it preserves a position in
/// the text. You can convert the mark to an iterator using
/// gtk_text_buffer_get_iter_at_mark(). Unlike iterators, marks remain valid across
/// buffer mutations, because their behavior is defined when text is inserted or
/// deleted. When text containing a mark is deleted, the mark remains in the
/// position originally occupied by the deleted text. When text is inserted at a
/// mark, a mark with “left gravity” will be moved to the
/// beginning of the newly-inserted text, and a mark with “right
/// gravity” will be moved to the end.
/// </para>
/// <para>
/// Note that “left” and “right” here refer to logical direction (left
/// is the toward the start of the buffer); in some languages such as
/// Hebrew the logically-leftmost text is not actually on the left when
/// displayed.
/// </para>
/// <para>
/// Marks are reference counted, but the reference count only controls the validity
/// of the memory; marks can be deleted from the buffer at any time with
/// gtk_text_buffer_delete_mark(). Once deleted from the buffer, a mark is
/// essentially useless.
/// </para>
/// <para>
/// Marks optionally have names; these can be convenient to avoid passing the
/// #GtkTextMark object around.
/// </para>
/// <para>
/// Marks are typically created using the gtk_text_buffer_create_mark() function.
/// </para>
/// </summary>

public class GtkTextMarkHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a text mark. Add it to a buffer using gtk_text_buffer_add_mark().
/// If @name is %NULL, the mark is anonymous; otherwise, the mark can be
/// retrieved by name using gtk_text_buffer_get_mark(). If a mark has left
/// gravity, and text is inserted at the mark’s current location, the mark
/// will be moved to the left of the newly-inserted text. If the mark has
/// right gravity (@left_gravity = %FALSE), the mark will end up on the
/// right of newly-inserted text. The standard left-to-right cursor is a
/// mark with right gravity (when you type, the cursor stays on the right
/// side of the text you’re typing).
/// </para>
/// </summary>

/// <param name="name">
/// mark name or %NULL
/// </param>
/// <param name="left_gravity">
/// whether the mark should have left gravity
/// </param>
/// <return>
/// new #GtkTextMark
/// </return>

	public static MentorLake.Gtk.GtkTextMarkHandle New(string name, bool left_gravity)
	{
		return GtkTextMarkHandleExterns.gtk_text_mark_new(name, left_gravity);
	}

}

public static class GtkTextMarkHandleExtensions
{
/// <summary>
/// <para>
/// Gets the buffer this mark is located inside,
/// or %NULL if the mark is deleted.
/// </para>
/// </summary>

/// <param name="mark">
/// a #GtkTextMark
/// </param>
/// <return>
/// the mark’s #GtkTextBuffer
/// </return>

	public static MentorLake.Gtk.GtkTextBufferHandle GetBuffer(this MentorLake.Gtk.GtkTextMarkHandle mark)
	{
		if (mark.IsInvalid) throw new Exception("Invalid handle (GtkTextMarkHandle)");
		return GtkTextMarkHandleExterns.gtk_text_mark_get_buffer(mark);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the mark has been removed from its buffer
/// with gtk_text_buffer_delete_mark(). See gtk_text_buffer_add_mark()
/// for a way to add it to a buffer again.
/// </para>
/// </summary>

/// <param name="mark">
/// a #GtkTextMark
/// </param>
/// <return>
/// whether the mark is deleted
/// </return>

	public static bool GetDeleted(this MentorLake.Gtk.GtkTextMarkHandle mark)
	{
		if (mark.IsInvalid) throw new Exception("Invalid handle (GtkTextMarkHandle)");
		return GtkTextMarkHandleExterns.gtk_text_mark_get_deleted(mark);
	}

/// <summary>
/// <para>
/// Determines whether the mark has left gravity.
/// </para>
/// </summary>

/// <param name="mark">
/// a #GtkTextMark
/// </param>
/// <return>
/// %TRUE if the mark has left gravity, %FALSE otherwise
/// </return>

	public static bool GetLeftGravity(this MentorLake.Gtk.GtkTextMarkHandle mark)
	{
		if (mark.IsInvalid) throw new Exception("Invalid handle (GtkTextMarkHandle)");
		return GtkTextMarkHandleExterns.gtk_text_mark_get_left_gravity(mark);
	}

/// <summary>
/// <para>
/// Returns the mark name; returns NULL for anonymous marks.
/// </para>
/// </summary>

/// <param name="mark">
/// a #GtkTextMark
/// </param>
/// <return>
/// mark name
/// </return>

	public static string GetName(this MentorLake.Gtk.GtkTextMarkHandle mark)
	{
		if (mark.IsInvalid) throw new Exception("Invalid handle (GtkTextMarkHandle)");
		return GtkTextMarkHandleExterns.gtk_text_mark_get_name(mark);
	}

/// <summary>
/// <para>
/// Returns %TRUE if the mark is visible (i.e. a cursor is displayed
/// for it).
/// </para>
/// </summary>

/// <param name="mark">
/// a #GtkTextMark
/// </param>
/// <return>
/// %TRUE if visible
/// </return>

	public static bool GetVisible(this MentorLake.Gtk.GtkTextMarkHandle mark)
	{
		if (mark.IsInvalid) throw new Exception("Invalid handle (GtkTextMarkHandle)");
		return GtkTextMarkHandleExterns.gtk_text_mark_get_visible(mark);
	}

/// <summary>
/// <para>
/// Sets the visibility of @mark; the insertion point is normally
/// visible, i.e. you can see it as a vertical bar. Also, the text
/// widget uses a visible mark to indicate where a drop will occur when
/// dragging-and-dropping text. Most other marks are not visible.
/// Marks are not visible by default.
/// </para>
/// </summary>

/// <param name="mark">
/// a #GtkTextMark
/// </param>
/// <param name="setting">
/// visibility of mark
/// </param>

	public static T SetVisible<T>(this T mark, bool setting) where T : GtkTextMarkHandle
	{
		if (mark.IsInvalid) throw new Exception("Invalid handle (GtkTextMarkHandle)");
		GtkTextMarkHandleExterns.gtk_text_mark_set_visible(mark, setting);
		return mark;
	}

}

internal class GtkTextMarkHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))]
	internal static extern MentorLake.Gtk.GtkTextMarkHandle gtk_text_mark_new(string name, bool left_gravity);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))]
	internal static extern MentorLake.Gtk.GtkTextBufferHandle gtk_text_mark_get_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_mark_get_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_mark_get_left_gravity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_text_mark_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_mark_get_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_mark_set_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark, bool setting);

}
