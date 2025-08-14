namespace MentorLake.Gio;


public class GDataInputStreamClassHandle : BaseSafeHandle
{
}


public static class GDataInputStreamClassExtensions
{

	public static GDataInputStreamClass Dereference(this GDataInputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDataInputStreamClass>(x.DangerousGetHandle());
}
internal class GDataInputStreamClassExterns
{
}


public struct GDataInputStreamClass
{
	
public GBufferedInputStreamClass parent_class;
	
public IntPtr _g_reserved1;
	
public IntPtr _g_reserved2;
	
public IntPtr _g_reserved3;
	
public IntPtr _g_reserved4;
	
public IntPtr _g_reserved5;
}
