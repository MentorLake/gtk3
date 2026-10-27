namespace MentorLake.WebKit2;


public class WebKitWebsiteDataAccessPermissionRequestPrivateHandle : BaseSafeHandle
{
}


public static class WebKitWebsiteDataAccessPermissionRequestPrivateExtensions
{

	public static WebKitWebsiteDataAccessPermissionRequestPrivate Dereference(this WebKitWebsiteDataAccessPermissionRequestPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebsiteDataAccessPermissionRequestPrivate>(x.DangerousGetHandle());
}
internal class WebKitWebsiteDataAccessPermissionRequestPrivateExterns
{
}


public struct WebKitWebsiteDataAccessPermissionRequestPrivate
{
}
