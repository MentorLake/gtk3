namespace MentorLake.Gio;


public class GFileIOStreamClassHandle : BaseSafeHandle
{
}


public static class GFileIOStreamClassExtensions
{

	public static GFileIOStreamClass Dereference(this GFileIOStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileIOStreamClass>(x.DangerousGetHandle());
}
internal class GFileIOStreamClassExterns
{
}


public struct GFileIOStreamClass
{
	
public GIOStreamClass parent_class;
	
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
