namespace MentorLake.Soup;


public class SoupAuthManagerClassHandle : BaseSafeHandle
{
}


public static class SoupAuthManagerClassExtensions
{

	public static SoupAuthManagerClass Dereference(this SoupAuthManagerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupAuthManagerClass>(x.DangerousGetHandle());
}
internal class SoupAuthManagerClassExterns
{
}


public struct SoupAuthManagerClass
{
	
public GObjectClass parent_class;
}
