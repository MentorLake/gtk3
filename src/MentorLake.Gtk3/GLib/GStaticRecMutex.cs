namespace MentorLake.GLib;

public class GStaticRecMutexHandle : BaseSafeHandle
{
}


public static class GStaticRecMutexExtensions
{
	public static void Free(this MentorLake.GLib.GStaticRecMutexHandle mutex)
	{
		GStaticRecMutexExterns.g_static_rec_mutex_free(mutex);
	}

	public static void Init(this MentorLake.GLib.GStaticRecMutexHandle mutex)
	{
		GStaticRecMutexExterns.g_static_rec_mutex_init(mutex);
	}

	public static void Lock(this MentorLake.GLib.GStaticRecMutexHandle mutex)
	{
		GStaticRecMutexExterns.g_static_rec_mutex_lock(mutex);
	}

	public static void LockFull(this MentorLake.GLib.GStaticRecMutexHandle mutex, uint depth)
	{
		GStaticRecMutexExterns.g_static_rec_mutex_lock_full(mutex, depth);
	}

	public static bool Trylock(this MentorLake.GLib.GStaticRecMutexHandle mutex)
	{
		return GStaticRecMutexExterns.g_static_rec_mutex_trylock(mutex);
	}

	public static void Unlock(this MentorLake.GLib.GStaticRecMutexHandle mutex)
	{
		GStaticRecMutexExterns.g_static_rec_mutex_unlock(mutex);
	}

	public static uint UnlockFull(this MentorLake.GLib.GStaticRecMutexHandle mutex)
	{
		return GStaticRecMutexExterns.g_static_rec_mutex_unlock_full(mutex);
	}


	public static GStaticRecMutex Dereference(this GStaticRecMutexHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GStaticRecMutex>(x.DangerousGetHandle());
}
internal class GStaticRecMutexExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rec_mutex_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRecMutexHandle>))] MentorLake.GLib.GStaticRecMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rec_mutex_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRecMutexHandle>))] MentorLake.GLib.GStaticRecMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rec_mutex_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRecMutexHandle>))] MentorLake.GLib.GStaticRecMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rec_mutex_lock_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRecMutexHandle>))] MentorLake.GLib.GStaticRecMutexHandle mutex, uint depth);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_static_rec_mutex_trylock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRecMutexHandle>))] MentorLake.GLib.GStaticRecMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_rec_mutex_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRecMutexHandle>))] MentorLake.GLib.GStaticRecMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_static_rec_mutex_unlock_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticRecMutexHandle>))] MentorLake.GLib.GStaticRecMutexHandle mutex);

}

public struct GStaticRecMutex
{
}
