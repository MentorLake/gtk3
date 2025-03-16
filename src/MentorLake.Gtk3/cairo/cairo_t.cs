namespace MentorLake.cairo;

public class cairo_tHandle : BaseSafeHandle
{
}


public static class cairo_tExtensions
{

	public static cairo_t Dereference(this cairo_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_t>(x.DangerousGetHandle());
}
internal class cairo_tExterns
{
}

public struct cairo_t
{
}
