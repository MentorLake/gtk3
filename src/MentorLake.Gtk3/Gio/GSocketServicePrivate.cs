namespace MentorLake.Gio;


public class GSocketServicePrivateHandle : BaseSafeHandle
{
}


public static class GSocketServicePrivateExtensions
{

	public static GSocketServicePrivate Dereference(this GSocketServicePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketServicePrivate>(x.DangerousGetHandle());
}
internal class GSocketServicePrivateExterns
{
}


public struct GSocketServicePrivate
{
}
