namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type to hold information for a &quot;part&quot; component of a math-variant glyph.
/// Large variants for stretchable math glyphs (such as parentheses) can be constructed
/// on the fly from parts.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Data type to hold information for a &quot;part&quot; component of a math-variant glyph.
/// Large variants for stretchable math glyphs (such as parentheses) can be constructed
/// on the fly from parts.
/// </para>
/// </summary>

public struct hb_ot_math_glyph_part_t
{
	/// <summary>
/// <para>
/// The glyph index of the variant part
/// </para>
/// </summary>

public hb_codepoint_t glyph;
	/// <summary>
/// <para>
/// The length of the connector on the starting side of the variant part
/// </para>
/// </summary>

public hb_position_t start_connector_length;
	/// <summary>
/// <para>
/// The length of the connector on the ending side of the variant part
/// </para>
/// </summary>

public hb_position_t end_connector_length;
	/// <summary>
/// <para>
/// The total advance of the part
/// </para>
/// </summary>

public hb_position_t full_advance;
	/// <summary>
/// <para>
/// #hb_ot_math_glyph_part_flags_t flags for the part
/// </para>
/// </summary>

public hb_ot_math_glyph_part_flags_t flags;
}
