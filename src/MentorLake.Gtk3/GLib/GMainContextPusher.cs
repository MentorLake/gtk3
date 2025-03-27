namespace MentorLake.GLib;

public struct GMainContextPusher
{
}

public class GMainContextPusherHandle : BaseSafeHandle
{
}

public static class GMainContextPusherHandleExtensions
{
	public static GMainContextPusher Dereference(this GMainContextPusherHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMainContextPusher>(x.DangerousGetHandle());
}
