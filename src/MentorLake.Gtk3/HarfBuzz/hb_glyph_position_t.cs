namespace MentorLake.HarfBuzz;

public class hb_glyph_position_tHandle : BaseSafeHandle
{
}


public static class hb_glyph_position_tExtensions
{

	public static hb_glyph_position_t Dereference(this hb_glyph_position_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_glyph_position_t>(x.DangerousGetHandle());
}
internal class hb_glyph_position_tExterns
{
}

public struct hb_glyph_position_t
{
	public hb_position_t x_advance;
	public hb_position_t y_advance;
	public hb_position_t x_offset;
	public hb_position_t y_offset;
}
