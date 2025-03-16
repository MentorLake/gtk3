namespace MentorLake.HarfBuzz;

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

public struct hb_font_funcs_t
{
}
