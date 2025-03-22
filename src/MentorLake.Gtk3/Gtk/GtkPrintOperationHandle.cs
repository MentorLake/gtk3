namespace MentorLake.Gtk;

public class GtkPrintOperationHandle : GObjectHandle, GtkPrintOperationPreviewHandle
{
	public static MentorLake.Gtk.GtkPrintOperationHandle New()
	{
		return GtkPrintOperationHandleExterns.gtk_print_operation_new();
	}

}
public static class GtkPrintOperationHandleSignalExtensions
{

	public static IObservable<GtkPrintOperationHandleSignalStructs.BeginPrintSignal> Signal_BeginPrint(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.BeginPrintSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.begin_print handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkPrintContextHandle context,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.BeginPrintSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "begin-print", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkPrintOperationHandleSignalStructs.CreateCustomWidgetSignal> Signal_CreateCustomWidget(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.CreateCustomWidgetSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.create_custom_widget handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.CreateCustomWidgetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "create-custom-widget", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkPrintOperationHandleSignalStructs.CustomWidgetApplySignal> Signal_CustomWidgetApply(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.CustomWidgetApplySignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.custom_widget_apply handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkWidgetHandle widget,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.CustomWidgetApplySignal()
				{
					Self = self, Widget = widget, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "custom-widget-apply", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkPrintOperationHandleSignalStructs.DoneSignal> Signal_Done(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.DoneSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.done handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkPrintOperationResult result,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.DoneSignal()
				{
					Self = self, Result = result, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "done", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkPrintOperationHandleSignalStructs.DrawPageSignal> Signal_DrawPage(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.DrawPageSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.draw_page handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkPrintContextHandle context,  int page_nr,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.DrawPageSignal()
				{
					Self = self, Context = context, PageNr = page_nr, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "draw-page", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkPrintOperationHandleSignalStructs.EndPrintSignal> Signal_EndPrint(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.EndPrintSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.end_print handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkPrintContextHandle context,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.EndPrintSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "end-print", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkPrintOperationHandleSignalStructs.PaginateSignal> Signal_Paginate(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.PaginateSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.paginate handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkPrintContextHandle context,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.PaginateSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "paginate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkPrintOperationHandleSignalStructs.PreviewSignal> Signal_Preview(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.PreviewSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.preview handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkPrintOperationPreviewHandle preview,  MentorLake.Gtk.GtkPrintContextHandle context,  MentorLake.Gtk.GtkWindowHandle parent,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.PreviewSignal()
				{
					Self = self, Preview = preview, Context = context, Parent = parent, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "preview", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkPrintOperationHandleSignalStructs.RequestPageSetupSignal> Signal_RequestPageSetup(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.RequestPageSetupSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.request_page_setup handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkPrintContextHandle context,  int page_nr,  MentorLake.Gtk.GtkPageSetupHandle setup,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.RequestPageSetupSignal()
				{
					Self = self, Context = context, PageNr = page_nr, Setup = setup, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "request-page-setup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkPrintOperationHandleSignalStructs.StatusChangedSignal> Signal_StatusChanged(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.StatusChangedSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.status_changed handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.StatusChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "status-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkPrintOperationHandleSignalStructs.UpdateCustomWidgetSignal> Signal_UpdateCustomWidget(this GtkPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPrintOperationHandleSignalStructs.UpdateCustomWidgetSignal> obs) =>
		{
			GtkPrintOperationHandleSignalDelegates.update_custom_widget handler = ( MentorLake.Gtk.GtkPrintOperationHandle self,  MentorLake.Gtk.GtkWidgetHandle widget,  MentorLake.Gtk.GtkPageSetupHandle setup,  MentorLake.Gtk.GtkPrintSettingsHandle settings,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPrintOperationHandleSignalStructs.UpdateCustomWidgetSignal()
				{
					Self = self, Widget = widget, Setup = setup, Settings = settings, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "update-custom-widget", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkPrintOperationHandleSignalStructs
{

public struct BeginPrintSignal
{
	public MentorLake.Gtk.GtkPrintOperationHandle Self;
	public MentorLake.Gtk.GtkPrintContextHandle Context;
	public IntPtr UserData;
}

public struct CreateCustomWidgetSignal
{
	public MentorLake.Gtk.GtkPrintOperationHandle Self;
	public IntPtr UserData;
	public MentorLake.GObject.GObjectHandle ReturnValue;
}

public struct CustomWidgetApplySignal
{
	public MentorLake.Gtk.GtkPrintOperationHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Widget;
	public IntPtr UserData;
}

public struct DoneSignal
{
	public MentorLake.Gtk.GtkPrintOperationHandle Self;
	public MentorLake.Gtk.GtkPrintOperationResult Result;
	public IntPtr UserData;
}

public struct DrawPageSignal
{
	public MentorLake.Gtk.GtkPrintOperationHandle Self;
	public MentorLake.Gtk.GtkPrintContextHandle Context;
	public int PageNr;
	public IntPtr UserData;
}

public struct EndPrintSignal
{
	public MentorLake.Gtk.GtkPrintOperationHandle Self;
	public MentorLake.Gtk.GtkPrintContextHandle Context;
	public IntPtr UserData;
}

public struct PaginateSignal
{
	public MentorLake.Gtk.GtkPrintOperationHandle Self;
	public MentorLake.Gtk.GtkPrintContextHandle Context;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct PreviewSignal
{
	public MentorLake.Gtk.GtkPrintOperationHandle Self;
	public MentorLake.Gtk.GtkPrintOperationPreviewHandle Preview;
	public MentorLake.Gtk.GtkPrintContextHandle Context;
	public MentorLake.Gtk.GtkWindowHandle Parent;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct RequestPageSetupSignal
{
	public MentorLake.Gtk.GtkPrintOperationHandle Self;
	public MentorLake.Gtk.GtkPrintContextHandle Context;
	public int PageNr;
	public MentorLake.Gtk.GtkPageSetupHandle Setup;
	public IntPtr UserData;
}

public struct StatusChangedSignal
{
	public MentorLake.Gtk.GtkPrintOperationHandle Self;
	public IntPtr UserData;
}

public struct UpdateCustomWidgetSignal
{
	public MentorLake.Gtk.GtkPrintOperationHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Widget;
	public MentorLake.Gtk.GtkPageSetupHandle Setup;
	public MentorLake.Gtk.GtkPrintSettingsHandle Settings;
	public IntPtr UserData;
}
}

public static class GtkPrintOperationHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void begin_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.GObject.GObjectHandle create_custom_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void custom_widget_apply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, MentorLake.Gtk.GtkPrintOperationResult result, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void draw_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context, int page_nr, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void end_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool paginate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool preview([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationPreviewHandleImpl>))] MentorLake.Gtk.GtkPrintOperationPreviewHandle preview, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void request_page_setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintContextHandle>))] MentorLake.Gtk.GtkPrintContextHandle context, int page_nr, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void status_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void update_custom_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle setup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle settings, IntPtr user_data);

}


public static class GtkPrintOperationHandleExtensions
{
	public static T Cancel<T>(this T op) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_cancel(op);
		return op;
	}

	public static T DrawPageFinish<T>(this T op) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_draw_page_finish(op);
		return op;
	}

	public static MentorLake.Gtk.GtkPageSetupHandle GetDefaultPageSetup(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		return GtkPrintOperationHandleExterns.gtk_print_operation_get_default_page_setup(op);
	}

	public static bool GetEmbedPageSetup(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		return GtkPrintOperationHandleExterns.gtk_print_operation_get_embed_page_setup(op);
	}

	public static T GetError<T>(this T op) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_get_error(op);
		return op;
	}

	public static bool GetHasSelection(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		return GtkPrintOperationHandleExterns.gtk_print_operation_get_has_selection(op);
	}

	public static int GetNPagesToPrint(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		return GtkPrintOperationHandleExterns.gtk_print_operation_get_n_pages_to_print(op);
	}

	public static MentorLake.Gtk.GtkPrintSettingsHandle GetPrintSettings(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		return GtkPrintOperationHandleExterns.gtk_print_operation_get_print_settings(op);
	}

	public static MentorLake.Gtk.GtkPrintStatus GetStatus(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		return GtkPrintOperationHandleExterns.gtk_print_operation_get_status(op);
	}

	public static string GetStatusString(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		return GtkPrintOperationHandleExterns.gtk_print_operation_get_status_string(op);
	}

	public static bool GetSupportSelection(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		return GtkPrintOperationHandleExterns.gtk_print_operation_get_support_selection(op);
	}

	public static bool IsFinished(this MentorLake.Gtk.GtkPrintOperationHandle op)
	{
		return GtkPrintOperationHandleExterns.gtk_print_operation_is_finished(op);
	}

	public static MentorLake.Gtk.GtkPrintOperationResult Run(this MentorLake.Gtk.GtkPrintOperationHandle op, MentorLake.Gtk.GtkPrintOperationAction action, MentorLake.Gtk.GtkWindowHandle parent)
	{
		return GtkPrintOperationHandleExterns.gtk_print_operation_run(op, action, parent);
	}

	public static T SetAllowAsync<T>(this T op, bool allow_async) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_set_allow_async(op, allow_async);
		return op;
	}

	public static T SetCurrentPage<T>(this T op, int current_page) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_set_current_page(op, current_page);
		return op;
	}

	public static T SetCustomTabLabel<T>(this T op, string label) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_set_custom_tab_label(op, label);
		return op;
	}

	public static T SetDefaultPageSetup<T>(this T op, MentorLake.Gtk.GtkPageSetupHandle default_page_setup) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_set_default_page_setup(op, default_page_setup);
		return op;
	}

	public static T SetDeferDrawing<T>(this T op) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_set_defer_drawing(op);
		return op;
	}

	public static T SetEmbedPageSetup<T>(this T op, bool embed) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_set_embed_page_setup(op, embed);
		return op;
	}

	public static T SetExportFilename<T>(this T op, string filename) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_set_export_filename(op, filename);
		return op;
	}

	public static T SetHasSelection<T>(this T op, bool has_selection) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_set_has_selection(op, has_selection);
		return op;
	}

	public static T SetJobName<T>(this T op, string job_name) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_set_job_name(op, job_name);
		return op;
	}

	public static T SetNPages<T>(this T op, int n_pages) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_set_n_pages(op, n_pages);
		return op;
	}

