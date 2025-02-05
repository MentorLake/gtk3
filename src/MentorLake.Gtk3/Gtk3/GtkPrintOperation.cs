namespace MentorLake.Gtk3.Gtk3;

public class GtkPrintOperationHandle : GObjectHandle, GtkPrintOperationPreviewHandle
{
	public static GtkPrintOperationHandle New()
	{
		return GtkPrintOperationExterns.gtk_print_operation_new();
	}

}

public static class GtkPrintOperationSignalExtensions
{

	public static IObservable<GtkPrintOperationSignalStructs.BeginPrintSignal> Signal_BeginPrint(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.BeginPrintSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.begin_print handler = (GtkPrintOperationHandle self, GtkPrintContextHandle context, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.BeginPrintSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "begin_print", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.CreateCustomWidgetSignal> Signal_CreateCustomWidget(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.CreateCustomWidgetSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.create_custom_widget handler = (GtkPrintOperationHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.CreateCustomWidgetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "create_custom_widget", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.CustomWidgetApplySignal> Signal_CustomWidgetApply(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.CustomWidgetApplySignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.custom_widget_apply handler = (GtkPrintOperationHandle self, GtkWidgetHandle widget, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.CustomWidgetApplySignal()
				{
					Self = self, Widget = widget, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "custom_widget_apply", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.DoneSignal> Signal_Done(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.DoneSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.done handler = (GtkPrintOperationHandle self, GtkPrintOperationResult result, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.DoneSignal()
				{
					Self = self, Result = result, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "done", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.DrawPageSignal> Signal_DrawPage(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.DrawPageSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.draw_page handler = (GtkPrintOperationHandle self, GtkPrintContextHandle context, int page_nr, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.DrawPageSignal()
				{
					Self = self, Context = context, PageNr = page_nr, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "draw_page", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.EndPrintSignal> Signal_EndPrint(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.EndPrintSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.end_print handler = (GtkPrintOperationHandle self, GtkPrintContextHandle context, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.EndPrintSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "end_print", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.PaginateSignal> Signal_Paginate(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.PaginateSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.paginate handler = (GtkPrintOperationHandle self, GtkPrintContextHandle context, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.PaginateSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "paginate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.PreviewSignal> Signal_Preview(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.PreviewSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.preview handler = (GtkPrintOperationHandle self, GtkPrintOperationPreviewHandle preview, GtkPrintContextHandle context, GtkWindowHandle parent, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.PreviewSignal()
				{
					Self = self, Preview = preview, Context = context, Parent = parent, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "preview", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.RequestPageSetupSignal> Signal_RequestPageSetup(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.RequestPageSetupSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.request_page_setup handler = (GtkPrintOperationHandle self, GtkPrintContextHandle context, int page_nr, GtkPageSetupHandle setup, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.RequestPageSetupSignal()
				{
					Self = self, Context = context, PageNr = page_nr, Setup = setup, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "request_page_setup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.StatusChangedSignal> Signal_StatusChanged(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.StatusChangedSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.status_changed handler = (GtkPrintOperationHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.StatusChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "status_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPrintOperationSignalStructs.UpdateCustomWidgetSignal> Signal_UpdateCustomWidget(this GtkPrintOperationHandle instance)
	{
		return Observable.Create((IObserver<GtkPrintOperationSignalStructs.UpdateCustomWidgetSignal> obs) =>
		{
			GtkPrintOperationSignalDelegates.update_custom_widget handler = (GtkPrintOperationHandle self, GtkWidgetHandle widget, GtkPageSetupHandle setup, GtkPrintSettingsHandle settings, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationSignalStructs.UpdateCustomWidgetSignal()
				{
					Self = self, Widget = widget, Setup = setup, Settings = settings, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "update_custom_widget", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkPrintOperationSignalStructs
{

public struct BeginPrintSignal
{
	public GtkPrintOperationHandle Self;
	public GtkPrintContextHandle Context;
	public IntPtr UserData;
}

public struct CreateCustomWidgetSignal
{
	public GtkPrintOperationHandle Self;
	public IntPtr UserData;
	public GObjectHandle ReturnValue;
}

public struct CustomWidgetApplySignal
{
	public GtkPrintOperationHandle Self;
	public GtkWidgetHandle Widget;
	public IntPtr UserData;
}

public struct DoneSignal
{
	public GtkPrintOperationHandle Self;
	public GtkPrintOperationResult Result;
	public IntPtr UserData;
}

public struct DrawPageSignal
{
	public GtkPrintOperationHandle Self;
	public GtkPrintContextHandle Context;
	public int PageNr;
	public IntPtr UserData;
}

public struct EndPrintSignal
{
	public GtkPrintOperationHandle Self;
	public GtkPrintContextHandle Context;
	public IntPtr UserData;
}

public struct PaginateSignal
{
	public GtkPrintOperationHandle Self;
	public GtkPrintContextHandle Context;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct PreviewSignal
{
	public GtkPrintOperationHandle Self;
	public GtkPrintOperationPreviewHandle Preview;
	public GtkPrintContextHandle Context;
	public GtkWindowHandle Parent;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct RequestPageSetupSignal
{
	public GtkPrintOperationHandle Self;
	public GtkPrintContextHandle Context;
	public int PageNr;
	public GtkPageSetupHandle Setup;
	public IntPtr UserData;
}

public struct StatusChangedSignal
{
	public GtkPrintOperationHandle Self;
	public IntPtr UserData;
}

public struct UpdateCustomWidgetSignal
{
	public GtkPrintOperationHandle Self;
	public GtkWidgetHandle Widget;
	public GtkPageSetupHandle Setup;
	public GtkPrintSettingsHandle Settings;
	public IntPtr UserData;
}
}

public static class GtkPrintOperationSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void begin_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintContextHandle>))] GtkPrintContextHandle context, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GObjectHandle create_custom_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void custom_widget_apply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle widget, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, GtkPrintOperationResult result, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void draw_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintContextHandle>))] GtkPrintContextHandle context, int page_nr, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void end_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintContextHandle>))] GtkPrintContextHandle context, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool paginate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintContextHandle>))] GtkPrintContextHandle context, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool preview([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationPreviewHandleImpl>))] GtkPrintOperationPreviewHandle preview, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintContextHandle>))] GtkPrintContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWindowHandle>))] GtkWindowHandle parent, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void request_page_setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintContextHandle>))] GtkPrintContextHandle context, int page_nr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPageSetupHandle>))] GtkPageSetupHandle setup, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void status_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void update_custom_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintOperationHandle>))] GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPageSetupHandle>))] GtkPageSetupHandle setup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPrintSettingsHandle>))] GtkPrintSettingsHandle settings, IntPtr user_data);

}


