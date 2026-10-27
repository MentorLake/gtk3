namespace MentorLake.WebKit2;


public class WebKitURISchemeResponsePrivateHandle : BaseSafeHandle
{
}


public static class WebKitURISchemeResponsePrivateExtensions
{

	public static WebKitURISchemeResponsePrivate Dereference(this WebKitURISchemeResponsePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitURISchemeResponsePrivate>(x.DangerousGetHandle());
}
internal class WebKitURISchemeResponsePrivateExterns
{
}


public struct WebKitURISchemeResponsePrivate
{
}
