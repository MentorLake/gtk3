namespace MentorLake.Gio;

public class GDatagramBasedInterfaceHandle : BaseSafeHandle
{
}


public static class GDatagramBasedInterfaceExtensions
{

	public static GDatagramBasedInterface Dereference(this GDatagramBasedInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDatagramBasedInterface>(x.DangerousGetHandle());
}
internal class GDatagramBasedInterfaceExterns
{
}

public struct GDatagramBasedInterface
{
	public GTypeInterface g_iface;
	public IntPtr receive_messages;
	public IntPtr send_messages;
	public IntPtr create_source;
	public IntPtr condition_check;
	public IntPtr condition_wait;
}
