namespace MentorLake.WebKit2;


public class WebKitWebsitePoliciesClassHandle : BaseSafeHandle
{
}


public static class WebKitWebsitePoliciesClassExtensions
{

	public static WebKitWebsitePoliciesClass Dereference(this WebKitWebsitePoliciesClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebsitePoliciesClass>(x.DangerousGetHandle());
}
internal class WebKitWebsitePoliciesClassExterns
{
}


public struct WebKitWebsitePoliciesClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
