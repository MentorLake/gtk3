namespace MentorLake.xlib;


public class XFontStructHandle : BaseSafeHandle
{
}


public static class XFontStructExtensions
{

	public static XFontStruct Dereference(this XFontStructHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XFontStruct>(x.DangerousGetHandle());
}
internal class XFontStructExterns
{
}


public struct XFontStruct
{
}
