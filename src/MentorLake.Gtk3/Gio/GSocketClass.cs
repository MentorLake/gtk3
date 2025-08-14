namespace MentorLake.Gio;


public class GSocketClassHandle : BaseSafeHandle
{
}


public static class GSocketClassExtensions
{

	public static GSocketClass Dereference(this GSocketClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketClass>(x.DangerousGetHandle());
}
internal class GSocketClassExterns
{
}


public struct GSocketClass
{
	
public GObjectClass parent_class;
	
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
