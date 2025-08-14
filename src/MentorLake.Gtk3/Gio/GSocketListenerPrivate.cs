namespace MentorLake.Gio;


public class GSocketListenerPrivateHandle : BaseSafeHandle
{
}


public static class GSocketListenerPrivateExtensions
{

	public static GSocketListenerPrivate Dereference(this GSocketListenerPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketListenerPrivate>(x.DangerousGetHandle());
}
internal class GSocketListenerPrivateExterns
{
}


public struct GSocketListenerPrivate
{
}
