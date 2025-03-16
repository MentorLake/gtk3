namespace MentorLake.cairo;

public class cairo_surface_tHandle : BaseSafeHandle
{
}


public static class cairo_surface_tExtensions
{

	public static cairo_surface_t Dereference(this cairo_surface_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_surface_t>(x.DangerousGetHandle());
}
internal class cairo_surface_tExterns
{
}

public struct cairo_surface_t
{
}
