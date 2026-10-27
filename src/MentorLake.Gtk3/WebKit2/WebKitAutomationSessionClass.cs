namespace MentorLake.WebKit2;


public class WebKitAutomationSessionClassHandle : BaseSafeHandle
{
}


public static class WebKitAutomationSessionClassExtensions
{

	public static WebKitAutomationSessionClass Dereference(this WebKitAutomationSessionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitAutomationSessionClass>(x.DangerousGetHandle());
}
internal class WebKitAutomationSessionClassExterns
{
}


public struct WebKitAutomationSessionClass
{
	
public GObjectClass parent_class;
	
public IntPtr _webkit_reserved0;
	
public IntPtr _webkit_reserved1;
	
public IntPtr _webkit_reserved2;
	
public IntPtr _webkit_reserved3;
}
