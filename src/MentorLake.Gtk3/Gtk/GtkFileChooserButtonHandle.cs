namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkFileChooserButton is a widget that lets the user select a
/// file.  It implements the #GtkFileChooser interface.  Visually, it is a
/// file name with a button to bring up a #GtkFileChooserDialog.
/// The user can then use that dialog to change the file associated with
/// that button.  This widget does not support setting the
/// #GtkFileChooser:select-multiple property to %TRUE.
/// </para>
/// <para>
/// ## Create a button to let the user select a file in /etc
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// {
///   GtkWidget *button;
/// </para>
/// <para>
///   button = gtk_file_chooser_button_new (_("Select a file"),
///                                         GTK_FILE_CHOOSER_ACTION_OPEN);
///   gtk_file_chooser_set_current_folder (GTK_FILE_CHOOSER (button),
///                                        "/etc");
/// }
/// ]|
/// </para>
/// <para>
/// The #GtkFileChooserButton supports the #GtkFileChooserActions
/// %GTK_FILE_CHOOSER_ACTION_OPEN and %GTK_FILE_CHOOSER_ACTION_SELECT_FOLDER.
/// </para>
/// <para>
/// > The #GtkFileChooserButton will ellipsize the label, and will thus
/// > request little horizontal space.  To give the button more space,
/// > you should call gtk_widget_get_preferred_size(),
/// > gtk_file_chooser_button_set_width_chars(), or pack the button in
/// > such a way that other interface elements give space to the
/// > widget.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkFileChooserButton has a CSS node with name “filechooserbutton”, containing
/// a subnode for the internal button with name “button” and style class “.file”.
/// </para>
/// </summary>

public class GtkFileChooserButtonHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFileChooserHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new file-selecting button widget.
/// </para>
/// </summary>

/// <param name="title">
/// the title of the browse dialog.
/// </param>
/// <param name="action">
/// the open mode for the widget.
/// </param>
/// <return>
/// a new button widget.
/// </return>

	public static MentorLake.Gtk.GtkFileChooserButtonHandle New(string title, MentorLake.Gtk.GtkFileChooserAction action)
	{
		return GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_new(title, action);
	}

/// <summary>
/// <para>
/// Creates a #GtkFileChooserButton widget which uses @dialog as its
/// file-picking window.
/// </para>
/// <para>
/// Note that @dialog must be a #GtkDialog (or subclass) which
/// implements the #GtkFileChooser interface and must not have
/// %GTK_DIALOG_DESTROY_WITH_PARENT set.
/// </para>
/// <para>
/// Also note that the dialog needs to have its confirmative button
/// added with response %GTK_RESPONSE_ACCEPT or %GTK_RESPONSE_OK in
/// order for the button to take over the file selected in the dialog.
/// </para>
/// </summary>

