namespace MentorLake.Gtk3.Gio;

public class GTaskHandle : GObjectHandle, GAsyncResultHandle
{
	public static GTaskHandle New(GObjectHandle source_object, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr callback_data)
	{
		return GTaskExterns.g_task_new(source_object, cancellable, callback, callback_data);
	}

	public static bool IsValid(GAsyncResultHandle result, GObjectHandle source_object)
	{
		return GTaskExterns.g_task_is_valid(result, source_object);
	}

	public static void ReportError(GObjectHandle source_object, GAsyncReadyCallback callback, IntPtr callback_data, IntPtr source_tag, GErrorHandle error)
	{
		GTaskExterns.g_task_report_error(source_object, callback, callback_data, source_tag, error);
	}

	public static void ReportNewError(GObjectHandle source_object, GAsyncReadyCallback callback, IntPtr callback_data, IntPtr source_tag, GQuark domain, int code, string format, IntPtr @__arglist)
	{
		GTaskExterns.g_task_report_new_error(source_object, callback, callback_data, source_tag, domain, code, format, @__arglist);
	}

}

public static class GTaskHandleExtensions
{
	public static T AttachSource<T>(this T task, GSourceHandle source, GSourceFunc callback) where T : GTaskHandle
	{
		GTaskExterns.g_task_attach_source(task, source, callback);
		return task;
	}

	public static GCancellableHandle GetCancellable(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_cancellable(task);
	}

	public static bool GetCheckCancellable(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_check_cancellable(task);
	}

	public static bool GetCompleted(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_completed(task);
	}

	public static GMainContextHandle GetContext(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_context(task);
	}

	public static string GetName(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_name(task);
	}

	public static int GetPriority(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_priority(task);
	}

	public static bool GetReturnOnCancel(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_return_on_cancel(task);
	}

	public static GObjectHandle GetSourceObject(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_source_object(task);
	}

	public static IntPtr GetSourceTag(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_source_tag(task);
	}

	public static IntPtr GetTaskData(this GTaskHandle task)
	{
		return GTaskExterns.g_task_get_task_data(task);
	}

	public static bool HadError(this GTaskHandle task)
	{
		return GTaskExterns.g_task_had_error(task);
	}

	public static bool PropagateBoolean(this GTaskHandle task, out GErrorHandle error)
	{
		return GTaskExterns.g_task_propagate_boolean(task, out error);
	}

	public static UIntPtr PropagateInt(this GTaskHandle task, out GErrorHandle error)
	{
		return GTaskExterns.g_task_propagate_int(task, out error);
	}

	public static IntPtr PropagatePointer(this GTaskHandle task, out GErrorHandle error)
	{
		return GTaskExterns.g_task_propagate_pointer(task, out error);
	}

	public static bool PropagateValue(this GTaskHandle task, out GValue value, out GErrorHandle error)
	{
		return GTaskExterns.g_task_propagate_value(task, out value, out error);
	}

	public static T ReturnBoolean<T>(this T task, bool result) where T : GTaskHandle
	{
		GTaskExterns.g_task_return_boolean(task, result);
		return task;
	}

	public static T ReturnError<T>(this T task, GErrorHandle error) where T : GTaskHandle
	{
		GTaskExterns.g_task_return_error(task, error);
		return task;
	}

	public static bool ReturnErrorIfCancelled(this GTaskHandle task)
	{
		return GTaskExterns.g_task_return_error_if_cancelled(task);
	}

	public static T ReturnInt<T>(this T task, UIntPtr result) where T : GTaskHandle
	{
		GTaskExterns.g_task_return_int(task, result);
		return task;
	}

	public static T ReturnNewError<T>(this T task, GQuark domain, int code, string format, IntPtr @__arglist) where T : GTaskHandle
	{
		GTaskExterns.g_task_return_new_error(task, domain, code, format, @__arglist);
		return task;
	}

	public static T ReturnNewErrorLiteral<T>(this T task, GQuark domain, int code, string message) where T : GTaskHandle
	{
		GTaskExterns.g_task_return_new_error_literal(task, domain, code, message);
		return task;
	}

	public static T ReturnPointer<T>(this T task, IntPtr result, GDestroyNotify result_destroy) where T : GTaskHandle
	{
		GTaskExterns.g_task_return_pointer(task, result, result_destroy);
		return task;
	}

	public static T ReturnPrefixedError<T>(this T task, GErrorHandle error, string format, IntPtr @__arglist) where T : GTaskHandle
	{
		GTaskExterns.g_task_return_prefixed_error(task, error, format, @__arglist);
		return task;
	}

	public static T ReturnValue<T>(this T task, GValueHandle result) where T : GTaskHandle
	{
		GTaskExterns.g_task_return_value(task, result);
		return task;
	}

