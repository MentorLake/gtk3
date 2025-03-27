namespace MentorLake.xlib;

public struct Colormap
{
	public ulong Value;
}

public class ColormapHandle : BaseSafeHandle
{
}

public static class ColormapHandleExtensions
{
	public static Colormap Dereference(this ColormapHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<Colormap>(x.DangerousGetHandle());
	public static ulong DereferenceValue(this ColormapHandle x) => x.Dereference().Value;
}
