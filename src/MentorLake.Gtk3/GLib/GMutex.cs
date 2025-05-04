namespace MentorLake.GLib;

public class GMutexHandle : BaseSafeHandle
{
}


public static class GMutexExtensions
{
	public static void Clear(this MentorLake.GLib.GMutexHandle mutex)
	{
		if (mutex.IsInvalid || mutex.IsClosed) throw new Exception("Invalid or closed handle (GMutex)");
		GMutexExterns.g_mutex_clear(mutex);
	}

	public static void Free(this MentorLake.GLib.GMutexHandle mutex)
	{
		if (mutex.IsInvalid || mutex.IsClosed) throw new Exception("Invalid or closed handle (GMutex)");
		GMutexExterns.g_mutex_free(mutex);
	}

	public static void Init(this MentorLake.GLib.GMutexHandle mutex)
	{
		if (mutex.IsInvalid || mutex.IsClosed) throw new Exception("Invalid or closed handle (GMutex)");
		GMutexExterns.g_mutex_init(mutex);
	}

	public static void Lock(this MentorLake.GLib.GMutexHandle mutex)
	{
		if (mutex.IsInvalid || mutex.IsClosed) throw new Exception("Invalid or closed handle (GMutex)");
		GMutexExterns.g_mutex_lock(mutex);
	}

	public static bool Trylock(this MentorLake.GLib.GMutexHandle mutex)
	{
		if (mutex.IsInvalid || mutex.IsClosed) throw new Exception("Invalid or closed handle (GMutex)");
		return GMutexExterns.g_mutex_trylock(mutex);
	}

	public static void Unlock(this MentorLake.GLib.GMutexHandle mutex)
	{
		if (mutex.IsInvalid || mutex.IsClosed) throw new Exception("Invalid or closed handle (GMutex)");
		GMutexExterns.g_mutex_unlock(mutex);
	}


	public static GMutex Dereference(this GMutexHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMutex>(x.DangerousGetHandle());
}
internal class GMutexExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mutex_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mutex_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mutex_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mutex_lock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_mutex_trylock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mutex_unlock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMutexHandle>))] MentorLake.GLib.GMutexHandle mutex);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMutexHandle g_mutex_new();

}

public struct GMutex
{
	public IntPtr p;
	[MarshalAs(UnmanagedType.ByValArray)] public uint[] i;
	public static MentorLake.GLib.GMutexHandle New()
	{
		return GMutexExterns.g_mutex_new();
	}

}
