namespace MentorLake.Gio;

public class GInputStreamClassHandle : BaseSafeHandle
{
}


public static class GInputStreamClassExtensions
{

	public static GInputStreamClass Dereference(this GInputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInputStreamClass>(x.DangerousGetHandle());
}
internal class GInputStreamClassExterns
{
}

public struct GInputStreamClass
{
	public GObjectClass parent_class;
	public IntPtr read_fn;
	public IntPtr skip;
	public IntPtr close_fn;
	public IntPtr read_async;
	public IntPtr read_finish;
	public IntPtr skip_async;
	public IntPtr skip_finish;
	public IntPtr close_async;
	public IntPtr close_finish;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}
