namespace MentorLake.Gtk;

public class GtkDialogHandle : GtkWindowHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkDialogHandle New()
	{
		return GtkDialogHandleExterns.gtk_dialog_new();
	}

	public static MentorLake.Gtk.GtkDialogHandle NewWithButtons(string title, MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, string first_button_text, IntPtr @__arglist)
	{
		return GtkDialogHandleExterns.gtk_dialog_new_with_buttons(title, parent, flags, first_button_text, @__arglist);
	}

}
public static class GtkDialogHandleSignalExtensions
{

	public static IObservable<GtkDialogHandleSignalStructs.CloseSignal> Signal_Close(this GtkDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkDialogHandleSignalStructs.CloseSignal> obs) =>
		{
			GtkDialogHandleSignalDelegates.close handler = ( MentorLake.Gtk.GtkDialogHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDialogHandleSignalStructs.CloseSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "close", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkDialogHandleSignalStructs.ResponseSignal> Signal_Response(this GtkDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkDialogHandleSignalStructs.ResponseSignal> obs) =>
		{
			GtkDialogHandleSignalDelegates.response handler = ( MentorLake.Gtk.GtkDialogHandle self,  MentorLake.Gtk.GtkResponseType response_id,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkDialogHandleSignalStructs.ResponseSignal()
				{
					Self = self, ResponseId = response_id, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "response", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkDialogHandleSignalStructs
{

public class CloseSignal
{
	public MentorLake.Gtk.GtkDialogHandle Self;
	public IntPtr UserData;
}

public class ResponseSignal
{
	public MentorLake.Gtk.GtkDialogHandle Self;
	public MentorLake.Gtk.GtkResponseType ResponseId;
	public IntPtr UserData;
}
}

public static class GtkDialogHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle self, MentorLake.Gtk.GtkResponseType response_id, IntPtr user_data);

}


public static class GtkDialogHandleExtensions
{
	public static T AddActionWidget<T>(this T dialog, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkResponseType response_id) where T : GtkDialogHandle
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		GtkDialogHandleExterns.gtk_dialog_add_action_widget(dialog, child, response_id);
		return dialog;
	}

	public static MentorLake.Gtk.GtkWidgetHandle AddButton(this MentorLake.Gtk.GtkDialogHandle dialog, string button_text, MentorLake.Gtk.GtkResponseType response_id)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		return GtkDialogHandleExterns.gtk_dialog_add_button(dialog, button_text, response_id);
	}

	public static T AddButtons<T>(this T dialog, string first_button_text, IntPtr @__arglist) where T : GtkDialogHandle
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		GtkDialogHandleExterns.gtk_dialog_add_buttons(dialog, first_button_text, @__arglist);
		return dialog;
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetActionArea(this MentorLake.Gtk.GtkDialogHandle dialog)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		return GtkDialogHandleExterns.gtk_dialog_get_action_area(dialog);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetContentArea(this MentorLake.Gtk.GtkDialogHandle dialog)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		return GtkDialogHandleExterns.gtk_dialog_get_content_area(dialog);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetHeaderBar(this MentorLake.Gtk.GtkDialogHandle dialog)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		return GtkDialogHandleExterns.gtk_dialog_get_header_bar(dialog);
	}

	public static int GetResponseForWidget(this MentorLake.Gtk.GtkDialogHandle dialog, MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		return GtkDialogHandleExterns.gtk_dialog_get_response_for_widget(dialog, widget);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetWidgetForResponse(this MentorLake.Gtk.GtkDialogHandle dialog, MentorLake.Gtk.GtkResponseType response_id)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		return GtkDialogHandleExterns.gtk_dialog_get_widget_for_response(dialog, response_id);
	}

	public static T Response<T>(this T dialog, MentorLake.Gtk.GtkResponseType response_id) where T : GtkDialogHandle
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		GtkDialogHandleExterns.gtk_dialog_response(dialog, response_id);
		return dialog;
	}

	public static int Run(this MentorLake.Gtk.GtkDialogHandle dialog)
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		return GtkDialogHandleExterns.gtk_dialog_run(dialog);
	}

	public static T SetAlternativeButtonOrder<T>(this T dialog, int first_response_id, IntPtr @__arglist) where T : GtkDialogHandle
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		GtkDialogHandleExterns.gtk_dialog_set_alternative_button_order(dialog, first_response_id, @__arglist);
		return dialog;
	}

	public static T SetAlternativeButtonOrderFromArray<T>(this T dialog, int n_params, int[] new_order) where T : GtkDialogHandle
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		GtkDialogHandleExterns.gtk_dialog_set_alternative_button_order_from_array(dialog, n_params, new_order);
		return dialog;
	}

	public static T SetDefaultResponse<T>(this T dialog, MentorLake.Gtk.GtkResponseType response_id) where T : GtkDialogHandle
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		GtkDialogHandleExterns.gtk_dialog_set_default_response(dialog, response_id);
		return dialog;
	}

	public static T SetResponseSensitive<T>(this T dialog, MentorLake.Gtk.GtkResponseType response_id, bool setting) where T : GtkDialogHandle
	{
		if (dialog.IsInvalid) throw new Exception("Invalid handle (GtkDialogHandle)");
		GtkDialogHandleExterns.gtk_dialog_set_response_sensitive(dialog, response_id, setting);
		return dialog;
	}

}

internal class GtkDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))]
	internal static extern MentorLake.Gtk.GtkDialogHandle gtk_dialog_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))]
	internal static extern MentorLake.Gtk.GtkDialogHandle gtk_dialog_new_with_buttons(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkDialogFlags flags, string first_button_text, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_dialog_add_action_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_dialog_add_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, string button_text, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_dialog_add_buttons([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, string first_button_text, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_dialog_get_action_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_dialog_get_content_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_dialog_get_header_bar([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_dialog_get_response_for_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_dialog_get_widget_for_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_dialog_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_dialog_run([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_dialog_set_alternative_button_order([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, int first_response_id, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_dialog_set_alternative_button_order_from_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, int n_params, int[] new_order);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_dialog_set_default_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_dialog_set_response_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkDialogHandle>))] MentorLake.Gtk.GtkDialogHandle dialog, MentorLake.Gtk.GtkResponseType response_id, bool setting);

}
