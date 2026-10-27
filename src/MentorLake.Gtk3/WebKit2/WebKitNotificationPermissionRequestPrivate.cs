namespace MentorLake.WebKit2;


public class WebKitNotificationPermissionRequestPrivateHandle : BaseSafeHandle
{
}


public static class WebKitNotificationPermissionRequestPrivateExtensions
{

	public static WebKitNotificationPermissionRequestPrivate Dereference(this WebKitNotificationPermissionRequestPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitNotificationPermissionRequestPrivate>(x.DangerousGetHandle());
}
internal class WebKitNotificationPermissionRequestPrivateExterns
{
}


public struct WebKitNotificationPermissionRequestPrivate
{
}
