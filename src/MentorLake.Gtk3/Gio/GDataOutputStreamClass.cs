namespace MentorLake.Gio;

public class GDataOutputStreamClassHandle : BaseSafeHandle
{
}


public static class GDataOutputStreamClassExtensions
{

	public static GDataOutputStreamClass Dereference(this GDataOutputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDataOutputStreamClass>(x.DangerousGetHandle());
}
internal class GDataOutputStreamClassExterns
{
}

public struct GDataOutputStreamClass
{
	public GFilterOutputStreamClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}
