namespace MentorLake.WebKit2;


public class WebKitAuthenticationRequestClassHandle : BaseSafeHandle
{
}


public static class WebKitAuthenticationRequestClassExtensions
{

	public static WebKitAuthenticationRequestClass Dereference(this WebKitAuthenticationRequestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitAuthenticationRequestClass>(x.DangerousGetHandle());
}
internal class WebKitAuthenticationRequestClassExterns
{
}


public struct WebKitAuthenticationRequestClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
