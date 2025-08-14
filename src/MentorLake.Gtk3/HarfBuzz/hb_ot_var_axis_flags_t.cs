namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Flags for #hb_ot_var_axis_info_t.
/// </para>
/// </summary>

[Flags]
public enum hb_ot_var_axis_flags_t : uint
{
/// <summary>
/// <para>
/// The axis should not be exposed directly in user interfaces.
/// </para>
/// </summary>

	HB_OT_VAR_AXIS_FLAG_HIDDEN = 1
}
