namespace MentorLake.WebKit2;


public class WebKitInstallMissingMediaPluginsPermissionRequestClassHandle : BaseSafeHandle
{
}


public static class WebKitInstallMissingMediaPluginsPermissionRequestClassExtensions
{

	public static WebKitInstallMissingMediaPluginsPermissionRequestClass Dereference(this WebKitInstallMissingMediaPluginsPermissionRequestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitInstallMissingMediaPluginsPermissionRequestClass>(x.DangerousGetHandle());
}
internal class WebKitInstallMissingMediaPluginsPermissionRequestClassExterns
{
}


public struct WebKitInstallMissingMediaPluginsPermissionRequestClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
