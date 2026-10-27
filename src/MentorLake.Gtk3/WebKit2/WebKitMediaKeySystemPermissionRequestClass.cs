namespace MentorLake.WebKit2;


public class WebKitMediaKeySystemPermissionRequestClassHandle : BaseSafeHandle
{
}


public static class WebKitMediaKeySystemPermissionRequestClassExtensions
{

	public static WebKitMediaKeySystemPermissionRequestClass Dereference(this WebKitMediaKeySystemPermissionRequestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitMediaKeySystemPermissionRequestClass>(x.DangerousGetHandle());
}
internal class WebKitMediaKeySystemPermissionRequestClassExterns
{
}


public struct WebKitMediaKeySystemPermissionRequestClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
