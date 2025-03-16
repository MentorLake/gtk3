namespace MentorLake.HarfBuzz;

public class hb_draw_state_tHandle : BaseSafeHandle
{
}


public static class hb_draw_state_tExtensions
{

	public static hb_draw_state_t Dereference(this hb_draw_state_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_draw_state_t>(x.DangerousGetHandle());
}
internal class hb_draw_state_tExterns
{
}

public struct hb_draw_state_t
{
	public hb_bool_t path_open;
	public float path_start_x;
	public float path_start_y;
	public float current_x;
	public float current_y;
}
