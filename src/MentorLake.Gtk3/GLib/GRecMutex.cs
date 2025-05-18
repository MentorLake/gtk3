namespace MentorLake.GLib;

public class GRecMutexHandle : BaseSafeHandle
{
}


public static class GRecMutexExtensions
{
	public static void Clear(this MentorLake.GLib.GRecMutexHandle rec_mutex)
	{
		if (rec_mutex.IsInvalid) throw new Exception("Invalid handle (GRecMutex)");
		GRecMutexExterns.g_rec_mutex_clear(rec_mutex);
	}

	public static void Init(this MentorLake.GLib.GRecMutexHandle rec_mutex)
	{
		if (rec_mutex.IsInvalid) throw new Exception("Invalid handle (GRecMutex)");
		GRecMutexExterns.g_rec_mutex_init(rec_mutex);
	}

	public static void Lock(this MentorLake.GLib.GRecMutexHandle rec_mutex)
	{
		if (rec_mutex.IsInvalid) throw new Exception("Invalid handle (GRecMutex)");
		GRecMutexExterns.g_rec_mutex_lock(rec_mutex);
	}

	public static bool Trylock(this MentorLake.GLib.GRecMutexHandle rec_mutex)
	{
		if (rec_mutex.IsInvalid) throw new Exception("Invalid handle (GRecMutex)");
		return GRecMutexExterns.g_rec_mutex_trylock(rec_mutex);
	}

	public static void Unlock(this MentorLake.GLib.GRecMutexHandle rec_mutex)
	{
		if (rec_mutex.IsInvalid) throw new Exception("Invalid handle (GRecMutex)");
		GRecMutexExterns.g_rec_mutex_unlock(rec_mutex);
	}


	public static GRecMutex Dereference(this GRecMutexHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GRecMutex>(x.DangerousGetHandle());
}
internal class GRecMutexExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rec_mutex_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRecMutexHandle>))] MentorLake.GLib.GRecMutexHandle rec_mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rec_mutex_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRecMutexHandle>))] MentorLake.GLib.GRecMutexHandle rec_mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rec_mutex_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRecMutexHandle>))] MentorLake.GLib.GRecMutexHandle rec_mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_rec_mutex_trylock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRecMutexHandle>))] MentorLake.GLib.GRecMutexHandle rec_mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_rec_mutex_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GRecMutexHandle>))] MentorLake.GLib.GRecMutexHandle rec_mutex);

}

public struct GRecMutex
{
}
