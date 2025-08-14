namespace MentorLake.Atk;

/// <summary>
/// <para>
/// A structure used to store a rectangle used by AtkText.
/// </para>
/// </summary>

public class AtkTextRectangleHandle : BaseSafeHandle
{
}


public static class AtkTextRectangleExtensions
{

	public static AtkTextRectangle Dereference(this AtkTextRectangleHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkTextRectangle>(x.DangerousGetHandle());
}
internal class AtkTextRectangleExterns
{
}

/// <summary>
/// <para>
/// A structure used to store a rectangle used by AtkText.
/// </para>
/// </summary>

public struct AtkTextRectangle
{
	/// <summary>
/// <para>
/// The horizontal coordinate of a rectangle
/// </para>
/// </summary>

public int x;
	/// <summary>
/// <para>
/// The vertical coordinate of a rectangle
/// </para>
/// </summary>

public int y;
	/// <summary>
/// <para>
/// The width of a rectangle
/// </para>
/// </summary>

public int width;
	/// <summary>
/// <para>
/// The height of a rectangle
/// </para>
/// </summary>

public int height;
}
