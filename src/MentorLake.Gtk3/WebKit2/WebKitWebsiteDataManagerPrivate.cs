namespace MentorLake.WebKit2;


public class WebKitWebsiteDataManagerPrivateHandle : BaseSafeHandle
{
}


public static class WebKitWebsiteDataManagerPrivateExtensions
{

	public static WebKitWebsiteDataManagerPrivate Dereference(this WebKitWebsiteDataManagerPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebsiteDataManagerPrivate>(x.DangerousGetHandle());
}
internal class WebKitWebsiteDataManagerPrivateExterns
{
}


public struct WebKitWebsiteDataManagerPrivate
{
}
