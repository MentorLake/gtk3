namespace MentorLake.WebKit2;


public class WebKitWindowPropertiesClassHandle : BaseSafeHandle
{
}


public static class WebKitWindowPropertiesClassExtensions
{

	public static WebKitWindowPropertiesClass Dereference(this WebKitWindowPropertiesClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWindowPropertiesClass>(x.DangerousGetHandle());
}
internal class WebKitWindowPropertiesClassExterns
{
}


public struct WebKitWindowPropertiesClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
