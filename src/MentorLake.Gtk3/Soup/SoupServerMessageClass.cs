namespace MentorLake.Soup;


public class SoupServerMessageClassHandle : BaseSafeHandle
{
}


public static class SoupServerMessageClassExtensions
{

	public static SoupServerMessageClass Dereference(this SoupServerMessageClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupServerMessageClass>(x.DangerousGetHandle());
}
internal class SoupServerMessageClassExterns
{
}


public struct SoupServerMessageClass
{
	
public GObjectClass parent_class;
}
