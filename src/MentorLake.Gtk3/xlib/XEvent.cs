namespace MentorLake.xlib;

public class XEventHandle : BaseSafeHandle
{
}


public static class XEventExtensions
{

	public static XEvent Dereference(this XEventHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XEvent>(x.DangerousGetHandle());
}
internal class XEventExterns
{
}

public struct XEvent
{
}
