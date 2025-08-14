namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Class structure for #GtkEntry. All virtual functions have a default
/// implementation. Derived classes may set the virtual function pointers for the
/// signal handlers to %NULL, but must keep @get_text_area_size and
/// @get_frame_size non-%NULL; either use the default implementation, or provide
/// a custom one.
/// </para>
/// </summary>

public class GtkEntryClassHandle : BaseSafeHandle
{
}


public static class GtkEntryClassExtensions
{

	public static GtkEntryClass Dereference(this GtkEntryClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkEntryClass>(x.DangerousGetHandle());
}
internal class GtkEntryClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for #GtkEntry. All virtual functions have a default
/// implementation. Derived classes may set the virtual function pointers for the
/// signal handlers to %NULL, but must keep @get_text_area_size and
/// @get_frame_size non-%NULL; either use the default implementation, or provide
/// a custom one.
/// </para>
/// </summary>

public struct GtkEntryClass
{
	/// <summary>
/// <para>
/// The parent class.
/// </para>
/// </summary>

public GtkWidgetClass parent_class;
	/// <summary>
/// <para>
/// Class handler for the #GtkEntry::populate-popup signal. If
///   non-%NULL, this will be called to add additional entries to the context
///   menu when it is displayed.
/// </para>
/// </summary>

public IntPtr populate_popup;
	/// <summary>
/// <para>
/// Class handler for the #GtkEntry::activate signal. The default
///   implementation calls gtk_window_activate_default() on the entry’s top-level
///   window.
/// </para>
/// </summary>

public IntPtr activate;
	/// <summary>
/// <para>
/// Class handler for the #GtkEntry::move-cursor signal. The
///   default implementation specifies the standard #GtkEntry cursor movement
///   behavior.
/// </para>
/// </summary>

public IntPtr move_cursor;
	/// <summary>
/// <para>
/// Class handler for the #GtkEntry::insert-at-cursor signal.
///   The default implementation inserts text at the cursor.
/// </para>
/// </summary>

public IntPtr insert_at_cursor;
	/// <summary>
/// <para>
/// Class handler for the #GtkEntry::delete-from-cursor
///   signal. The default implementation deletes the selection or the specified
///   number of characters or words.
/// </para>
/// </summary>

public IntPtr delete_from_cursor;
	/// <summary>
/// <para>
/// Class handler for the #GtkEntry::backspace signal. The default
///   implementation deletes the selection or a single character or word.
/// </para>
/// </summary>

public IntPtr backspace;
	/// <summary>
/// <para>
/// Class handler for the #GtkEntry::cut-clipboard signal. The
///   default implementation cuts the selection, if one exists.
/// </para>
/// </summary>

public IntPtr cut_clipboard;
	/// <summary>
/// <para>
/// Class handler for the #GtkEntry::copy-clipboard signal. The
///   default implementation copies the selection, if one exists.
/// </para>
/// </summary>

public IntPtr copy_clipboard;
	/// <summary>
/// <para>
/// Class handler for the #GtkEntry::paste-clipboard signal.
///   The default implementation pastes at the current cursor position or over
///   the current selection if one exists.
/// </para>
/// </summary>

public IntPtr paste_clipboard;
	/// <summary>
/// <para>
/// Class handler for the #GtkEntry::toggle-overwrite signal.
///   The default implementation toggles overwrite mode and blinks the cursor.
/// </para>
/// </summary>

public IntPtr toggle_overwrite;
	/// <summary>
/// <para>
/// Calculate the size of the text area, which is its
///   allocated width and requested height, minus space for margins and borders.
///   This virtual function must be non-%NULL.
/// </para>
/// </summary>

public IntPtr get_text_area_size;
	/// <summary>
/// <para>
/// Calculate the size of the text area frame, which is its
///   allocated width and requested height, minus space for margins and borders,
///   and taking baseline and text height into account. This virtual function
///   must be non-%NULL.
/// </para>
/// </summary>

public IntPtr get_frame_size;
	
public IntPtr insert_emoji;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
	
public IntPtr _gtk_reserved5;
	
public IntPtr _gtk_reserved6;
}
