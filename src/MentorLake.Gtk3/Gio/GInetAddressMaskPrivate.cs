namespace MentorLake.Gio;


public class GInetAddressMaskPrivateHandle : BaseSafeHandle
{
}


public static class GInetAddressMaskPrivateExtensions
{

	public static GInetAddressMaskPrivate Dereference(this GInetAddressMaskPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInetAddressMaskPrivate>(x.DangerousGetHandle());
}
internal class GInetAddressMaskPrivateExterns
{
}


public struct GInetAddressMaskPrivate
{
}
