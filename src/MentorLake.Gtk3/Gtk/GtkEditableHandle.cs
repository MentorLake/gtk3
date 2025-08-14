namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkEditable interface is an interface which should be implemented by
/// text editing widgets, such as #GtkEntry and #GtkSpinButton. It contains functions
/// for generically manipulating an editable widget, a large number of action
/// signals used for key bindings, and several signals that an application can
/// connect to to modify the behavior of a widget.
/// </para>
/// <para>
/// As an example of the latter usage, by connecting
/// the following handler to #GtkEditable::insert-text, an application
/// can convert all entry into a widget into uppercase.
/// </para>
/// <para>
/// ## Forcing entry to uppercase.
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// #include <ctype.h>;
/// </para>
/// <para>
/// void
/// insert_text_handler (GtkEditable *editable,
///                      const gchar *text,
///                      gint         length,
///                      gint        *position,
///                      gpointer     data)
/// {
///   gchar *result = g_utf8_strup (text, length);
/// </para>
/// <para>
///   g_signal_handlers_block_by_func (editable,
///                                (gpointer) insert_text_handler, data);
///   gtk_editable_insert_text (editable, result, length, position);
///   g_signal_handlers_unblock_by_func (editable,
///                                      (gpointer) insert_text_handler, data);
/// </para>
/// <para>
///   g_signal_stop_emission_by_name (editable, "insert_text");
/// </para>
/// <para>
///   g_free (result);
/// }
/// ]|
/// </para>
/// </summary>

public interface GtkEditableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GtkEditableHandleImpl : BaseSafeHandle, GtkEditableHandle
{
}

public static class GtkEditableHandleExtensions
{
/// <summary>
/// <para>
/// Copies the contents of the currently selected content in the editable and
/// puts it on the clipboard.
/// </para>
/// </summary>

/// <param name="editable">
/// a #GtkEditable
/// </param>

	public static T CopyClipboard<T>(this T editable) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_copy_clipboard(editable);
		return editable;
	}

/// <summary>
/// <para>
/// Removes the contents of the currently selected content in the editable and
/// puts it on the clipboard.
/// </para>
/// </summary>

/// <param name="editable">
/// a #GtkEditable
/// </param>

	public static T CutClipboard<T>(this T editable) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_cut_clipboard(editable);
		return editable;
	}

/// <summary>
/// <para>
/// Deletes the currently selected text of the editable.
/// This call doesn’t do anything if there is no selected text.
/// </para>
/// </summary>

/// <param name="editable">
/// a #GtkEditable
/// </param>

	public static T DeleteSelection<T>(this T editable) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_delete_selection(editable);
		return editable;
	}

/// <summary>
/// <para>
/// Deletes a sequence of characters. The characters that are deleted are
/// those characters at positions from @start_pos up to, but not including
/// @end_pos. If @end_pos is negative, then the characters deleted
/// are those from @start_pos to the end of the text.
/// </para>
/// <para>
/// Note that the positions are specified in characters, not bytes.
/// </para>
/// </summary>

/// <param name="editable">
/// a #GtkEditable
/// </param>
/// <param name="start_pos">
/// start position
/// </param>
/// <param name="end_pos">
/// end position
/// </param>

	public static T DeleteText<T>(this T editable, int start_pos, int end_pos) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_delete_text(editable, start_pos, end_pos);
		return editable;
	}

/// <summary>
/// <para>
/// Retrieves a sequence of characters. The characters that are retrieved
/// are those characters at positions from @start_pos up to, but not
/// including @end_pos. If @end_pos is negative, then the characters
/// retrieved are those characters from @start_pos to the end of the text.
/// </para>
/// <para>
/// Note that positions are specified in characters, not bytes.
/// </para>
/// </summary>

/// <param name="editable">
/// a #GtkEditable
/// </param>
/// <param name="start_pos">
/// start of text
/// </param>
/// <param name="end_pos">
/// end of text
/// </param>
/// <return>
/// a pointer to the contents of the widget as a
///      string. This string is allocated by the #GtkEditable
///      implementation and should be freed by the caller.
/// </return>

	public static string GetChars(this MentorLake.Gtk.GtkEditableHandle editable, int start_pos, int end_pos)
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		return GtkEditableHandleExterns.gtk_editable_get_chars(editable, start_pos, end_pos);
	}

/// <summary>
/// <para>
/// Retrieves whether @editable is editable. See
/// gtk_editable_set_editable().
/// </para>
/// </summary>

/// <param name="editable">
/// a #GtkEditable
/// </param>
/// <return>
/// %TRUE if @editable is editable.
/// </return>

	public static bool GetEditable(this MentorLake.Gtk.GtkEditableHandle editable)
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		return GtkEditableHandleExterns.gtk_editable_get_editable(editable);
	}

/// <summary>
/// <para>
/// Retrieves the current position of the cursor relative to the start
/// of the content of the editable.
/// </para>
/// <para>
/// Note that this position is in characters, not in bytes.
/// </para>
/// </summary>

