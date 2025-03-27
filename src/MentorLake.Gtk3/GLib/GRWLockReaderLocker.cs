namespace MentorLake.GLib;

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
