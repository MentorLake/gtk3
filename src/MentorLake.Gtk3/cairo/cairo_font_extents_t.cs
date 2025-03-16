namespace MentorLake.cairo;

public class cairo_font_extents_tHandle : BaseSafeHandle
{
}


public static class cairo_font_extents_tExtensions
{

	public static cairo_font_extents_t Dereference(this cairo_font_extents_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_font_extents_t>(x.DangerousGetHandle());
}
internal class cairo_font_extents_tExterns
{
}

public struct cairo_font_extents_t
{
	public double ascent;
	public double descent;
	public double height;
	public double max_x_advance;
	public double max_y_advance;
}
