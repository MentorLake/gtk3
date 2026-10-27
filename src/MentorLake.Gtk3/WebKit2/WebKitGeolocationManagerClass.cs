namespace MentorLake.WebKit2;


public class WebKitGeolocationManagerClassHandle : BaseSafeHandle
{
}


public static class WebKitGeolocationManagerClassExtensions
{

	public static WebKitGeolocationManagerClass Dereference(this WebKitGeolocationManagerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitGeolocationManagerClass>(x.DangerousGetHandle());
}
internal class WebKitGeolocationManagerClassExterns
{
}


public struct WebKitGeolocationManagerClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
