namespace MentorLake.WebKit2;


public class WebKitWebViewPrivateHandle : BaseSafeHandle
{
}


public static class WebKitWebViewPrivateExtensions
{

	public static WebKitWebViewPrivate Dereference(this WebKitWebViewPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebViewPrivate>(x.DangerousGetHandle());
}
internal class WebKitWebViewPrivateExterns
{
}


public struct WebKitWebViewPrivate
{
}
