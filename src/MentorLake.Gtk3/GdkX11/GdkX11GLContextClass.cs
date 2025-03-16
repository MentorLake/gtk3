namespace MentorLake.GdkX11;

public class GdkX11GLContextClassHandle : BaseSafeHandle
{
}


public static class GdkX11GLContextClassExtensions
{

	public static GdkX11GLContextClass Dereference(this GdkX11GLContextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkX11GLContextClass>(x.DangerousGetHandle());
}
internal class GdkX11GLContextClassExterns
{
}

public struct GdkX11GLContextClass
{
}
