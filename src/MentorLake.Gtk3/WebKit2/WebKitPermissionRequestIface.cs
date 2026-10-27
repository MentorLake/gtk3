namespace MentorLake.WebKit2;


public class WebKitPermissionRequestIfaceHandle : BaseSafeHandle
{
}


public static class WebKitPermissionRequestIfaceExtensions
{

	public static WebKitPermissionRequestIface Dereference(this WebKitPermissionRequestIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitPermissionRequestIface>(x.DangerousGetHandle());
}
internal class WebKitPermissionRequestIfaceExterns
{
}


public struct WebKitPermissionRequestIface
{
	
public GTypeInterface parent_interface;
	
public IntPtr allow;
	
public IntPtr deny;
}
