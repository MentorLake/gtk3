namespace MentorLake.Gio;


public class GProxyAddressPrivateHandle : BaseSafeHandle
{
}


public static class GProxyAddressPrivateExtensions
{

	public static GProxyAddressPrivate Dereference(this GProxyAddressPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GProxyAddressPrivate>(x.DangerousGetHandle());
}
internal class GProxyAddressPrivateExterns
{
}


public struct GProxyAddressPrivate
{
}
