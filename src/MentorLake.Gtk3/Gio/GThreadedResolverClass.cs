namespace MentorLake.Gio;


public class GThreadedResolverClassHandle : BaseSafeHandle
{
}


public static class GThreadedResolverClassExtensions
{

	public static GThreadedResolverClass Dereference(this GThreadedResolverClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GThreadedResolverClass>(x.DangerousGetHandle());
}
internal class GThreadedResolverClassExterns
{
}


public struct GThreadedResolverClass
{
	
public GResolverClass parent_class;
}
