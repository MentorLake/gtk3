namespace MentorLake.Gtk3.Gio;

public interface GAsyncInitableHandle
{
}

internal class GAsyncInitableHandleImpl : BaseSafeHandle, GAsyncInitableHandle
{
}

public static class GAsyncInitableHandleExtensions
{
	public static T InitAsync<T>(this T initable, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data) where T : GAsyncInitableHandle
	{
		GAsyncInitableExterns.g_async_initable_init_async(initable, io_priority, cancellable, callback, user_data);
		return initable;
	}

	public static bool InitFinish(this GAsyncInitableHandle initable, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GAsyncInitableExterns.g_async_initable_init_finish(initable, res, out error);
	}

	public static GObjectHandle NewFinish(this GAsyncInitableHandle initable, GAsyncResultHandle res, out GErrorHandle error)
	{
		return GAsyncInitableExterns.g_async_initable_new_finish(initable, res, out error);
	}

	public static void NewAsync(GType object_type, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data, string first_property_name, IntPtr @__arglist)
	{
		GAsyncInitableExterns.g_async_initable_new_async(object_type, io_priority, cancellable, callback, user_data, first_property_name, @__arglist);
	}

	public static void NewValistAsync(GType object_type, string first_property_name, IntPtr var_args, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GAsyncInitableExterns.g_async_initable_new_valist_async(object_type, first_property_name, var_args, io_priority, cancellable, callback, user_data);
	}

	public static void NewvAsync(GType object_type, uint n_parameters, GParameterHandle parameters, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data)
	{
		GAsyncInitableExterns.g_async_initable_newv_async(object_type, n_parameters, parameters, io_priority, cancellable, callback, user_data);
	}

}

internal class GAsyncInitableExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_async_initable_init_async(GAsyncInitableHandle initable, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_async_initable_init_finish(GAsyncInitableHandle initable, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GObjectHandle g_async_initable_new_finish(GAsyncInitableHandle initable, GAsyncResultHandle res, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_async_initable_new_async(GType object_type, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data, string first_property_name, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern void g_async_initable_new_valist_async(GType object_type, string first_property_name, IntPtr var_args, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

	[DllImport(Libraries.Gio)]
	internal static extern void g_async_initable_newv_async(GType object_type, uint n_parameters, GParameterHandle parameters, int io_priority, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr user_data);

}
