namespace MentorLake.WebKit2;


public class WebKitEditorStatePrivateHandle : BaseSafeHandle
{
}


public static class WebKitEditorStatePrivateExtensions
{

	public static WebKitEditorStatePrivate Dereference(this WebKitEditorStatePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitEditorStatePrivate>(x.DangerousGetHandle());
}
internal class WebKitEditorStatePrivateExterns
{
}


public struct WebKitEditorStatePrivate
{
}
