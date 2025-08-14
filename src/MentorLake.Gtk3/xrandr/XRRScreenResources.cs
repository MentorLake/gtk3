namespace MentorLake.xrandr;


public class XRRScreenResourcesHandle : BaseSafeHandle
{
}


public static class XRRScreenResourcesExtensions
{

	public static XRRScreenResources Dereference(this XRRScreenResourcesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<XRRScreenResources>(x.DangerousGetHandle());
}
internal class XRRScreenResourcesExterns
{
}


public struct XRRScreenResources
{
}
