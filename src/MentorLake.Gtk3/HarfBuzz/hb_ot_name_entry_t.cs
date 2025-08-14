namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Structure representing a name ID in a particular language.
/// </para>
/// </summary>

public class hb_ot_name_entry_tHandle : BaseSafeHandle
{
}


public static class hb_ot_name_entry_tExtensions
{

	public static hb_ot_name_entry_t Dereference(this hb_ot_name_entry_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_ot_name_entry_t>(x.DangerousGetHandle());
}
internal class hb_ot_name_entry_tExterns
{
}

/// <summary>
/// <para>
/// Structure representing a name ID in a particular language.
/// </para>
/// </summary>

public struct hb_ot_name_entry_t
{
	/// <summary>
/// <para>
/// name ID
/// </para>
/// </summary>

public hb_ot_name_id_t name_id;
	/// <summary>
/// <para>
/// language
/// </para>
/// </summary>

public hb_language_t language;
}
