namespace MentorLake.GLib;

/// <summary>
/// <para>
/// Opaque type. See g_rw_lock_reader_locker_new() for details.
/// </para>
/// </summary>

public struct GRWLockReaderLocker
{
}

public class GRWLockReaderLockerHandle : BaseSafeHandle
{
}

public static class GRWLockReaderLockerHandleExtensions
{
	public static GRWLockReaderLocker Dereference(this GRWLockReaderLockerHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GRWLockReaderLocker>(x.DangerousGetHandle());
}
