namespace MentorLake.WebKit2;


public class WebKitFaviconDatabaseClassHandle : BaseSafeHandle
{
}


public static class WebKitFaviconDatabaseClassExtensions
{

	public static WebKitFaviconDatabaseClass Dereference(this WebKitFaviconDatabaseClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitFaviconDatabaseClass>(x.DangerousGetHandle());
}
internal class WebKitFaviconDatabaseClassExterns
{
}


public struct WebKitFaviconDatabaseClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
