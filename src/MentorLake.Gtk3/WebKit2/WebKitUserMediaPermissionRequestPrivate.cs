namespace MentorLake.WebKit2;


public class WebKitUserMediaPermissionRequestPrivateHandle : BaseSafeHandle
{
}


public static class WebKitUserMediaPermissionRequestPrivateExtensions
{

	public static WebKitUserMediaPermissionRequestPrivate Dereference(this WebKitUserMediaPermissionRequestPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitUserMediaPermissionRequestPrivate>(x.DangerousGetHandle());
}
internal class WebKitUserMediaPermissionRequestPrivateExterns
{
}


public struct WebKitUserMediaPermissionRequestPrivate
{
}
