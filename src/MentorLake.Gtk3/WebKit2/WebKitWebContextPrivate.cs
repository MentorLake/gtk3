namespace MentorLake.WebKit2;


public class WebKitWebContextPrivateHandle : BaseSafeHandle
{
}


public static class WebKitWebContextPrivateExtensions
{

	public static WebKitWebContextPrivate Dereference(this WebKitWebContextPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebContextPrivate>(x.DangerousGetHandle());
}
internal class WebKitWebContextPrivateExterns
{
}


public struct WebKitWebContextPrivate
{
}
