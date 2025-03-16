namespace MentorLake.GioUnix;

public class GFileDescriptorBasedIfaceHandle : BaseSafeHandle
{
}


public static class GFileDescriptorBasedIfaceExtensions
{

	public static GFileDescriptorBasedIface Dereference(this GFileDescriptorBasedIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileDescriptorBasedIface>(x.DangerousGetHandle());
}
internal class GFileDescriptorBasedIfaceExterns
{
}

public struct GFileDescriptorBasedIface
{
	public GTypeInterface g_iface;
	public IntPtr get_fd;
}
