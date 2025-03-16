namespace MentorLake.HarfBuzz;

public class hb_color_stop_tHandle : BaseSafeHandle
{
}


public static class hb_color_stop_tExtensions
{

	public static hb_color_stop_t Dereference(this hb_color_stop_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_color_stop_t>(x.DangerousGetHandle());
}
internal class hb_color_stop_tExterns
{
}

public struct hb_color_stop_t
{
	public float offset;
	public hb_bool_t is_foreground;
	public hb_color_t color;
}
