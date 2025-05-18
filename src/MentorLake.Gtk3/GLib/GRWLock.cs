namespace MentorLake.GLib;

public class GRWLockHandle : BaseSafeHandle
{
}


public static class GRWLockExtensions
{
	public static void Clear(this MentorLake.GLib.GRWLockHandle rw_lock)
	{
		if (rw_lock.IsInvalid) throw new Exception("Invalid handle (GRWLock)");
		GRWLockExterns.g_rw_lock_clear(rw_lock);
	}

	public static void Init(this MentorLake.GLib.GRWLockHandle rw_lock)
	{
		if (rw_lock.IsInvalid) throw new Exception("Invalid handle (GRWLock)");
		GRWLockExterns.g_rw_lock_init(rw_lock);
	}

	public static void ReaderLock(this MentorLake.GLib.GRWLockHandle rw_lock)
	{
		if (rw_lock.IsInvalid) throw new Exception("Invalid handle (GRWLock)");
		GRWLockExterns.g_rw_lock_reader_lock(rw_lock);
	}

	public static bool ReaderTrylock(this MentorLake.GLib.GRWLockHandle rw_lock)
	{
		if (rw_lock.IsInvalid) throw new Exception("Invalid handle (GRWLock)");
		return GRWLockExterns.g_rw_lock_reader_trylock(rw_lock);
	}

	public static void ReaderUnlock(this MentorLake.GLib.GRWLockHandle rw_lock)
	{
		if (rw_lock.IsInvalid) throw new Exception("Invalid handle (GRWLock)");
		GRWLockExterns.g_rw_lock_reader_unlock(rw_lock);
	}

	public static void WriterLock(this MentorLake.GLib.GRWLockHandle rw_lock)
	{
		if (rw_lock.IsInvalid) throw new Exception("Invalid handle (GRWLock)");
		GRWLockExterns.g_rw_lock_writer_lock(rw_lock);
	}

	public static bool WriterTrylock(this MentorLake.GLib.GRWLockHandle rw_lock)
	{
		if (rw_lock.IsInvalid) throw new Exception("Invalid handle (GRWLock)");
		return GRWLockExterns.g_rw_lock_writer_trylock(rw_lock);
	}

	public static void WriterUnlock(this MentorLake.GLib.GRWLockHandle rw_lock)
	{
		if (rw_lock.IsInvalid) throw new Exception("Invalid handle (GRWLock)");
		GRWLockExterns.g_rw_lock_writer_unlock(rw_lock);
	}


	public static GRWLock Dereference(this GRWLockHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GRWLock>(x.DangerousGetHandle());
}
internal class GRWLockExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rw_lock_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRWLockHandle>))] MentorLake.GLib.GRWLockHandle rw_lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rw_lock_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRWLockHandle>))] MentorLake.GLib.GRWLockHandle rw_lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rw_lock_reader_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRWLockHandle>))] MentorLake.GLib.GRWLockHandle rw_lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_rw_lock_reader_trylock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRWLockHandle>))] MentorLake.GLib.GRWLockHandle rw_lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rw_lock_reader_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRWLockHandle>))] MentorLake.GLib.GRWLockHandle rw_lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rw_lock_writer_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRWLockHandle>))] MentorLake.GLib.GRWLockHandle rw_lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_rw_lock_writer_trylock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRWLockHandle>))] MentorLake.GLib.GRWLockHandle rw_lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rw_lock_writer_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRWLockHandle>))] MentorLake.GLib.GRWLockHandle rw_lock);

}

public struct GRWLock
{
}
