namespace MentorLake.xlib;

public struct Cursor
{
	public ulong Value;
}

public class CursorHandle : BaseSafeHandle
{
}

public static class CursorHandleExtensions
{
	public static Cursor Dereference(this CursorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<Cursor>(x.DangerousGetHandle());
	public static ulong DereferenceValue(this CursorHandle x) => x.Dereference().Value;
}
