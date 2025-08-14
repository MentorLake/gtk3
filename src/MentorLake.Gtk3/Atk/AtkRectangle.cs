namespace MentorLake.Atk;

/// <summary>
/// <para>
/// A data structure for holding a rectangle. Those coordinates are
/// relative to the component top-level parent.
/// </para>
/// </summary>

public class AtkRectangleHandle : BaseSafeHandle
{
}


public static class AtkRectangleExtensions
{

	public static AtkRectangle Dereference(this AtkRectangleHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkRectangle>(x.DangerousGetHandle());
}
internal class AtkRectangleExterns
{
}

/// <summary>
/// <para>
/// A data structure for holding a rectangle. Those coordinates are
/// relative to the component top-level parent.
/// </para>
/// </summary>

public struct AtkRectangle
{
	/// <summary>
/// <para>
/// X coordinate of the left side of the rectangle.
/// </para>
/// </summary>

public int x;
	/// <summary>
/// <para>
/// Y coordinate of the top side of the rectangle.
/// </para>
/// </summary>

public int y;
	/// <summary>
/// <para>
/// width of the rectangle.
/// </para>
/// </summary>

public int width;
	/// <summary>
/// <para>
/// height of the rectangle.
/// </para>
/// </summary>

public int height;
}
