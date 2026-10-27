namespace MentorLake.WebKit2;


public class WebKitUserMessagePrivateHandle : BaseSafeHandle
{
}


public static class WebKitUserMessagePrivateExtensions
{

	public static WebKitUserMessagePrivate Dereference(this WebKitUserMessagePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitUserMessagePrivate>(x.DangerousGetHandle());
}
internal class WebKitUserMessagePrivateExterns
{
}


public struct WebKitUserMessagePrivate
{
}
