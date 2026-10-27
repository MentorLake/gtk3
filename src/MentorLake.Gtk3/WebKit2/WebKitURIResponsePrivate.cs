namespace MentorLake.WebKit2;


public class WebKitURIResponsePrivateHandle : BaseSafeHandle
{
}


public static class WebKitURIResponsePrivateExtensions
{

	public static WebKitURIResponsePrivate Dereference(this WebKitURIResponsePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitURIResponsePrivate>(x.DangerousGetHandle());
}
internal class WebKitURIResponsePrivateExterns
{
}


public struct WebKitURIResponsePrivate
{
}
