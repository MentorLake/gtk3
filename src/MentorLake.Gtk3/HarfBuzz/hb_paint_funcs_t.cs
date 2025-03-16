namespace MentorLake.HarfBuzz;

public class hb_paint_funcs_tHandle : BaseSafeHandle
{
}


public static class hb_paint_funcs_tExtensions
{

	public static hb_paint_funcs_t Dereference(this hb_paint_funcs_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_paint_funcs_t>(x.DangerousGetHandle());
}
internal class hb_paint_funcs_tExterns
{
}

public struct hb_paint_funcs_t
{
}
