namespace MentorLake.WebKit2;


public class WebKitResponsePolicyDecisionPrivateHandle : BaseSafeHandle
{
}


public static class WebKitResponsePolicyDecisionPrivateExtensions
{

	public static WebKitResponsePolicyDecisionPrivate Dereference(this WebKitResponsePolicyDecisionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitResponsePolicyDecisionPrivate>(x.DangerousGetHandle());
}
internal class WebKitResponsePolicyDecisionPrivateExterns
{
}


public struct WebKitResponsePolicyDecisionPrivate
{
}
