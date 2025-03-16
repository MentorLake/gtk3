namespace MentorLake.HarfBuzz;

public class hb_font_extents_tHandle : BaseSafeHandle
{
}


public static class hb_font_extents_tExtensions
{

	public static hb_font_extents_t Dereference(this hb_font_extents_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_font_extents_t>(x.DangerousGetHandle());
}
internal class hb_font_extents_tExterns
{
}

public struct hb_font_extents_t
{
	public hb_position_t ascender;
	public hb_position_t descender;
	public hb_position_t line_gap;
}
