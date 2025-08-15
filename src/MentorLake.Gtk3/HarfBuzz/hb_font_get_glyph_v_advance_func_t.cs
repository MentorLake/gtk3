namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// A virtual method for the #hb_font_funcs_t of an #hb_font_t object.
/// </para>
/// <para>
/// This method should retrieve the advance for a specified glyph, in
/// vertical-direction text segments. Advances must be returned in
/// an #hb_position_t output parameter.
/// </para>
/// </summary>

public struct hb_font_get_glyph_v_advance_func_t
{
	public MentorLake.HarfBuzz.hb_font_get_glyph_advance_func_t Value;
}

/// <summary>
/// <para>
/// A virtual method for the #hb_font_funcs_t of an #hb_font_t object.
/// </para>
/// <para>
/// This method should retrieve the advance for a specified glyph, in
/// vertical-direction text segments. Advances must be returned in
/// an #hb_position_t output parameter.
/// </para>
/// </summary>

public class hb_font_get_glyph_v_advance_func_tHandle : BaseSafeHandle
{
}

public static class hb_font_get_glyph_v_advance_func_tHandleExtensions
{
	public static hb_font_get_glyph_v_advance_func_t Dereference(this hb_font_get_glyph_v_advance_func_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_font_get_glyph_v_advance_func_t>(x.DangerousGetHandle());
	public static MentorLake.HarfBuzz.hb_font_get_glyph_advance_func_t DereferenceValue(this hb_font_get_glyph_v_advance_func_tHandle x) => x.Dereference().Value;
}
