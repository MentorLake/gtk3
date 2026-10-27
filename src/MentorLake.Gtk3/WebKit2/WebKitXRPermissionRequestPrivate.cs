namespace MentorLake.WebKit2;


public class WebKitXRPermissionRequestPrivateHandle : BaseSafeHandle
{
}


public static class WebKitXRPermissionRequestPrivateExtensions
{

	public static WebKitXRPermissionRequestPrivate Dereference(this WebKitXRPermissionRequestPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitXRPermissionRequestPrivate>(x.DangerousGetHandle());
}
internal class WebKitXRPermissionRequestPrivateExterns
{
}


public struct WebKitXRPermissionRequestPrivate
{
}
