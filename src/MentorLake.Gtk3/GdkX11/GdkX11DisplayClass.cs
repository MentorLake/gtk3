namespace MentorLake.GdkX11;

public class GdkX11DisplayClassHandle : BaseSafeHandle
{
}


public static class GdkX11DisplayClassExtensions
{

	public static GdkX11DisplayClass Dereference(this GdkX11DisplayClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkX11DisplayClass>(x.DangerousGetHandle());
}
internal class GdkX11DisplayClassExterns
{
}

public struct GdkX11DisplayClass
{
}
