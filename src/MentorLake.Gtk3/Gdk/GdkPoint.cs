namespace MentorLake.Gdk;

public class GdkPointHandle : BaseSafeHandle
{
}


public static class GdkPointExtensions
{

	public static GdkPoint Dereference(this GdkPointHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkPoint>(x.DangerousGetHandle());
}
internal class GdkPointExterns
{
}

public struct GdkPoint
{
	public int x;
	public int y;
}
