namespace MentorLake.WebKit2;


public class WebKitAutomationSessionPrivateHandle : BaseSafeHandle
{
}


public static class WebKitAutomationSessionPrivateExtensions
{

	public static WebKitAutomationSessionPrivate Dereference(this WebKitAutomationSessionPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitAutomationSessionPrivate>(x.DangerousGetHandle());
}
internal class WebKitAutomationSessionPrivateExterns
{
}


public struct WebKitAutomationSessionPrivate
{
}
