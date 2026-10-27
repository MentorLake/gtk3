namespace MentorLake.WebKit2;


public class WebKitCookieManagerClassHandle : BaseSafeHandle
{
}


public static class WebKitCookieManagerClassExtensions
{

	public static WebKitCookieManagerClass Dereference(this WebKitCookieManagerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitCookieManagerClass>(x.DangerousGetHandle());
}
internal class WebKitCookieManagerClassExterns
{
}


public struct WebKitCookieManagerClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
