namespace MentorLake.Soup;


public class SoupCookieJarDBClassHandle : BaseSafeHandle
{
}


public static class SoupCookieJarDBClassExtensions
{

	public static SoupCookieJarDBClass Dereference(this SoupCookieJarDBClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupCookieJarDBClass>(x.DangerousGetHandle());
}
internal class SoupCookieJarDBClassExterns
{
}


public struct SoupCookieJarDBClass
{
	
public SoupCookieJarClass parent_class;
}
