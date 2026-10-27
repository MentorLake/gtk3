namespace MentorLake.Soup;


public class SoupLoggerClassHandle : BaseSafeHandle
{
}


public static class SoupLoggerClassExtensions
{

	public static SoupLoggerClass Dereference(this SoupLoggerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupLoggerClass>(x.DangerousGetHandle());
}
internal class SoupLoggerClassExterns
{
}


public struct SoupLoggerClass
{
	
public GObjectClass parent_class;
}
