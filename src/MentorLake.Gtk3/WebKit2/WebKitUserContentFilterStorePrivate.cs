namespace MentorLake.WebKit2;


public class WebKitUserContentFilterStorePrivateHandle : BaseSafeHandle
{
}


public static class WebKitUserContentFilterStorePrivateExtensions
{

	public static WebKitUserContentFilterStorePrivate Dereference(this WebKitUserContentFilterStorePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitUserContentFilterStorePrivate>(x.DangerousGetHandle());
}
internal class WebKitUserContentFilterStorePrivateExterns
{
}


public struct WebKitUserContentFilterStorePrivate
{
}
