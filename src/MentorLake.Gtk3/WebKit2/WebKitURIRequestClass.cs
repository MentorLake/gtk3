namespace MentorLake.WebKit2;


public class WebKitURIRequestClassHandle : BaseSafeHandle
{
}


public static class WebKitURIRequestClassExtensions
{

	public static WebKitURIRequestClass Dereference(this WebKitURIRequestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitURIRequestClass>(x.DangerousGetHandle());
}
internal class WebKitURIRequestClassExterns
{
}


public struct WebKitURIRequestClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
