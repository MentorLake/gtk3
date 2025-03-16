namespace MentorLake.cairo;

public class cairo_pattern_tHandle : BaseSafeHandle
{
}


public static class cairo_pattern_tExtensions
{

	public static cairo_pattern_t Dereference(this cairo_pattern_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_pattern_t>(x.DangerousGetHandle());
}
internal class cairo_pattern_tExterns
{
}

public struct cairo_pattern_t
{
}
