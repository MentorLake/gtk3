namespace MentorLake.Gio;


public class GDBusObjectManagerServerPrivateHandle : BaseSafeHandle
{
}


public static class GDBusObjectManagerServerPrivateExtensions
{

	public static GDBusObjectManagerServerPrivate Dereference(this GDBusObjectManagerServerPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusObjectManagerServerPrivate>(x.DangerousGetHandle());
}
internal class GDBusObjectManagerServerPrivateExterns
{
}


public struct GDBusObjectManagerServerPrivate
{
}
