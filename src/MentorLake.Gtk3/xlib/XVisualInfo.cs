namespace MentorLake.xlib;

public class XVisualInfoHandle : BaseSafeHandle
{
}


public static class XVisualInfoExtensions
{

	public static XVisualInfo Dereference(this XVisualInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XVisualInfo>(x.DangerousGetHandle());
}
internal class XVisualInfoExterns
{
}

public struct XVisualInfo
{
}
