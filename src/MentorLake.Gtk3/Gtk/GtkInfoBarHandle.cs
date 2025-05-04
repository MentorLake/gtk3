namespace MentorLake.Gtk;

public class GtkInfoBarHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkInfoBarHandle New()
	{
		return GtkInfoBarHandleExterns.gtk_info_bar_new();
	}

	public static MentorLake.Gtk.GtkInfoBarHandle NewWithButtons(string first_button_text, IntPtr @__arglist)
	{
		return GtkInfoBarHandleExterns.gtk_info_bar_new_with_buttons(first_button_text, @__arglist);
	}

}
public static class GtkInfoBarHandleSignalExtensions
{

	public static IObservable<GtkInfoBarHandleSignalStructs.CloseSignal> Signal_Close(this GtkInfoBarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkInfoBarHandleSignalStructs.CloseSignal> obs) =>
		{
			GtkInfoBarHandleSignalDelegates.close handler = ( MentorLake.Gtk.GtkInfoBarHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkInfoBarHandleSignalStructs.CloseSignal()
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

	public static IObservable<GtkInfoBarHandleSignalStructs.ResponseSignal> Signal_Response(this GtkInfoBarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkInfoBarHandleSignalStructs.ResponseSignal> obs) =>
		{
			GtkInfoBarHandleSignalDelegates.response handler = ( MentorLake.Gtk.GtkInfoBarHandle self,  MentorLake.Gtk.GtkResponseType response_id,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkInfoBarHandleSignalStructs.ResponseSignal()
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

public static class GtkInfoBarHandleSignalStructs
{

public class CloseSignal
{
	public MentorLake.Gtk.GtkInfoBarHandle Self;
	public IntPtr UserData;
}

public class ResponseSignal
{
	public MentorLake.Gtk.GtkInfoBarHandle Self;
	public MentorLake.Gtk.GtkResponseType ResponseId;
	public IntPtr UserData;
}
}

public static class GtkInfoBarHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle self, MentorLake.Gtk.GtkResponseType response_id, IntPtr user_data);

}


public static class GtkInfoBarHandleExtensions
{
	public static T AddActionWidget<T>(this T info_bar, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkResponseType response_id) where T : GtkInfoBarHandle
	{
		if (info_bar.IsInvalid || info_bar.IsClosed) throw new Exception("Invalid or closed handle (GtkInfoBarHandle)");
		GtkInfoBarHandleExterns.gtk_info_bar_add_action_widget(info_bar, child, response_id);
		return info_bar;
	}

	public static MentorLake.Gtk.GtkWidgetHandle AddButton(this MentorLake.Gtk.GtkInfoBarHandle info_bar, string button_text, MentorLake.Gtk.GtkResponseType response_id)
	{
		if (info_bar.IsInvalid || info_bar.IsClosed) throw new Exception("Invalid or closed handle (GtkInfoBarHandle)");
		return GtkInfoBarHandleExterns.gtk_info_bar_add_button(info_bar, button_text, response_id);
	}

	public static T AddButtons<T>(this T info_bar, string first_button_text, IntPtr @__arglist) where T : GtkInfoBarHandle
	{
		if (info_bar.IsInvalid || info_bar.IsClosed) throw new Exception("Invalid or closed handle (GtkInfoBarHandle)");
		GtkInfoBarHandleExterns.gtk_info_bar_add_buttons(info_bar, first_button_text, @__arglist);
		return info_bar;
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetActionArea(this MentorLake.Gtk.GtkInfoBarHandle info_bar)
	{
		if (info_bar.IsInvalid || info_bar.IsClosed) throw new Exception("Invalid or closed handle (GtkInfoBarHandle)");
		return GtkInfoBarHandleExterns.gtk_info_bar_get_action_area(info_bar);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetContentArea(this MentorLake.Gtk.GtkInfoBarHandle info_bar)
	{
		if (info_bar.IsInvalid || info_bar.IsClosed) throw new Exception("Invalid or closed handle (GtkInfoBarHandle)");
		return GtkInfoBarHandleExterns.gtk_info_bar_get_content_area(info_bar);
	}

	public static MentorLake.Gtk.GtkMessageType GetMessageType(this MentorLake.Gtk.GtkInfoBarHandle info_bar)
	{
		if (info_bar.IsInvalid || info_bar.IsClosed) throw new Exception("Invalid or closed handle (GtkInfoBarHandle)");
		return GtkInfoBarHandleExterns.gtk_info_bar_get_message_type(info_bar);
	}

	public static bool GetRevealed(this MentorLake.Gtk.GtkInfoBarHandle info_bar)
	{
		if (info_bar.IsInvalid || info_bar.IsClosed) throw new Exception("Invalid or closed handle (GtkInfoBarHandle)");
		return GtkInfoBarHandleExterns.gtk_info_bar_get_revealed(info_bar);
	}

	public static bool GetShowCloseButton(this MentorLake.Gtk.GtkInfoBarHandle info_bar)
	{
		if (info_bar.IsInvalid || info_bar.IsClosed) throw new Exception("Invalid or closed handle (GtkInfoBarHandle)");
		return GtkInfoBarHandleExterns.gtk_info_bar_get_show_close_button(info_bar);
	}

	public static T Response<T>(this T info_bar, MentorLake.Gtk.GtkResponseType response_id) where T : GtkInfoBarHandle
	{
		if (info_bar.IsInvalid || info_bar.IsClosed) throw new Exception("Invalid or closed handle (GtkInfoBarHandle)");
		GtkInfoBarHandleExterns.gtk_info_bar_response(info_bar, response_id);
		return info_bar;
	}

	public static T SetDefaultResponse<T>(this T info_bar, MentorLake.Gtk.GtkResponseType response_id) where T : GtkInfoBarHandle
	{
		if (info_bar.IsInvalid || info_bar.IsClosed) throw new Exception("Invalid or closed handle (GtkInfoBarHandle)");
		GtkInfoBarHandleExterns.gtk_info_bar_set_default_response(info_bar, response_id);
		return info_bar;
	}

	public static T SetMessageType<T>(this T info_bar, MentorLake.Gtk.GtkMessageType message_type) where T : GtkInfoBarHandle
	{
		if (info_bar.IsInvalid || info_bar.IsClosed) throw new Exception("Invalid or closed handle (GtkInfoBarHandle)");
		GtkInfoBarHandleExterns.gtk_info_bar_set_message_type(info_bar, message_type);
		return info_bar;
	}

	public static T SetResponseSensitive<T>(this T info_bar, MentorLake.Gtk.GtkResponseType response_id, bool setting) where T : GtkInfoBarHandle
	{
		if (info_bar.IsInvalid || info_bar.IsClosed) throw new Exception("Invalid or closed handle (GtkInfoBarHandle)");
		GtkInfoBarHandleExterns.gtk_info_bar_set_response_sensitive(info_bar, response_id, setting);
		return info_bar;
	}

	public static T SetRevealed<T>(this T info_bar, bool revealed) where T : GtkInfoBarHandle
	{
		if (info_bar.IsInvalid || info_bar.IsClosed) throw new Exception("Invalid or closed handle (GtkInfoBarHandle)");
		GtkInfoBarHandleExterns.gtk_info_bar_set_revealed(info_bar, revealed);
		return info_bar;
	}

	public static T SetShowCloseButton<T>(this T info_bar, bool setting) where T : GtkInfoBarHandle
	{
		if (info_bar.IsInvalid || info_bar.IsClosed) throw new Exception("Invalid or closed handle (GtkInfoBarHandle)");
		GtkInfoBarHandleExterns.gtk_info_bar_set_show_close_button(info_bar, setting);
		return info_bar;
	}

}

internal class GtkInfoBarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkInfoBarHandle gtk_info_bar_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkInfoBarHandle gtk_info_bar_new_with_buttons(string first_button_text, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_info_bar_add_action_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_info_bar_add_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, string button_text, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_info_bar_add_buttons([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, string first_button_text, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_info_bar_get_action_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_info_bar_get_content_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkMessageType gtk_info_bar_get_message_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_info_bar_get_revealed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_info_bar_get_show_close_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_info_bar_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_info_bar_set_default_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, MentorLake.Gtk.GtkResponseType response_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_info_bar_set_message_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, MentorLake.Gtk.GtkMessageType message_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_info_bar_set_response_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, MentorLake.Gtk.GtkResponseType response_id, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_info_bar_set_revealed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, bool revealed);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_info_bar_set_show_close_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkInfoBarHandle>))] MentorLake.Gtk.GtkInfoBarHandle info_bar, bool setting);

}
