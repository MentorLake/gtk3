namespace MentorLake.WebKit2;


public class WebKitDownloadClassHandle : BaseSafeHandle
{
}


public static class WebKitDownloadClassExtensions
{

	public static WebKitDownloadClass Dereference(this WebKitDownloadClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitDownloadClass>(x.DangerousGetHandle());
}
internal class WebKitDownloadClassExterns
{
}


public struct WebKitDownloadClass
{
	
public GObjectClass parent_class;
	
public IntPtr decide_destination;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
