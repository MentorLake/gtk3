namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for bitmasks.
/// </para>
/// </summary>

public struct hb_mask_t
{
	public uint Value;
}

public class hb_mask_tHandle : BaseSafeHandle
{
}

public static class hb_mask_tHandleExtensions
{
	public static hb_mask_t Dereference(this hb_mask_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_mask_t>(x.DangerousGetHandle());
	public static uint DereferenceValue(this hb_mask_tHandle x) => x.Dereference().Value;
}
