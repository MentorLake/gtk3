namespace MentorLake.WebKit2;


public class WebKitWebsitePoliciesPrivateHandle : BaseSafeHandle
{
}


public static class WebKitWebsitePoliciesPrivateExtensions
{

	public static WebKitWebsitePoliciesPrivate Dereference(this WebKitWebsitePoliciesPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebsitePoliciesPrivate>(x.DangerousGetHandle());
}
internal class WebKitWebsitePoliciesPrivateExterns
{
}


public struct WebKitWebsitePoliciesPrivate
{
}
