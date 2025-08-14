namespace MentorLake.Gio;


public class GDBusObjectProxyPrivateHandle : BaseSafeHandle
{
}


public static class GDBusObjectProxyPrivateExtensions
{

	public static GDBusObjectProxyPrivate Dereference(this GDBusObjectProxyPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusObjectProxyPrivate>(x.DangerousGetHandle());
}
internal class GDBusObjectProxyPrivateExterns
{
}


public struct GDBusObjectProxyPrivate
{
}
