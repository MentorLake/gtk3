namespace MentorLake.Gio;

public class GAppLaunchContextPrivateHandle : BaseSafeHandle
{
}


public static class GAppLaunchContextPrivateExtensions
{

	public static GAppLaunchContextPrivate Dereference(this GAppLaunchContextPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GAppLaunchContextPrivate>(x.DangerousGetHandle());
}
internal class GAppLaunchContextPrivateExterns
{
}

public struct GAppLaunchContextPrivate
{
}
