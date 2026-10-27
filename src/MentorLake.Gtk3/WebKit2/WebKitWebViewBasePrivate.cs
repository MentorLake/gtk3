namespace MentorLake.WebKit2;


public class WebKitWebViewBasePrivateHandle : BaseSafeHandle
{
}


public static class WebKitWebViewBasePrivateExtensions
{

	public static WebKitWebViewBasePrivate Dereference(this WebKitWebViewBasePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebViewBasePrivate>(x.DangerousGetHandle());
}
internal class WebKitWebViewBasePrivateExterns
{
}


public struct WebKitWebViewBasePrivate
{
}
