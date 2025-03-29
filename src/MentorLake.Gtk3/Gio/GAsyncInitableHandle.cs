namespace MentorLake.Gio;

public interface GAsyncInitableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GAsyncInitableHandleImpl : BaseSafeHandle, GAsyncInitableHandle
{
}

public static class GAsyncInitableHandleExtensions
{
	public static T InitAsync<T>(this T initable, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data) where T : GAsyncInitableHandle
	{
		if (initable.IsInvalid || initable.IsClosed) throw new Exception("Invalid or closed handle (GAsyncInitableHandle)");
		GAsyncInitableHandleExterns.g_async_initable_init_async(initable, io_priority, cancellable, callback, user_data);
		return initable;
	}

	public static bool InitFinish(this MentorLake.Gio.GAsyncInitableHandle initable, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (initable.IsInvalid || initable.IsClosed) throw new Exception("Invalid or closed handle (GAsyncInitableHandle)");
		var externCallResult = GAsyncInitableHandleExterns.g_async_initable_init_finish(initable, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GObject.GObjectHandle NewFinish(this MentorLake.Gio.GAsyncInitableHandle initable, MentorLake.Gio.GAsyncResultHandle res)
	{
		if (initable.IsInvalid || initable.IsClosed) throw new Exception("Invalid or closed handle (GAsyncInitableHandle)");
		var externCallResult = GAsyncInitableHandleExterns.g_async_initable_new_finish(initable, res, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static void NewAsync(MentorLake.GObject.GType object_type, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, string first_property_name, IntPtr @__arglist)
	{
		GAsyncInitableHandleExterns.g_async_initable_new_async(object_type, io_priority, cancellable, callback, user_data, first_property_name, @__arglist);
	}

	public static void NewValistAsync(MentorLake.GObject.GType object_type, string first_property_name, IntPtr var_args, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GAsyncInitableHandleExterns.g_async_initable_new_valist_async(object_type, first_property_name, var_args, io_priority, cancellable, callback, user_data);
	}

	public static void NewvAsync(MentorLake.GObject.GType object_type, uint n_parameters, MentorLake.GObject.GParameterHandle parameters, int io_priority, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data)
	{
		GAsyncInitableHandleExterns.g_async_initable_newv_async(object_type, n_parameters, parameters, io_priority, cancellable, callback, user_data);
	}

}

internal class GAsyncInitableHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_async_initable_init_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncInitableHandleImpl>))] MentorLake.Gio.GAsyncInitableHandle initable, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_async_initable_init_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncInitableHandleImpl>))] MentorLake.Gio.GAsyncInitableHandle initable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GObjectHandle g_async_initable_new_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncInitableHandleImpl>))] MentorLake.Gio.GAsyncInitableHandle initable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle res, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_async_initable_new_async(MentorLake.GObject.GType object_type, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, string first_property_name, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_async_initable_new_valist_async(MentorLake.GObject.GType object_type, string first_property_name, IntPtr var_args, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_async_initable_newv_async(MentorLake.GObject.GType object_type, uint n_parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParameterHandle>))] MentorLake.GObject.GParameterHandle parameters, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data);

}
