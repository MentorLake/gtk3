namespace MentorLake.WebKit2;


public class WebKitNavigationPolicyDecisionPrivateHandle : BaseSafeHandle
{
}


public static class WebKitNavigationPolicyDecisionPrivateExtensions
{

	public static WebKitNavigationPolicyDecisionPrivate Dereference(this WebKitNavigationPolicyDecisionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitNavigationPolicyDecisionPrivate>(x.DangerousGetHandle());
}
internal class WebKitNavigationPolicyDecisionPrivateExterns
{
}


public struct WebKitNavigationPolicyDecisionPrivate
{
}
