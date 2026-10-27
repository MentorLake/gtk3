namespace MentorLake.WebKit2;


public class WebKitGeolocationPermissionRequestClassHandle : BaseSafeHandle
{
}


public static class WebKitGeolocationPermissionRequestClassExtensions
{

	public static WebKitGeolocationPermissionRequestClass Dereference(this WebKitGeolocationPermissionRequestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitGeolocationPermissionRequestClass>(x.DangerousGetHandle());
}
internal class WebKitGeolocationPermissionRequestClassExterns
{
}


public struct WebKitGeolocationPermissionRequestClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
