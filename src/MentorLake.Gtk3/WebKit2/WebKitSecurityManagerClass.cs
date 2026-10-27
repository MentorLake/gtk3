namespace MentorLake.WebKit2;


public class WebKitSecurityManagerClassHandle : BaseSafeHandle
{
}


public static class WebKitSecurityManagerClassExtensions
{

	public static WebKitSecurityManagerClass Dereference(this WebKitSecurityManagerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitSecurityManagerClass>(x.DangerousGetHandle());
}
internal class WebKitSecurityManagerClassExterns
{
}


public struct WebKitSecurityManagerClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
