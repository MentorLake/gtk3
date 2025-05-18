namespace MentorLake.GLib;

public class GStaticRWLockHandle : BaseSafeHandle
{
}


public static class GStaticRWLockExtensions
{
	public static void Free(this MentorLake.GLib.GStaticRWLockHandle @lock)
	{
		if (@lock.IsInvalid) throw new Exception("Invalid handle (GStaticRWLock)");
		GStaticRWLockExterns.g_static_rw_lock_free(@lock);
	}

	public static void Init(this MentorLake.GLib.GStaticRWLockHandle @lock)
	{
		if (@lock.IsInvalid) throw new Exception("Invalid handle (GStaticRWLock)");
		GStaticRWLockExterns.g_static_rw_lock_init(@lock);
	}

	public static void ReaderLock(this MentorLake.GLib.GStaticRWLockHandle @lock)
	{
		if (@lock.IsInvalid) throw new Exception("Invalid handle (GStaticRWLock)");
		GStaticRWLockExterns.g_static_rw_lock_reader_lock(@lock);
	}

	public static bool ReaderTrylock(this MentorLake.GLib.GStaticRWLockHandle @lock)
	{
		if (@lock.IsInvalid) throw new Exception("Invalid handle (GStaticRWLock)");
		return GStaticRWLockExterns.g_static_rw_lock_reader_trylock(@lock);
	}

	public static void ReaderUnlock(this MentorLake.GLib.GStaticRWLockHandle @lock)
	{
		if (@lock.IsInvalid) throw new Exception("Invalid handle (GStaticRWLock)");
		GStaticRWLockExterns.g_static_rw_lock_reader_unlock(@lock);
	}

	public static void WriterLock(this MentorLake.GLib.GStaticRWLockHandle @lock)
	{
		if (@lock.IsInvalid) throw new Exception("Invalid handle (GStaticRWLock)");
		GStaticRWLockExterns.g_static_rw_lock_writer_lock(@lock);
	}

	public static bool WriterTrylock(this MentorLake.GLib.GStaticRWLockHandle @lock)
	{
		if (@lock.IsInvalid) throw new Exception("Invalid handle (GStaticRWLock)");
		return GStaticRWLockExterns.g_static_rw_lock_writer_trylock(@lock);
	}

	public static void WriterUnlock(this MentorLake.GLib.GStaticRWLockHandle @lock)
	{
		if (@lock.IsInvalid) throw new Exception("Invalid handle (GStaticRWLock)");
		GStaticRWLockExterns.g_static_rw_lock_writer_unlock(@lock);
	}


	public static GStaticRWLock Dereference(this GStaticRWLockHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GStaticRWLock>(x.DangerousGetHandle());
}
internal class GStaticRWLockExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rw_lock_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRWLockHandle>))] MentorLake.GLib.GStaticRWLockHandle @lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rw_lock_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRWLockHandle>))] MentorLake.GLib.GStaticRWLockHandle @lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rw_lock_reader_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRWLockHandle>))] MentorLake.GLib.GStaticRWLockHandle @lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_static_rw_lock_reader_trylock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRWLockHandle>))] MentorLake.GLib.GStaticRWLockHandle @lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rw_lock_reader_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRWLockHandle>))] MentorLake.GLib.GStaticRWLockHandle @lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rw_lock_writer_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRWLockHandle>))] MentorLake.GLib.GStaticRWLockHandle @lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_static_rw_lock_writer_trylock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRWLockHandle>))] MentorLake.GLib.GStaticRWLockHandle @lock);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rw_lock_writer_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRWLockHandle>))] MentorLake.GLib.GStaticRWLockHandle @lock);

}

public struct GStaticRWLock
{
}
