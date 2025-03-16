namespace MentorLake.HarfBuzz;

public class hb_draw_funcs_tHandle : BaseSafeHandle
{
}


public static class hb_draw_funcs_tExtensions
{

	public static hb_draw_funcs_t Dereference(this hb_draw_funcs_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_draw_funcs_t>(x.DangerousGetHandle());
}
internal class hb_draw_funcs_tExterns
{
}

public struct hb_draw_funcs_t
{
}
