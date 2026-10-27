namespace MentorLake.Soup;


public class SoupAuthDomainDigestClassHandle : BaseSafeHandle
{
}


public static class SoupAuthDomainDigestClassExtensions
{

	public static SoupAuthDomainDigestClass Dereference(this SoupAuthDomainDigestClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupAuthDomainDigestClass>(x.DangerousGetHandle());
}
internal class SoupAuthDomainDigestClassExterns
{
}


public struct SoupAuthDomainDigestClass
{
	
public SoupAuthDomainClass parent_class;
}
