namespace MentorLake.Gio;


public class GIOStreamClassHandle : BaseSafeHandle
{
}


public static class GIOStreamClassExtensions
{

	public static GIOStreamClass Dereference(this GIOStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GIOStreamClass>(x.DangerousGetHandle());
}
internal class GIOStreamClassExterns
{
}


public struct GIOStreamClass
{
	
public GObjectClass parent_class;
	
public IntPtr get_input_stream;
	
public IntPtr get_output_stream;
	
public IntPtr close_fn;
	
public IntPtr close_async;
	
public IntPtr close_finish;
	
public IntPtr _g_reserved1;
	
public IntPtr _g_reserved2;
	
public IntPtr _g_reserved3;
	
public IntPtr _g_reserved4;
	
public IntPtr _g_reserved5;
	
public IntPtr _g_reserved6;
	
public IntPtr _g_reserved7;
	
public IntPtr _g_reserved8;
	
public IntPtr _g_reserved9;
	
public IntPtr _g_reserved10;
}
