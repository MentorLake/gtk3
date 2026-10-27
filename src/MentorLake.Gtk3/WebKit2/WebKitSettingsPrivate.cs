namespace MentorLake.WebKit2;


public class WebKitSettingsPrivateHandle : BaseSafeHandle
{
}


public static class WebKitSettingsPrivateExtensions
{

	public static WebKitSettingsPrivate Dereference(this WebKitSettingsPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitSettingsPrivate>(x.DangerousGetHandle());
}
internal class WebKitSettingsPrivateExterns
{
}


public struct WebKitSettingsPrivate
{
}
