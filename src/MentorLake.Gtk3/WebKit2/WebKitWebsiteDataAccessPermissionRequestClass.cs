namespace MentorLake.WebKit2;


public class WebKitWebsiteDataAccessPermissionRequestClassHandle : BaseSafeHandle
{
}


public static class WebKitWebsiteDataAccessPermissionRequestClassExtensions
{

	public static WebKitWebsiteDataAccessPermissionRequestClass Dereference(this WebKitWebsiteDataAccessPermissionRequestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebsiteDataAccessPermissionRequestClass>(x.DangerousGetHandle());
}
internal class WebKitWebsiteDataAccessPermissionRequestClassExterns
{
}


public struct WebKitWebsiteDataAccessPermissionRequestClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
