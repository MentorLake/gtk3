namespace MentorLake.Gio;

public class GDBusObjectManagerServerClassHandle : BaseSafeHandle
{
}


public static class GDBusObjectManagerServerClassExtensions
{

	public static GDBusObjectManagerServerClass Dereference(this GDBusObjectManagerServerClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusObjectManagerServerClass>(x.DangerousGetHandle());
}
internal class GDBusObjectManagerServerClassExterns
{
}

public struct GDBusObjectManagerServerClass
{
	public GObjectClass parent_class;
}
