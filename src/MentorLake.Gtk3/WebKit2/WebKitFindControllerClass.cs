namespace MentorLake.WebKit2;


public class WebKitFindControllerClassHandle : BaseSafeHandle
{
}


public static class WebKitFindControllerClassExtensions
{

	public static WebKitFindControllerClass Dereference(this WebKitFindControllerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitFindControllerClass>(x.DangerousGetHandle());
}
internal class WebKitFindControllerClassExterns
{
}


public struct WebKitFindControllerClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
