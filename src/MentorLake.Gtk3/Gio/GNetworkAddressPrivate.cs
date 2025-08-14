namespace MentorLake.Gio;


public class GNetworkAddressPrivateHandle : BaseSafeHandle
{
}


public static class GNetworkAddressPrivateExtensions
{

	public static GNetworkAddressPrivate Dereference(this GNetworkAddressPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GNetworkAddressPrivate>(x.DangerousGetHandle());
}
internal class GNetworkAddressPrivateExterns
{
}


public struct GNetworkAddressPrivate
{
}
