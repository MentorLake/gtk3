namespace MentorLake.Soup;


public class SoupHSTSEnforcerDBClassHandle : BaseSafeHandle
{
}


public static class SoupHSTSEnforcerDBClassExtensions
{

	public static SoupHSTSEnforcerDBClass Dereference(this SoupHSTSEnforcerDBClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupHSTSEnforcerDBClass>(x.DangerousGetHandle());
}
internal class SoupHSTSEnforcerDBClassExterns
{
}


public struct SoupHSTSEnforcerDBClass
{
	
public SoupHSTSEnforcerClass parent_class;
}
