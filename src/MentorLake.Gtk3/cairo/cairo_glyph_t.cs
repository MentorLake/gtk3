namespace MentorLake.cairo;

public class cairo_glyph_tHandle : BaseSafeHandle
{
}


public static class cairo_glyph_tExtensions
{

	public static cairo_glyph_t Dereference(this cairo_glyph_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_glyph_t>(x.DangerousGetHandle());
}
internal class cairo_glyph_tExterns
{
}

public struct cairo_glyph_t
{
	public ulong index;
	public double x;
	public double y;
}
