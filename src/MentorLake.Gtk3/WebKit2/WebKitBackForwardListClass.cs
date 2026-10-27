namespace MentorLake.WebKit2;


public class WebKitBackForwardListClassHandle : BaseSafeHandle
{
}


public static class WebKitBackForwardListClassExtensions
{

	public static WebKitBackForwardListClass Dereference(this WebKitBackForwardListClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitBackForwardListClass>(x.DangerousGetHandle());
}
internal class WebKitBackForwardListClassExterns
{
}


public struct WebKitBackForwardListClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
