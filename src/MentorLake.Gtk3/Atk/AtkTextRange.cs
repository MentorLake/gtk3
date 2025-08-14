namespace MentorLake.Atk;

/// <summary>
/// <para>
/// A structure used to describe a text range.
/// </para>
/// </summary>

public class AtkTextRangeHandle : BaseSafeHandle
{
}


public static class AtkTextRangeExtensions
{

	public static AtkTextRange Dereference(this AtkTextRangeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkTextRange>(x.DangerousGetHandle());
}
internal class AtkTextRangeExterns
{
}

/// <summary>
/// <para>
/// A structure used to describe a text range.
/// </para>
/// </summary>

public struct AtkTextRange
{
	/// <summary>
/// <para>
/// A rectangle giving the bounds of the text range
/// </para>
/// </summary>

public AtkTextRectangle bounds;
	/// <summary>
/// <para>
/// The start offset of a AtkTextRange
/// </para>
/// </summary>

public int start_offset;
	/// <summary>
/// <para>
/// The end offset of a AtkTextRange
/// </para>
/// </summary>

public int end_offset;
	/// <summary>
/// <para>
/// The text in the text range
/// </para>
/// </summary>

public string content;
}
