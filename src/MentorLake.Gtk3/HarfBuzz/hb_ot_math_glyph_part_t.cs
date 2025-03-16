namespace MentorLake.HarfBuzz;

public class hb_ot_math_glyph_part_tHandle : BaseSafeHandle
{
}


public static class hb_ot_math_glyph_part_tExtensions
{

	public static hb_ot_math_glyph_part_t Dereference(this hb_ot_math_glyph_part_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_ot_math_glyph_part_t>(x.DangerousGetHandle());
}
internal class hb_ot_math_glyph_part_tExterns
{
}

public struct hb_ot_math_glyph_part_t
{
	public hb_codepoint_t glyph;
	public hb_position_t start_connector_length;
	public hb_position_t end_connector_length;
	public hb_position_t full_advance;
	public hb_ot_math_glyph_part_flags_t flags;
}
