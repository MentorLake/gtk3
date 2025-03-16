namespace MentorLake.GdkX11;

public class GdkX11AppLaunchContextClassHandle : BaseSafeHandle
{
}


public static class GdkX11AppLaunchContextClassExtensions
{

	public static GdkX11AppLaunchContextClass Dereference(this GdkX11AppLaunchContextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkX11AppLaunchContextClass>(x.DangerousGetHandle());
}
internal class GdkX11AppLaunchContextClassExterns
{
}

public struct GdkX11AppLaunchContextClass
{
}
