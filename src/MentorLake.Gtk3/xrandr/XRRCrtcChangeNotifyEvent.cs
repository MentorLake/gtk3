namespace MentorLake.xrandr;


public class XRRCrtcChangeNotifyEventHandle : BaseSafeHandle
{
}


public static class XRRCrtcChangeNotifyEventExtensions
{

	public static XRRCrtcChangeNotifyEvent Dereference(this XRRCrtcChangeNotifyEventHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XRRCrtcChangeNotifyEvent>(x.DangerousGetHandle());
}
internal class XRRCrtcChangeNotifyEventExterns
{
}


public struct XRRCrtcChangeNotifyEvent
{
}
