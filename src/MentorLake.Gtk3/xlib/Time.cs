namespace MentorLake.xlib;


public struct Time
{
	public ulong Value;
}

public class TimeHandle : BaseSafeHandle
{
}

public static class TimeHandleExtensions
{
	public static Time Dereference(this TimeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<Time>(x.DangerousGetHandle());
	public static ulong DereferenceValue(this TimeHandle x) => x.Dereference().Value;
}
