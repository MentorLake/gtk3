namespace MentorLake.WebKit2;


public class WebKitXRPermissionRequestClassHandle : BaseSafeHandle
{
}


public static class WebKitXRPermissionRequestClassExtensions
{

	public static WebKitXRPermissionRequestClass Dereference(this WebKitXRPermissionRequestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitXRPermissionRequestClass>(x.DangerousGetHandle());
}
internal class WebKitXRPermissionRequestClassExterns
{
}


public struct WebKitXRPermissionRequestClass
{
	
public GObjectClass parent_class;
}
