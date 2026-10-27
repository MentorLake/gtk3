namespace MentorLake.WebKit2;


public class WebKitNotificationPrivateHandle : BaseSafeHandle
{
}


public static class WebKitNotificationPrivateExtensions
{

	public static WebKitNotificationPrivate Dereference(this WebKitNotificationPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitNotificationPrivate>(x.DangerousGetHandle());
}
internal class WebKitNotificationPrivateExterns
{
}


public struct WebKitNotificationPrivate
{
}
