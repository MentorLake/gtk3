namespace MentorLake.xrandr;

public class XRROutputPropertyNotifyEventHandle : BaseSafeHandle
{
}


public static class XRROutputPropertyNotifyEventExtensions
{

	public static XRROutputPropertyNotifyEvent Dereference(this XRROutputPropertyNotifyEventHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XRROutputPropertyNotifyEvent>(x.DangerousGetHandle());
}
internal class XRROutputPropertyNotifyEventExterns
{
}

public struct XRROutputPropertyNotifyEvent
{
}
