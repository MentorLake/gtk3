namespace MentorLake.WebKit2;


public class WebKitWebResourcePrivateHandle : BaseSafeHandle
{
}


public static class WebKitWebResourcePrivateExtensions
{

	public static WebKitWebResourcePrivate Dereference(this WebKitWebResourcePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebResourcePrivate>(x.DangerousGetHandle());
}
internal class WebKitWebResourcePrivateExterns
{
}


public struct WebKitWebResourcePrivate
{
}
