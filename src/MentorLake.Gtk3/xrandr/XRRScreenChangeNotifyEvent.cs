namespace MentorLake.xrandr;

public class XRRScreenChangeNotifyEventHandle : BaseSafeHandle
{
}


public static class XRRScreenChangeNotifyEventExtensions
{

	public static XRRScreenChangeNotifyEvent Dereference(this XRRScreenChangeNotifyEventHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XRRScreenChangeNotifyEvent>(x.DangerousGetHandle());
}
internal class XRRScreenChangeNotifyEventExterns
{
}

public struct XRRScreenChangeNotifyEvent
{
}
