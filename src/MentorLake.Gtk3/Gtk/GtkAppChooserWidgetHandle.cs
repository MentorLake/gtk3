namespace MentorLake.Gtk;

public class GtkAppChooserWidgetHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkAppChooserHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkAppChooserWidgetHandle New(string content_type)
	{
		return GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_new(content_type);
	}

}
public static class GtkAppChooserWidgetHandleSignalExtensions
{

	public static IObservable<GtkAppChooserWidgetHandleSignalStructs.ApplicationActivatedSignal> Signal_ApplicationActivated(this GtkAppChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAppChooserWidgetHandleSignalStructs.ApplicationActivatedSignal> obs) =>
		{
			GtkAppChooserWidgetHandleSignalDelegates.application_activated handler = ( MentorLake.Gtk.GtkAppChooserWidgetHandle self,  MentorLake.Gio.GAppInfoHandle application,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAppChooserWidgetHandleSignalStructs.ApplicationActivatedSignal()
				{
					Self = self, Application = application, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "application-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkAppChooserWidgetHandleSignalStructs.ApplicationSelectedSignal> Signal_ApplicationSelected(this GtkAppChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAppChooserWidgetHandleSignalStructs.ApplicationSelectedSignal> obs) =>
		{
			GtkAppChooserWidgetHandleSignalDelegates.application_selected handler = ( MentorLake.Gtk.GtkAppChooserWidgetHandle self,  MentorLake.Gio.GAppInfoHandle application,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAppChooserWidgetHandleSignalStructs.ApplicationSelectedSignal()
				{
					Self = self, Application = application, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "application-selected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkAppChooserWidgetHandleSignalStructs.PopulatePopupSignal> Signal_PopulatePopup(this GtkAppChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkAppChooserWidgetHandleSignalStructs.PopulatePopupSignal> obs) =>
		{
			GtkAppChooserWidgetHandleSignalDelegates.populate_popup handler = ( MentorLake.Gtk.GtkAppChooserWidgetHandle self,  MentorLake.Gtk.GtkMenuHandle menu,  MentorLake.Gio.GAppInfoHandle application,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAppChooserWidgetHandleSignalStructs.PopulatePopupSignal()
				{
					Self = self, Menu = menu, Application = application, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "populate-popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkAppChooserWidgetHandleSignalStructs
{

public class ApplicationActivatedSignal
{
	public MentorLake.Gtk.GtkAppChooserWidgetHandle Self;
	public MentorLake.Gio.GAppInfoHandle Application;
	public IntPtr UserData;
}

public class ApplicationSelectedSignal
{
	public MentorLake.Gtk.GtkAppChooserWidgetHandle Self;
	public MentorLake.Gio.GAppInfoHandle Application;
	public IntPtr UserData;
}

public class PopulatePopupSignal
{
	public MentorLake.Gtk.GtkAppChooserWidgetHandle Self;
	public MentorLake.Gtk.GtkMenuHandle Menu;
	public MentorLake.Gio.GAppInfoHandle Application;
	public IntPtr UserData;
}
}

public static class GtkAppChooserWidgetHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void application_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle application, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void application_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle application, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void populate_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle application, IntPtr user_data);

}


public static class GtkAppChooserWidgetHandleExtensions
{
	public static string GetDefaultText(this MentorLake.Gtk.GtkAppChooserWidgetHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserWidgetHandle)");
		return GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_get_default_text(self);
	}

	public static bool GetShowAll(this MentorLake.Gtk.GtkAppChooserWidgetHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserWidgetHandle)");
		return GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_get_show_all(self);
	}

	public static bool GetShowDefault(this MentorLake.Gtk.GtkAppChooserWidgetHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserWidgetHandle)");
		return GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_get_show_default(self);
	}

	public static bool GetShowFallback(this MentorLake.Gtk.GtkAppChooserWidgetHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserWidgetHandle)");
		return GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_get_show_fallback(self);
	}

	public static bool GetShowOther(this MentorLake.Gtk.GtkAppChooserWidgetHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserWidgetHandle)");
		return GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_get_show_other(self);
	}

	public static bool GetShowRecommended(this MentorLake.Gtk.GtkAppChooserWidgetHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserWidgetHandle)");
		return GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_get_show_recommended(self);
	}

	public static T SetDefaultText<T>(this T self, string text) where T : GtkAppChooserWidgetHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserWidgetHandle)");
		GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_set_default_text(self, text);
		return self;
	}

	public static T SetShowAll<T>(this T self, bool setting) where T : GtkAppChooserWidgetHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserWidgetHandle)");
		GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_set_show_all(self, setting);
		return self;
	}

	public static T SetShowDefault<T>(this T self, bool setting) where T : GtkAppChooserWidgetHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserWidgetHandle)");
		GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_set_show_default(self, setting);
		return self;
	}

	public static T SetShowFallback<T>(this T self, bool setting) where T : GtkAppChooserWidgetHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserWidgetHandle)");
		GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_set_show_fallback(self, setting);
		return self;
	}

	public static T SetShowOther<T>(this T self, bool setting) where T : GtkAppChooserWidgetHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserWidgetHandle)");
		GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_set_show_other(self, setting);
		return self;
	}

	public static T SetShowRecommended<T>(this T self, bool setting) where T : GtkAppChooserWidgetHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkAppChooserWidgetHandle)");
		GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_set_show_recommended(self, setting);
		return self;
	}

}

internal class GtkAppChooserWidgetHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAppChooserWidgetHandle gtk_app_chooser_widget_new(string content_type);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_app_chooser_widget_get_default_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_app_chooser_widget_get_show_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_app_chooser_widget_get_show_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_app_chooser_widget_get_show_fallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_app_chooser_widget_get_show_other([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_app_chooser_widget_get_show_recommended([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_widget_set_default_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_widget_set_show_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_widget_set_show_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_widget_set_show_fallback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_widget_set_show_other([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_app_chooser_widget_set_show_recommended([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self, bool setting);

}
