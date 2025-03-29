namespace MentorLake.GLib;

public class GStaticPrivateHandle : BaseSafeHandle
{
}


public static class GStaticPrivateExtensions
{
	public static void Free(this MentorLake.GLib.GStaticPrivateHandle private_key)
	{
		if (private_key.IsInvalid || private_key.IsClosed) throw new Exception("Invalid or closed handle (GStaticPrivate)");
		GStaticPrivateExterns.g_static_private_free(private_key);
	}

	public static IntPtr Get(this MentorLake.GLib.GStaticPrivateHandle private_key)
	{
		if (private_key.IsInvalid || private_key.IsClosed) throw new Exception("Invalid or closed handle (GStaticPrivate)");
		return GStaticPrivateExterns.g_static_private_get(private_key);
	}

	public static void Init(this MentorLake.GLib.GStaticPrivateHandle private_key)
	{
		if (private_key.IsInvalid || private_key.IsClosed) throw new Exception("Invalid or closed handle (GStaticPrivate)");
		GStaticPrivateExterns.g_static_private_init(private_key);
	}

	public static void Set(this MentorLake.GLib.GStaticPrivateHandle private_key, IntPtr data, MentorLake.GLib.GDestroyNotify notify)
	{
		if (private_key.IsInvalid || private_key.IsClosed) throw new Exception("Invalid or closed handle (GStaticPrivate)");
		GStaticPrivateExterns.g_static_private_set(private_key, data, notify);
	}


	public static GStaticPrivate Dereference(this GStaticPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GStaticPrivate>(x.DangerousGetHandle());
}
internal class GStaticPrivateExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_private_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticPrivateHandle>))] MentorLake.GLib.GStaticPrivateHandle private_key);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_static_private_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticPrivateHandle>))] MentorLake.GLib.GStaticPrivateHandle private_key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_private_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticPrivateHandle>))] MentorLake.GLib.GStaticPrivateHandle private_key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_static_private_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStaticPrivateHandle>))] MentorLake.GLib.GStaticPrivateHandle private_key, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

}

public struct GStaticPrivate
{
}
