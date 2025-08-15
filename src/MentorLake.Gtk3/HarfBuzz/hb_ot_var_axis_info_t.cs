namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for holding variation-axis values.
/// </para>
/// <para>
/// The minimum, default, and maximum values are in un-normalized, user scales.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: at present, the only flag defined for @flags is
/// #HB_OT_VAR_AXIS_FLAG_HIDDEN.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Data type for holding variation-axis values.
/// </para>
/// <para>
/// The minimum, default, and maximum values are in un-normalized, user scales.
/// </para>
/// <para>
/// &amp;lt;note&amp;gt;Note: at present, the only flag defined for @flags is
/// #HB_OT_VAR_AXIS_FLAG_HIDDEN.&amp;lt;/note&amp;gt;
/// </para>
/// </summary>

public struct hb_ot_var_axis_info_t
{
	/// <summary>
/// <para>
/// Index of the axis in the variation-axis array
/// </para>
/// </summary>

public uint axis_index;
	/// <summary>
/// <para>
/// The #hb_tag_t tag identifying the design variation of the axis
/// </para>
/// </summary>

public hb_tag_t tag;
	/// <summary>
/// <para>
/// The `name` table Name ID that provides display names for the axis
/// </para>
/// </summary>

public hb_ot_name_id_t name_id;
	/// <summary>
/// <para>
/// The #hb_ot_var_axis_flags_t flags for the axis
/// </para>
/// </summary>

public hb_ot_var_axis_flags_t flags;
	/// <summary>
/// <para>
/// The minimum value on the variation axis that the font covers
/// </para>
/// </summary>

public float min_value;
	/// <summary>
/// <para>
/// The position on the variation axis corresponding to the font&apos;s defaults
/// </para>
/// </summary>

public float default_value;
	/// <summary>
/// <para>
/// The maximum value on the variation axis that the font covers
/// </para>
/// </summary>

public float max_value;
}
