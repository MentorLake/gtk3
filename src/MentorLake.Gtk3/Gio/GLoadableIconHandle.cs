namespace MentorLake.Gio;

public interface GLoadableIconHandle
{
}

internal class GLoadableIconHandleImpl : BaseSafeHandle, GLoadableIconHandle
{
}

public static class GLoadableIconHandleExtensions
{
	public static MentorLake.Gio.GInputStreamHandle Load(this MentorLake.Gio.GLoadableIconHandle icon, int size, out string type, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error)
	{
		return GLoadableIconHandleExterns.g_loadable_icon_load(icon, size, out type, cancellable, error);
	}

	public static T LoadAsync<T>(this T icon, int size, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GLoadableIconHandle
	{
		GLoadableIconHandleExterns.g_loadable_icon_load_async(icon, size, cancellable, callback, user_data);
		return icon;
	}

	public static MentorLake.Gio.GInputStreamHandle LoadFinish(this MentorLake.Gio.GLoadableIconHandle icon, MentorLake.Gio.GAsyncResultHandle res, out string type, IntPtr error)
	{
		return GLoadableIconHandleExterns.g_loadable_icon_load_finish(icon, res, out type, error);
	}

}

internal class GLoadableIconHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GInputStreamHandle g_loadable_icon_load([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GLoadableIconHandleImpl>))] MentorLake.Gio.GLoadableIconHandle icon, int size, out string type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_loadable_icon_load_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GLoadableIconHandleImpl>))] MentorLake.Gio.GLoadableIconHandle icon, int size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GInputStreamHandle g_loadable_icon_load_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GLoadableIconHandleImpl>))] MentorLake.Gio.GLoadableIconHandle icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out string type, IntPtr error);

}
