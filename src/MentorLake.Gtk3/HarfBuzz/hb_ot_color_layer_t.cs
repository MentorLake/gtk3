namespace MentorLake.HarfBuzz;

public class hb_ot_color_layer_tHandle : BaseSafeHandle
{
}


public static class hb_ot_color_layer_tExtensions
{

	public static hb_ot_color_layer_t Dereference(this hb_ot_color_layer_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_ot_color_layer_t>(x.DangerousGetHandle());
}
internal class hb_ot_color_layer_tExterns
{
}

public struct hb_ot_color_layer_t
{
	public hb_codepoint_t glyph;
	public uint color_index;
}
