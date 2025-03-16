namespace MentorLake.cairo;

public class cairo_region_tHandle : BaseSafeHandle
{
}


public static class cairo_region_tExtensions
{

	public static cairo_region_t Dereference(this cairo_region_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_region_t>(x.DangerousGetHandle());
}
internal class cairo_region_tExterns
{
}

public struct cairo_region_t
{
}
