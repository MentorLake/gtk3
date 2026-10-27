namespace MentorLake.Soup;


public class SoupContentSnifferClassHandle : BaseSafeHandle
{
}


public static class SoupContentSnifferClassExtensions
{

	public static SoupContentSnifferClass Dereference(this SoupContentSnifferClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupContentSnifferClass>(x.DangerousGetHandle());
}
internal class SoupContentSnifferClassExterns
{
}


public struct SoupContentSnifferClass
{
	
public GObjectClass parent_class;
}
