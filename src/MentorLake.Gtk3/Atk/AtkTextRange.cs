namespace MentorLake.Gtk3.Atk;

public class AtkTextRangeHandle : BaseSafeHandle
{
}


public static class AtkTextRangeHandleExtensions
{
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