	public static T SetPrintSettings<T>(this T op, MentorLake.Gtk.GtkPrintSettingsHandle print_settings) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_set_print_settings(op, print_settings);
		return op;
	}

	public static T SetShowProgress<T>(this T op, bool show_progress) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_set_show_progress(op, show_progress);
		return op;
	}

	public static T SetSupportSelection<T>(this T op, bool support_selection) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_set_support_selection(op, support_selection);
		return op;
	}

	public static T SetTrackPrintStatus<T>(this T op, bool track_status) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_set_track_print_status(op, track_status);
		return op;
	}

	public static T SetUnit<T>(this T op, MentorLake.Gtk.GtkUnit unit) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_set_unit(op, unit);
		return op;
	}

	public static T SetUseFullPage<T>(this T op, bool full_page) where T : GtkPrintOperationHandle
	{
		GtkPrintOperationHandleExterns.gtk_print_operation_set_use_full_page(op, full_page);
		return op;
	}

}

internal class GtkPrintOperationHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPrintOperationHandle gtk_print_operation_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_cancel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_draw_page_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPageSetupHandle gtk_print_operation_get_default_page_setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_operation_get_embed_page_setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_get_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_operation_get_has_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_print_operation_get_n_pages_to_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPrintSettingsHandle gtk_print_operation_get_print_settings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPrintStatus gtk_print_operation_get_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_print_operation_get_status_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_operation_get_support_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_print_operation_is_finished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPrintOperationResult gtk_print_operation_run([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, MentorLake.Gtk.GtkPrintOperationAction action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_allow_async([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, bool allow_async);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_current_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, int current_page);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_custom_tab_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_default_page_setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle default_page_setup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_defer_drawing([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_embed_page_setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, bool embed);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_export_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, string filename);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_has_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, bool has_selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_job_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, string job_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_n_pages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, int n_pages);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_print_settings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle print_settings);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_show_progress([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, bool show_progress);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_support_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, bool support_selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_track_print_status([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, bool track_status);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_unit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, MentorLake.Gtk.GtkUnit unit);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_print_operation_set_use_full_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintOperationHandle>))] MentorLake.Gtk.GtkPrintOperationHandle op, bool full_page);

}
