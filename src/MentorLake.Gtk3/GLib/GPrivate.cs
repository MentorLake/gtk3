namespace MentorLake.GLib;

public class GPrivateHandle : BaseSafeHandle
{
}


public static class GPrivateExtensions
{
	public static IntPtr Get(this MentorLake.GLib.GPrivateHandle key)
	{
		return GPrivateExterns.g_private_get(key);
	}

	public static void Replace(this MentorLake.GLib.GPrivateHandle key, IntPtr value)
	{
		GPrivateExterns.g_private_replace(key, value);
	}

	public static void Set(this MentorLake.GLib.GPrivateHandle key, IntPtr value)
	{
		GPrivateExterns.g_private_set(key, value);
	}


	public static GPrivate Dereference(this GPrivateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPrivate>(x.DangerousGetHandle());
}
internal class GPrivateExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_private_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPrivateHandle>))] MentorLake.GLib.GPrivateHandle key);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_private_replace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPrivateHandle>))] MentorLake.GLib.GPrivateHandle key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_private_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPrivateHandle>))] MentorLake.GLib.GPrivateHandle key, IntPtr value);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPrivateHandle g_private_new(MentorLake.GLib.GDestroyNotify notify);

}

public struct GPrivate
{
	public static MentorLake.GLib.GPrivateHandle New(MentorLake.GLib.GDestroyNotify notify)
	{
		return GPrivateExterns.g_private_new(notify);
	}

}
