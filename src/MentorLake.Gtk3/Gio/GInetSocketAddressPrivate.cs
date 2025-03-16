namespace MentorLake.Gio;

public class GInetSocketAddressPrivateHandle : BaseSafeHandle
{
}


public static class GInetSocketAddressPrivateExtensions
{

	public static GInetSocketAddressPrivate Dereference(this GInetSocketAddressPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInetSocketAddressPrivate>(x.DangerousGetHandle());
}
internal class GInetSocketAddressPrivateExterns
{
}

public struct GInetSocketAddressPrivate
{
}
