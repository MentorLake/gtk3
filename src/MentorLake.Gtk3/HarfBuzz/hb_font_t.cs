namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for holding fonts.
/// </para>
/// </summary>

public class hb_font_tHandle : BaseSafeHandle
{
}


public static class hb_font_tExtensions
{

	public static hb_font_t Dereference(this hb_font_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_font_t>(x.DangerousGetHandle());
}
internal class hb_font_tExterns
{
}

/// <summary>
/// <para>
/// Data type for holding fonts.
/// </para>
/// </summary>

public struct hb_font_t
{
}
