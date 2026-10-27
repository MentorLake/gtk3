namespace MentorLake.WebKit2;


public class WebKitDeviceInfoPermissionRequestPrivateHandle : BaseSafeHandle
{
}


public static class WebKitDeviceInfoPermissionRequestPrivateExtensions
{

	public static WebKitDeviceInfoPermissionRequestPrivate Dereference(this WebKitDeviceInfoPermissionRequestPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitDeviceInfoPermissionRequestPrivate>(x.DangerousGetHandle());
}
internal class WebKitDeviceInfoPermissionRequestPrivateExterns
{
}


public struct WebKitDeviceInfoPermissionRequestPrivate
{
}
