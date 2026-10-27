namespace MentorLake.WebKit2;


public class WebKitGeolocationPermissionRequestPrivateHandle : BaseSafeHandle
{
}


public static class WebKitGeolocationPermissionRequestPrivateExtensions
{

	public static WebKitGeolocationPermissionRequestPrivate Dereference(this WebKitGeolocationPermissionRequestPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitGeolocationPermissionRequestPrivate>(x.DangerousGetHandle());
}
internal class WebKitGeolocationPermissionRequestPrivateExterns
{
}


public struct WebKitGeolocationPermissionRequestPrivate
{
}
