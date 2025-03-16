namespace MentorLake.Gio;

public class GFileOutputStreamClassHandle : BaseSafeHandle
{
}


public static class GFileOutputStreamClassExtensions
{

	public static GFileOutputStreamClass Dereference(this GFileOutputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileOutputStreamClass>(x.DangerousGetHandle());
}
internal class GFileOutputStreamClassExterns
{
}

public struct GFileOutputStreamClass
{
	public GOutputStreamClass parent_class;
	public IntPtr tell;
	public IntPtr can_seek;
	public IntPtr seek;
	public IntPtr can_truncate;
	public IntPtr truncate_fn;
	public IntPtr query_info;
	public IntPtr query_info_async;
	public IntPtr query_info_finish;
	public IntPtr get_etag;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}
