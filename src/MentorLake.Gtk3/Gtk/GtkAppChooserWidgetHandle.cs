namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkAppChooserWidget is a widget for selecting applications.
/// It is the main building block for #GtkAppChooserDialog. Most
/// applications only need to use the latter; but you can use
/// this widget as part of a larger widget if you have special needs.
/// </para>
/// <para>
/// #GtkAppChooserWidget offers detailed control over what applications
/// are shown, using the
/// #GtkAppChooserWidget:show-default,
/// #GtkAppChooserWidget:show-recommended,
/// #GtkAppChooserWidget:show-fallback,
/// #GtkAppChooserWidget:show-other and
/// #GtkAppChooserWidget:show-all
/// properties. See the #GtkAppChooser documentation for more information
/// about these groups of applications.
/// </para>
/// <para>
/// To keep track of the selected application, use the
/// #GtkAppChooserWidget::application-selected and #GtkAppChooserWidget::application-activated signals.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkAppChooserWidget has a single CSS node with name appchooser.
/// </para>
/// </summary>

public class GtkAppChooserWidgetHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkAppChooserHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkAppChooserWidget for applications
/// that can handle content of the given type.
/// </para>
/// </summary>

/// <param name="content_type">
/// the content type to show applications for
/// </param>
/// <return>
/// a newly created #GtkAppChooserWidget
/// </return>

	public static MentorLake.Gtk.GtkAppChooserWidgetHandle New(string content_type)
	{
		return GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_new(content_type);
	}

}
public static class GtkAppChooserWidgetHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when an application item is activated from the widget's list.
/// </para>
/// <para>
/// This usually happens when the user double clicks an item, or an item
/// is selected and the user presses one of the keys Space, Shift+Space,
/// Return or Enter.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when an application item is selected from the widget's list.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Emitted when a context menu is about to popup over an application item.
/// Clients can insert menu items into the provided #GtkMenu object in the
/// callback of this signal; the context menu will be shown over the item
/// if at least one item has been added to the menu.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the activated #GAppInfo
/// </para>
/// </summary>

	public MentorLake.Gio.GAppInfoHandle Application;

	public IntPtr UserData;
}

public class ApplicationSelectedSignal
{

	public MentorLake.Gtk.GtkAppChooserWidgetHandle Self;
/// <summary>
/// <para>
/// the selected #GAppInfo
/// </para>
/// </summary>

	public MentorLake.Gio.GAppInfoHandle Application;

	public IntPtr UserData;
}

public class PopulatePopupSignal
{

	public MentorLake.Gtk.GtkAppChooserWidgetHandle Self;
/// <summary>
/// <para>
/// the #GtkMenu to populate
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkMenuHandle Menu;
/// <summary>
/// <para>
/// the current #GAppInfo
/// </para>
/// </summary>

	public MentorLake.Gio.GAppInfoHandle Application;

	public IntPtr UserData;
}
}

public static class GtkAppChooserWidgetHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when an application item is activated from the widget's list.
/// </para>
/// <para>
/// This usually happens when the user double clicks an item, or an item
/// is selected and the user presses one of the keys Space, Shift+Space,
/// Return or Enter.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="application">
/// the activated #GAppInfo
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void application_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle application, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when an application item is selected from the widget's list.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="application">
/// the selected #GAppInfo
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void application_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle application, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when a context menu is about to popup over an application item.
/// Clients can insert menu items into the provided #GtkMenu object in the
/// callback of this signal; the context menu will be shown over the item
/// if at least one item has been added to the menu.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="menu">
/// the #GtkMenu to populate
/// </param>
/// <param name="application">
/// the current #GAppInfo
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void populate_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))] MentorLake.Gtk.GtkAppChooserWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuHandle>))] MentorLake.Gtk.GtkMenuHandle menu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GAppInfoHandleImpl>))] MentorLake.Gio.GAppInfoHandle application, IntPtr user_data);

}


public static class GtkAppChooserWidgetHandleExtensions
{
/// <summary>
/// <para>
/// Returns the text that is shown if there are not applications
/// that can handle the content type.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserWidget
/// </param>
/// <return>
/// the value of #GtkAppChooserWidget:default-text
/// </return>

	public static string GetDefaultText(this MentorLake.Gtk.GtkAppChooserWidgetHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserWidgetHandle)");
		return GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_get_default_text(self);
	}

/// <summary>
/// <para>
/// Returns the current value of the #GtkAppChooserWidget:show-all
/// property.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserWidget
/// </param>
/// <return>
/// the value of #GtkAppChooserWidget:show-all
/// </return>

	public static bool GetShowAll(this MentorLake.Gtk.GtkAppChooserWidgetHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserWidgetHandle)");
		return GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_get_show_all(self);
	}

