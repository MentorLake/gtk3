namespace MentorLake.WebKit2;


public class WebKitPointerLockPermissionRequestPrivateHandle : BaseSafeHandle
{
}


public static class WebKitPointerLockPermissionRequestPrivateExtensions
{

	public static WebKitPointerLockPermissionRequestPrivate Dereference(this WebKitPointerLockPermissionRequestPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitPointerLockPermissionRequestPrivate>(x.DangerousGetHandle());
}
internal class WebKitPointerLockPermissionRequestPrivateExterns
{
}


public struct WebKitPointerLockPermissionRequestPrivate
{
}
