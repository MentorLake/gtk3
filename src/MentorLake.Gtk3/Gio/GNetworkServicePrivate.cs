namespace MentorLake.Gio;

public class GNetworkServicePrivateHandle : BaseSafeHandle
{
}


public static class GNetworkServicePrivateExtensions
{

	public static GNetworkServicePrivate Dereference(this GNetworkServicePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GNetworkServicePrivate>(x.DangerousGetHandle());
}
internal class GNetworkServicePrivateExterns
{
}

public struct GNetworkServicePrivate
{
}
