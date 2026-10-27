namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Controls a print operation.
/// </para>
/// <para>
/// A #WebKitPrintOperation controls a print operation in WebKit. With
/// a similar API to #GtkPrintOperation, it lets you set the print
/// settings with webkit_print_operation_set_print_settings() or
/// display the print dialog with webkit_print_operation_run_dialog().
/// </para>
/// </summary>

public class WebKitPrintOperationHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Create a new #WebKitPrintOperation to print @web_view contents.
/// </para>
/// </summary>

/// <param name="web_view">
/// a #WebKitWebView
/// </param>
/// <return>
/// a new #WebKitPrintOperation.
/// </return>

	public static MentorLake.WebKit2.WebKitPrintOperationHandle New(MentorLake.WebKit2.WebKitWebViewHandle web_view)
	{
		return WebKitPrintOperationHandleExterns.webkit_print_operation_new(web_view);
	}

}
public static class WebKitPrintOperationHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when displaying the print dialog with webkit_print_operation_run_dialog().
/// The returned #WebKitPrintCustomWidget will be added to the print dialog and
/// it will be owned by the @print_operation. However, the object is guaranteed
/// to be alive until the #WebKitPrintCustomWidget::apply is emitted.
/// </para>
/// </summary>

	public static IObservable<WebKitPrintOperationHandleSignalStructs.CreateCustomWidgetSignal> Signal_CreateCustomWidget(this WebKitPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitPrintOperationHandleSignalStructs.CreateCustomWidgetSignal> obs) =>
		{
			WebKitPrintOperationHandleSignalDelegates.create_custom_widget handler = ( MentorLake.WebKit2.WebKitPrintOperationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitPrintOperationHandleSignalStructs.CreateCustomWidgetSignal()
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
/// <summary>
/// <para>
/// Emitted when an error occurs while printing. The given @error, of the domain
/// %WEBKIT_PRINT_ERROR, contains further details of the failure.
/// The #WebKitPrintOperation::finished signal is emitted after this one.
/// </para>
/// </summary>

	public static IObservable<WebKitPrintOperationHandleSignalStructs.FailedSignal> Signal_Failed(this WebKitPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitPrintOperationHandleSignalStructs.FailedSignal> obs) =>
		{
			WebKitPrintOperationHandleSignalDelegates.failed handler = ( MentorLake.WebKit2.WebKitPrintOperationHandle self,  MentorLake.GLib.GErrorHandle error,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitPrintOperationHandleSignalStructs.FailedSignal()
				{
					Self = self, Error = error, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "failed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// Emitted when the print operation has finished doing everything
/// required for printing.
/// </para>
/// </summary>

	public static IObservable<WebKitPrintOperationHandleSignalStructs.FinishedSignal> Signal_Finished(this WebKitPrintOperationHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitPrintOperationHandleSignalStructs.FinishedSignal> obs) =>
		{
			WebKitPrintOperationHandleSignalDelegates.finished handler = ( MentorLake.WebKit2.WebKitPrintOperationHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitPrintOperationHandleSignalStructs.FinishedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "finished", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitPrintOperationHandleSignalStructs
{

public class CreateCustomWidgetSignal
{

	public MentorLake.WebKit2.WebKitPrintOperationHandle Self;

	public IntPtr UserData;
/// <summary>
/// <para>
/// A #WebKitPrintCustomWidget that will be embedded in the dialog.
/// </para>
/// </summary>

	public MentorLake.WebKit2.WebKitPrintCustomWidgetHandle ReturnValue;
}

public class FailedSignal
{

	public MentorLake.WebKit2.WebKitPrintOperationHandle Self;
/// <summary>
/// <para>
/// the #GError that was triggered
/// </para>
/// </summary>

	public MentorLake.GLib.GErrorHandle Error;

	public IntPtr UserData;
}

public class FinishedSignal
{

	public MentorLake.WebKit2.WebKitPrintOperationHandle Self;

	public IntPtr UserData;
}
}

public static class WebKitPrintOperationHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when displaying the print dialog with webkit_print_operation_run_dialog().
/// The returned #WebKitPrintCustomWidget will be added to the print dialog and
/// it will be owned by the @print_operation. However, the object is guaranteed
/// to be alive until the #WebKitPrintCustomWidget::apply is emitted.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// A #WebKitPrintCustomWidget that will be embedded in the dialog.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.WebKit2.WebKitPrintCustomWidgetHandle create_custom_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPrintOperationHandle>))] MentorLake.WebKit2.WebKitPrintOperationHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when an error occurs while printing. The given @error, of the domain
/// %WEBKIT_PRINT_ERROR, contains further details of the failure.
/// The #WebKitPrintOperation::finished signal is emitted after this one.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="error">
/// the #GError that was triggered
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void failed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPrintOperationHandle>))] MentorLake.WebKit2.WebKitPrintOperationHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, IntPtr user_data);


/// <summary>
/// <para>
/// Emitted when the print operation has finished doing everything
/// required for printing.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void finished([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPrintOperationHandle>))] MentorLake.WebKit2.WebKitPrintOperationHandle self, IntPtr user_data);

}


public static class WebKitPrintOperationHandleExtensions
{
/// <summary>
/// <para>
/// Return the current page setup of @print_operation.
/// </para>
/// <para>
/// It returns %NULL until
/// either webkit_print_operation_set_page_setup() or webkit_print_operation_run_dialog()
/// have been called.
/// </para>
/// </summary>

/// <param name="print_operation">
/// a #WebKitPrintOperation
/// </param>
/// <return>
/// the current #GtkPageSetup of @print_operation.
/// </return>

	public static MentorLake.Gtk.GtkPageSetupHandle GetPageSetup(this MentorLake.WebKit2.WebKitPrintOperationHandle print_operation)
	{
		if (print_operation.IsInvalid) throw new Exception("Invalid handle (WebKitPrintOperationHandle)");
		return WebKitPrintOperationHandleExterns.webkit_print_operation_get_page_setup(print_operation);
	}

/// <summary>
/// <para>
/// Return the current print settings of @print_operation.
/// </para>
/// <para>
/// It returns %NULL until
/// either webkit_print_operation_set_print_settings() or webkit_print_operation_run_dialog()
/// have been called.
/// </para>
/// </summary>

/// <param name="print_operation">
/// a #WebKitPrintOperation
/// </param>
/// <return>
/// the current #GtkPrintSettings of @print_operation.
/// </return>

	public static MentorLake.Gtk.GtkPrintSettingsHandle GetPrintSettings(this MentorLake.WebKit2.WebKitPrintOperationHandle print_operation)
	{
		if (print_operation.IsInvalid) throw new Exception("Invalid handle (WebKitPrintOperationHandle)");
		return WebKitPrintOperationHandleExterns.webkit_print_operation_get_print_settings(print_operation);
	}

/// <summary>
/// <para>
/// Start a print operation using current print settings and page setup.
/// </para>
/// <para>
/// Start a print operation using current print settings and page setup
/// without showing the print dialog. If either print settings or page setup
/// are not set with webkit_print_operation_set_print_settings() and
/// webkit_print_operation_set_page_setup(), the default options will be used
/// and the print job will be sent to the default printer.
/// The #WebKitPrintOperation::finished signal is emitted when the printing
/// operation finishes. If an error occurs while printing the signal
/// #WebKitPrintOperation::failed is emitted before #WebKitPrintOperation::finished.
/// </para>
/// <para>
/// If the app is running in a sandbox, this function only works if printing to
/// a file that is in a location accessible to the sandbox, usually acquired
/// through the File Chooser portal. This function will not work for physical
/// printers when running in a sandbox.
/// </para>
/// </summary>

/// <param name="print_operation">
/// a #WebKitPrintOperation
/// </param>

	public static T Print<T>(this T print_operation) where T : WebKitPrintOperationHandle
	{
		if (print_operation.IsInvalid) throw new Exception("Invalid handle (WebKitPrintOperationHandle)");
		WebKitPrintOperationHandleExterns.webkit_print_operation_print(print_operation);
		return print_operation;
	}

/// <summary>
/// <para>
/// Run the print dialog and start printing.
/// </para>
/// <para>
/// Run the print dialog and start printing using the options selected by
/// the user. This method returns when the print dialog is closed.
/// If the print dialog is cancelled %WEBKIT_PRINT_OPERATION_RESPONSE_CANCEL
/// is returned. If the user clicks on the print button, %WEBKIT_PRINT_OPERATION_RESPONSE_PRINT
/// is returned and the print operation starts. In this case, the #WebKitPrintOperation::finished
/// signal is emitted when the operation finishes. If an error occurs while printing, the signal
/// #WebKitPrintOperation::failed is emitted before #WebKitPrintOperation::finished.
/// If the print dialog is not cancelled current print settings and page setup of @print_operation
/// are updated with options selected by the user when Print button is pressed in print dialog.
/// You can get the updated print settings and page setup by calling
/// webkit_print_operation_get_print_settings() and webkit_print_operation_get_page_setup()
/// after this method.
/// </para>
/// </summary>

/// <param name="print_operation">
/// a #WebKitPrintOperation
/// </param>
/// <param name="parent">
/// transient parent of the print dialog
/// </param>
/// <return>
/// the #WebKitPrintOperationResponse of the print dialog
/// </return>

	public static MentorLake.WebKit2.WebKitPrintOperationResponse RunDialog(this MentorLake.WebKit2.WebKitPrintOperationHandle print_operation, MentorLake.Gtk.GtkWindowHandle parent)
	{
		if (print_operation.IsInvalid) throw new Exception("Invalid handle (WebKitPrintOperationHandle)");
		return WebKitPrintOperationHandleExterns.webkit_print_operation_run_dialog(print_operation, parent);
	}

/// <summary>
/// <para>
/// Set the current page setup of @print_operation.
/// </para>
/// <para>
/// Current page setup is used for the
/// initial values of the print dialog when webkit_print_operation_run_dialog() is called.
/// </para>
/// </summary>

/// <param name="print_operation">
/// a #WebKitPrintOperation
/// </param>
/// <param name="page_setup">
/// a #GtkPageSetup to set
/// </param>

	public static T SetPageSetup<T>(this T print_operation, MentorLake.Gtk.GtkPageSetupHandle page_setup) where T : WebKitPrintOperationHandle
	{
		if (print_operation.IsInvalid) throw new Exception("Invalid handle (WebKitPrintOperationHandle)");
		WebKitPrintOperationHandleExterns.webkit_print_operation_set_page_setup(print_operation, page_setup);
		return print_operation;
	}

/// <summary>
/// <para>
/// Set the current print settings of @print_operation.
/// </para>
/// <para>
/// Set the current print settings of @print_operation. Current print settings are used for
/// the initial values of the print dialog when webkit_print_operation_run_dialog() is called.
/// </para>
/// </summary>

/// <param name="print_operation">
/// a #WebKitPrintOperation
/// </param>
/// <param name="print_settings">
/// a #GtkPrintSettings to set
/// </param>

	public static T SetPrintSettings<T>(this T print_operation, MentorLake.Gtk.GtkPrintSettingsHandle print_settings) where T : WebKitPrintOperationHandle
	{
		if (print_operation.IsInvalid) throw new Exception("Invalid handle (WebKitPrintOperationHandle)");
		WebKitPrintOperationHandleExterns.webkit_print_operation_set_print_settings(print_operation, print_settings);
		return print_operation;
	}

}

internal class WebKitPrintOperationHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.WebKit2.WebKitPrintOperationHandle>))]
	internal static extern MentorLake.WebKit2.WebKitPrintOperationHandle webkit_print_operation_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))] MentorLake.WebKit2.WebKitWebViewHandle web_view);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))]
	internal static extern MentorLake.Gtk.GtkPageSetupHandle webkit_print_operation_get_page_setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPrintOperationHandle>))] MentorLake.WebKit2.WebKitPrintOperationHandle print_operation);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))]
	internal static extern MentorLake.Gtk.GtkPrintSettingsHandle webkit_print_operation_get_print_settings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPrintOperationHandle>))] MentorLake.WebKit2.WebKitPrintOperationHandle print_operation);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_print_operation_print([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPrintOperationHandle>))] MentorLake.WebKit2.WebKitPrintOperationHandle print_operation);

	[DllImport(WebKit2Library.Name)]
	internal static extern MentorLake.WebKit2.WebKitPrintOperationResponse webkit_print_operation_run_dialog([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPrintOperationHandle>))] MentorLake.WebKit2.WebKitPrintOperationHandle print_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_print_operation_set_page_setup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPrintOperationHandle>))] MentorLake.WebKit2.WebKitPrintOperationHandle print_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPageSetupHandle>))] MentorLake.Gtk.GtkPageSetupHandle page_setup);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_print_operation_set_print_settings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitPrintOperationHandle>))] MentorLake.WebKit2.WebKitPrintOperationHandle print_operation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPrintSettingsHandle>))] MentorLake.Gtk.GtkPrintSettingsHandle print_settings);

}
