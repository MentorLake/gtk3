namespace MentorLake.Gtk;

public class GtkAppChooserButtonHandle : GtkComboBoxHandle, AtkImplementorIfaceHandle, GtkAppChooserHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkCellLayoutHandle
{
	public static MentorLake.Gtk.GtkAppChooserButtonHandle New(string content_type)
	{
		return GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_new(content_type);
	}

}
public static class GtkAppChooserButtonHandleSignalExtensions
{

	public static IObservable<GtkAppChooserButtonHandleSignalStructs.CustomItemActivatedSignal> Signal_CustomItemActivated(this GtkAppChooserButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAppChooserButtonHandleSignalStructs.CustomItemActivatedSignal> obs) =>
		{
			GtkAppChooserButtonHandleSignalDelegates.custom_item_activated handler = ( MentorLake.Gtk.GtkAppChooserButtonHandle self,  string item_name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAppChooserButtonHandleSignalStructs.CustomItemActivatedSignal()
				{
					Self = self, ItemName = item_name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "custom-item-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkAppChooserButtonHandleSignalStructs.EditingDoneSignal> Signal_EditingDone(this GtkAppChooserButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAppChooserButtonHandleSignalStructs.EditingDoneSignal> obs) =>
		{
			GtkAppChooserButtonHandleSignalDelegates.editing_done handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAppChooserButtonHandleSignalStructs.EditingDoneSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "editing-done", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkAppChooserButtonHandleSignalStructs.RemoveWidgetSignal> Signal_RemoveWidget(this GtkAppChooserButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAppChooserButtonHandleSignalStructs.RemoveWidgetSignal> obs) =>
		{
			GtkAppChooserButtonHandleSignalDelegates.remove_widget handler = ( MentorLake.Gtk.GtkCellEditableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAppChooserButtonHandleSignalStructs.RemoveWidgetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "remove-widget", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkAppChooserButtonHandleSignalStructs
{

public class CustomItemActivatedSignal
{
	public MentorLake.Gtk.GtkAppChooserButtonHandle Self;
	public string ItemName;
	public IntPtr UserData;
}

public class EditingDoneSignal
{
	public MentorLake.Gtk.GtkCellEditableHandle Self;
	public IntPtr UserData;
}

public class RemoveWidgetSignal
{
	public MentorLake.Gtk.GtkCellEditableHandle Self;
	public IntPtr UserData;
}
}

public static class GtkAppChooserButtonHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void custom_item_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self, string item_name, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void editing_done([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void remove_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellEditableHandleImpl>))] MentorLake.Gtk.GtkCellEditableHandle self, IntPtr user_data);

}


public static class GtkAppChooserButtonHandleExtensions
{
	public static T AppendCustomItem<T>(this T self, string name, string label, MentorLake.Gio.GIconHandle icon) where T : GtkAppChooserButtonHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserButtonHandle)");
		GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_append_custom_item(self, name, label, icon);
		return self;
	}

	public static T AppendSeparator<T>(this T self) where T : GtkAppChooserButtonHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserButtonHandle)");
		GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_append_separator(self);
		return self;
	}

	public static string GetHeading(this MentorLake.Gtk.GtkAppChooserButtonHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserButtonHandle)");
		return GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_get_heading(self);
	}

	public static bool GetShowDefaultItem(this MentorLake.Gtk.GtkAppChooserButtonHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserButtonHandle)");
		return GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_get_show_default_item(self);
	}

	public static bool GetShowDialogItem(this MentorLake.Gtk.GtkAppChooserButtonHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserButtonHandle)");
		return GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_get_show_dialog_item(self);
	}

	public static T SetActiveCustomItem<T>(this T self, string name) where T : GtkAppChooserButtonHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserButtonHandle)");
		GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_set_active_custom_item(self, name);
		return self;
	}

	public static T SetHeading<T>(this T self, string heading) where T : GtkAppChooserButtonHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserButtonHandle)");
		GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_set_heading(self, heading);
		return self;
	}

	public static T SetShowDefaultItem<T>(this T self, bool setting) where T : GtkAppChooserButtonHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserButtonHandle)");
		GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_set_show_default_item(self, setting);
		return self;
	}

	public static T SetShowDialogItem<T>(this T self, bool setting) where T : GtkAppChooserButtonHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserButtonHandle)");
		GtkAppChooserButtonHandleExterns.gtk_app_chooser_button_set_show_dialog_item(self, setting);
		return self;
	}

}

internal class GtkAppChooserButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAppChooserButtonHandle gtk_app_chooser_button_new(string content_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_button_append_custom_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self, string name, string label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_button_append_separator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_app_chooser_button_get_heading([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_app_chooser_button_get_show_default_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_app_chooser_button_get_show_dialog_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_button_set_active_custom_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_button_set_heading([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self, string heading);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_button_set_show_default_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_button_set_show_dialog_item([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserButtonHandle>))] MentorLake.Gtk.GtkAppChooserButtonHandle self, bool setting);

}
