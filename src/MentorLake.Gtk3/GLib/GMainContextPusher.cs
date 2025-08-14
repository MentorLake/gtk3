namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Opaque type. See g_main_context_pusher_new() for details.
/// </para>
/// </summary>

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
