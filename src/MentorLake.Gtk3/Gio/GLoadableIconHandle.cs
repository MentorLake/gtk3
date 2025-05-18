namespace MentorLake.Gio;

public interface GLoadableIconHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GLoadableIconHandleImpl : BaseSafeHandle, GLoadableIconHandle
{
}

public static class GLoadableIconHandleExtensions
{
	public static MentorLake.Gio.GInputStreamHandle Load(this MentorLake.Gio.GLoadableIconHandle icon, int size, out string type, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (icon.IsInvalid) throw new Exception("Invalid handle (GLoadableIconHandle)");
		var externCallResult = GLoadableIconHandleExterns.g_loadable_icon_load(icon, size, out type, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T LoadAsync<T>(this T icon, int size, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GLoadableIconHandle
	{
		if (icon.IsInvalid) throw new Exception("Invalid handle (GLoadableIconHandle)");
		GLoadableIconHandleExterns.g_loadable_icon_load_async(icon, size, cancellable, callback, user_data);
		return icon;
	}

	public static MentorLake.Gio.GInputStreamHandle LoadFinish(this MentorLake.Gio.GLoadableIconHandle icon, MentorLake.Gio.GAsyncResultHandle res, out string type)
	{
		if (icon.IsInvalid) throw new Exception("Invalid handle (GLoadableIconHandle)");
		var externCallResult = GLoadableIconHandleExterns.g_loadable_icon_load_finish(icon, res, out type, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GLoadableIconHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle g_loadable_icon_load([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GLoadableIconHandleImpl>))] MentorLake.Gio.GLoadableIconHandle icon, int size, out string type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_loadable_icon_load_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GLoadableIconHandleImpl>))] MentorLake.Gio.GLoadableIconHandle icon, int size, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInputStreamHandle>))]
	internal static extern MentorLake.Gio.GInputStreamHandle g_loadable_icon_load_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GLoadableIconHandleImpl>))] MentorLake.Gio.GLoadableIconHandle icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out string type, out MentorLake.GLib.GErrorHandle error);

}
