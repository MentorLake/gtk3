namespace MentorLake.WebKit2;


public class WebKitPolicyDecisionPrivateHandle : BaseSafeHandle
{
}


public static class WebKitPolicyDecisionPrivateExtensions
{

	public static WebKitPolicyDecisionPrivate Dereference(this WebKitPolicyDecisionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitPolicyDecisionPrivate>(x.DangerousGetHandle());
}
internal class WebKitPolicyDecisionPrivateExterns
{
}


public struct WebKitPolicyDecisionPrivate
{
}
