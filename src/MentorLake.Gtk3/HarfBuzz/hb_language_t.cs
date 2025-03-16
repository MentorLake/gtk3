namespace MentorLake.HarfBuzz;

public class hb_language_tHandle : BaseSafeHandle
{
}


public static class hb_language_tExtensions
{
	public static string String(this MentorLake.HarfBuzz.hb_language_t language)
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

public struct hb_language_t
{
}
