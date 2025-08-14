namespace MentorLake.Gtk;


public class GtkIMContextClassHandle : BaseSafeHandle
{
}


public static class GtkIMContextClassExtensions
{

	public static GtkIMContextClass Dereference(this GtkIMContextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GtkIMContextClass>(x.DangerousGetHandle());
}
internal class GtkIMContextClassExterns
{
}


public struct GtkIMContextClass
{
	/// <summary>
/// <para>
/// Default handler of the #GtkIMContext::preedit-start signal.
/// </para>
/// </summary>

public IntPtr preedit_start;
	/// <summary>
/// <para>
/// Default handler of the #GtkIMContext::preedit-end signal.
/// </para>
/// </summary>

public IntPtr preedit_end;
	/// <summary>
/// <para>
/// Default handler of the #GtkIMContext::preedit-changed
///   signal.
/// </para>
/// </summary>

public IntPtr preedit_changed;
	/// <summary>
/// <para>
/// Default handler of the #GtkIMContext::commit signal.
/// </para>
/// </summary>

public IntPtr commit;
	/// <summary>
/// <para>
/// Default handler of the
///   #GtkIMContext::retrieve-surrounding signal.
/// </para>
/// </summary>

public IntPtr retrieve_surrounding;
	/// <summary>
/// <para>
/// Default handler of the
///   #GtkIMContext::delete-surrounding signal.
/// </para>
/// </summary>

public IntPtr delete_surrounding;
	/// <summary>
/// <para>
/// Called via gtk_im_context_set_client_window() when the
///   input window where the entered text will appear changes. Override this to
///   keep track of the current input window, for instance for the purpose of
///   positioning a status display of your input method.
/// </para>
/// </summary>

public IntPtr set_client_window;
	/// <summary>
/// <para>
/// Called via gtk_im_context_get_preedit_string() to
///   retrieve the text currently being preedited for display at the cursor
///   position. Any input method which composes complex characters or any
///   other compositions from multiple sequential key presses should override
///   this method to provide feedback.
/// </para>
/// </summary>

public IntPtr get_preedit_string;
	/// <summary>
/// <para>
/// Called via gtk_im_context_filter_keypress() on every
///   key press or release event. Every non-trivial input method needs to
///   override this in order to implement the mapping from key events to text.
///   A return value of %TRUE indicates to the caller that the event was
///   consumed by the input method. In that case, the #GtkIMContext::commit
///   signal should be emitted upon completion of a key sequence to pass the
///   resulting text back to the input widget. Alternatively, %FALSE may be
///   returned to indicate that the event wasn’t handled by the input method.
///   If a builtin mapping exists for the key, it is used to produce a
///   character.
/// </para>
/// </summary>

public IntPtr filter_keypress;
	/// <summary>
/// <para>
/// Called via gtk_im_context_focus_in() when the input widget
///   has gained focus. May be overridden to keep track of the current focus.
/// </para>
/// </summary>

public IntPtr focus_in;
	/// <summary>
/// <para>
/// Called via gtk_im_context_focus_out() when the input widget
///   has lost focus. May be overridden to keep track of the current focus.
/// </para>
/// </summary>

public IntPtr focus_out;
	/// <summary>
/// <para>
/// Called via gtk_im_context_reset() to signal a change such as a
///   change in cursor position. An input method that implements preediting
///   should override this method to clear the preedit state on reset.
/// </para>
/// </summary>

public IntPtr reset;
	/// <summary>
/// <para>
/// Called via gtk_im_context_set_cursor_location()
///   to inform the input method of the current cursor location relative to
///   the client window. May be overridden to implement the display of popup
///   windows at the cursor position.
/// </para>
/// </summary>

public IntPtr set_cursor_location;
	/// <summary>
/// <para>
/// Called via gtk_im_context_set_use_preedit() to control
///   the use of the preedit string. Override this to display feedback by some
///   other means if turned off.
/// </para>
/// </summary>

public IntPtr set_use_preedit;
	/// <summary>
/// <para>
/// Called via gtk_im_context_set_surrounding() in response
///   to signal #GtkIMContext::retrieve-surrounding to update the input
///   method’s idea of the context around the cursor. It is not necessary to
///   override this method even with input methods which implement
///   context-dependent behavior. The base implementation is sufficient for
///   gtk_im_context_get_surrounding() to work.
/// </para>
/// </summary>

public IntPtr set_surrounding;
	/// <summary>
/// <para>
/// Called via gtk_im_context_get_surrounding() to update
///   the context around the cursor location. It is not necessary to override
///   this method even with input methods which implement context-dependent
///   behavior. The base implementation emits
///   #GtkIMContext::retrieve-surrounding and records the context received
///   by the subsequent invocation of @get_surrounding.
/// </para>
/// </summary>

public IntPtr get_surrounding;
	
public IntPtr _gtk_reserved1;
	
public IntPtr _gtk_reserved2;
	
public IntPtr _gtk_reserved3;
	
public IntPtr _gtk_reserved4;
	
public IntPtr _gtk_reserved5;
	
public IntPtr _gtk_reserved6;
}
