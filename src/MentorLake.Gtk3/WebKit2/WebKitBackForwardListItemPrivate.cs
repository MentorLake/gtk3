namespace MentorLake.WebKit2;


public class WebKitBackForwardListItemPrivateHandle : BaseSafeHandle
{
}


public static class WebKitBackForwardListItemPrivateExtensions
{

	public static WebKitBackForwardListItemPrivate Dereference(this WebKitBackForwardListItemPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitBackForwardListItemPrivate>(x.DangerousGetHandle());
}
internal class WebKitBackForwardListItemPrivateExterns
{
}


public struct WebKitBackForwardListItemPrivate
{
}