/// <param name="editable">
/// a #GtkEditable
/// </param>
/// <return>
/// the cursor position
/// </return>

	public static int GetPosition(this MentorLake.Gtk.GtkEditableHandle editable)
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		return GtkEditableHandleExterns.gtk_editable_get_position(editable);
	}

/// <summary>
/// <para>
/// Retrieves the selection bound of the editable. start_pos will be filled
/// with the start of the selection and @end_pos with end. If no text was
/// selected both will be identical and %FALSE will be returned.
/// </para>
/// <para>
/// Note that positions are specified in characters, not bytes.
/// </para>
/// </summary>

/// <param name="editable">
/// a #GtkEditable
/// </param>
/// <param name="start_pos">
/// location to store the starting position, or %NULL
/// </param>
/// <param name="end_pos">
/// location to store the end position, or %NULL
/// </param>
/// <return>
/// %TRUE if an area is selected, %FALSE otherwise
/// </return>

	public static bool GetSelectionBounds(this MentorLake.Gtk.GtkEditableHandle editable, out int start_pos, out int end_pos)
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		return GtkEditableHandleExterns.gtk_editable_get_selection_bounds(editable, out start_pos, out end_pos);
	}

/// <summary>
/// <para>
/// Inserts @new_text_length bytes of @new_text into the contents of the
/// widget, at position @position.
/// </para>
/// <para>
/// Note that the position is in characters, not in bytes.
/// The function updates @position to point after the newly inserted text.
/// </para>
/// </summary>

/// <param name="editable">
/// a #GtkEditable
/// </param>
/// <param name="new_text">
/// the text to append
/// </param>
/// <param name="new_text_length">
/// the length of the text in bytes, or -1
/// </param>
/// <param name="position">
/// location of the position text will be inserted at
/// </param>

	public static T InsertText<T>(this T editable, string new_text, int new_text_length, ref int position) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_insert_text(editable, new_text, new_text_length, ref position);
		return editable;
	}

/// <summary>
/// <para>
/// Pastes the content of the clipboard to the current position of the
/// cursor in the editable.
/// </para>
/// </summary>

/// <param name="editable">
/// a #GtkEditable
/// </param>

	public static T PasteClipboard<T>(this T editable) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_paste_clipboard(editable);
		return editable;
	}

/// <summary>
/// <para>
/// Selects a region of text. The characters that are selected are
/// those characters at positions from @start_pos up to, but not
/// including @end_pos. If @end_pos is negative, then the
/// characters selected are those characters from @start_pos to
/// the end of the text.
/// </para>
/// <para>
/// Note that positions are specified in characters, not bytes.
/// </para>
/// </summary>

/// <param name="editable">
/// a #GtkEditable
/// </param>
/// <param name="start_pos">
/// start of region
/// </param>
/// <param name="end_pos">
/// end of region
/// </param>

	public static T SelectRegion<T>(this T editable, int start_pos, int end_pos) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_select_region(editable, start_pos, end_pos);
		return editable;
	}

/// <summary>
/// <para>
/// Determines if the user can edit the text in the editable
/// widget or not.
/// </para>
/// </summary>

/// <param name="editable">
/// a #GtkEditable
/// </param>
/// <param name="is_editable">
/// %TRUE if the user is allowed to edit the text
///   in the widget
/// </param>

	public static T SetEditable<T>(this T editable, bool is_editable) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_set_editable(editable, is_editable);
		return editable;
	}

/// <summary>
/// <para>
/// Sets the cursor position in the editable to the given value.
/// </para>
/// <para>
/// The cursor is displayed before the character with the given (base 0)
/// index in the contents of the editable. The value must be less than or
/// equal to the number of characters in the editable. A value of -1
/// indicates that the position should be set after the last character
/// of the editable. Note that @position is in characters, not in bytes.
/// </para>
/// </summary>

/// <param name="editable">
/// a #GtkEditable
/// </param>
/// <param name="position">
/// the position of the cursor
/// </param>

	public static T SetPosition<T>(this T editable, int position) where T : GtkEditableHandle
	{
		if (editable.IsInvalid) throw new Exception("Invalid handle (GtkEditableHandle)");
		GtkEditableHandleExterns.gtk_editable_set_position(editable, position);
		return editable;
	}

}

internal class GtkEditableHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_copy_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_cut_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_delete_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_delete_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable, int start_pos, int end_pos);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_editable_get_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable, int start_pos, int end_pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_editable_get_editable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_editable_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_editable_get_selection_bounds([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable, out int start_pos, out int end_pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_insert_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable, string new_text, int new_text_length, ref int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_paste_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_select_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable, int start_pos, int end_pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_set_editable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable, bool is_editable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_editable_set_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEditableHandleImpl>))] MentorLake.Gtk.GtkEditableHandle editable, int position);

}
