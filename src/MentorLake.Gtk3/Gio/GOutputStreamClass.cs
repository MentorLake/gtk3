namespace MentorLake.Gio;

public class GOutputStreamClassHandle : BaseSafeHandle
{
}


public static class GOutputStreamClassExtensions
{

	public static GOutputStreamClass Dereference(this GOutputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GOutputStreamClass>(x.DangerousGetHandle());
}
internal class GOutputStreamClassExterns
{
}

public struct GOutputStreamClass
{
	public GObjectClass parent_class;
	public IntPtr write_fn;
	public IntPtr splice;
	public IntPtr flush;
	public IntPtr close_fn;
	public IntPtr write_async;
	public IntPtr write_finish;
	public IntPtr splice_async;
	public IntPtr splice_finish;
	public IntPtr flush_async;
	public IntPtr flush_finish;
	public IntPtr close_async;
	public IntPtr close_finish;
	public IntPtr writev_fn;
	public IntPtr writev_async;
	public IntPtr writev_finish;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
	public IntPtr _g_reserved7;
	public IntPtr _g_reserved8;
}
