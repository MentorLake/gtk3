namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type containing a set of virtual methods used for
/// accessing various Unicode character properties.
/// </para>
/// <para>
/// HarfBuzz provides a default function for each of the
/// methods in #hb_unicode_funcs_t. Client programs can implement
/// their own replacements for the individual Unicode functions, as
/// needed, and replace the default by calling the setter for a
/// method.
/// </para>
/// </summary>

public class hb_unicode_funcs_tHandle : BaseSafeHandle
{
}


public static class hb_unicode_funcs_tExtensions
{

	public static hb_unicode_funcs_t Dereference(this hb_unicode_funcs_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_unicode_funcs_t>(x.DangerousGetHandle());
}
internal class hb_unicode_funcs_tExterns
{
}

/// <summary>
/// <para>
/// Data type containing a set of virtual methods used for
/// accessing various Unicode character properties.
/// </para>
/// <para>
/// HarfBuzz provides a default function for each of the
/// methods in #hb_unicode_funcs_t. Client programs can implement
/// their own replacements for the individual Unicode functions, as
/// needed, and replace the default by calling the setter for a
/// method.
/// </para>
/// </summary>

public struct hb_unicode_funcs_t
{
}
