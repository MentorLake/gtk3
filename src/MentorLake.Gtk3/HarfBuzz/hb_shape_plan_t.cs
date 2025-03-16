namespace MentorLake.HarfBuzz;

public class hb_shape_plan_tHandle : BaseSafeHandle
{
}


public static class hb_shape_plan_tExtensions
{

	public static hb_shape_plan_t Dereference(this hb_shape_plan_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_shape_plan_t>(x.DangerousGetHandle());
}
internal class hb_shape_plan_tExterns
{
}

public struct hb_shape_plan_t
{
}
