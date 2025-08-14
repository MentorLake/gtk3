namespace MentorLake.Gio;


public class GFileMonitorClassHandle : BaseSafeHandle
{
}


public static class GFileMonitorClassExtensions
{

	public static GFileMonitorClass Dereference(this GFileMonitorClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GFileMonitorClass>(x.DangerousGetHandle());
}
internal class GFileMonitorClassExterns
{
}


public struct GFileMonitorClass
{
	
public GObjectClass parent_class;
	
public IntPtr changed;
	
public IntPtr cancel;
	
public IntPtr _g_reserved1;
	
public IntPtr _g_reserved2;
	
public IntPtr _g_reserved3;
	
public IntPtr _g_reserved4;
	
public IntPtr _g_reserved5;
}
