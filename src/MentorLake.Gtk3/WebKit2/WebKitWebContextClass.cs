namespace MentorLake.WebKit2;


public class WebKitWebContextClassHandle : BaseSafeHandle
{
}


public static class WebKitWebContextClassExtensions
{

	public static WebKitWebContextClass Dereference(this WebKitWebContextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebContextClass>(x.DangerousGetHandle());
}
internal class WebKitWebContextClassExterns
{
}


public struct WebKitWebContextClass
{
	
public GObjectClass parent;
	
public IntPtr download_started;
	
public IntPtr initialize_web_extensions;
	
public IntPtr initialize_notification_permissions;
	
public IntPtr automation_started;
	
public IntPtr user_message_received;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
}