	public static T RunInThread<T>(this T task, GTaskThreadFunc task_func) where T : GTaskHandle
	{
		GTaskExterns.g_task_run_in_thread(task, task_func);
		return task;
	}

	public static T RunInThreadSync<T>(this T task, GTaskThreadFunc task_func) where T : GTaskHandle
	{
		GTaskExterns.g_task_run_in_thread_sync(task, task_func);
		return task;
	}

	public static T SetCheckCancellable<T>(this T task, bool check_cancellable) where T : GTaskHandle
	{
		GTaskExterns.g_task_set_check_cancellable(task, check_cancellable);
		return task;
	}

	public static T SetName<T>(this T task, string name) where T : GTaskHandle
	{
		GTaskExterns.g_task_set_name(task, name);
		return task;
	}

	public static T SetPriority<T>(this T task, int priority) where T : GTaskHandle
	{
		GTaskExterns.g_task_set_priority(task, priority);
		return task;
	}

	public static bool SetReturnOnCancel(this GTaskHandle task, bool return_on_cancel)
	{
		return GTaskExterns.g_task_set_return_on_cancel(task, return_on_cancel);
	}

	public static T SetSourceTag<T>(this T task, IntPtr source_tag) where T : GTaskHandle
	{
		GTaskExterns.g_task_set_source_tag(task, source_tag);
		return task;
	}

	public static T SetStaticName<T>(this T task, string name) where T : GTaskHandle
	{
		GTaskExterns.g_task_set_static_name(task, name);
		return task;
	}

	public static T SetTaskData<T>(this T task, IntPtr task_data, GDestroyNotify task_data_destroy) where T : GTaskHandle
	{
		GTaskExterns.g_task_set_task_data(task, task_data, task_data_destroy);
		return task;
	}

}

internal class GTaskExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GTaskHandle g_task_new(GObjectHandle source_object, GCancellableHandle cancellable, GAsyncReadyCallback callback, IntPtr callback_data);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_attach_source(GTaskHandle task, GSourceHandle source, GSourceFunc callback);

	[DllImport(Libraries.Gio)]
	internal static extern GCancellableHandle g_task_get_cancellable(GTaskHandle task);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_get_check_cancellable(GTaskHandle task);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_get_completed(GTaskHandle task);

	[DllImport(Libraries.Gio)]
	internal static extern GMainContextHandle g_task_get_context(GTaskHandle task);

	[DllImport(Libraries.Gio)]
	internal static extern string g_task_get_name(GTaskHandle task);

	[DllImport(Libraries.Gio)]
	internal static extern int g_task_get_priority(GTaskHandle task);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_get_return_on_cancel(GTaskHandle task);

	[DllImport(Libraries.Gio)]
	internal static extern GObjectHandle g_task_get_source_object(GTaskHandle task);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_task_get_source_tag(GTaskHandle task);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_task_get_task_data(GTaskHandle task);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_had_error(GTaskHandle task);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_propagate_boolean(GTaskHandle task, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern UIntPtr g_task_propagate_int(GTaskHandle task, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_task_propagate_pointer(GTaskHandle task, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_propagate_value(GTaskHandle task, out GValue value, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_return_boolean(GTaskHandle task, bool result);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_return_error(GTaskHandle task, GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_return_error_if_cancelled(GTaskHandle task);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_return_int(GTaskHandle task, UIntPtr result);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_return_new_error(GTaskHandle task, GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_return_new_error_literal(GTaskHandle task, GQuark domain, int code, string message);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_return_pointer(GTaskHandle task, IntPtr result, GDestroyNotify result_destroy);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_return_prefixed_error(GTaskHandle task, GErrorHandle error, string format, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_return_value(GTaskHandle task, GValueHandle result);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_run_in_thread(GTaskHandle task, GTaskThreadFunc task_func);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_run_in_thread_sync(GTaskHandle task, GTaskThreadFunc task_func);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_set_check_cancellable(GTaskHandle task, bool check_cancellable);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_set_name(GTaskHandle task, string name);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_set_priority(GTaskHandle task, int priority);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_set_return_on_cancel(GTaskHandle task, bool return_on_cancel);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_set_source_tag(GTaskHandle task, IntPtr source_tag);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_set_static_name(GTaskHandle task, string name);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_set_task_data(GTaskHandle task, IntPtr task_data, GDestroyNotify task_data_destroy);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_task_is_valid(GAsyncResultHandle result, GObjectHandle source_object);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_report_error(GObjectHandle source_object, GAsyncReadyCallback callback, IntPtr callback_data, IntPtr source_tag, GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_task_report_new_error(GObjectHandle source_object, GAsyncReadyCallback callback, IntPtr callback_data, IntPtr source_tag, GQuark domain, int code, string format, IntPtr @__arglist);

}
