namespace MentorLake.WebKit2;


public class WebKitUserMessageClassHandle : BaseSafeHandle
{
}


public static class WebKitUserMessageClassExtensions
{

	public static WebKitUserMessageClass Dereference(this WebKitUserMessageClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitUserMessageClass>(x.DangerousGetHandle());
}
internal class WebKitUserMessageClassExterns
{
}


public struct WebKitUserMessageClass
{
	
public GInitiallyUnownedClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
