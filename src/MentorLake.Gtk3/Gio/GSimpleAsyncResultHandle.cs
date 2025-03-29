namespace MentorLake.Gio;

public class GSimpleAsyncResultHandle : GObjectHandle, GAsyncResultHandle
{
	public static MentorLake.Gio.GSimpleAsyncResultHandle New(MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, IntPtr source_tag)
	{
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_new(source_object, callback, user_data, source_tag);
	}

	public static MentorLake.Gio.GSimpleAsyncResultHandle NewError(MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist)
	{
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_new_error(source_object, callback, user_data, domain, code, format, @__arglist);
	}

	public static MentorLake.Gio.GSimpleAsyncResultHandle NewFromError(MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, MentorLake.GLib.GErrorHandle error)
	{
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_new_from_error(source_object, callback, user_data, error);
	}

	public static MentorLake.Gio.GSimpleAsyncResultHandle NewTakeError(MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, MentorLake.GLib.GErrorHandle error)
	{
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_new_take_error(source_object, callback, user_data, error);
	}

	public static bool IsValid(MentorLake.Gio.GAsyncResultHandle result, MentorLake.GObject.GObjectHandle source, IntPtr source_tag)
	{
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_is_valid(result, source, source_tag);
	}

}

public static class GSimpleAsyncResultHandleExtensions
{
	public static T Complete<T>(this T simple) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_complete(simple);
		return simple;
	}

	public static T CompleteInIdle<T>(this T simple) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_complete_in_idle(simple);
		return simple;
	}

	public static bool GetOpResGboolean(this MentorLake.Gio.GSimpleAsyncResultHandle simple)
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_get_op_res_gboolean(simple);
	}

	public static IntPtr GetOpResGpointer(this MentorLake.Gio.GSimpleAsyncResultHandle simple)
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_get_op_res_gpointer(simple);
	}

	public static UIntPtr GetOpResGssize(this MentorLake.Gio.GSimpleAsyncResultHandle simple)
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_get_op_res_gssize(simple);
	}

	public static IntPtr GetSourceTag(this MentorLake.Gio.GSimpleAsyncResultHandle simple)
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		return GSimpleAsyncResultHandleExterns.g_simple_async_result_get_source_tag(simple);
	}

	public static bool PropagateError(this MentorLake.Gio.GSimpleAsyncResultHandle simple)
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		var externCallResult = GSimpleAsyncResultHandleExterns.g_simple_async_result_propagate_error(simple, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T RunInThread<T>(this T simple, MentorLake.Gio.GSimpleAsyncThreadFunc func, int io_priority, MentorLake.Gio.GCancellableHandle cancellable) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_run_in_thread(simple, func, io_priority, cancellable);
		return simple;
	}

	public static T SetCheckCancellable<T>(this T simple, MentorLake.Gio.GCancellableHandle check_cancellable) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_set_check_cancellable(simple, check_cancellable);
		return simple;
	}

	public static T SetError<T>(this T simple, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_set_error(simple, domain, code, format, @__arglist);
		return simple;
	}

	public static T SetErrorVa<T>(this T simple, MentorLake.GLib.GQuark domain, int code, string format, IntPtr args) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_set_error_va(simple, domain, code, format, args);
		return simple;
	}

	public static T SetFromError<T>(this T simple, MentorLake.GLib.GErrorHandle error) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_set_from_error(simple, error);
		return simple;
	}

	public static T SetHandleCancellation<T>(this T simple, bool handle_cancellation) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_set_handle_cancellation(simple, handle_cancellation);
		return simple;
	}

	public static T SetOpResGboolean<T>(this T simple, bool op_res) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_set_op_res_gboolean(simple, op_res);
		return simple;
	}

	public static T SetOpResGpointer<T>(this T simple, IntPtr op_res, MentorLake.GLib.GDestroyNotify destroy_op_res) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_set_op_res_gpointer(simple, op_res, destroy_op_res);
		return simple;
	}

	public static T SetOpResGssize<T>(this T simple, UIntPtr op_res) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_set_op_res_gssize(simple, op_res);
		return simple;
	}

	public static T TakeError<T>(this T simple, MentorLake.GLib.GErrorHandle error) where T : GSimpleAsyncResultHandle
	{
		if (simple.IsInvalid || simple.IsClosed) throw new Exception("Invalid or closed handle (GSimpleAsyncResultHandle)");
		GSimpleAsyncResultHandleExterns.g_simple_async_result_take_error(simple, error);
		return simple;
	}

}

internal class GSimpleAsyncResultHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSimpleAsyncResultHandle g_simple_async_result_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, IntPtr source_tag);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSimpleAsyncResultHandle g_simple_async_result_new_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSimpleAsyncResultHandle g_simple_async_result_new_from_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSimpleAsyncResultHandle g_simple_async_result_new_take_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr user_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_complete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_complete_in_idle([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_simple_async_result_get_op_res_gboolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_simple_async_result_get_op_res_gpointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_simple_async_result_get_op_res_gssize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_simple_async_result_get_source_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_simple_async_result_propagate_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_run_in_thread([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, MentorLake.Gio.GSimpleAsyncThreadFunc func, int io_priority, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_set_check_cancellable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle check_cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_set_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_set_error_va([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, MentorLake.GLib.GQuark domain, int code, string format, IntPtr args);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_set_from_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_set_handle_cancellation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, bool handle_cancellation);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_set_op_res_gboolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, bool op_res);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_set_op_res_gpointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, IntPtr op_res, MentorLake.GLib.GDestroyNotify destroy_op_res);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_set_op_res_gssize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, UIntPtr op_res);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_simple_async_result_take_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSimpleAsyncResultHandle>))] MentorLake.Gio.GSimpleAsyncResultHandle simple, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_simple_async_result_is_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source, IntPtr source_tag);

}
