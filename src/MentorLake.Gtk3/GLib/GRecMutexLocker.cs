namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Opaque type. See g_rec_mutex_locker_new() for details.
/// </para>
/// </summary>

public struct GRecMutexLocker
{
}

/// <summary>
/// <para>
/// Opaque type. See g_rec_mutex_locker_new() for details.
/// </para>
/// </summary>

public class GRecMutexLockerHandle : BaseSafeHandle
{
}

public static class GRecMutexLockerHandleExtensions
{
	public static GRecMutexLocker Dereference(this GRecMutexLockerHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GRecMutexLocker>(x.DangerousGetHandle());
}
