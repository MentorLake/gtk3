namespace MentorLake.Soup;


public class SoupCacheClassHandle : BaseSafeHandle
{
}


public static class SoupCacheClassExtensions
{

	public static SoupCacheClass Dereference(this SoupCacheClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupCacheClass>(x.DangerousGetHandle());
}
internal class SoupCacheClassExterns
{
}


public struct SoupCacheClass
{
	
public GObjectClass parent_class;
	
public IntPtr get_cacheability;
	
public IntPtr padding;
}
