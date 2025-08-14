namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Opaque type. See g_rw_lock_writer_locker_new() for details.
/// </para>
/// </summary>

public struct GRWLockWriterLocker
{
}

public class GRWLockWriterLockerHandle : BaseSafeHandle
{
}

public static class GRWLockWriterLockerHandleExtensions
{
	public static GRWLockWriterLocker Dereference(this GRWLockWriterLockerHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GRWLockWriterLocker>(x.DangerousGetHandle());
}
