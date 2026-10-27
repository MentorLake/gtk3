namespace MentorLake.WebKit2;


public class WebKitOptionMenuClassHandle : BaseSafeHandle
{
}


public static class WebKitOptionMenuClassExtensions
{

	public static WebKitOptionMenuClass Dereference(this WebKitOptionMenuClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitOptionMenuClass>(x.DangerousGetHandle());
}
internal class WebKitOptionMenuClassExterns
{
}


public struct WebKitOptionMenuClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