public static class GtkPrintOperationHandleExtensions
{
	public static T Cancel<T>(this T op) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_cancel(op);
		return op;
	}

	public static T DrawPageFinish<T>(this T op) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_draw_page_finish(op);
		return op;
	}

	public static GtkPageSetupHandle GetDefaultPageSetup(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_default_page_setup(op);
	}

	public static bool GetEmbedPageSetup(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_embed_page_setup(op);
	}

	public static T GetError<T>(this T op, out GErrorHandle error) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_get_error(op, out error);
		return op;
	}

	public static bool GetHasSelection(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_has_selection(op);
	}

	public static int GetNPagesToPrint(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_n_pages_to_print(op);
	}

	public static GtkPrintSettingsHandle GetPrintSettings(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_print_settings(op);
	}

	public static GtkPrintStatus GetStatus(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_status(op);
	}

	public static string GetStatusString(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_status_string(op);
	}

	public static bool GetSupportSelection(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_get_support_selection(op);
	}

	public static bool IsFinished(this GtkPrintOperationHandle op)
	{
		return GtkPrintOperationExterns.gtk_print_operation_is_finished(op);
	}

	public static GtkPrintOperationResult Run(this GtkPrintOperationHandle op, GtkPrintOperationAction action, GtkWindowHandle parent, out GErrorHandle error)
	{
		return GtkPrintOperationExterns.gtk_print_operation_run(op, action, parent, out error);
	}

	public static T SetAllowAsync<T>(this T op, bool allow_async) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_set_allow_async(op, allow_async);
		return op;
	}

	public static T SetCurrentPage<T>(this T op, int current_page) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_set_current_page(op, current_page);
		return op;
	}

	public static T SetCustomTabLabel<T>(this T op, string label) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_set_custom_tab_label(op, label);
		return op;
	}

	public static T SetDefaultPageSetup<T>(this T op, GtkPageSetupHandle default_page_setup) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_set_default_page_setup(op, default_page_setup);
		return op;
	}

	public static T SetDeferDrawing<T>(this T op) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_set_defer_drawing(op);
		return op;
	}

	public static T SetEmbedPageSetup<T>(this T op, bool embed) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_set_embed_page_setup(op, embed);
		return op;
	}

	public static T SetExportFilename<T>(this T op, string filename) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_set_export_filename(op, filename);
		return op;
	}

	public static T SetHasSelection<T>(this T op, bool has_selection) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_set_has_selection(op, has_selection);
		return op;
	}

	public static T SetJobName<T>(this T op, string job_name) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_set_job_name(op, job_name);
		return op;
	}

	public static T SetNPages<T>(this T op, int n_pages) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_set_n_pages(op, n_pages);
		return op;
	}

	public static T SetPrintSettings<T>(this T op, GtkPrintSettingsHandle print_settings) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_set_print_settings(op, print_settings);
		return op;
	}

	public static T SetShowProgress<T>(this T op, bool show_progress) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_set_show_progress(op, show_progress);
		return op;
	}

	public static T SetSupportSelection<T>(this T op, bool support_selection) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_set_support_selection(op, support_selection);
		return op;
	}

	public static T SetTrackPrintStatus<T>(this T op, bool track_status) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_set_track_print_status(op, track_status);
		return op;
	}

	public static T SetUnit<T>(this T op, GtkUnit unit) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_set_unit(op, unit);
		return op;
	}

	public static T SetUseFullPage<T>(this T op, bool full_page) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationExterns.gtk_print_operation_set_use_full_page(op, full_page);
		return op;
	}

}

