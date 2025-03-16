namespace MentorLake.xlib;

public class XImageHandle : BaseSafeHandle
{
}


public static class XImageExtensions
{

	public static XImage Dereference(this XImageHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XImage>(x.DangerousGetHandle());
}
internal class XImageExterns
{
}

public struct XImage
{
}
