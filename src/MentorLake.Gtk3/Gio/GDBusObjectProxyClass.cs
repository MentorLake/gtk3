namespace MentorLake.Gio;

public class GDBusObjectProxyClassHandle : BaseSafeHandle
{
}


public static class GDBusObjectProxyClassExtensions
{

	public static GDBusObjectProxyClass Dereference(this GDBusObjectProxyClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusObjectProxyClass>(x.DangerousGetHandle());
}
internal class GDBusObjectProxyClassExterns
{
}

public struct GDBusObjectProxyClass
{
	public GObjectClass parent_class;
}
