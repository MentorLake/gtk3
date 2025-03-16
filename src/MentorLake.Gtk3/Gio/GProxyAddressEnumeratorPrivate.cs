namespace MentorLake.Gio;

public class GProxyAddressEnumeratorPrivateHandle : BaseSafeHandle
{
}


public static class GProxyAddressEnumeratorPrivateExtensions
{

	public static GProxyAddressEnumeratorPrivate Dereference(this GProxyAddressEnumeratorPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GProxyAddressEnumeratorPrivate>(x.DangerousGetHandle());
}
internal class GProxyAddressEnumeratorPrivateExterns
{
}

public struct GProxyAddressEnumeratorPrivate
{
}
