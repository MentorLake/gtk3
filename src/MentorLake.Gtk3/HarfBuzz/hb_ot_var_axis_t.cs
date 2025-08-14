namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Use #hb_ot_var_axis_info_t instead.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Use #hb_ot_var_axis_info_t instead.
/// </para>
/// </summary>

public struct hb_ot_var_axis_t
{
	/// <summary>
/// <para>
/// axis tag
/// </para>
/// </summary>

public hb_tag_t tag;
	/// <summary>
/// <para>
/// axis name identifier
/// </para>
/// </summary>

public hb_ot_name_id_t name_id;
	/// <summary>
/// <para>
/// minimum value of the axis
/// </para>
/// </summary>

public float min_value;
	/// <summary>
/// <para>
/// default value of the axis
/// </para>
/// </summary>

public float default_value;
	/// <summary>
/// <para>
/// maximum value of the axis
/// </para>
/// </summary>

public float max_value;
}
