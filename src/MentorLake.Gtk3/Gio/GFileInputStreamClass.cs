namespace MentorLake.Gio;


public class GFileInputStreamClassHandle : BaseSafeHandle
{
}


public static class GFileInputStreamClassExtensions
{

	public static GFileInputStreamClass Dereference(this GFileInputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileInputStreamClass>(x.DangerousGetHandle());
}
internal class GFileInputStreamClassExterns
{
}


public struct GFileInputStreamClass
{
	
public GInputStreamClass parent_class;
	
public IntPtr tell;
	
public IntPtr can_seek;
	
public IntPtr seek;
	
public IntPtr query_info;
	
public IntPtr query_info_async;
	
public IntPtr query_info_finish;
	
public IntPtr _g_reserved1;
	
public IntPtr _g_reserved2;
	
public IntPtr _g_reserved3;
	
public IntPtr _g_reserved4;
	
public IntPtr _g_reserved5;
}
