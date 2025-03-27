namespace MentorLake.xlib;

public struct Window
{
	public ulong Value;
}

public class WindowHandle : BaseSafeHandle
{
}

public static class WindowHandleExtensions
{
	public static Window Dereference(this WindowHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<Window>(x.DangerousGetHandle());
	public static ulong DereferenceValue(this WindowHandle x) => x.Dereference().Value;
}
