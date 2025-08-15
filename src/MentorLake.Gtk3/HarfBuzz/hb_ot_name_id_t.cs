namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// An integral type representing an OpenType &apos;name&apos; table name identifier.
/// There are predefined name IDs, as well as name IDs return from other
/// API.  These can be used to fetch name strings from a font face.
/// </para>
/// </summary>

public struct hb_ot_name_id_t
{
	public uint Value;
}

/// <summary>
/// <para>
/// An integral type representing an OpenType &apos;name&apos; table name identifier.
/// There are predefined name IDs, as well as name IDs return from other
/// API.  These can be used to fetch name strings from a font face.
/// </para>
/// </summary>

public class hb_ot_name_id_tHandle : BaseSafeHandle
{
}

public static class hb_ot_name_id_tHandleExtensions
{
	public static hb_ot_name_id_t Dereference(this hb_ot_name_id_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_ot_name_id_t>(x.DangerousGetHandle());
	public static uint DereferenceValue(this hb_ot_name_id_tHandle x) => x.Dereference().Value;
}
