namespace MentorLake.Gio;


public class GNativeSocketAddressPrivateHandle : BaseSafeHandle
{
}


public static class GNativeSocketAddressPrivateExtensions
{

	public static GNativeSocketAddressPrivate Dereference(this GNativeSocketAddressPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GNativeSocketAddressPrivate>(x.DangerousGetHandle());
}
internal class GNativeSocketAddressPrivateExterns
{
}


public struct GNativeSocketAddressPrivate
{
}
