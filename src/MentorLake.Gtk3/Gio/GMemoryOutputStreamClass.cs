namespace MentorLake.Gio;

public class GMemoryOutputStreamClassHandle : BaseSafeHandle
{
}


public static class GMemoryOutputStreamClassExtensions
{

	public static GMemoryOutputStreamClass Dereference(this GMemoryOutputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMemoryOutputStreamClass>(x.DangerousGetHandle());
}
internal class GMemoryOutputStreamClassExterns
{
}

public struct GMemoryOutputStreamClass
{
	public GOutputStreamClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}
