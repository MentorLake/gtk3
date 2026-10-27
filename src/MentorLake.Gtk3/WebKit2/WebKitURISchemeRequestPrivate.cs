namespace MentorLake.WebKit2;


public class WebKitURISchemeRequestPrivateHandle : BaseSafeHandle
{
}


public static class WebKitURISchemeRequestPrivateExtensions
{

	public static WebKitURISchemeRequestPrivate Dereference(this WebKitURISchemeRequestPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitURISchemeRequestPrivate>(x.DangerousGetHandle());
}
internal class WebKitURISchemeRequestPrivateExterns
{
}


public struct WebKitURISchemeRequestPrivate
{
}
