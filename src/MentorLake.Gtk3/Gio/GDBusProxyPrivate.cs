namespace MentorLake.Gio;


public class GDBusProxyPrivateHandle : BaseSafeHandle
{
}


public static class GDBusProxyPrivateExtensions
{

	public static GDBusProxyPrivate Dereference(this GDBusProxyPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDBusProxyPrivate>(x.DangerousGetHandle());
}
internal class GDBusProxyPrivateExterns
{
}


public struct GDBusProxyPrivate
{
}
