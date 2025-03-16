namespace MentorLake.Gio;

public class GDBusInterfaceVTableHandle : BaseSafeHandle
{
}


public static class GDBusInterfaceVTableExtensions
{

	public static GDBusInterfaceVTable Dereference(this GDBusInterfaceVTableHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusInterfaceVTable>(x.DangerousGetHandle());
}
internal class GDBusInterfaceVTableExterns
{
}

public struct GDBusInterfaceVTable
{
	public GDBusInterfaceMethodCallFunc method_call;
	public GDBusInterfaceGetPropertyFunc get_property;
	public GDBusInterfaceSetPropertyFunc set_property;
}
