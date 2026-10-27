namespace MentorLake.WebKit2;


public class WebKitInputMethodContextClassHandle : BaseSafeHandle
{
}


public static class WebKitInputMethodContextClassExtensions
{

	public static WebKitInputMethodContextClass Dereference(this WebKitInputMethodContextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitInputMethodContextClass>(x.DangerousGetHandle());
}
internal class WebKitInputMethodContextClassExterns
{
}


public struct WebKitInputMethodContextClass
{
	
public GObjectClass parent_class;
	
public IntPtr preedit_started;
	
public IntPtr preedit_changed;
	
public IntPtr preedit_finished;
	
public IntPtr committed;
	
public IntPtr delete_surrounding;
	/// <summary>
/// <para>
/// Called via webkit_input_method_context_set_enable_preedit() to
///   control the use of the preedit string.
/// </para>
/// </summary>

public IntPtr set_enable_preedit;
	/// <summary>
/// <para>
/// Called via webkit_input_method_context_get_preedit() to
///   retrieve the text currently being preedited for display at the cursor
///   position. Any input method which composes complex characters or any
///   other compositions from multiple sequential key presses should override
///   this method to provide feedback.
/// </para>
/// </summary>

public IntPtr get_preedit;
	/// <summary>
/// <para>
/// Called via webkit_input_method_context_filter_key_event() on every
///   key press or release event. Every non-trivial input method needs to
///   override this in order to implement the mapping from key events to text.
///   A return value of %TRUE indicates to the caller that the event was
///   consumed by the input method. In that case, the #WebKitInputMethodContext::committed
///   signal should be emitted upon completion of a key sequence to pass the
///   resulting text back to the editable element. Alternatively, %FALSE may be
///   returned to indicate that the event wasn’t handled by the input method.
/// </para>
/// </summary>

public IntPtr filter_key_event;
	/// <summary>
/// <para>
/// Called via webkit_input_method_context_notify_focus_in() when
///   an editable element of the #WebKitWebView has gained focus.
/// </para>
/// </summary>

public IntPtr notify_focus_in;
	/// <summary>
/// <para>
/// Called via webkit_input_method_context_notify_focus_out() when
///   an editable element of the #WebKitWebView has lost focus.
/// </para>
/// </summary>

public IntPtr notify_focus_out;
	/// <summary>
/// <para>
/// Called via webkit_input_method_context_notify_cursor_area()
///   to inform the input method of the current cursor location relative to
///   the client window.
/// </para>
/// </summary>

public IntPtr notify_cursor_area;
	/// <summary>
/// <para>
/// Called via webkit_input_method_context_notify_surrounding() to
///   update the context surrounding the cursor. The provided text should not include
///   the preedit string.
/// </para>
/// </summary>

public IntPtr notify_surrounding;
	/// <summary>
/// <para>
/// Called via webkit_input_method_context_reset() to signal a change that
///   requires a reset. An input method that implements preediting
///   should override this method to clear the preedit state on reset.
/// </para>
/// </summary>

public IntPtr reset;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
	
public IntPtr _webkit_reserved4;
	
public IntPtr _webkit_reserved5;
	
public IntPtr _webkit_reserved6;
	
public IntPtr _webkit_reserved7;
}
