namespace MentorLake.HarfBuzz;

public class hb_aat_layout_feature_selector_info_tHandle : BaseSafeHandle
{
}


public static class hb_aat_layout_feature_selector_info_tExtensions
{

	public static hb_aat_layout_feature_selector_info_t Dereference(this hb_aat_layout_feature_selector_info_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_aat_layout_feature_selector_info_t>(x.DangerousGetHandle());
}
internal class hb_aat_layout_feature_selector_info_tExterns
{
}

public struct hb_aat_layout_feature_selector_info_t
{
	public hb_ot_name_id_t name_id;
	public hb_aat_layout_feature_selector_t enable;
	public hb_aat_layout_feature_selector_t disable;
}
