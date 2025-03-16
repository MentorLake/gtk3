namespace MentorLake.Gio;

public class GFilterInputStreamClassHandle : BaseSafeHandle
{
}


public static class GFilterInputStreamClassExtensions
{

	public static GFilterInputStreamClass Dereference(this GFilterInputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFilterInputStreamClass>(x.DangerousGetHandle());
}
internal class GFilterInputStreamClassExterns
{
}

public struct GFilterInputStreamClass
{
	public GInputStreamClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
}
