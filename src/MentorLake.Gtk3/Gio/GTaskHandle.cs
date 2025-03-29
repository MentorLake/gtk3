namespace MentorLake.Gio;

public class GTaskHandle : GObjectHandle, GAsyncResultHandle
{
	public static MentorLake.Gio.GTaskHandle New(MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr callback_data)
	{
		return GTaskHandleExterns.g_task_new(source_object, cancellable, callback, callback_data);
	}

	public static bool IsValid(MentorLake.Gio.GAsyncResultHandle result, MentorLake.GObject.GObjectHandle source_object)
	{
		return GTaskHandleExterns.g_task_is_valid(result, source_object);
	}

	public static void ReportError(MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr callback_data, IntPtr source_tag, MentorLake.GLib.GErrorHandle error)
	{
		GTaskHandleExterns.g_task_report_error(source_object, callback, callback_data, source_tag, error);
	}

	public static void ReportNewError(MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr callback_data, IntPtr source_tag, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist)
	{
		GTaskHandleExterns.g_task_report_new_error(source_object, callback, callback_data, source_tag, domain, code, format, @__arglist);
	}

}

public static class GTaskHandleExtensions
{
	public static T AttachSource<T>(this T task, MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceFunc callback) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_attach_source(task, source, callback);
		return task;
	}

	public static MentorLake.Gio.GCancellableHandle GetCancellable(this MentorLake.Gio.GTaskHandle task)
	{
		return GTaskHandleExterns.g_task_get_cancellable(task);
	}

	public static bool GetCheckCancellable(this MentorLake.Gio.GTaskHandle task)
	{
		return GTaskHandleExterns.g_task_get_check_cancellable(task);
	}

	public static bool GetCompleted(this MentorLake.Gio.GTaskHandle task)
	{
		return GTaskHandleExterns.g_task_get_completed(task);
	}

	public static MentorLake.GLib.GMainContextHandle GetContext(this MentorLake.Gio.GTaskHandle task)
	{
		return GTaskHandleExterns.g_task_get_context(task);
	}

	public static string GetName(this MentorLake.Gio.GTaskHandle task)
	{
		return GTaskHandleExterns.g_task_get_name(task);
	}

	public static int GetPriority(this MentorLake.Gio.GTaskHandle task)
	{
		return GTaskHandleExterns.g_task_get_priority(task);
	}

	public static bool GetReturnOnCancel(this MentorLake.Gio.GTaskHandle task)
	{
		return GTaskHandleExterns.g_task_get_return_on_cancel(task);
	}

	public static MentorLake.GObject.GObjectHandle GetSourceObject(this MentorLake.Gio.GTaskHandle task)
	{
		return GTaskHandleExterns.g_task_get_source_object(task);
	}

	public static IntPtr GetSourceTag(this MentorLake.Gio.GTaskHandle task)
	{
		return GTaskHandleExterns.g_task_get_source_tag(task);
	}

	public static IntPtr GetTaskData(this MentorLake.Gio.GTaskHandle task)
	{
		return GTaskHandleExterns.g_task_get_task_data(task);
	}

	public static bool HadError(this MentorLake.Gio.GTaskHandle task)
	{
		return GTaskHandleExterns.g_task_had_error(task);
	}

	public static bool PropagateBoolean(this MentorLake.Gio.GTaskHandle task)
	{
		var externCallResult = GTaskHandleExterns.g_task_propagate_boolean(task, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static UIntPtr PropagateInt(this MentorLake.Gio.GTaskHandle task)
	{
		var externCallResult = GTaskHandleExterns.g_task_propagate_int(task, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static IntPtr PropagatePointer(this MentorLake.Gio.GTaskHandle task)
	{
		var externCallResult = GTaskHandleExterns.g_task_propagate_pointer(task, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool PropagateValue(this MentorLake.Gio.GTaskHandle task, out MentorLake.GObject.GValue value)
	{
		var externCallResult = GTaskHandleExterns.g_task_propagate_value(task, out value, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static T ReturnBoolean<T>(this T task, bool result) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_return_boolean(task, result);
		return task;
	}

	public static T ReturnError<T>(this T task, MentorLake.GLib.GErrorHandle error) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_return_error(task, error);
		return task;
	}

	public static bool ReturnErrorIfCancelled(this MentorLake.Gio.GTaskHandle task)
	{
		return GTaskHandleExterns.g_task_return_error_if_cancelled(task);
	}

	public static T ReturnInt<T>(this T task, UIntPtr result) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_return_int(task, result);
		return task;
	}

	public static T ReturnNewError<T>(this T task, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_return_new_error(task, domain, code, format, @__arglist);
		return task;
	}

	public static T ReturnNewErrorLiteral<T>(this T task, MentorLake.GLib.GQuark domain, int code, string message) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_return_new_error_literal(task, domain, code, message);
		return task;
	}

	public static T ReturnPointer<T>(this T task, IntPtr result, MentorLake.GLib.GDestroyNotify result_destroy) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_return_pointer(task, result, result_destroy);
		return task;
	}

	public static T ReturnPrefixedError<T>(this T task, MentorLake.GLib.GErrorHandle error, string format, IntPtr @__arglist) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_return_prefixed_error(task, error, format, @__arglist);
		return task;
	}

	public static T ReturnValue<T>(this T task, MentorLake.GObject.GValueHandle result) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_return_value(task, result);
		return task;
	}

	public static T RunInThread<T>(this T task, MentorLake.Gio.GTaskThreadFunc task_func) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_run_in_thread(task, task_func);
		return task;
	}

	public static T RunInThreadSync<T>(this T task, MentorLake.Gio.GTaskThreadFunc task_func) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_run_in_thread_sync(task, task_func);
		return task;
	}

	public static T SetCheckCancellable<T>(this T task, bool check_cancellable) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_set_check_cancellable(task, check_cancellable);
		return task;
	}

	public static T SetName<T>(this T task, string name) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_set_name(task, name);
		return task;
	}

	public static T SetPriority<T>(this T task, int priority) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_set_priority(task, priority);
		return task;
	}

	public static bool SetReturnOnCancel(this MentorLake.Gio.GTaskHandle task, bool return_on_cancel)
	{
		return GTaskHandleExterns.g_task_set_return_on_cancel(task, return_on_cancel);
	}

	public static T SetSourceTag<T>(this T task, IntPtr source_tag) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_set_source_tag(task, source_tag);
		return task;
	}

	public static T SetStaticName<T>(this T task, string name) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_set_static_name(task, name);
		return task;
	}

	public static T SetTaskData<T>(this T task, IntPtr task_data, MentorLake.GLib.GDestroyNotify task_data_destroy) where T : GTaskHandle
	{
		GTaskHandleExterns.g_task_set_task_data(task, task_data, task_data_destroy);
		return task;
	}

}

