namespace MentorLake.HarfBuzz;

public class hb_ot_math_glyph_variant_tHandle : BaseSafeHandle
{
}


public static class hb_ot_math_glyph_variant_tExtensions
{

	public static hb_ot_math_glyph_variant_t Dereference(this hb_ot_math_glyph_variant_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_ot_math_glyph_variant_t>(x.DangerousGetHandle());
}
internal class hb_ot_math_glyph_variant_tExterns
{
}

public struct hb_ot_math_glyph_variant_t
{
	public hb_codepoint_t glyph;
	public hb_position_t advance;
}
