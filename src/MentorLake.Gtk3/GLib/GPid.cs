namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A type which is used to hold a process identification.
/// </para>
/// <para>
/// On UNIX, processes are identified by a process id (an integer),
/// while Windows uses process handles (which are pointers).
/// </para>
/// <para>
/// GPid is used in GLib only for descendant processes spawned with
/// the g_spawn functions.
/// </para>
/// </summary>

public struct GPid
{
	public int Value;
}

public class GPidHandle : BaseSafeHandle
{
}

public static class GPidHandleExtensions
{
	public static GPid Dereference(this GPidHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPid>(x.DangerousGetHandle());
	public static int DereferenceValue(this GPidHandle x) => x.Dereference().Value;
}
