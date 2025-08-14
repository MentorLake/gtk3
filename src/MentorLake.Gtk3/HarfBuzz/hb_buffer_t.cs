namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// The main structure holding the input text and its properties before shaping,
/// and output glyphs and their information after shaping.
/// </para>
/// </summary>

public class hb_buffer_tHandle : BaseSafeHandle
{
}


public static class hb_buffer_tExtensions
{

	public static hb_buffer_t Dereference(this hb_buffer_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_buffer_t>(x.DangerousGetHandle());
}
internal class hb_buffer_tExterns
{
}

/// <summary>
/// <para>
/// The main structure holding the input text and its properties before shaping,
/// and output glyphs and their information after shaping.
/// </para>
/// </summary>

public struct hb_buffer_t
{
}
