namespace MentorLake.GdkX11;


public class GdkX11KeymapClassHandle : BaseSafeHandle
{
}


public static class GdkX11KeymapClassExtensions
{

	public static GdkX11KeymapClass Dereference(this GdkX11KeymapClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkX11KeymapClass>(x.DangerousGetHandle());
}
internal class GdkX11KeymapClassExterns
{
}


public struct GdkX11KeymapClass
{
}
