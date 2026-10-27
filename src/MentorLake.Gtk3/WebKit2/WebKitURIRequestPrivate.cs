namespace MentorLake.WebKit2;


public class WebKitURIRequestPrivateHandle : BaseSafeHandle
{
}


public static class WebKitURIRequestPrivateExtensions
{

	public static WebKitURIRequestPrivate Dereference(this WebKitURIRequestPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitURIRequestPrivate>(x.DangerousGetHandle());
}
internal class WebKitURIRequestPrivateExterns
{
}


public struct WebKitURIRequestPrivate
{
}
