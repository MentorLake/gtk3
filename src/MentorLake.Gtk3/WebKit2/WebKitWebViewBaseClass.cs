namespace MentorLake.WebKit2;


public class WebKitWebViewBaseClassHandle : BaseSafeHandle
{
}


public static class WebKitWebViewBaseClassExtensions
{

	public static WebKitWebViewBaseClass Dereference(this WebKitWebViewBaseClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebViewBaseClass>(x.DangerousGetHandle());
}
internal class WebKitWebViewBaseClassExterns
{
}


public struct WebKitWebViewBaseClass
{
	
public GtkContainerClass parentClass;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
