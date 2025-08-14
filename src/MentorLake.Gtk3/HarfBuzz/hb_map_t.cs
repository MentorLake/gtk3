namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for holding integer-to-integer hash maps.
/// </para>
/// </summary>

public class hb_map_tHandle : BaseSafeHandle
{
}


public static class hb_map_tExtensions
{

	public static hb_map_t Dereference(this hb_map_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_map_t>(x.DangerousGetHandle());
}
internal class hb_map_tExterns
{
}

/// <summary>
/// <para>
/// Data type for holding integer-to-integer hash maps.
/// </para>
/// </summary>

public struct hb_map_t
{
}
