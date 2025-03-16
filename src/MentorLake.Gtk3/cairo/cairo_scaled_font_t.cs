namespace MentorLake.cairo;

public class cairo_scaled_font_tHandle : BaseSafeHandle
{
}


public static class cairo_scaled_font_tExtensions
{

	public static cairo_scaled_font_t Dereference(this cairo_scaled_font_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_scaled_font_t>(x.DangerousGetHandle());
}
internal class cairo_scaled_font_tExterns
{
}

public struct cairo_scaled_font_t
{
}
