namespace MentorLake.GioUnix;


public class GUnixInputStreamClassHandle : BaseSafeHandle
{
}


public static class GUnixInputStreamClassExtensions
{

	public static GUnixInputStreamClass Dereference(this GUnixInputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixInputStreamClass>(x.DangerousGetHandle());
}
internal class GUnixInputStreamClassExterns
{
}


public struct GUnixInputStreamClass
{
	
public GInputStreamClass parent_class;
	
public IntPtr _g_reserved1;
	
public IntPtr _g_reserved2;
	
public IntPtr _g_reserved3;
	
public IntPtr _g_reserved4;
	
public IntPtr _g_reserved5;
}
