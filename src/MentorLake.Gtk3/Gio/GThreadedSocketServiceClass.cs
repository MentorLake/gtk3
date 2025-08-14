namespace MentorLake.Gio;


public class GThreadedSocketServiceClassHandle : BaseSafeHandle
{
}


public static class GThreadedSocketServiceClassExtensions
{

	public static GThreadedSocketServiceClass Dereference(this GThreadedSocketServiceClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GThreadedSocketServiceClass>(x.DangerousGetHandle());
}
internal class GThreadedSocketServiceClassExterns
{
}


public struct GThreadedSocketServiceClass
{
	
public GSocketServiceClass parent_class;
	
public IntPtr run;
	
public IntPtr _g_reserved1;
	
public IntPtr _g_reserved2;
	
public IntPtr _g_reserved3;
	
public IntPtr _g_reserved4;
	
public IntPtr _g_reserved5;
}
