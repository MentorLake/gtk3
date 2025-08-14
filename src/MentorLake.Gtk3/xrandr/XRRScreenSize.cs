namespace MentorLake.xrandr;


public class XRRScreenSizeHandle : BaseSafeHandle
{
}


public static class XRRScreenSizeExtensions
{

	public static XRRScreenSize Dereference(this XRRScreenSizeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XRRScreenSize>(x.DangerousGetHandle());
}
internal class XRRScreenSizeExterns
{
}


public struct XRRScreenSize
{
}