internal class GTaskHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GTaskHandle g_task_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr callback_data);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_attach_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSourceHandle>))] MentorLake.GLib.GSourceHandle source, MentorLake.GLib.GSourceFunc callback);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GCancellableHandle g_task_get_cancellable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_get_check_cancellable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_get_completed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GMainContextHandle g_task_get_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_task_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_task_get_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_get_return_on_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GObjectHandle g_task_get_source_object([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_task_get_source_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_task_get_task_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_had_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_propagate_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern UIntPtr g_task_propagate_int([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_task_propagate_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_propagate_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, out MentorLake.GObject.GValue value, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_return_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, bool result);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_return_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_return_error_if_cancelled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_return_int([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, UIntPtr result);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_return_new_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_return_new_error_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, MentorLake.GLib.GQuark domain, int code, string message);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_return_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, IntPtr result, MentorLake.GLib.GDestroyNotify result_destroy);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_return_prefixed_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_return_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle result);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_run_in_thread([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, MentorLake.Gio.GTaskThreadFunc task_func);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_run_in_thread_sync([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, MentorLake.Gio.GTaskThreadFunc task_func);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_set_check_cancellable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, bool check_cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, string name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_set_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, int priority);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_set_return_on_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, bool return_on_cancel);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_set_source_tag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, IntPtr source_tag);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_set_static_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, string name);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_set_task_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GTaskHandle>))] MentorLake.Gio.GTaskHandle task, IntPtr task_data, MentorLake.GLib.GDestroyNotify task_data_destroy);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_task_is_valid([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAsyncResultHandleImpl>))] MentorLake.Gio.GAsyncResultHandle result, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_report_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr callback_data, IntPtr source_tag, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_task_report_new_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source_object, MentorLake.Gio.GAsyncReadyCallback callback, IntPtr callback_data, IntPtr source_tag, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist);

}
