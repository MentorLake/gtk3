namespace MentorLake.HarfBuzz;

public class hb_ot_var_axis_info_tHandle : BaseSafeHandle
{
}


public static class hb_ot_var_axis_info_tExtensions
{

	public static hb_ot_var_axis_info_t Dereference(this hb_ot_var_axis_info_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_ot_var_axis_info_t>(x.DangerousGetHandle());
}
internal class hb_ot_var_axis_info_tExterns
{
}

public struct hb_ot_var_axis_info_t
{
	public uint axis_index;
	public hb_tag_t tag;
	public hb_ot_name_id_t name_id;
	public hb_ot_var_axis_flags_t flags;
	public float min_value;
	public float default_value;
	public float max_value;
}
