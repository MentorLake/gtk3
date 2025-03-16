namespace MentorLake.Gio;

public class GDBusProxyClassHandle : BaseSafeHandle
{
}


public static class GDBusProxyClassExtensions
{

	public static GDBusProxyClass Dereference(this GDBusProxyClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusProxyClass>(x.DangerousGetHandle());
}
internal class GDBusProxyClassExterns
{
}

public struct GDBusProxyClass
{
	public IntPtr g_properties_changed;
	public IntPtr g_signal;
}
