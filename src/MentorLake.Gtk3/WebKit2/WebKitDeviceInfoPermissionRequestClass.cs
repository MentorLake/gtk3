namespace MentorLake.WebKit2;


public class WebKitDeviceInfoPermissionRequestClassHandle : BaseSafeHandle
{
}


public static class WebKitDeviceInfoPermissionRequestClassExtensions
{

	public static WebKitDeviceInfoPermissionRequestClass Dereference(this WebKitDeviceInfoPermissionRequestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitDeviceInfoPermissionRequestClass>(x.DangerousGetHandle());
}
internal class WebKitDeviceInfoPermissionRequestClassExterns
{
}


public struct WebKitDeviceInfoPermissionRequestClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
