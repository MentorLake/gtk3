namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// The #hb_glyph_position_t is the structure that holds the positions of the
/// glyph in both horizontal and vertical directions. All positions in
/// #hb_glyph_position_t are relative to the current point.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// The #hb_glyph_position_t is the structure that holds the positions of the
/// glyph in both horizontal and vertical directions. All positions in
/// #hb_glyph_position_t are relative to the current point.
/// </para>
/// </summary>

public struct hb_glyph_position_t
{
	/// <summary>
/// <para>
/// how much the line advances after drawing this glyph when setting
///             text in horizontal direction.
/// </para>
/// </summary>

public hb_position_t x_advance;
	/// <summary>
/// <para>
/// how much the line advances after drawing this glyph when setting
///             text in vertical direction.
/// </para>
/// </summary>

public hb_position_t y_advance;
	/// <summary>
/// <para>
/// how much the glyph moves on the X-axis before drawing it, this
///            should not affect how much the line advances.
/// </para>
/// </summary>

public hb_position_t x_offset;
	/// <summary>
/// <para>
/// how much the glyph moves on the Y-axis before drawing it, this
///            should not affect how much the line advances.
/// </para>
/// </summary>

public hb_position_t y_offset;
}
