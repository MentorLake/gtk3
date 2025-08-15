namespace MentorLake.xlib;


public struct Picture
{
	public ulong Value;
}


public class PictureHandle : BaseSafeHandle
{
}

public static class PictureHandleExtensions
{
	public static Picture Dereference(this PictureHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<Picture>(x.DangerousGetHandle());
	public static ulong DereferenceValue(this PictureHandle x) => x.Dereference().Value;
}
