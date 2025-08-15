namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for holding a single coordinate value.
/// Contour points and other multi-dimensional data are
/// stored as tuples of #hb_position_t&apos;s.
/// </para>
/// </summary>

public struct hb_position_t
{
	public int Value;
}

/// <summary>
/// <para>
/// Data type for holding a single coordinate value.
/// Contour points and other multi-dimensional data are
/// stored as tuples of #hb_position_t&apos;s.
/// </para>
/// </summary>

public class hb_position_tHandle : BaseSafeHandle
{
}

public static class hb_position_tHandleExtensions
{
	public static hb_position_t Dereference(this hb_position_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_position_t>(x.DangerousGetHandle());
	public static int DereferenceValue(this hb_position_tHandle x) => x.Dereference().Value;
}
