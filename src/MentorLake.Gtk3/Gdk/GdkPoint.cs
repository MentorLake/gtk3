namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Defines the x and y coordinates of a point.
/// </para>
/// </summary>

public class GdkPointHandle : BaseSafeHandle
{
}


public static class GdkPointExtensions
{

	public static GdkPoint Dereference(this GdkPointHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkPoint>(x.DangerousGetHandle());
}
internal class GdkPointExterns
{
}

/// <summary>
/// <para>
/// Defines the x and y coordinates of a point.
/// </para>
/// </summary>

public struct GdkPoint
{
	/// <summary>
/// <para>
/// the x coordinate of the point.
/// </para>
/// </summary>

public int x;
	/// <summary>
/// <para>
/// the y coordinate of the point.
/// </para>
/// </summary>

public int y;
}
