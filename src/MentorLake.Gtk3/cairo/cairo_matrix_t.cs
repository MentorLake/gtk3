namespace MentorLake.cairo;

public class cairo_matrix_tHandle : BaseSafeHandle
{
}


public static class cairo_matrix_tExtensions
{

	public static cairo_matrix_t Dereference(this cairo_matrix_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_matrix_t>(x.DangerousGetHandle());
}
internal class cairo_matrix_tExterns
{
}

public struct cairo_matrix_t
{
	public double xx;
	public double yx;
	public double xy;
	public double yy;
	public double x0;
	public double y0;
}
