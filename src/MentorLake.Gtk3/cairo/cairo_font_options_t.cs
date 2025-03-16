namespace MentorLake.cairo;

public class cairo_font_options_tHandle : BaseSafeHandle
{
}


public static class cairo_font_options_tExtensions
{

	public static cairo_font_options_t Dereference(this cairo_font_options_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_font_options_t>(x.DangerousGetHandle());
}
internal class cairo_font_options_tExterns
{
}

public struct cairo_font_options_t
{
}
