namespace MentorLake.WebKit2;


public class WebKitUserContentManagerClassHandle : BaseSafeHandle
{
}


public static class WebKitUserContentManagerClassExtensions
{

	public static WebKitUserContentManagerClass Dereference(this WebKitUserContentManagerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitUserContentManagerClass>(x.DangerousGetHandle());
}
internal class WebKitUserContentManagerClassExterns
{
}


public struct WebKitUserContentManagerClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
