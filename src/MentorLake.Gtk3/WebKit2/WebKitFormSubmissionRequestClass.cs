namespace MentorLake.WebKit2;


public class WebKitFormSubmissionRequestClassHandle : BaseSafeHandle
{
}


public static class WebKitFormSubmissionRequestClassExtensions
{

	public static WebKitFormSubmissionRequestClass Dereference(this WebKitFormSubmissionRequestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitFormSubmissionRequestClass>(x.DangerousGetHandle());
}
internal class WebKitFormSubmissionRequestClassExterns
{
}


public struct WebKitFormSubmissionRequestClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
