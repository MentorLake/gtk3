namespace MentorLake.HarfBuzz;

public struct hb_font_get_glyph_h_kerning_func_t
{
	public MentorLake.HarfBuzz.hb_font_get_glyph_kerning_func_t Value;
}

public class hb_font_get_glyph_h_kerning_func_tHandle : BaseSafeHandle
{
}

public static class hb_font_get_glyph_h_kerning_func_tHandleExtensions
{
	public static hb_font_get_glyph_h_kerning_func_t Dereference(this hb_font_get_glyph_h_kerning_func_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_font_get_glyph_h_kerning_func_t>(x.DangerousGetHandle());
	public static MentorLake.HarfBuzz.hb_font_get_glyph_kerning_func_t DereferenceValue(this hb_font_get_glyph_h_kerning_func_tHandle x) => x.Dereference().Value;
}
