namespace MentorLake.Soup;


public class SoupAuthDomainClassHandle : BaseSafeHandle
{
}


public static class SoupAuthDomainClassExtensions
{

	public static SoupAuthDomainClass Dereference(this SoupAuthDomainClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupAuthDomainClass>(x.DangerousGetHandle());
}
internal class SoupAuthDomainClassExterns
{
}


public struct SoupAuthDomainClass
{
	
public GObjectClass parent_class;
	
public IntPtr accepts;
	
public IntPtr challenge;
	
public IntPtr check_password;
	
public IntPtr padding;
}
