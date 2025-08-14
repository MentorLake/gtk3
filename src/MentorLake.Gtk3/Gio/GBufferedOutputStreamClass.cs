namespace MentorLake.Gio;


public class GBufferedOutputStreamClassHandle : BaseSafeHandle
{
}


public static class GBufferedOutputStreamClassExtensions
{

	public static GBufferedOutputStreamClass Dereference(this GBufferedOutputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GBufferedOutputStreamClass>(x.DangerousGetHandle());
}
internal class GBufferedOutputStreamClassExterns
{
}


public struct GBufferedOutputStreamClass
{
	
public GFilterOutputStreamClass parent_class;
	
public IntPtr _g_reserved1;
	
public IntPtr _g_reserved2;
}
