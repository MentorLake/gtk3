namespace MentorLake.Gdk;

public class GdkWindowRedirectHandle : BaseSafeHandle
{
}


public static class GdkWindowRedirectExtensions
{

	public static GdkWindowRedirect Dereference(this GdkWindowRedirectHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkWindowRedirect>(x.DangerousGetHandle());
}
internal class GdkWindowRedirectExterns
{
}

public struct GdkWindowRedirect
{
}
