namespace MentorLake.GdkX11;

public class GdkX11DisplayManagerClassHandle : BaseSafeHandle
{
}


public static class GdkX11DisplayManagerClassExtensions
{

	public static GdkX11DisplayManagerClass Dereference(this GdkX11DisplayManagerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkX11DisplayManagerClass>(x.DangerousGetHandle());
}
internal class GdkX11DisplayManagerClassExterns
{
}

public struct GdkX11DisplayManagerClass
{
}
