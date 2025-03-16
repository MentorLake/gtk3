namespace MentorLake.Gio;

public class GUnixSocketAddressPrivateHandle : BaseSafeHandle
{
}


public static class GUnixSocketAddressPrivateExtensions
{

	public static GUnixSocketAddressPrivate Dereference(this GUnixSocketAddressPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixSocketAddressPrivate>(x.DangerousGetHandle());
}
internal class GUnixSocketAddressPrivateExterns
{
}

public struct GUnixSocketAddressPrivate
{
}
