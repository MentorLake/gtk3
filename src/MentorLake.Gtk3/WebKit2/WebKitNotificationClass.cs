namespace MentorLake.WebKit2;


public class WebKitNotificationClassHandle : BaseSafeHandle
{
}


public static class WebKitNotificationClassExtensions
{

	public static WebKitNotificationClass Dereference(this WebKitNotificationClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitNotificationClass>(x.DangerousGetHandle());
}
internal class WebKitNotificationClassExterns
{
}


public struct WebKitNotificationClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
	
public IntPtr _webkit_reserved4;
	
public IntPtr _webkit_reserved5;
}
