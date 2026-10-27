namespace MentorLake.WebKit2;


public class WebKitFaviconDatabasePrivateHandle : BaseSafeHandle
{
}


public static class WebKitFaviconDatabasePrivateExtensions
{

	public static WebKitFaviconDatabasePrivate Dereference(this WebKitFaviconDatabasePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitFaviconDatabasePrivate>(x.DangerousGetHandle());
}
internal class WebKitFaviconDatabasePrivateExterns
{
}


public struct WebKitFaviconDatabasePrivate
{
}
