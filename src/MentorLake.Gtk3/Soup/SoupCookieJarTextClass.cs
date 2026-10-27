namespace MentorLake.Soup;


public class SoupCookieJarTextClassHandle : BaseSafeHandle
{
}


public static class SoupCookieJarTextClassExtensions
{

	public static SoupCookieJarTextClass Dereference(this SoupCookieJarTextClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupCookieJarTextClass>(x.DangerousGetHandle());
}
internal class SoupCookieJarTextClassExterns
{
}


public struct SoupCookieJarTextClass
{
	
public SoupCookieJarClass parent_class;
}
