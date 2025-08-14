namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Opaque type. See g_mutex_locker_new() for details.
/// </para>
/// </summary>

public struct GMutexLocker
{
}

public class GMutexLockerHandle : BaseSafeHandle
{
}

public static class GMutexLockerHandleExtensions
{
	public static GMutexLocker Dereference(this GMutexLockerHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMutexLocker>(x.DangerousGetHandle());
}
