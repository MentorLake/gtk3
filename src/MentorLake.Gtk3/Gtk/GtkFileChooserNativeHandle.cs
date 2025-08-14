namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkFileChooserNative is an abstraction of a dialog box suitable
/// for use with “File/Open” or “File/Save as” commands. By default, this
/// just uses a #GtkFileChooserDialog to implement the actual dialog.
/// However, on certain platforms, such as Windows and macOS, the native platform
/// file chooser is used instead. When the application is running in a
/// sandboxed environment without direct filesystem access (such as Flatpak),
/// #GtkFileChooserNative may call the proper APIs (portals) to let the user
/// choose a file and make it available to the application.
/// </para>
/// <para>
/// While the API of #GtkFileChooserNative closely mirrors #GtkFileChooserDialog, the main
/// difference is that there is no access to any #GtkWindow or #GtkWidget for the dialog.
/// This is required, as there may not be one in the case of a platform native dialog.
/// Showing, hiding and running the dialog is handled by the #GtkNativeDialog functions.
/// </para>
/// <para>
/// ## Typical usage ## {#gtkfilechoosernative-typical-usage}
/// </para>
/// <para>
/// In the simplest of cases, you can the following code to use
/// #GtkFileChooserDialog to select a file for opening:
/// </para>
/// <para>
/// |[
/// GtkFileChooserNative *native;
/// GtkFileChooserAction action = GTK_FILE_CHOOSER_ACTION_OPEN;
/// gint res;
/// </para>
/// <para>
/// native = gtk_file_chooser_native_new ("Open File",
///                                       parent_window,
///                                       action,
///                                       "_Open",
///                                       "_Cancel");
/// </para>
/// <para>
/// res = gtk_native_dialog_run (GTK_NATIVE_DIALOG (native));
/// if (res == GTK_RESPONSE_ACCEPT)
///   {
///     char *filename;
///     GtkFileChooser *chooser = GTK_FILE_CHOOSER (native);
///     filename = gtk_file_chooser_get_filename (chooser);
///     open_file (filename);
///     g_free (filename);
///   }
/// </para>
/// <para>
/// g_object_unref (native);
/// ]|
/// </para>
/// <para>
/// To use a dialog for saving, you can use this:
/// </para>
/// <para>
/// |[
/// GtkFileChooserNative *native;
/// GtkFileChooser *chooser;
/// GtkFileChooserAction action = GTK_FILE_CHOOSER_ACTION_SAVE;
/// gint res;
/// </para>
/// <para>
/// native = gtk_file_chooser_native_new ("Save File",
///                                       parent_window,
///                                       action,
///                                       "_Save",
///                                       "_Cancel");
/// chooser = GTK_FILE_CHOOSER (native);
/// </para>
/// <para>
/// gtk_file_chooser_set_do_overwrite_confirmation (chooser, TRUE);
/// </para>
/// <para>
/// if (user_edited_a_new_document)
///   gtk_file_chooser_set_current_name (chooser,
///                                      _("Untitled document"));
/// else
///   gtk_file_chooser_set_filename (chooser,
///                                  existing_filename);
/// </para>
/// <para>
/// res = gtk_native_dialog_run (GTK_NATIVE_DIALOG (native));
/// if (res == GTK_RESPONSE_ACCEPT)
///   {
///     char *filename;
/// </para>
/// <para>
///     filename = gtk_file_chooser_get_filename (chooser);
///     save_to_file (filename);
///     g_free (filename);
///   }
/// </para>
/// <para>
/// g_object_unref (native);
/// ]|
/// </para>
/// <para>
/// For more information on how to best set up a file dialog, see #GtkFileChooserDialog.
/// </para>
/// <para>
/// ## Response Codes ## {#gtkfilechooserdialognative-responses}
/// </para>
/// <para>
/// #GtkFileChooserNative inherits from #GtkNativeDialog, which means it
/// will return #GTK_RESPONSE_ACCEPT if the user accepted, and
/// #GTK_RESPONSE_CANCEL if he pressed cancel. It can also return
/// #GTK_RESPONSE_DELETE_EVENT if the window was unexpectedly closed.
/// </para>
/// <para>
/// ## Differences from #GtkFileChooserDialog ##  {#gtkfilechooserdialognative-differences}
/// </para>
/// <para>
/// There are a few things in the GtkFileChooser API that are not
/// possible to use with #GtkFileChooserNative, as such use would
/// prohibit the use of a native dialog.
/// </para>
/// <para>
/// There is no support for the signals that are emitted when the user
/// navigates in the dialog, including:
/// * #GtkFileChooser::current-folder-changed
/// * #GtkFileChooser::selection-changed
/// * #GtkFileChooser::file-activated
/// * #GtkFileChooser::confirm-overwrite
/// </para>
/// <para>
/// You can also not use the methods that directly control user navigation:
/// * gtk_file_chooser_unselect_filename()
/// * gtk_file_chooser_select_all()
/// * gtk_file_chooser_unselect_all()
/// </para>
/// <para>
/// If you need any of the above you will have to use #GtkFileChooserDialog directly.
/// </para>
/// <para>
/// No operations that change the the dialog work while the dialog is
/// visible. Set all the properties that are required before showing the dialog.
/// </para>
/// <para>
/// ## Win32 details ## {#gtkfilechooserdialognative-win32}
/// </para>
/// <para>
/// On windows the IFileDialog implementation (added in Windows Vista) is
/// used. It supports many of the features that #GtkFileChooserDialog
/// does, but there are some things it does not handle:
/// </para>
/// <para>
/// * Extra widgets added with gtk_file_chooser_set_extra_widget().
/// </para>
/// <para>
/// * Use of custom previews by connecting to #GtkFileChooser::update-preview.
/// </para>
/// <para>
/// * Any #GtkFileFilter added using a mimetype or custom filter.
/// </para>
/// <para>
/// If any of these features are used the regular #GtkFileChooserDialog
/// will be used in place of the native one.
/// </para>
/// <para>
/// ## Portal details ## {#gtkfilechooserdialognative-portal}
/// </para>
/// <para>
/// When the org.freedesktop.portal.FileChooser portal is available on the
/// session bus, it is used to bring up an out-of-process file chooser. Depending
/// on the kind of session the application is running in, this may or may not
/// be a GTK+ file chooser. In this situation, the following things are not
/// supported and will be silently ignored:
/// </para>
/// <para>
/// * Extra widgets added with gtk_file_chooser_set_extra_widget().
/// </para>
/// <para>
/// * Use of custom previews by connecting to #GtkFileChooser::update-preview.
/// </para>
/// <para>
/// * Any #GtkFileFilter added with a custom filter.
/// </para>
/// <para>
/// ## macOS details ## {#gtkfilechooserdialognative-macos}
/// </para>
/// <para>
/// On macOS the NSSavePanel and NSOpenPanel classes are used to provide native
/// file chooser dialogs. Some features provided by #GtkFileChooserDialog are
/// not supported:
/// </para>
/// <para>
/// * Extra widgets added with gtk_file_chooser_set_extra_widget(), unless the
///   widget is an instance of GtkLabel, in which case the label text will be used
///   to set the NSSavePanel message instance property.
/// </para>
/// <para>
/// * Use of custom previews by connecting to #GtkFileChooser::update-preview.
/// </para>
/// <para>
/// * Any #GtkFileFilter added with a custom filter.
/// </para>
/// <para>
/// * Shortcut folders.
/// </para>
/// </summary>

