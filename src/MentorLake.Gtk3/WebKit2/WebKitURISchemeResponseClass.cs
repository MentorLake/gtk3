namespace MentorLake.WebKit2;


public class WebKitURISchemeResponseClassHandle : BaseSafeHandle
{
}


public static class WebKitURISchemeResponseClassExtensions
{

	public static WebKitURISchemeResponseClass Dereference(this WebKitURISchemeResponseClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitURISchemeResponseClass>(x.DangerousGetHandle());
}
internal class WebKitURISchemeResponseClassExterns
{
}


public struct WebKitURISchemeResponseClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
