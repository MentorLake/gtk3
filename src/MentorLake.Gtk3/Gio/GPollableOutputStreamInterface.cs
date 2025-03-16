namespace MentorLake.Gio;

public class GPollableOutputStreamInterfaceHandle : BaseSafeHandle
{
}


public static class GPollableOutputStreamInterfaceExtensions
{

	public static GPollableOutputStreamInterface Dereference(this GPollableOutputStreamInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPollableOutputStreamInterface>(x.DangerousGetHandle());
}
internal class GPollableOutputStreamInterfaceExterns
{
}

public struct GPollableOutputStreamInterface
{
	public GTypeInterface g_iface;
	public IntPtr can_poll;
	public IntPtr is_writable;
	public IntPtr create_source;
	public IntPtr write_nonblocking;
	public IntPtr writev_nonblocking;
}
