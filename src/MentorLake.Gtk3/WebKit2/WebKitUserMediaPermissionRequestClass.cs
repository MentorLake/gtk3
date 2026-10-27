namespace MentorLake.WebKit2;


public class WebKitUserMediaPermissionRequestClassHandle : BaseSafeHandle
{
}


public static class WebKitUserMediaPermissionRequestClassExtensions
{

	public static WebKitUserMediaPermissionRequestClass Dereference(this WebKitUserMediaPermissionRequestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitUserMediaPermissionRequestClass>(x.DangerousGetHandle());
}
internal class WebKitUserMediaPermissionRequestClassExterns
{
}


public struct WebKitUserMediaPermissionRequestClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
