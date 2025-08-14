namespace MentorLake.HarfBuzz;

/// <summary>
/// <para>
/// Data type for languages. Each #hb_language_t corresponds to a BCP 47
/// language tag.
/// </para>
/// </summary>

public class hb_language_tHandle : BaseSafeHandle
{
}


public static class hb_language_tExtensions
{
/// <summary>
/// <para>
/// Converts an #hb_language_t to a string.
/// </para>
/// </summary>

/// <param name="language">
/// The #hb_language_t to convert
/// </param>
/// <return>
/// 
/// A `NULL`-terminated string representing the @language. Must not be freed by
/// the caller.
/// </return>

	public static string String(MentorLake.HarfBuzz.hb_language_t language)
	{
		return hb_language_tExterns.hb_language_to_string(language);
	}


	public static hb_language_t Dereference(this hb_language_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<hb_language_t>(x.DangerousGetHandle());
}
internal class hb_language_tExterns
{
	[DllImport(HarfBuzzLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string hb_language_to_string(MentorLake.HarfBuzz.hb_language_t language);

}

/// <summary>
/// <para>
/// Data type for languages. Each #hb_language_t corresponds to a BCP 47
/// language tag.
/// </para>
/// </summary>

public struct hb_language_t
{
}
