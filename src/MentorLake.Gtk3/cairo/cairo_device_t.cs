namespace MentorLake.cairo;

public class cairo_device_tHandle : BaseSafeHandle
{
}


public static class cairo_device_tExtensions
{

	public static cairo_device_t Dereference(this cairo_device_tHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<cairo_device_t>(x.DangerousGetHandle());
}
internal class cairo_device_tExterns
{
}

public struct cairo_device_t
{
}
