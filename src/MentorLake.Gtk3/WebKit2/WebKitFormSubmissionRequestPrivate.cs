namespace MentorLake.WebKit2;


public class WebKitFormSubmissionRequestPrivateHandle : BaseSafeHandle
{
}


public static class WebKitFormSubmissionRequestPrivateExtensions
{

	public static WebKitFormSubmissionRequestPrivate Dereference(this WebKitFormSubmissionRequestPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitFormSubmissionRequestPrivate>(x.DangerousGetHandle());
}
internal class WebKitFormSubmissionRequestPrivateExterns
{
}


public struct WebKitFormSubmissionRequestPrivate
{
}
