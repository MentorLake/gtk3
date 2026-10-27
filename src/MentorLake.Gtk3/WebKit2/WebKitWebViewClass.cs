namespace MentorLake.WebKit2;


public class WebKitWebViewClassHandle : BaseSafeHandle
{
}


public static class WebKitWebViewClassExtensions
{

	public static WebKitWebViewClass Dereference(this WebKitWebViewClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebViewClass>(x.DangerousGetHandle());
}
internal class WebKitWebViewClassExterns
{
}


public struct WebKitWebViewClass
{
	
public WebKitWebViewBaseClass parent;
	
public IntPtr load_changed;
	
public IntPtr load_failed;
	
public IntPtr create;
	
public IntPtr ready_to_show;
	
public IntPtr run_as_modal;
	
public IntPtr close;
	
public IntPtr script_dialog;
	
public IntPtr decide_policy;
	
public IntPtr permission_request;
	
public IntPtr mouse_target_changed;
	
public IntPtr print;
	
public IntPtr resource_load_started;
	
public IntPtr enter_fullscreen;
	
public IntPtr leave_fullscreen;
	
public IntPtr run_file_chooser;
	
public IntPtr context_menu;
	
public IntPtr context_menu_dismissed;
	
public IntPtr submit_form;
	
public IntPtr insecure_content_detected;
	
public IntPtr web_process_crashed;
	
public IntPtr authenticate;
	
public IntPtr load_failed_with_tls_errors;
	
public IntPtr show_notification;
	
public IntPtr run_color_chooser;
	
public IntPtr show_option_menu;
	
public IntPtr web_process_terminated;
	
public IntPtr user_message_received;
	
public IntPtr query_permission_state;
}
