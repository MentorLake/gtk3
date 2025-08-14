namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type containing a set of virtual methods used for
/// working on #hb_font_t font objects.
/// </para>
/// <para>
/// HarfBuzz provides a lightweight default function for each of
/// the methods in #hb_font_funcs_t. Client programs can implement
/// their own replacements for the individual font functions, as
/// needed, and replace the default by calling the setter for a
/// method.
/// </para>
/// </summary>

public class hb_font_funcs_tHandle : BaseSafeHandle
{
}


public static class hb_font_funcs_tExtensions
{

	public static hb_font_funcs_t Dereference(this hb_font_funcs_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_font_funcs_t>(x.DangerousGetHandle());
}
internal class hb_font_funcs_tExterns
{
}

/// <summary>
/// <para>
/// Data type containing a set of virtual methods used for
/// working on #hb_font_t font objects.
/// </para>
/// <para>
/// HarfBuzz provides a lightweight default function for each of
/// the methods in #hb_font_funcs_t. Client programs can implement
/// their own replacements for the individual font functions, as
/// needed, and replace the default by calling the setter for a
/// method.
/// </para>
/// </summary>

public struct hb_font_funcs_t
{
}
