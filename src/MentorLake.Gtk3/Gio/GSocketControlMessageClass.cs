namespace MentorLake.Gio;

public class GSocketControlMessageClassHandle : BaseSafeHandle
{
}


public static class GSocketControlMessageClassExtensions
{

	public static GSocketControlMessageClass Dereference(this GSocketControlMessageClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketControlMessageClass>(x.DangerousGetHandle());
}
internal class GSocketControlMessageClassExterns
{
}

public struct GSocketControlMessageClass
{
	public GObjectClass parent_class;
	public IntPtr get_size;
	public IntPtr get_level;
	public IntPtr get_type;
	public IntPtr serialize;
	public IntPtr deserialize;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}
