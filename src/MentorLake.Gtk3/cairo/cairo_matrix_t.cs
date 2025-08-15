namespace MentorLake.cairo;

/// <summary>
/// <para>
/// A #cairo_matrix_t holds an affine transformation, such as a scale,
/// rotation, shear, or a combination of those. The transformation of
/// a point (x, y) is given by:
/// &amp;lt;programlisting&amp;gt;
///     x_new = xx * x + xy * y + x0;
///     y_new = yx * x + yy * y + y0;
/// &amp;lt;/programlisting&amp;gt;
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// A #cairo_matrix_t holds an affine transformation, such as a scale,
/// rotation, shear, or a combination of those. The transformation of
/// a point (x, y) is given by:
/// &amp;lt;programlisting&amp;gt;
///     x_new = xx * x + xy * y + x0;
///     y_new = yx * x + yy * y + y0;
/// &amp;lt;/programlisting&amp;gt;
/// </para>
/// </summary>

public struct cairo_matrix_t
{
	/// <summary>
/// <para>
/// xx component of the affine transformation
/// </para>
/// </summary>

public double xx;
	/// <summary>
/// <para>
/// yx component of the affine transformation
/// </para>
/// </summary>

public double yx;
	/// <summary>
/// <para>
/// xy component of the affine transformation
/// </para>
/// </summary>

public double xy;
	/// <summary>
/// <para>
/// yy component of the affine transformation
/// </para>
/// </summary>

public double yy;
	/// <summary>
/// <para>
/// X translation component of the affine transformation
/// </para>
/// </summary>

public double x0;
	/// <summary>
/// <para>
/// Y translation component of the affine transformation
/// </para>
/// </summary>

public double y0;
}
