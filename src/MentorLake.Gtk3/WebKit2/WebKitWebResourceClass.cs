namespace MentorLake.WebKit2;


public class WebKitWebResourceClassHandle : BaseSafeHandle
{
}


public static class WebKitWebResourceClassExtensions
{

	public static WebKitWebResourceClass Dereference(this WebKitWebResourceClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebResourceClass>(x.DangerousGetHandle());
}
internal class WebKitWebResourceClassExterns
{
}


public struct WebKitWebResourceClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
