namespace MentorLake.Soup;


public class SoupServerClassHandle : BaseSafeHandle
{
}


public static class SoupServerClassExtensions
{

	public static SoupServerClass Dereference(this SoupServerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupServerClass>(x.DangerousGetHandle());
}
internal class SoupServerClassExterns
{
}


public struct SoupServerClass
{
	
public GObjectClass parent_class;
	
public IntPtr request_started;
	
public IntPtr request_read;
	
public IntPtr request_finished;
	
public IntPtr request_aborted;
	
public IntPtr padding;
}
