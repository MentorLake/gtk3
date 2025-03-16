namespace MentorLake.Gio;

public class GPollableInputStreamInterfaceHandle : BaseSafeHandle
{
}


public static class GPollableInputStreamInterfaceExtensions
{

	public static GPollableInputStreamInterface Dereference(this GPollableInputStreamInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPollableInputStreamInterface>(x.DangerousGetHandle());
}
internal class GPollableInputStreamInterfaceExterns
{
}

public struct GPollableInputStreamInterface
{
	public GTypeInterface g_iface;
	public IntPtr can_poll;
	public IntPtr is_readable;
	public IntPtr create_source;
	public IntPtr read_nonblocking;
}
