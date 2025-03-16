namespace MentorLake.cairo;

public class cairo_rectangle_tHandle : BaseSafeHandle
{
}


public static class cairo_rectangle_tExtensions
{

	public static cairo_rectangle_t Dereference(this cairo_rectangle_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_rectangle_t>(x.DangerousGetHandle());
}
internal class cairo_rectangle_tExterns
{
}

public struct cairo_rectangle_t
{
	public double x;
	public double y;
	public double width;
	public double height;
}
