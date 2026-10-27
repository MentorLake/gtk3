namespace MentorLake.Soup;


public class SoupMessageClassHandle : BaseSafeHandle
{
}


public static class SoupMessageClassExtensions
{

	public static SoupMessageClass Dereference(this SoupMessageClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupMessageClass>(x.DangerousGetHandle());
}
internal class SoupMessageClassExterns
{
}


public struct SoupMessageClass
{
	
public GObjectClass parent_class;
}
