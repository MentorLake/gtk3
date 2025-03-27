namespace MentorLake.GLib;

public struct GRecMutexLocker
{
}

public class GRecMutexLockerHandle : BaseSafeHandle
{
}

public static class GRecMutexLockerHandleExtensions
{
	public static GRecMutexLocker Dereference(this GRecMutexLockerHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GRecMutexLocker>(x.DangerousGetHandle());
}
