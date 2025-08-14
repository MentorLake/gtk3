namespace MentorLake.Gio;


public class GMemoryInputStreamClassHandle : BaseSafeHandle
{
}


public static class GMemoryInputStreamClassExtensions
{

	public static GMemoryInputStreamClass Dereference(this GMemoryInputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMemoryInputStreamClass>(x.DangerousGetHandle());
}
internal class GMemoryInputStreamClassExterns
{
}


public struct GMemoryInputStreamClass
{
	
public GInputStreamClass parent_class;
	
public IntPtr _g_reserved1;
	
public IntPtr _g_reserved2;
	
public IntPtr _g_reserved3;
	
public IntPtr _g_reserved4;
	
public IntPtr _g_reserved5;
}
