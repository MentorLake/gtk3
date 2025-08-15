namespace MentorLake.xlib;


public struct VisualID
{
	public ulong Value;
}


public class VisualIDHandle : BaseSafeHandle
{
}

public static class VisualIDHandleExtensions
{
	public static VisualID Dereference(this VisualIDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VisualID>(x.DangerousGetHandle());
	public static ulong DereferenceValue(this VisualIDHandle x) => x.Dereference().Value;
}
