namespace MentorLake.WebKit2;


public class WebKitBackForwardListItemClassHandle : BaseSafeHandle
{
}


public static class WebKitBackForwardListItemClassExtensions
{

	public static WebKitBackForwardListItemClass Dereference(this WebKitBackForwardListItemClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitBackForwardListItemClass>(x.DangerousGetHandle());
}
internal class WebKitBackForwardListItemClassExterns
{
}


public struct WebKitBackForwardListItemClass
{
	
public GInitiallyUnownedClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
