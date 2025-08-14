namespace MentorLake.cairo;

/// <summary>
/// <para>
/// A data structure for holding a dynamically allocated
/// array of rectangles.
/// </para>
/// </summary>

public class cairo_rectangle_list_tHandle : BaseSafeHandle
{
}


public static class cairo_rectangle_list_tExtensions
{

	public static cairo_rectangle_list_t Dereference(this cairo_rectangle_list_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_rectangle_list_t>(x.DangerousGetHandle());
}
internal class cairo_rectangle_list_tExterns
{
}

/// <summary>
/// <para>
/// A data structure for holding a dynamically allocated
/// array of rectangles.
/// </para>
/// </summary>

public struct cairo_rectangle_list_t
{
	/// <summary>
/// <para>
/// Error status of the rectangle list
/// </para>
/// </summary>

public cairo_status_t status;
	/// <summary>
/// <para>
/// Array containing the rectangles
/// </para>
/// </summary>

public IntPtr rectangles;
	/// <summary>
/// <para>
/// Number of rectangles in this list
/// </para>
/// </summary>

public int num_rectangles;
}
