namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type to hold math kerning (cut-in) information for a glyph.
/// </para>
/// </summary>

public class hb_ot_math_kern_entry_tHandle : BaseSafeHandle
{
}


public static class hb_ot_math_kern_entry_tExtensions
{

	public static hb_ot_math_kern_entry_t Dereference(this hb_ot_math_kern_entry_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_ot_math_kern_entry_t>(x.DangerousGetHandle());
}
internal class hb_ot_math_kern_entry_tExterns
{
}

/// <summary>
/// <para>
/// Data type to hold math kerning (cut-in) information for a glyph.
/// </para>
/// </summary>

public struct hb_ot_math_kern_entry_t
{
	/// <summary>
/// <para>
/// The maximum height at which this entry should be used
/// </para>
/// </summary>

public hb_position_t max_correction_height;
	/// <summary>
/// <para>
/// The kern value of the entry
/// </para>
/// </summary>

public hb_position_t kern_value;
}
