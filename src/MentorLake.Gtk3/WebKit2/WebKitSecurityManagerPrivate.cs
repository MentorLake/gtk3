namespace MentorLake.WebKit2;


public class WebKitSecurityManagerPrivateHandle : BaseSafeHandle
{
}


public static class WebKitSecurityManagerPrivateExtensions
{

	public static WebKitSecurityManagerPrivate Dereference(this WebKitSecurityManagerPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitSecurityManagerPrivate>(x.DangerousGetHandle());
}
internal class WebKitSecurityManagerPrivateExterns
{
}


public struct WebKitSecurityManagerPrivate
{
}
