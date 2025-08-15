namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for holding color values. Colors are eight bits per
/// channel RGB plus alpha transparency.
/// </para>
/// </summary>

public struct hb_color_t
{
	public uint Value;
}

/// <summary>
/// <para>
/// Data type for holding color values. Colors are eight bits per
/// channel RGB plus alpha transparency.
/// </para>
/// </summary>

public class hb_color_tHandle : BaseSafeHandle
{
}

public static class hb_color_tHandleExtensions
{
	public static hb_color_t Dereference(this hb_color_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_color_t>(x.DangerousGetHandle());
	public static uint DereferenceValue(this hb_color_tHandle x) => x.Dereference().Value;
}
