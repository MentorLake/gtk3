namespace MentorLake.Gio;


public class GFileEnumeratorClassHandle : BaseSafeHandle
{
}


public static class GFileEnumeratorClassExtensions
{

	public static GFileEnumeratorClass Dereference(this GFileEnumeratorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileEnumeratorClass>(x.DangerousGetHandle());
}
internal class GFileEnumeratorClassExterns
{
}


public struct GFileEnumeratorClass
{
	
public GObjectClass parent_class;
	
public IntPtr next_file;
	
public IntPtr close_fn;
	
public IntPtr next_files_async;
	
public IntPtr next_files_finish;
	
public IntPtr close_async;
	
public IntPtr close_finish;
	
public IntPtr _g_reserved1;
	
public IntPtr _g_reserved2;
	
public IntPtr _g_reserved3;
	
public IntPtr _g_reserved4;
	
public IntPtr _g_reserved5;
	
public IntPtr _g_reserved6;
	
public IntPtr _g_reserved7;
}
