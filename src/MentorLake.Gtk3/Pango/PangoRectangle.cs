namespace MentorLake.Pango;

/// <summary>
/// <para>
/// The `PangoRectangle` structure represents a rectangle.
/// </para>
/// <para>
/// `PangoRectangle` is frequently used to represent the logical or ink
/// extents of a single glyph or section of text. (See, for instance,
/// [method@Pango.Font.get_glyph_extents].)
/// </para>
/// </summary>

public class PangoRectangleHandle : BaseSafeHandle
{
}


public static class PangoRectangleExtensions
{

	public static PangoRectangle Dereference(this PangoRectangleHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoRectangle>(x.DangerousGetHandle());
}
internal class PangoRectangleExterns
{
}

/// <summary>
/// <para>
/// The `PangoRectangle` structure represents a rectangle.
/// </para>
/// <para>
/// `PangoRectangle` is frequently used to represent the logical or ink
/// extents of a single glyph or section of text. (See, for instance,
/// [method@Pango.Font.get_glyph_extents].)
/// </para>
/// </summary>

public struct PangoRectangle
{
	/// <summary>
/// <para>
/// X coordinate of the left side of the rectangle.
/// </para>
/// </summary>

public int x;
	/// <summary>
/// <para>
/// Y coordinate of the the top side of the rectangle.
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
