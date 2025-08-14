namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type to hold math-variant information for a glyph.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Data type to hold math-variant information for a glyph.
/// </para>
/// </summary>

public struct hb_ot_math_glyph_variant_t
{
	/// <summary>
/// <para>
/// The glyph index of the variant
/// </para>
/// </summary>

public hb_codepoint_t glyph;
	/// <summary>
/// <para>
/// The advance width of the variant
/// </para>
/// </summary>

public hb_position_t advance;
}
