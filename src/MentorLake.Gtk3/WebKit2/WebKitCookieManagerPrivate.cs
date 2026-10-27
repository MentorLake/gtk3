namespace MentorLake.WebKit2;


public class WebKitCookieManagerPrivateHandle : BaseSafeHandle
{
}


public static class WebKitCookieManagerPrivateExtensions
{

	public static WebKitCookieManagerPrivate Dereference(this WebKitCookieManagerPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitCookieManagerPrivate>(x.DangerousGetHandle());
}
internal class WebKitCookieManagerPrivateExterns
{
}


public struct WebKitCookieManagerPrivate
{
}
