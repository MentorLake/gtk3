namespace MentorLake.HarfBuzz;

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

public struct hb_unicode_funcs_t
{
}