public class GtkFileChooserNativeHandle : GtkNativeDialogHandle, GtkFileChooserHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkFileChooserNative.
/// </para>
/// </summary>

/// <param name="title">
/// Title of the native, or %NULL
/// </param>
/// <param name="parent">
/// Transient parent of the native, or %NULL
/// </param>
/// <param name="action">
/// Open or save mode for the dialog
/// </param>
/// <param name="accept_label">
/// text to go in the accept button, or %NULL for the default
/// </param>
/// <param name="cancel_label">
/// text to go in the cancel button, or %NULL for the default
/// </param>
/// <return>
/// a new #GtkFileChooserNative
/// </return>

	public static MentorLake.Gtk.GtkFileChooserNativeHandle New(string title, MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkFileChooserAction action, string accept_label, string cancel_label)
	{
		return GtkFileChooserNativeHandleExterns.gtk_file_chooser_native_new(title, parent, action, accept_label, cancel_label);
	}

}
public static class GtkFileChooserNativeHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal gets emitted whenever it is appropriate to present a
/// confirmation dialog when the user has selected a file name that
/// already exists.  The signal only gets emitted when the file
/// chooser is in %GTK_FILE_CHOOSER_ACTION_SAVE mode.
/// </para>
/// <para>
/// Most applications just need to turn on the
/// #GtkFileChooser:do-overwrite-confirmation property (or call the
/// gtk_file_chooser_set_do_overwrite_confirmation() function), and
/// they will automatically get a stock confirmation dialog.
/// Applications which need to customize this behavior should do
/// that, and also connect to the #GtkFileChooser::confirm-overwrite
/// signal.
/// </para>
/// <para>
/// A signal handler for this signal must return a
/// #GtkFileChooserConfirmation value, which indicates the action to
/// take.  If the handler determines that the user wants to select a
/// different filename, it should return
/// %GTK_FILE_CHOOSER_CONFIRMATION_SELECT_AGAIN.  If it determines
/// that the user is satisfied with his choice of file name, it
/// should return %GTK_FILE_CHOOSER_CONFIRMATION_ACCEPT_FILENAME.
/// On the other hand, if it determines that the stock confirmation
/// dialog should be used, it should return
/// %GTK_FILE_CHOOSER_CONFIRMATION_CONFIRM. The following example
/// illustrates this.
/// </para>
/// <para>
/// ## Custom confirmation ## {#gtkfilechooser-confirmation}
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static GtkFileChooserConfirmation
/// confirm_overwrite_callback (GtkFileChooser *chooser, gpointer data)
/// {
///   char *uri;
/// </para>
/// <para>
///   uri = gtk_file_chooser_get_uri (chooser);
/// </para>
/// <para>
///   if (is_uri_read_only (uri))
///     {
///       if (user_wants_to_replace_read_only_file (uri))
///         return GTK_FILE_CHOOSER_CONFIRMATION_ACCEPT_FILENAME;
///       else
///         return GTK_FILE_CHOOSER_CONFIRMATION_SELECT_AGAIN;
///     } else
///       return GTK_FILE_CHOOSER_CONFIRMATION_CONFIRM; // fall back to the default dialog
/// }
/// </para>
/// <para>
/// ...
/// </para>
/// <para>
/// chooser = gtk_file_chooser_dialog_new (...);
/// </para>
/// <para>
/// gtk_file_chooser_set_do_overwrite_confirmation (GTK_FILE_CHOOSER (dialog), TRUE);
/// g_signal_connect (chooser, "confirm-overwrite",
///                   G_CALLBACK (confirm_overwrite_callback), NULL);
/// </para>
/// <para>
/// if (gtk_dialog_run (chooser) == GTK_RESPONSE_ACCEPT)
///         save_to_file (gtk_file_chooser_get_filename (GTK_FILE_CHOOSER (chooser));
/// </para>
/// <para>
/// gtk_widget_destroy (chooser);
/// ]|
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserNativeHandleSignalStructs.ConfirmOverwriteSignal> Signal_ConfirmOverwrite(this GtkFileChooserNativeHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserNativeHandleSignalStructs.ConfirmOverwriteSignal> obs) =>
		{
			GtkFileChooserNativeHandleSignalDelegates.confirm_overwrite handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserNativeHandleSignalStructs.ConfirmOverwriteSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "confirm-overwrite", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when the current folder in a #GtkFileChooser
/// changes.  This can happen due to the user performing some action that
/// changes folders, such as selecting a bookmark or visiting a folder on the
/// file list.  It can also happen as a result of calling a function to
/// explicitly change the current folder in a file chooser.
/// </para>
/// <para>
/// Normally you do not need to connect to this signal, unless you need to keep
/// track of which folder a file chooser is showing.
/// </para>
/// <para>
/// See also:  gtk_file_chooser_set_current_folder(),
/// gtk_file_chooser_get_current_folder(),
/// gtk_file_chooser_set_current_folder_uri(),
/// gtk_file_chooser_get_current_folder_uri().
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserNativeHandleSignalStructs.CurrentFolderChangedSignal> Signal_CurrentFolderChanged(this GtkFileChooserNativeHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserNativeHandleSignalStructs.CurrentFolderChangedSignal> obs) =>
		{
			GtkFileChooserNativeHandleSignalDelegates.current_folder_changed handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserNativeHandleSignalStructs.CurrentFolderChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "current-folder-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when the user "activates" a file in the file
/// chooser.  This can happen by double-clicking on a file in the file list, or
/// by pressing `Enter`.
/// </para>
/// <para>
/// Normally you do not need to connect to this signal.  It is used internally
/// by #GtkFileChooserDialog to know when to activate the default button in the
/// dialog.
/// </para>
/// <para>
/// See also: gtk_file_chooser_get_filename(),
/// gtk_file_chooser_get_filenames(), gtk_file_chooser_get_uri(),
/// gtk_file_chooser_get_uris().
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserNativeHandleSignalStructs.FileActivatedSignal> Signal_FileActivated(this GtkFileChooserNativeHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserNativeHandleSignalStructs.FileActivatedSignal> obs) =>
		{
			GtkFileChooserNativeHandleSignalDelegates.file_activated handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserNativeHandleSignalStructs.FileActivatedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "file-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when there is a change in the set of selected files
/// in a #GtkFileChooser.  This can happen when the user modifies the selection
/// with the mouse or the keyboard, or when explicitly calling functions to
/// change the selection.
/// </para>
/// <para>
/// Normally you do not need to connect to this signal, as it is easier to wait
/// for the file chooser to finish running, and then to get the list of
/// selected files using the functions mentioned below.
/// </para>
/// <para>
/// See also: gtk_file_chooser_select_filename(),
/// gtk_file_chooser_unselect_filename(), gtk_file_chooser_get_filename(),
/// gtk_file_chooser_get_filenames(), gtk_file_chooser_select_uri(),
/// gtk_file_chooser_unselect_uri(), gtk_file_chooser_get_uri(),
/// gtk_file_chooser_get_uris().
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserNativeHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkFileChooserNativeHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserNativeHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkFileChooserNativeHandleSignalDelegates.selection_changed handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserNativeHandleSignalStructs.SelectionChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when the preview in a file chooser should be
/// regenerated.  For example, this can happen when the currently selected file
/// changes.  You should use this signal if you want your file chooser to have
/// a preview widget.
/// </para>
/// <para>
/// Once you have installed a preview widget with
/// gtk_file_chooser_set_preview_widget(), you should update it when this
/// signal is emitted.  You can use the functions
/// gtk_file_chooser_get_preview_filename() or
/// gtk_file_chooser_get_preview_uri() to get the name of the file to preview.
/// Your widget may not be able to preview all kinds of files; your callback
/// must call gtk_file_chooser_set_preview_widget_active() to inform the file
/// chooser about whether the preview was generated successfully or not.
/// </para>
/// <para>
/// Please see the example code in
/// [Using a Preview Widget][gtkfilechooser-preview].
/// </para>
/// <para>
/// See also: gtk_file_chooser_set_preview_widget(),
/// gtk_file_chooser_set_preview_widget_active(),
/// gtk_file_chooser_set_use_preview_label(),
/// gtk_file_chooser_get_preview_filename(),
/// gtk_file_chooser_get_preview_uri().
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserNativeHandleSignalStructs.UpdatePreviewSignal> Signal_UpdatePreview(this GtkFileChooserNativeHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserNativeHandleSignalStructs.UpdatePreviewSignal> obs) =>
		{
			GtkFileChooserNativeHandleSignalDelegates.update_preview handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserNativeHandleSignalStructs.UpdatePreviewSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "update-preview", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkFileChooserNativeHandleSignalStructs
{

public class ConfirmOverwriteSignal
{

	public MentorLake.Gtk.GtkFileChooserHandle Self;

	public IntPtr UserData;
/// <summary>
/// <para>
/// a #GtkFileChooserConfirmation value that indicates which
///  action to take after emitting the signal.
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkFileChooserConfirmation ReturnValue;
}

public class CurrentFolderChangedSignal
{

	public MentorLake.Gtk.GtkFileChooserHandle Self;

	public IntPtr UserData;
}

public class FileActivatedSignal
{

	public MentorLake.Gtk.GtkFileChooserHandle Self;

	public IntPtr UserData;
}

public class SelectionChangedSignal
{

	public MentorLake.Gtk.GtkFileChooserHandle Self;

	public IntPtr UserData;
}

public class UpdatePreviewSignal
{

	public MentorLake.Gtk.GtkFileChooserHandle Self;

	public IntPtr UserData;
}
}

public static class GtkFileChooserNativeHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal gets emitted whenever it is appropriate to present a
/// confirmation dialog when the user has selected a file name that
/// already exists.  The signal only gets emitted when the file
/// chooser is in %GTK_FILE_CHOOSER_ACTION_SAVE mode.
/// </para>
/// <para>
/// Most applications just need to turn on the
/// #GtkFileChooser:do-overwrite-confirmation property (or call the
/// gtk_file_chooser_set_do_overwrite_confirmation() function), and
/// they will automatically get a stock confirmation dialog.
/// Applications which need to customize this behavior should do
/// that, and also connect to the #GtkFileChooser::confirm-overwrite
/// signal.
/// </para>
/// <para>
/// A signal handler for this signal must return a
/// #GtkFileChooserConfirmation value, which indicates the action to
/// take.  If the handler determines that the user wants to select a
/// different filename, it should return
/// %GTK_FILE_CHOOSER_CONFIRMATION_SELECT_AGAIN.  If it determines
/// that the user is satisfied with his choice of file name, it
/// should return %GTK_FILE_CHOOSER_CONFIRMATION_ACCEPT_FILENAME.
/// On the other hand, if it determines that the stock confirmation
/// dialog should be used, it should return
/// %GTK_FILE_CHOOSER_CONFIRMATION_CONFIRM. The following example
/// illustrates this.
/// </para>
/// <para>
/// ## Custom confirmation ## {#gtkfilechooser-confirmation}
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// static GtkFileChooserConfirmation
/// confirm_overwrite_callback (GtkFileChooser *chooser, gpointer data)
/// {
///   char *uri;
/// </para>
/// <para>
///   uri = gtk_file_chooser_get_uri (chooser);
/// </para>
/// <para>
///   if (is_uri_read_only (uri))
///     {
///       if (user_wants_to_replace_read_only_file (uri))
///         return GTK_FILE_CHOOSER_CONFIRMATION_ACCEPT_FILENAME;
///       else
///         return GTK_FILE_CHOOSER_CONFIRMATION_SELECT_AGAIN;
///     } else
///       return GTK_FILE_CHOOSER_CONFIRMATION_CONFIRM; // fall back to the default dialog
/// }
/// </para>
/// <para>
/// ...
/// </para>
/// <para>
/// chooser = gtk_file_chooser_dialog_new (...);
/// </para>
/// <para>
/// gtk_file_chooser_set_do_overwrite_confirmation (GTK_FILE_CHOOSER (dialog), TRUE);
/// g_signal_connect (chooser, "confirm-overwrite",
///                   G_CALLBACK (confirm_overwrite_callback), NULL);
/// </para>
/// <para>
/// if (gtk_dialog_run (chooser) == GTK_RESPONSE_ACCEPT)
///         save_to_file (gtk_file_chooser_get_filename (GTK_FILE_CHOOSER (chooser));
/// </para>
/// <para>
/// gtk_widget_destroy (chooser);
/// ]|
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// a #GtkFileChooserConfirmation value that indicates which
///  action to take after emitting the signal.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gtk.GtkFileChooserConfirmation confirm_overwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when the current folder in a #GtkFileChooser
/// changes.  This can happen due to the user performing some action that
/// changes folders, such as selecting a bookmark or visiting a folder on the
/// file list.  It can also happen as a result of calling a function to
/// explicitly change the current folder in a file chooser.
/// </para>
/// <para>
/// Normally you do not need to connect to this signal, unless you need to keep
/// track of which folder a file chooser is showing.
/// </para>
/// <para>
/// See also:  gtk_file_chooser_set_current_folder(),
/// gtk_file_chooser_get_current_folder(),
/// gtk_file_chooser_set_current_folder_uri(),
/// gtk_file_chooser_get_current_folder_uri().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void current_folder_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when the user "activates" a file in the file
/// chooser.  This can happen by double-clicking on a file in the file list, or
/// by pressing `Enter`.
/// </para>
/// <para>
/// Normally you do not need to connect to this signal.  It is used internally
/// by #GtkFileChooserDialog to know when to activate the default button in the
/// dialog.
/// </para>
/// <para>
/// See also: gtk_file_chooser_get_filename(),
/// gtk_file_chooser_get_filenames(), gtk_file_chooser_get_uri(),
/// gtk_file_chooser_get_uris().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void file_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when there is a change in the set of selected files
/// in a #GtkFileChooser.  This can happen when the user modifies the selection
/// with the mouse or the keyboard, or when explicitly calling functions to
/// change the selection.
/// </para>
/// <para>
/// Normally you do not need to connect to this signal, as it is easier to wait
/// for the file chooser to finish running, and then to get the list of
/// selected files using the functions mentioned below.
/// </para>
/// <para>
/// See also: gtk_file_chooser_select_filename(),
/// gtk_file_chooser_unselect_filename(), gtk_file_chooser_get_filename(),
/// gtk_file_chooser_get_filenames(), gtk_file_chooser_select_uri(),
/// gtk_file_chooser_unselect_uri(), gtk_file_chooser_get_uri(),
/// gtk_file_chooser_get_uris().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when the preview in a file chooser should be
/// regenerated.  For example, this can happen when the currently selected file
/// changes.  You should use this signal if you want your file chooser to have
/// a preview widget.
/// </para>
/// <para>
/// Once you have installed a preview widget with
/// gtk_file_chooser_set_preview_widget(), you should update it when this
/// signal is emitted.  You can use the functions
/// gtk_file_chooser_get_preview_filename() or
/// gtk_file_chooser_get_preview_uri() to get the name of the file to preview.
/// Your widget may not be able to preview all kinds of files; your callback
/// must call gtk_file_chooser_set_preview_widget_active() to inform the file
/// chooser about whether the preview was generated successfully or not.
/// </para>
/// <para>
/// Please see the example code in
/// [Using a Preview Widget][gtkfilechooser-preview].
/// </para>
/// <para>
/// See also: gtk_file_chooser_set_preview_widget(),
/// gtk_file_chooser_set_preview_widget_active(),
/// gtk_file_chooser_set_use_preview_label(),
/// gtk_file_chooser_get_preview_filename(),
/// gtk_file_chooser_get_preview_uri().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void update_preview([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle self, IntPtr user_data);

}


public static class GtkFileChooserNativeHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the custom label text for the accept button.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtFileChooserNative
/// </param>
/// <return>
/// The custom label, or %NULL for the default. This string
/// is owned by GTK+ and should not be modified or freed
/// </return>

	public static string GetAcceptLabel(this MentorLake.Gtk.GtkFileChooserNativeHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserNativeHandle)");
		return GtkFileChooserNativeHandleExterns.gtk_file_chooser_native_get_accept_label(self);
	}

/// <summary>
/// <para>
/// Retrieves the custom label text for the cancel button.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtFileChooserNative
/// </param>
/// <return>
/// The custom label, or %NULL for the default. This string
/// is owned by GTK+ and should not be modified or freed
/// </return>

	public static string GetCancelLabel(this MentorLake.Gtk.GtkFileChooserNativeHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserNativeHandle)");
		return GtkFileChooserNativeHandleExterns.gtk_file_chooser_native_get_cancel_label(self);
	}

/// <summary>
/// <para>
/// Sets the custom label text for the accept button.
/// </para>
/// <para>
/// If characters in @label are preceded by an underscore, they are underlined.
/// If you need a literal underscore character in a label, use “__” (two
/// underscores). The first underlined character represents a keyboard
/// accelerator called a mnemonic.
/// Pressing Alt and that key activates the button.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtFileChooserNative
/// </param>
/// <param name="accept_label">
/// custom label or %NULL for the default
/// </param>

	public static T SetAcceptLabel<T>(this T self, string accept_label) where T : GtkFileChooserNativeHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserNativeHandle)");
		GtkFileChooserNativeHandleExterns.gtk_file_chooser_native_set_accept_label(self, accept_label);
		return self;
	}

