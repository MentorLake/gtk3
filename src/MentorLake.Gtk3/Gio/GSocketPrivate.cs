namespace MentorLake.Gio;


public class GSocketPrivateHandle : BaseSafeHandle
{
}


public static class GSocketPrivateExtensions
{

	public static GSocketPrivate Dereference(this GSocketPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketPrivate>(x.DangerousGetHandle());
}
internal class GSocketPrivateExterns
{
}


public struct GSocketPrivate
{
}
