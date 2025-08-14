namespace MentorLake.xlib;


public class XConfigureEventHandle : BaseSafeHandle
{
}


public static class XConfigureEventExtensions
{

	public static XConfigureEvent Dereference(this XConfigureEventHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XConfigureEvent>(x.DangerousGetHandle());
}
internal class XConfigureEventExterns
{
}


public struct XConfigureEvent
{
}
