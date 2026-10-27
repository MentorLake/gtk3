namespace MentorLake.WebKit2;


public class WebKitPolicyDecisionClassHandle : BaseSafeHandle
{
}


public static class WebKitPolicyDecisionClassExtensions
{

	public static WebKitPolicyDecisionClass Dereference(this WebKitPolicyDecisionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitPolicyDecisionClass>(x.DangerousGetHandle());
}
internal class WebKitPolicyDecisionClassExterns
{
}


public struct WebKitPolicyDecisionClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
