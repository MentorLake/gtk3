namespace MentorLake.xlib;

public struct Drawable
{
	public ulong Value;
}

public class DrawableHandle : BaseSafeHandle
{
}

public static class DrawableHandleExtensions
{
	public static Drawable Dereference(this DrawableHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<Drawable>(x.DangerousGetHandle());
	public static ulong DereferenceValue(this DrawableHandle x) => x.Dereference().Value;
}
