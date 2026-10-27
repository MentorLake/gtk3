namespace MentorLake.WebKit2;


public class WebKitResponsePolicyDecisionClassHandle : BaseSafeHandle
{
}


public static class WebKitResponsePolicyDecisionClassExtensions
{

	public static WebKitResponsePolicyDecisionClass Dereference(this WebKitResponsePolicyDecisionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitResponsePolicyDecisionClass>(x.DangerousGetHandle());
}
internal class WebKitResponsePolicyDecisionClassExterns
{
}


public struct WebKitResponsePolicyDecisionClass
{
	
public WebKitPolicyDecisionClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
