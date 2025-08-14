namespace MentorLake.cairo;

/// <summary>
/// <para>
/// A data structure for holding a rectangle with integer coordinates.
/// </para>
/// </summary>

public class cairo_rectangle_int_tHandle : BaseSafeHandle
{
}


public static class cairo_rectangle_int_tExtensions
{

	public static cairo_rectangle_int_t Dereference(this cairo_rectangle_int_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_rectangle_int_t>(x.DangerousGetHandle());
}
internal class cairo_rectangle_int_tExterns
{
}

/// <summary>
/// <para>
/// A data structure for holding a rectangle with integer coordinates.
/// </para>
/// </summary>

public struct cairo_rectangle_int_t
{
	/// <summary>
/// <para>
/// X coordinate of the left side of the rectangle
/// </para>
/// </summary>

public int x;
	/// <summary>
/// <para>
/// Y coordinate of the the top side of the rectangle
/// </para>
/// </summary>

public int y;
	/// <summary>
/// <para>
/// width of the rectangle
/// </para>
/// </summary>

public int width;
	/// <summary>
/// <para>
/// height of the rectangle
/// </para>
/// </summary>

public int height;
}
