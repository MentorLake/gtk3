namespace MentorLake.Soup;


public class SoupAuthDomainBasicClassHandle : BaseSafeHandle
{
}


public static class SoupAuthDomainBasicClassExtensions
{

	public static SoupAuthDomainBasicClass Dereference(this SoupAuthDomainBasicClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupAuthDomainBasicClass>(x.DangerousGetHandle());
}
internal class SoupAuthDomainBasicClassExterns
{
}


public struct SoupAuthDomainBasicClass
{
	
public SoupAuthDomainClass parent_class;
}
