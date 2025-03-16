namespace MentorLake.HarfBuzz;

public class hb_ot_var_axis_tHandle : BaseSafeHandle
{
}


public static class hb_ot_var_axis_tExtensions
{

	public static hb_ot_var_axis_t Dereference(this hb_ot_var_axis_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_ot_var_axis_t>(x.DangerousGetHandle());
}
internal class hb_ot_var_axis_tExterns
{
}

public struct hb_ot_var_axis_t
{
	public hb_tag_t tag;
	public hb_ot_name_id_t name_id;
	public float min_value;
	public float default_value;
	public float max_value;
}
