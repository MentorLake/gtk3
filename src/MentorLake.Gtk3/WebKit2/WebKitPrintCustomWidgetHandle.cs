namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Allows to embed a custom widget in print dialog.
/// </para>
/// <para>
/// A WebKitPrintCustomWidget allows to embed a custom widget in the print
/// dialog by connecting to the #WebKitPrintOperation::create-custom-widget
/// signal, creating a new WebKitPrintCustomWidget with
/// webkit_print_custom_widget_new() and returning it from there. You can later
/// use webkit_print_operation_run_dialog() to display the dialog.
/// </para>
/// <para>
/// Unfortunately, use of custom widgets is incompatible with modern
/// containerized application frameworks like Flatpak. A print dialog
/// constructed in the application process will not have access to host
/// printers, so instead it must be constructed by a desktop portal service
/// running on the host system. Because this print dialog runs in a separate
/// process, it&apos;s not possible to attach a custom widget.
/// </para>
/// </summary>

public class WebKitPrintCustomWidgetHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Create a new #WebKitPrintCustomWidget with given @widget and @title.
/// </para>
/// <para>
/// The @widget
/// ownership is taken and it is destroyed together with the dialog even if this
/// object could still be alive at that point. You typically want to pass a container
/// widget with multiple widgets in it.
/// </para>
/// </summary>

/// <param name="widget">
/// a #GtkWidget
/// </param>
/// <param name="title">
/// a @widget&apos;s title
/// </param>
/// <return>
/// a new #WebKitPrintOperation.
/// </return>

	public static MentorLake.WebKit2.WebKitPrintCustomWidgetHandle New(MentorLake.Gtk.GtkWidgetHandle widget, string title)
	{
		return WebKitPrintCustomWidgetHandleExterns.webkit_print_custom_widget_new(widget, title);
	}

}
public static class WebKitPrintCustomWidgetHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted right before the printing will start. You should read the information
/// from the widget and update the content based on it if necessary. The widget
/// is not guaranteed to be valid at a later time.
/// </para>
/// </summary>

	public static IObservable<WebKitPrintCustomWidgetHandleSignalStructs.ApplySignal> Signal_Apply(this WebKitPrintCustomWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitPrintCustomWidgetHandleSignalStructs.ApplySignal> obs) =>
		{
			WebKitPrintCustomWidgetHandleSignalDelegates.apply handler = ( MentorLake.WebKit2.WebKitPrintCustomWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitPrintCustomWidgetHandleSignalStructs.ApplySignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "apply", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted after change of selected printer in the dialog. The actual page setup
/// and print settings are available and the custom widget can actualize itself
/// according to their values.
/// </para>
/// </summary>

	public static IObservable<WebKitPrintCustomWidgetHandleSignalStructs.UpdateSignal> Signal_Update(this WebKitPrintCustomWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitPrintCustomWidgetHandleSignalStructs.UpdateSignal> obs) =>
		{
			WebKitPrintCustomWidgetHandleSignalDelegates.update handler = ( MentorLake.WebKit2.WebKitPrintCustomWidgetHandle self,  MentorLake.Gtk.GtkPageSetupHandle page_setup,  MentorLake.Gtk.GtkPrintSettingsHandle print_settings,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitPrintCustomWidgetHandleSignalStructs.UpdateSignal()
				{
					Self = self, PageSetup = page_setup, PrintSettings = print_settings, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "update", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitPrintCustomWidgetHandleSignalStructs
{

public class ApplySignal
{

	public MentorLake.WebKit2.WebKitPrintCustomWidgetHandle Self;

	public IntPtr UserData;
}

public class UpdateSignal
{

	public MentorLake.WebKit2.WebKitPrintCustomWidgetHandle Self;
/// <summary>
/// <para>
/// actual page setup
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPageSetupHandle PageSetup;
/// <summary>
/// <para>
/// actual print settings
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPrintSettingsHandle PrintSettings;

	public IntPtr UserData;
}
}

public static class WebKitPrintCustomWidgetHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted right before the printing will start. You should read the information
/// from the widget and update the content based on it if necessary. The widget
/// is not guaranteed to be valid at a later time.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void apply([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPrintCustomWidgetHandle>))] MentorLake.WebKit2.WebKitPrintCustomWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted after change of selected printer in the dialog. The actual page setup
/// and print settings are available and the custom widget can actualize itself
/// according to their values.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="page_setup">
/// actual page setup
/// </param>
/// <param name="print_settings">
/// actual print settings
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void update([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPrintCustomWidgetHandle>))] MentorLake.WebKit2.WebKitPrintCustomWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle page_setup, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle print_settings, IntPtr user_data);

}


public static class WebKitPrintCustomWidgetHandleExtensions
{
/// <summary>
/// <para>
/// Return the value of #WebKitPrintCustomWidget:title property.
/// </para>
/// <para>
/// Return the value of #WebKitPrintCustomWidget:title property for the given
/// @print_custom_widget object.
/// </para>
/// </summary>

/// <param name="print_custom_widget">
/// a #WebKitPrintCustomWidget
/// </param>
/// <return>
/// Title of the @print_custom_widget.
/// </return>

	public static string GetTitle(this MentorLake.WebKit2.WebKitPrintCustomWidgetHandle print_custom_widget)
	{
		if (print_custom_widget.IsInvalid) throw new Exception("Invalid handle (WebKitPrintCustomWidgetHandle)");
		return WebKitPrintCustomWidgetHandleExterns.webkit_print_custom_widget_get_title(print_custom_widget);
	}

/// <summary>
/// <para>
/// Return the value of #WebKitPrintCustomWidget:widget property.
/// </para>
/// <para>
/// Return the value of #WebKitPrintCustomWidget:widget property for the given
/// @print_custom_widget object. The returned value will always be valid if called
/// from #WebKitPrintCustomWidget::apply or #WebKitPrintCustomWidget::update
/// callbacks, but it will be %NULL if called after the
/// #WebKitPrintCustomWidget::apply signal is emitted.
/// </para>
/// </summary>

/// <param name="print_custom_widget">
/// a #WebKitPrintCustomWidget
/// </param>
/// <return>
/// a #GtkWidget.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetWidget(this MentorLake.WebKit2.WebKitPrintCustomWidgetHandle print_custom_widget)
	{
		if (print_custom_widget.IsInvalid) throw new Exception("Invalid handle (WebKitPrintCustomWidgetHandle)");
		return WebKitPrintCustomWidgetHandleExterns.webkit_print_custom_widget_get_widget(print_custom_widget);
	}

}

internal class WebKitPrintCustomWidgetHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitPrintCustomWidgetHandle>))]
	internal static extern MentorLake.WebKit2.WebKitPrintCustomWidgetHandle webkit_print_custom_widget_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string title);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_print_custom_widget_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPrintCustomWidgetHandle>))] MentorLake.WebKit2.WebKitPrintCustomWidgetHandle print_custom_widget);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle webkit_print_custom_widget_get_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPrintCustomWidgetHandle>))] MentorLake.WebKit2.WebKitPrintCustomWidgetHandle print_custom_widget);

}