/// <summary>
/// <para>
/// Sets the custom label text for the cancel button.
/// </para>
/// <para>
/// If characters in @label are preceded by an underscore, they are underlined.
/// If you need a literal underscore character in a label, use “__” (two
/// underscores). The first underlined character represents a keyboard
/// accelerator called a mnemonic.
/// Pressing Alt and that key activates the button.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtFileChooserNative
/// </param>
/// <param name="cancel_label">
/// custom label or %NULL for the default
/// </param>

	public static T SetCancelLabel<T>(this T self, string cancel_label) where T : GtkFileChooserNativeHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserNativeHandle)");
		GtkFileChooserNativeHandleExterns.gtk_file_chooser_native_set_cancel_label(self, cancel_label);
		return self;
	}

}

internal class GtkFileChooserNativeHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserNativeHandle>))]
	internal static extern MentorLake.Gtk.GtkFileChooserNativeHandle gtk_file_chooser_native_new(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkFileChooserAction action, string accept_label, string cancel_label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_native_get_accept_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserNativeHandle>))] MentorLake.Gtk.GtkFileChooserNativeHandle self);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_native_get_cancel_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserNativeHandle>))] MentorLake.Gtk.GtkFileChooserNativeHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_native_set_accept_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserNativeHandle>))] MentorLake.Gtk.GtkFileChooserNativeHandle self, string accept_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_native_set_cancel_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserNativeHandle>))] MentorLake.Gtk.GtkFileChooserNativeHandle self, string cancel_label);

}
