namespace MentorLake.HarfBuzz;

public class hb_glyph_info_tHandle : BaseSafeHandle
{
}


public static class hb_glyph_info_tExtensions
{

	public static hb_glyph_info_t Dereference(this hb_glyph_info_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_glyph_info_t>(x.DangerousGetHandle());
}
internal class hb_glyph_info_tExterns
{
}

public struct hb_glyph_info_t
{
	public hb_codepoint_t codepoint;
	public uint cluster;
}
