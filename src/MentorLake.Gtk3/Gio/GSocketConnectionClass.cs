namespace MentorLake.Gio;


public class GSocketConnectionClassHandle : BaseSafeHandle
{
}


public static class GSocketConnectionClassExtensions
{

	public static GSocketConnectionClass Dereference(this GSocketConnectionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketConnectionClass>(x.DangerousGetHandle());
}
internal class GSocketConnectionClassExterns
{
}


public struct GSocketConnectionClass
{
	
public GIOStreamClass parent_class;
	
public IntPtr _g_reserved1;
	
public IntPtr _g_reserved2;
	
public IntPtr _g_reserved3;
	
public IntPtr _g_reserved4;
	
public IntPtr _g_reserved5;
	
public IntPtr _g_reserved6;
}
