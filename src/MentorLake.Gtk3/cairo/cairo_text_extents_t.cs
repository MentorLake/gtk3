namespace MentorLake.cairo;

public class cairo_text_extents_tHandle : BaseSafeHandle
{
}


public static class cairo_text_extents_tExtensions
{

	public static cairo_text_extents_t Dereference(this cairo_text_extents_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_text_extents_t>(x.DangerousGetHandle());
}
internal class cairo_text_extents_tExterns
{
}

public struct cairo_text_extents_t
{
	public double x_bearing;
	public double y_bearing;
	public double width;
	public double height;
	public double x_advance;
	public double y_advance;
}
