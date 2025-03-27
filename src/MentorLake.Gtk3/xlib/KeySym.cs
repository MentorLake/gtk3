namespace MentorLake.xlib;

public struct KeySym
{
	public ulong Value;
}

public class KeySymHandle : BaseSafeHandle
{
}

public static class KeySymHandleExtensions
{
	public static KeySym Dereference(this KeySymHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<KeySym>(x.DangerousGetHandle());
	public static ulong DereferenceValue(this KeySymHandle x) => x.Dereference().Value;
}