internal class GtkPrintOperationExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPrintOperationHandle gtk_print_operation_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_cancel(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_draw_page_finish(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPageSetupHandle gtk_print_operation_get_default_page_setup(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_print_operation_get_embed_page_setup(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_get_error(GtkPrintOperationHandle op, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_print_operation_get_has_selection(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_print_operation_get_n_pages_to_print(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPrintSettingsHandle gtk_print_operation_get_print_settings(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPrintStatus gtk_print_operation_get_status(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_operation_get_status_string(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_print_operation_get_support_selection(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_print_operation_is_finished(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPrintOperationResult gtk_print_operation_run(GtkPrintOperationHandle op, GtkPrintOperationAction action, GtkWindowHandle parent, out GErrorHandle error);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_set_allow_async(GtkPrintOperationHandle op, bool allow_async);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_set_current_page(GtkPrintOperationHandle op, int current_page);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_set_custom_tab_label(GtkPrintOperationHandle op, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_set_default_page_setup(GtkPrintOperationHandle op, GtkPageSetupHandle default_page_setup);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_set_defer_drawing(GtkPrintOperationHandle op);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_set_embed_page_setup(GtkPrintOperationHandle op, bool embed);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_set_export_filename(GtkPrintOperationHandle op, string filename);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_set_has_selection(GtkPrintOperationHandle op, bool has_selection);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_set_job_name(GtkPrintOperationHandle op, string job_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_set_n_pages(GtkPrintOperationHandle op, int n_pages);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_set_print_settings(GtkPrintOperationHandle op, GtkPrintSettingsHandle print_settings);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_set_show_progress(GtkPrintOperationHandle op, bool show_progress);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_set_support_selection(GtkPrintOperationHandle op, bool support_selection);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_set_track_print_status(GtkPrintOperationHandle op, bool track_status);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_set_unit(GtkPrintOperationHandle op, GtkUnit unit);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_print_operation_set_use_full_page(GtkPrintOperationHandle op, bool full_page);

}
