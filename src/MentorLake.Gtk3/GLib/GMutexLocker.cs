namespace MentorLake.GLib;

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
