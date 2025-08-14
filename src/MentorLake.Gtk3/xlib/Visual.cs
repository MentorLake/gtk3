namespace MentorLake.xlib;


public class VisualHandle : BaseSafeHandle
{
}


public static class VisualExtensions
{

	public static Visual Dereference(this VisualHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<Visual>(x.DangerousGetHandle());
}
internal class VisualExterns
{
}


public struct Visual
{
}
