namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Structure representing a setting for an #hb_aat_layout_feature_type_t.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Structure representing a setting for an #hb_aat_layout_feature_type_t.
/// </para>
/// </summary>

public struct hb_aat_layout_feature_selector_info_t
{
	/// <summary>
/// <para>
/// The selector's name identifier
/// </para>
/// </summary>

public hb_ot_name_id_t name_id;
	/// <summary>
/// <para>
/// The value to turn the selector on
/// </para>
/// </summary>

public hb_aat_layout_feature_selector_t enable;
	/// <summary>
/// <para>
/// The value to turn the selector off
/// </para>
/// </summary>

public hb_aat_layout_feature_selector_t disable;
}
