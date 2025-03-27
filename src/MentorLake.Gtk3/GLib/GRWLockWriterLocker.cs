namespace MentorLake.GLib;

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
