namespace MentorLake.WebKit2;


public class WebKitOptionMenuPrivateHandle : BaseSafeHandle
{
}


public static class WebKitOptionMenuPrivateExtensions
{

	public static WebKitOptionMenuPrivate Dereference(this WebKitOptionMenuPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitOptionMenuPrivate>(x.DangerousGetHandle());
}
internal class WebKitOptionMenuPrivateExterns
{
}


public struct WebKitOptionMenuPrivate
{
}
