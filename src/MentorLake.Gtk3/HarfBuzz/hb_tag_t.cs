namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for tag identifiers. Tags are four
/// byte integers, each byte representing a character.
/// </para>
/// <para>
/// Tags are used to identify tables, design-variation axes,
/// scripts, languages, font features, and baselines with
/// human-readable names.
/// </para>
/// </summary>

public struct hb_tag_t
{
	public uint Value;
}

public class hb_tag_tHandle : BaseSafeHandle
{
}

public static class hb_tag_tHandleExtensions
{
	public static hb_tag_t Dereference(this hb_tag_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_tag_t>(x.DangerousGetHandle());
	public static uint DereferenceValue(this hb_tag_tHandle x) => x.Dereference().Value;
}
