namespace MentorLake.Atk;

public class AtkTextSelectionHandle : BaseSafeHandle
{
}


public static class AtkTextSelectionExtensions
{

	public static AtkTextSelection Dereference(this AtkTextSelectionHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkTextSelection>(x.DangerousGetHandle());
}
internal class AtkTextSelectionExterns
{
}

public struct AtkTextSelection
{
	public IntPtr start_object;
	public int start_offset;
	public IntPtr end_object;
	public int end_offset;
	public bool start_is_active;
}
