namespace MentorLake.xlib;


public class XTrapezoidHandle : BaseSafeHandle
{
}


public static class XTrapezoidExtensions
{

	public static XTrapezoid Dereference(this XTrapezoidHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XTrapezoid>(x.DangerousGetHandle());
}
internal class XTrapezoidExterns
{
}


public struct XTrapezoid
{
}
