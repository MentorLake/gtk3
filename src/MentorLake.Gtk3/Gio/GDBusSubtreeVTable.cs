namespace MentorLake.Gio;

public class GDBusSubtreeVTableHandle : BaseSafeHandle
{
}


public static class GDBusSubtreeVTableExtensions
{

	public static GDBusSubtreeVTable Dereference(this GDBusSubtreeVTableHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusSubtreeVTable>(x.DangerousGetHandle());
}
internal class GDBusSubtreeVTableExterns
{
}

public struct GDBusSubtreeVTable
{
	public GDBusSubtreeEnumerateFunc enumerate;
	public GDBusSubtreeIntrospectFunc introspect;
	public GDBusSubtreeDispatchFunc dispatch;
}
