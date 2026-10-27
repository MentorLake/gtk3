namespace MentorLake.WebKit2;


public class WebKitFindControllerPrivateHandle : BaseSafeHandle
{
}


public static class WebKitFindControllerPrivateExtensions
{

	public static WebKitFindControllerPrivate Dereference(this WebKitFindControllerPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitFindControllerPrivate>(x.DangerousGetHandle());
}
internal class WebKitFindControllerPrivateExterns
{
}


public struct WebKitFindControllerPrivate
{
}