/// <summary>
/// <para>
/// Returns the current value of the #GtkAppChooserWidget:show-default
/// property.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserWidget
/// </param>
/// <return>
/// the value of #GtkAppChooserWidget:show-default
/// </return>

	public static bool GetShowDefault(this MentorLake.Gtk.GtkAppChooserWidgetHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserWidgetHandle)");
		return GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_get_show_default(self);
	}

/// <summary>
/// <para>
/// Returns the current value of the #GtkAppChooserWidget:show-fallback
/// property.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserWidget
/// </param>
/// <return>
/// the value of #GtkAppChooserWidget:show-fallback
/// </return>

	public static bool GetShowFallback(this MentorLake.Gtk.GtkAppChooserWidgetHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserWidgetHandle)");
		return GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_get_show_fallback(self);
	}

/// <summary>
/// <para>
/// Returns the current value of the #GtkAppChooserWidget:show-other
/// property.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserWidget
/// </param>
/// <return>
/// the value of #GtkAppChooserWidget:show-other
/// </return>

	public static bool GetShowOther(this MentorLake.Gtk.GtkAppChooserWidgetHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserWidgetHandle)");
		return GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_get_show_other(self);
	}

/// <summary>
/// <para>
/// Returns the current value of the #GtkAppChooserWidget:show-recommended
/// property.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserWidget
/// </param>
/// <return>
/// the value of #GtkAppChooserWidget:show-recommended
/// </return>

	public static bool GetShowRecommended(this MentorLake.Gtk.GtkAppChooserWidgetHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserWidgetHandle)");
		return GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_get_show_recommended(self);
	}

/// <summary>
/// <para>
/// Sets the text that is shown if there are not applications
/// that can handle the content type.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserWidget
/// </param>
/// <param name="text">
/// the new value for #GtkAppChooserWidget:default-text
/// </param>

	public static T SetDefaultText<T>(this T self, string text) where T : GtkAppChooserWidgetHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserWidgetHandle)");
		GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_set_default_text(self, text);
		return self;
	}

/// <summary>
/// <para>
/// Sets whether the app chooser should show all applications
/// in a flat list.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserWidget
/// </param>
/// <param name="setting">
/// the new value for #GtkAppChooserWidget:show-all
/// </param>

	public static T SetShowAll<T>(this T self, bool setting) where T : GtkAppChooserWidgetHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserWidgetHandle)");
		GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_set_show_all(self, setting);
		return self;
	}

/// <summary>
/// <para>
/// Sets whether the app chooser should show the default handler
/// for the content type in a separate section.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserWidget
/// </param>
/// <param name="setting">
/// the new value for #GtkAppChooserWidget:show-default
/// </param>

	public static T SetShowDefault<T>(this T self, bool setting) where T : GtkAppChooserWidgetHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserWidgetHandle)");
		GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_set_show_default(self, setting);
		return self;
	}

/// <summary>
/// <para>
/// Sets whether the app chooser should show related applications
/// for the content type in a separate section.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserWidget
/// </param>
/// <param name="setting">
/// the new value for #GtkAppChooserWidget:show-fallback
/// </param>

	public static T SetShowFallback<T>(this T self, bool setting) where T : GtkAppChooserWidgetHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserWidgetHandle)");
		GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_set_show_fallback(self, setting);
		return self;
	}

/// <summary>
/// <para>
/// Sets whether the app chooser should show applications
/// which are unrelated to the content type.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserWidget
/// </param>
/// <param name="setting">
/// the new value for #GtkAppChooserWidget:show-other
/// </param>

	public static T SetShowOther<T>(this T self, bool setting) where T : GtkAppChooserWidgetHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserWidgetHandle)");
		GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_set_show_other(self, setting);
		return self;
	}

/// <summary>
/// <para>
/// Sets whether the app chooser should show recommended applications
/// for the content type in a separate section.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkAppChooserWidget
/// </param>
/// <param name="setting">
/// the new value for #GtkAppChooserWidget:show-recommended
/// </param>

	public static T SetShowRecommended<T>(this T self, bool setting) where T : GtkAppChooserWidgetHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkAppChooserWidgetHandle)");
		GtkAppChooserWidgetHandleExterns.gtk_app_chooser_widget_set_show_recommended(self, setting);
		return self;
	}

}

internal class GtkAppChooserWidgetHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkAppChooserWidgetHandle>))]
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
