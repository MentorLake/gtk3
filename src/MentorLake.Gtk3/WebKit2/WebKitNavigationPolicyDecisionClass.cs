namespace MentorLake.WebKit2;


public class WebKitNavigationPolicyDecisionClassHandle : BaseSafeHandle
{
}


public static class WebKitNavigationPolicyDecisionClassExtensions
{

	public static WebKitNavigationPolicyDecisionClass Dereference(this WebKitNavigationPolicyDecisionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitNavigationPolicyDecisionClass>(x.DangerousGetHandle());
}
internal class WebKitNavigationPolicyDecisionClassExterns
{
}


public struct WebKitNavigationPolicyDecisionClass
{
	
public WebKitPolicyDecisionClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
