namespace MentorLake.Gio;

public class GSeekableIfaceHandle : BaseSafeHandle
{
}


public static class GSeekableIfaceExtensions
{

	public static GSeekableIface Dereference(this GSeekableIfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSeekableIface>(x.DangerousGetHandle());
}
internal class GSeekableIfaceExterns
{
}

public struct GSeekableIface
{
	public GTypeInterface g_iface;
	public IntPtr tell;
	public IntPtr can_seek;
	public IntPtr seek;
	public IntPtr can_truncate;
	public IntPtr truncate_fn;
}
