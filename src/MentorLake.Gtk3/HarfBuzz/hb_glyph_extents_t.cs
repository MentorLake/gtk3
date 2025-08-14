namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Glyph extent values, measured in font units.
/// </para>
/// <para>
/// Note that @height is negative, in coordinate systems that grow up.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Glyph extent values, measured in font units.
/// </para>
/// <para>
/// Note that @height is negative, in coordinate systems that grow up.
/// </para>
/// </summary>

public struct hb_glyph_extents_t
{
	/// <summary>
/// <para>
/// Distance from the x-origin to the left extremum of the glyph.
/// </para>
/// </summary>

public hb_position_t x_bearing;
	/// <summary>
/// <para>
/// Distance from the top extremum of the glyph to the y-origin.
/// </para>
/// </summary>

public hb_position_t y_bearing;
	/// <summary>
/// <para>
/// Distance from the left extremum of the glyph to the right extremum.
/// </para>
/// </summary>

public hb_position_t width;
	/// <summary>
/// <para>
/// Distance from the top extremum of the glyph to the bottom extremum.
/// </para>
/// </summary>

public hb_position_t height;
}
