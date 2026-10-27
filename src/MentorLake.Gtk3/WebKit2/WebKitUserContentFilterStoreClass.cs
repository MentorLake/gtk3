namespace MentorLake.WebKit2;


public class WebKitUserContentFilterStoreClassHandle : BaseSafeHandle
{
}


public static class WebKitUserContentFilterStoreClassExtensions
{

	public static WebKitUserContentFilterStoreClass Dereference(this WebKitUserContentFilterStoreClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitUserContentFilterStoreClass>(x.DangerousGetHandle());
}
internal class WebKitUserContentFilterStoreClassExterns
{
}


public struct WebKitUserContentFilterStoreClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
