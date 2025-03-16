namespace MentorLake.cairo;

public class cairo_rectangle_int_tHandle : BaseSafeHandle
{
}


public static class cairo_rectangle_int_tExtensions
{

	public static cairo_rectangle_int_t Dereference(this cairo_rectangle_int_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_rectangle_int_t>(x.DangerousGetHandle());
}
internal class cairo_rectangle_int_tExterns
{
}

public struct cairo_rectangle_int_t
{
	public int x;
	public int y;
	public int width;
	public int height;
}
