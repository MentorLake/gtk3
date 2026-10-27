namespace MentorLake.Soup;


public class SoupMultipartInputStreamClassHandle : BaseSafeHandle
{
}


public static class SoupMultipartInputStreamClassExtensions
{

	public static SoupMultipartInputStreamClass Dereference(this SoupMultipartInputStreamClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupMultipartInputStreamClass>(x.DangerousGetHandle());
}
internal class SoupMultipartInputStreamClassExterns
{
}


public struct SoupMultipartInputStreamClass
{
	
public GFilterInputStreamClass parent_class;
}
