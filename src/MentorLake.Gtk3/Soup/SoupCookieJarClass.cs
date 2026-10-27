namespace MentorLake.Soup;


public class SoupCookieJarClassHandle : BaseSafeHandle
{
}


public static class SoupCookieJarClassExtensions
{

	public static SoupCookieJarClass Dereference(this SoupCookieJarClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupCookieJarClass>(x.DangerousGetHandle());
}
internal class SoupCookieJarClassExterns
{
}


public struct SoupCookieJarClass
{
	
public GObjectClass parent_class;
	
public IntPtr save;
	
public IntPtr is_persistent;
	
public IntPtr changed;
	
public IntPtr padding;
}
