namespace MentorLake.xrandr;

public class XRRNotifyEventHandle : BaseSafeHandle
{
}


public static class XRRNotifyEventExtensions
{

	public static XRRNotifyEvent Dereference(this XRRNotifyEventHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XRRNotifyEvent>(x.DangerousGetHandle());
}
internal class XRRNotifyEventExterns
{
}

public struct XRRNotifyEvent
{
}
