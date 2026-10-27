namespace MentorLake.WebKit2;


public class WebKitURIResponseClassHandle : BaseSafeHandle
{
}


public static class WebKitURIResponseClassExtensions
{

	public static WebKitURIResponseClass Dereference(this WebKitURIResponseClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitURIResponseClass>(x.DangerousGetHandle());
}
internal class WebKitURIResponseClassExterns
{
}


public struct WebKitURIResponseClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
