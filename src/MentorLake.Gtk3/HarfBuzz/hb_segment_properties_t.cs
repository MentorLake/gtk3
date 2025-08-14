namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// The structure that holds various text properties of an #hb_buffer_t. Can be
/// set and retrieved using hb_buffer_set_segment_properties() and
/// hb_buffer_get_segment_properties(), respectively.
/// </para>
/// </summary>

public class hb_segment_properties_tHandle : BaseSafeHandle
{
}


public static class hb_segment_properties_tExtensions
{

	public static hb_segment_properties_t Dereference(this hb_segment_properties_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_segment_properties_t>(x.DangerousGetHandle());
}
internal class hb_segment_properties_tExterns
{
}

/// <summary>
/// <para>
/// The structure that holds various text properties of an #hb_buffer_t. Can be
/// set and retrieved using hb_buffer_set_segment_properties() and
/// hb_buffer_get_segment_properties(), respectively.
/// </para>
/// </summary>

public struct hb_segment_properties_t
{
	/// <summary>
/// <para>
/// the #hb_direction_t of the buffer, see hb_buffer_set_direction().
/// </para>
/// </summary>

public hb_direction_t direction;
	/// <summary>
/// <para>
/// the #hb_script_t of the buffer, see hb_buffer_set_script().
/// </para>
/// </summary>

public hb_script_t script;
	/// <summary>
/// <para>
/// the #hb_language_t of the buffer, see hb_buffer_set_language().
/// </para>
/// </summary>

public hb_language_t language;
}
