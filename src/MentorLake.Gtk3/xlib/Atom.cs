namespace MentorLake.xlib;


public struct Atom
{
	public ulong Value;
}


public class AtomHandle : BaseSafeHandle
{
}

public static class AtomHandleExtensions
{
	public static Atom Dereference(this AtomHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<Atom>(x.DangerousGetHandle());
	public static ulong DereferenceValue(this AtomHandle x) => x.Dereference().Value;
}
