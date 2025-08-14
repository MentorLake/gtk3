namespace MentorLake.Gio;


public class GSocketClientPrivateHandle : BaseSafeHandle
{
}


public static class GSocketClientPrivateExtensions
{

	public static GSocketClientPrivate Dereference(this GSocketClientPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketClientPrivate>(x.DangerousGetHandle());
}
internal class GSocketClientPrivateExterns
{
}


public struct GSocketClientPrivate
{
}
