namespace MentorLake.Atk;

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

public struct AtkTextRange
{
	public AtkTextRectangle bounds;
	public int start_offset;
	public int end_offset;
	public string content;
}
