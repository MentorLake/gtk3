namespace MentorLake.HarfBuzz;

public class hb_glyph_extents_tHandle : BaseSafeHandle
{
}


public static class hb_glyph_extents_tExtensions
{

	public static hb_glyph_extents_t Dereference(this hb_glyph_extents_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_glyph_extents_t>(x.DangerousGetHandle());
}
internal class hb_glyph_extents_tExterns
{
}

public struct hb_glyph_extents_t
{
	public hb_position_t x_bearing;
	public hb_position_t y_bearing;
	public hb_position_t width;
	public hb_position_t height;
}
