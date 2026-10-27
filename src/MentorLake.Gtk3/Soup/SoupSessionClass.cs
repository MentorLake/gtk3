namespace MentorLake.Soup;


public class SoupSessionClassHandle : BaseSafeHandle
{
}


public static class SoupSessionClassExtensions
{

	public static SoupSessionClass Dereference(this SoupSessionClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupSessionClass>(x.DangerousGetHandle());
}
internal class SoupSessionClassExterns
{
}


public struct SoupSessionClass
{
	
public GObjectClass parent_class;
	
public IntPtr request_queued;
	
public IntPtr request_unqueued;
	
public IntPtr _soup_reserved1;
	
public IntPtr _soup_reserved2;
	
public IntPtr _soup_reserved3;
	
public IntPtr _soup_reserved4;
	
public IntPtr _soup_reserved5;
	
public IntPtr _soup_reserved6;
	
public IntPtr _soup_reserved7;
	
public IntPtr _soup_reserved8;
}