/// <param name="dialog">
/// the widget to use as dialog
/// </param>
/// <return>
/// a new button widget.
/// </return>

	public static MentorLake.Gtk.GtkFileChooserButtonHandle NewWithDialog(MentorLake.Gtk.GtkWidgetHandle dialog)
	{
		return GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_new_with_dialog(dialog);
	}

}
public static class GtkFileChooserButtonHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::file-set signal is emitted when the user selects a file.
/// </para>
/// <para>
/// Note that this signal is only emitted when the user
/// changes the file.
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserButtonHandleSignalStructs.FileSetSignal> Signal_FileSet(this GtkFileChooserButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserButtonHandleSignalStructs.FileSetSignal> obs) =>
		{
			GtkFileChooserButtonHandleSignalDelegates.file_set handler = ( MentorLake.Gtk.GtkFileChooserButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserButtonHandleSignalStructs.FileSetSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "file-set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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

	public static IObservable<GtkFileChooserButtonHandleSignalStructs.ConfirmOverwriteSignal> Signal_ConfirmOverwrite(this GtkFileChooserButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserButtonHandleSignalStructs.ConfirmOverwriteSignal> obs) =>
		{
			GtkFileChooserButtonHandleSignalDelegates.confirm_overwrite handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserButtonHandleSignalStructs.ConfirmOverwriteSignal()
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

	public static IObservable<GtkFileChooserButtonHandleSignalStructs.CurrentFolderChangedSignal> Signal_CurrentFolderChanged(this GtkFileChooserButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserButtonHandleSignalStructs.CurrentFolderChangedSignal> obs) =>
		{
			GtkFileChooserButtonHandleSignalDelegates.current_folder_changed handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserButtonHandleSignalStructs.CurrentFolderChangedSignal()
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

	public static IObservable<GtkFileChooserButtonHandleSignalStructs.FileActivatedSignal> Signal_FileActivated(this GtkFileChooserButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserButtonHandleSignalStructs.FileActivatedSignal> obs) =>
		{
			GtkFileChooserButtonHandleSignalDelegates.file_activated handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserButtonHandleSignalStructs.FileActivatedSignal()
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

	public static IObservable<GtkFileChooserButtonHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkFileChooserButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserButtonHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkFileChooserButtonHandleSignalDelegates.selection_changed handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserButtonHandleSignalStructs.SelectionChangedSignal()
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

	public static IObservable<GtkFileChooserButtonHandleSignalStructs.UpdatePreviewSignal> Signal_UpdatePreview(this GtkFileChooserButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserButtonHandleSignalStructs.UpdatePreviewSignal> obs) =>
		{
			GtkFileChooserButtonHandleSignalDelegates.update_preview handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserButtonHandleSignalStructs.UpdatePreviewSignal()
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

public static class GtkFileChooserButtonHandleSignalStructs
{

public class FileSetSignal
{

	public MentorLake.Gtk.GtkFileChooserButtonHandle Self;

	public IntPtr UserData;
}

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

public static class GtkFileChooserButtonHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::file-set signal is emitted when the user selects a file.
/// </para>
/// <para>
/// Note that this signal is only emitted when the user
/// changes the file.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void file_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))] MentorLake.Gtk.GtkFileChooserButtonHandle self, IntPtr user_data);


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


public static class GtkFileChooserButtonHandleExtensions
{
/// <summary>
/// <para>
/// Returns whether the button grabs focus when it is clicked with the mouse.
/// See gtk_file_chooser_button_set_focus_on_click().
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkFileChooserButton
/// </param>
/// <return>
/// %TRUE if the button grabs focus when it is clicked with
///               the mouse.
/// </return>

	public static bool GetFocusOnClick(this MentorLake.Gtk.GtkFileChooserButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserButtonHandle)");
		return GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_get_focus_on_click(button);
	}

/// <summary>
/// <para>
/// Retrieves the title of the browse dialog used by @button. The returned value
/// should not be modified or freed.
/// </para>
/// </summary>

/// <param name="button">
/// the button widget to examine.
/// </param>
/// <return>
/// a pointer to the browse dialog’s title.
/// </return>

	public static string GetTitle(this MentorLake.Gtk.GtkFileChooserButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserButtonHandle)");
		return GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_get_title(button);
	}

/// <summary>
/// <para>
/// Retrieves the width in characters of the @button widget’s entry and/or label.
/// </para>
/// </summary>

/// <param name="button">
/// the button widget to examine.
/// </param>
/// <return>
/// an integer width (in characters) that the button will use to size itself.
/// </return>

	public static int GetWidthChars(this MentorLake.Gtk.GtkFileChooserButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserButtonHandle)");
		return GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_get_width_chars(button);
	}

/// <summary>
/// <para>
/// Sets whether the button will grab focus when it is clicked with the mouse.
/// Making mouse clicks not grab focus is useful in places like toolbars where
/// you don’t want the keyboard focus removed from the main area of the
/// application.
/// </para>
/// </summary>

/// <param name="button">
/// a #GtkFileChooserButton
/// </param>
/// <param name="focus_on_click">
/// whether the button grabs focus when clicked with the mouse
/// </param>

	public static T SetFocusOnClick<T>(this T button, bool focus_on_click) where T : GtkFileChooserButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserButtonHandle)");
		GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_set_focus_on_click(button, focus_on_click);
		return button;
	}

/// <summary>
/// <para>
/// Modifies the @title of the browse dialog used by @button.
/// </para>
/// </summary>

/// <param name="button">
/// the button widget to modify.
/// </param>
/// <param name="title">
/// the new browse dialog title.
/// </param>

	public static T SetTitle<T>(this T button, string title) where T : GtkFileChooserButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserButtonHandle)");
		GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_set_title(button, title);
		return button;
	}

/// <summary>
/// <para>
/// Sets the width (in characters) that @button will use to @n_chars.
/// </para>
/// </summary>

/// <param name="button">
/// the button widget to examine.
/// </param>
/// <param name="n_chars">
/// the new width, in characters.
/// </param>

	public static T SetWidthChars<T>(this T button, int n_chars) where T : GtkFileChooserButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserButtonHandle)");
		GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_set_width_chars(button, n_chars);
		return button;
	}

}

internal class GtkFileChooserButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkFileChooserButtonHandle gtk_file_chooser_button_new(string title, MentorLake.Gtk.GtkFileChooserAction action);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkFileChooserButtonHandle gtk_file_chooser_button_new_with_dialog([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle dialog);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_file_chooser_button_get_focus_on_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))] MentorLake.Gtk.GtkFileChooserButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_file_chooser_button_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))] MentorLake.Gtk.GtkFileChooserButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_file_chooser_button_get_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))] MentorLake.Gtk.GtkFileChooserButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_button_set_focus_on_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))] MentorLake.Gtk.GtkFileChooserButtonHandle button, bool focus_on_click);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_button_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))] MentorLake.Gtk.GtkFileChooserButtonHandle button, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_file_chooser_button_set_width_chars([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))] MentorLake.Gtk.GtkFileChooserButtonHandle button, int n_chars);

}
