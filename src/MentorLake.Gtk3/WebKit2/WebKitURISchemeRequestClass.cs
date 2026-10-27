namespace MentorLake.WebKit2;


public class WebKitURISchemeRequestClassHandle : BaseSafeHandle
{
}


public static class WebKitURISchemeRequestClassExtensions
{

	public static WebKitURISchemeRequestClass Dereference(this WebKitURISchemeRequestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitURISchemeRequestClass>(x.DangerousGetHandle());
}
internal class WebKitURISchemeRequestClassExterns
{
}


public struct WebKitURISchemeRequestClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
