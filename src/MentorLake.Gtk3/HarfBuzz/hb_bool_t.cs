namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for booleans.
/// </para>
/// </summary>

public struct hb_bool_t
{
	public int Value;
}

/// <summary>
/// <para>
/// Data type for booleans.
/// </para>
/// </summary>

public class hb_bool_tHandle : BaseSafeHandle
{
}

public static class hb_bool_tHandleExtensions
{
	public static hb_bool_t Dereference(this hb_bool_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_bool_t>(x.DangerousGetHandle());
	public static int DereferenceValue(this hb_bool_tHandle x) => x.Dereference().Value;
}
