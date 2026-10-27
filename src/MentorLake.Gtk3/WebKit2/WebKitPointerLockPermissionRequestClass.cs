namespace MentorLake.WebKit2;


public class WebKitPointerLockPermissionRequestClassHandle : BaseSafeHandle
{
}


public static class WebKitPointerLockPermissionRequestClassExtensions
{

	public static WebKitPointerLockPermissionRequestClass Dereference(this WebKitPointerLockPermissionRequestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitPointerLockPermissionRequestClass>(x.DangerousGetHandle());
}
internal class WebKitPointerLockPermissionRequestClassExterns
{
}


public struct WebKitPointerLockPermissionRequestClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
