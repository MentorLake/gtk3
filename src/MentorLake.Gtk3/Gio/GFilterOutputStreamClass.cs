namespace MentorLake.Gio;


public class GFilterOutputStreamClassHandle : BaseSafeHandle
{
}


public static class GFilterOutputStreamClassExtensions
{

	public static GFilterOutputStreamClass Dereference(this GFilterOutputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFilterOutputStreamClass>(x.DangerousGetHandle());
}
internal class GFilterOutputStreamClassExterns
{
}


public struct GFilterOutputStreamClass
{
	
public GOutputStreamClass parent_class;
	
public IntPtr _g_reserved1;
	
public IntPtr _g_reserved2;
	
public IntPtr _g_reserved3;
}
