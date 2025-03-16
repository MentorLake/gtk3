namespace MentorLake.Gio;

public class GDBusObjectManagerClientPrivateHandle : BaseSafeHandle
{
}


public static class GDBusObjectManagerClientPrivateExtensions
{

	public static GDBusObjectManagerClientPrivate Dereference(this GDBusObjectManagerClientPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusObjectManagerClientPrivate>(x.DangerousGetHandle());
}
internal class GDBusObjectManagerClientPrivateExterns
{
}

public struct GDBusObjectManagerClientPrivate
{
}
