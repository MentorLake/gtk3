namespace MentorLake.xlib;

public class XWindowAttributesHandle : BaseSafeHandle
{
}


public static class XWindowAttributesExtensions
{

	public static XWindowAttributes Dereference(this XWindowAttributesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XWindowAttributes>(x.DangerousGetHandle());
}
internal class XWindowAttributesExterns
{
}

public struct XWindowAttributes
{
}
