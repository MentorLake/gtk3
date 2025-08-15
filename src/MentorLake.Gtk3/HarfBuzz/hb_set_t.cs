namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for holding a set of integers. #hb_set_t&apos;s are
/// used to gather and contain glyph IDs, Unicode code
/// points, and various other collections of discrete
/// values.
/// </para>
/// </summary>

public class hb_set_tHandle : BaseSafeHandle
{
}


public static class hb_set_tExtensions
{

	public static hb_set_t Dereference(this hb_set_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_set_t>(x.DangerousGetHandle());
}
internal class hb_set_tExterns
{
}

/// <summary>
/// <para>
/// Data type for holding a set of integers. #hb_set_t&apos;s are
/// used to gather and contain glyph IDs, Unicode code
/// points, and various other collections of discrete
/// values.
/// </para>
/// </summary>

public struct hb_set_t
{
}
