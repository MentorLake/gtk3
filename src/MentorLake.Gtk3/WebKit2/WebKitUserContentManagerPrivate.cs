namespace MentorLake.WebKit2;


public class WebKitUserContentManagerPrivateHandle : BaseSafeHandle
{
}


public static class WebKitUserContentManagerPrivateExtensions
{

	public static WebKitUserContentManagerPrivate Dereference(this WebKitUserContentManagerPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitUserContentManagerPrivate>(x.DangerousGetHandle());
}
internal class WebKitUserContentManagerPrivateExterns
{
}


public struct WebKitUserContentManagerPrivate
{
}
