namespace MentorLake.xrandr;


public class XRROutputChangeNotifyEventHandle : BaseSafeHandle
{
}


public static class XRROutputChangeNotifyEventExtensions
{

	public static XRROutputChangeNotifyEvent Dereference(this XRROutputChangeNotifyEventHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XRROutputChangeNotifyEvent>(x.DangerousGetHandle());
}
internal class XRROutputChangeNotifyEventExterns
{
}


public struct XRROutputChangeNotifyEvent
{
}
