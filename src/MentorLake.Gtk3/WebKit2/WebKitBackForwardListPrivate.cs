namespace MentorLake.WebKit2;


public class WebKitBackForwardListPrivateHandle : BaseSafeHandle
{
}


public static class WebKitBackForwardListPrivateExtensions
{

	public static WebKitBackForwardListPrivate Dereference(this WebKitBackForwardListPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitBackForwardListPrivate>(x.DangerousGetHandle());
}
internal class WebKitBackForwardListPrivateExterns
{
}


public struct WebKitBackForwardListPrivate
{
}
