namespace MentorLake.GioUnix;

public class GUnixOutputStreamClassHandle : BaseSafeHandle
{
}


public static class GUnixOutputStreamClassExtensions
{

	public static GUnixOutputStreamClass Dereference(this GUnixOutputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixOutputStreamClass>(x.DangerousGetHandle());
}
internal class GUnixOutputStreamClassExterns
{
}

public struct GUnixOutputStreamClass
{
	public GOutputStreamClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}
