namespace MentorLake.Gio;


public class GInetAddressPrivateHandle : BaseSafeHandle
{
}


public static class GInetAddressPrivateExtensions
{

	public static GInetAddressPrivate Dereference(this GInetAddressPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInetAddressPrivate>(x.DangerousGetHandle());
}
internal class GInetAddressPrivateExterns
{
}


public struct GInetAddressPrivate
{
}
