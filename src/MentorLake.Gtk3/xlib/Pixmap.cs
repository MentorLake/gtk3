namespace MentorLake.xlib;


public struct Pixmap
{
	public ulong Value;
}


public class PixmapHandle : BaseSafeHandle
{
}

public static class PixmapHandleExtensions
{
	public static Pixmap Dereference(this PixmapHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<Pixmap>(x.DangerousGetHandle());
	public static ulong DereferenceValue(this PixmapHandle x) => x.Dereference().Value;
}
