namespace MentorLake.WebKit2;


public class WebKitClipboardPermissionRequestPrivateHandle : BaseSafeHandle
{
}


public static class WebKitClipboardPermissionRequestPrivateExtensions
{

	public static WebKitClipboardPermissionRequestPrivate Dereference(this WebKitClipboardPermissionRequestPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitClipboardPermissionRequestPrivate>(x.DangerousGetHandle());
}
internal class WebKitClipboardPermissionRequestPrivateExterns
{
}


public struct WebKitClipboardPermissionRequestPrivate
{
}
