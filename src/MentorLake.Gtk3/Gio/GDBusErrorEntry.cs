namespace MentorLake.Gio;

public class GDBusErrorEntryHandle : BaseSafeHandle
{
}


public static class GDBusErrorEntryExtensions
{

	public static GDBusErrorEntry Dereference(this GDBusErrorEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusErrorEntry>(x.DangerousGetHandle());
}
internal class GDBusErrorEntryExterns
{
}

public struct GDBusErrorEntry
{
	public int error_code;
	public string dbus_error_name;
}
