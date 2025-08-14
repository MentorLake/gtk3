namespace MentorLake.cairo;

/// <summary>
/// <para>
/// A data structure for holding a rectangle.
/// </para>
/// </summary>

public class cairo_rectangle_tHandle : BaseSafeHandle
{
}


public static class cairo_rectangle_tExtensions
{

	public static cairo_rectangle_t Dereference(this cairo_rectangle_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_rectangle_t>(x.DangerousGetHandle());
}
internal class cairo_rectangle_tExterns
{
}

/// <summary>
/// <para>
/// A data structure for holding a rectangle.
/// </para>
/// </summary>

public struct cairo_rectangle_t
{
	/// <summary>
/// <para>
/// X coordinate of the left side of the rectangle
/// </para>
/// </summary>

public double x;
	/// <summary>
/// <para>
/// Y coordinate of the the top side of the rectangle
/// </para>
/// </summary>

public double y;
	/// <summary>
/// <para>
/// width of the rectangle
/// </para>
/// </summary>

public double width;
	/// <summary>
/// <para>
/// height of the rectangle
/// </para>
/// </summary>

public double height;
}
