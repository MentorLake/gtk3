namespace MentorLake.Gio;

public class GThreadedSocketServicePrivateHandle : BaseSafeHandle
{
}


public static class GThreadedSocketServicePrivateExtensions
{

	public static GThreadedSocketServicePrivate Dereference(this GThreadedSocketServicePrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GThreadedSocketServicePrivate>(x.DangerousGetHandle());
}
internal class GThreadedSocketServicePrivateExterns
{
}

public struct GThreadedSocketServicePrivate
{
}
