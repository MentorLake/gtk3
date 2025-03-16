namespace MentorLake.Gio;

public class GConverterOutputStreamClassHandle : BaseSafeHandle
{
}


public static class GConverterOutputStreamClassExtensions
{

	public static GConverterOutputStreamClass Dereference(this GConverterOutputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GConverterOutputStreamClass>(x.DangerousGetHandle());
}
internal class GConverterOutputStreamClassExterns
{
}

public struct GConverterOutputStreamClass
{
	public GFilterOutputStreamClass parent_class;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
}
