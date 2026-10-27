namespace MentorLake.WebKit2;


public class WebKitMediaKeySystemPermissionRequestPrivateHandle : BaseSafeHandle
{
}


public static class WebKitMediaKeySystemPermissionRequestPrivateExtensions
{

	public static WebKitMediaKeySystemPermissionRequestPrivate Dereference(this WebKitMediaKeySystemPermissionRequestPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitMediaKeySystemPermissionRequestPrivate>(x.DangerousGetHandle());
}
internal class WebKitMediaKeySystemPermissionRequestPrivateExterns
{
}


public struct WebKitMediaKeySystemPermissionRequestPrivate
{
}
