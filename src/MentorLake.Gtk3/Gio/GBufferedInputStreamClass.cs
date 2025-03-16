namespace MentorLake.Gio;

public class GBufferedInputStreamClassHandle : BaseSafeHandle
{
}


public static class GBufferedInputStreamClassExtensions
{

	public static GBufferedInputStreamClass Dereference(this GBufferedInputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GBufferedInputStreamClass>(x.DangerousGetHandle());
}
internal class GBufferedInputStreamClassExterns
{
}

public struct GBufferedInputStreamClass
{
	public GFilterInputStreamClass parent_class;
	public IntPtr fill;
	public IntPtr fill_async;
	public IntPtr fill_finish;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}
