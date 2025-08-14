namespace MentorLake.Gio;


public class GNetworkServiceClassHandle : BaseSafeHandle
{
}


public static class GNetworkServiceClassExtensions
{

	public static GNetworkServiceClass Dereference(this GNetworkServiceClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GNetworkServiceClass>(x.DangerousGetHandle());
}
internal class GNetworkServiceClassExterns
{
}


public struct GNetworkServiceClass
{
	
public GObjectClass parent_class;
}
