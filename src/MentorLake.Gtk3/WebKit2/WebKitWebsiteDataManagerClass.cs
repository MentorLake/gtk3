namespace MentorLake.WebKit2;


public class WebKitWebsiteDataManagerClassHandle : BaseSafeHandle
{
}


public static class WebKitWebsiteDataManagerClassExtensions
{

	public static WebKitWebsiteDataManagerClass Dereference(this WebKitWebsiteDataManagerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitWebsiteDataManagerClass>(x.DangerousGetHandle());
}
internal class WebKitWebsiteDataManagerClassExterns
{
}


public struct WebKitWebsiteDataManagerClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
