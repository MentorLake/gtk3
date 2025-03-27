namespace MentorLake.xlib;

public struct XID
{
	public ulong Value;
}

public class XIDHandle : BaseSafeHandle
{
}

public static class XIDHandleExtensions
{
	public static XID Dereference(this XIDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XID>(x.DangerousGetHandle());
	public static ulong DereferenceValue(this XIDHandle x) => x.Dereference().Value;
}
