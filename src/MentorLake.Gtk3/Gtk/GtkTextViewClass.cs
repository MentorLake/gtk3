namespace MentorLake.Gtk;


public class GtkTextViewClassHandle : BaseSafeHandle
{
}


public static class GtkTextViewClassExtensions
{

	public static GtkTextViewClass Dereference(this GtkTextViewClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkTextViewClass>(x.DangerousGetHandle());
}
internal class GtkTextViewClassExterns
{
}


public struct GtkTextViewClass
{
	/// <summary>
/// <para>
/// The object class structure needs to be the first
/// </para>
/// </summary>

public GtkContainerClass parent_class;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextView::populate-popup
///   signal.
/// </para>
/// </summary>

public IntPtr populate_popup;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextView::move-cursor
///   keybinding signal.
/// </para>
/// </summary>

public IntPtr move_cursor;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextView::set-anchor
///   keybinding signal.
/// </para>
/// </summary>

public IntPtr set_anchor;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextView::insert-at-cursor
///   keybinding signal.
/// </para>
/// </summary>

public IntPtr insert_at_cursor;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextView::delete-from-cursor
///   keybinding signal.
/// </para>
/// </summary>

public IntPtr delete_from_cursor;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextView::backspace
///   keybinding signal.
/// </para>
/// </summary>

public IntPtr backspace;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextView::cut-clipboard
///   keybinding signal
/// </para>
/// </summary>

public IntPtr cut_clipboard;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextview::copy-clipboard
///   keybinding signal.
/// </para>
/// </summary>

public IntPtr copy_clipboard;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextView::paste-clipboard
///   keybinding signal.
/// </para>
/// </summary>

public IntPtr paste_clipboard;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextView::toggle-overwrite
///   keybinding signal.
/// </para>
/// </summary>

public IntPtr toggle_overwrite;
	/// <summary>
/// <para>
/// The create_buffer vfunc is called to create a #GtkTextBuffer
///   for the text view. The default implementation is to just call
///   gtk_text_buffer_new(). Since: 3.10
/// </para>
/// </summary>

public IntPtr create_buffer;
	/// <summary>
/// <para>
/// The draw_layer vfunc is called before and after the text
///   view is drawing its own text. Applications can override this vfunc
///   in a subclass to draw customized content underneath or above the
///   text. In the %GTK_TEXT_VIEW_LAYER_BELOW_TEXT and %GTK_TEXT_VIEW_LAYER_ABOVE_TEXT
///   the drawing is done in the buffer coordinate space, but the older (deprecated)
///   layers %GTK_TEXT_VIEW_LAYER_BELOW and %GTK_TEXT_VIEW_LAYER_ABOVE work in viewport
///   coordinates, which makes them unnecessarily hard to use. Since: 3.14
/// </para>
/// </summary>

public IntPtr draw_layer;
	/// <summary>
/// <para>
/// The class handler for the #GtkTextView::extend-selection
///   signal. Since 3.16
/// </para>
/// </summary>

public IntPtr extend_selection;
	
public IntPtr insert_emoji;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
}
