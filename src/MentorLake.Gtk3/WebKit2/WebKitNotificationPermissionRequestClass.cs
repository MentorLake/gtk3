namespace MentorLake.WebKit2;


public class WebKitNotificationPermissionRequestClassHandle : BaseSafeHandle
{
}


public static class WebKitNotificationPermissionRequestClassExtensions
{

	public static WebKitNotificationPermissionRequestClass Dereference(this WebKitNotificationPermissionRequestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitNotificationPermissionRequestClass>(x.DangerousGetHandle());
}
internal class WebKitNotificationPermissionRequestClassExterns
{
}


public struct WebKitNotificationPermissionRequestClass
{
	
public GObjectClass parent_class;
}
