namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkFileChooserDialog is a dialog box suitable for use with
/// “File/Open” or “File/Save as” commands.  This widget works by
/// putting a #GtkFileChooserWidget inside a #GtkDialog.  It exposes
/// the #GtkFileChooser interface, so you can use all of the
/// #GtkFileChooser functions on the file chooser dialog as well as
/// those for #GtkDialog.
/// </para>
/// <para>
/// Note that #GtkFileChooserDialog does not have any methods of its
/// own.  Instead, you should use the functions that work on a
/// #GtkFileChooser.
/// </para>
/// <para>
/// If you want to integrate well with the platform you should use the
/// #GtkFileChooserNative API, which will use a platform-specific
/// dialog if available and fall back to GtkFileChooserDialog
/// otherwise.
/// </para>
/// <para>
/// ## Typical usage ## {#gtkfilechooser-typical-usage}
/// </para>
/// <para>
/// In the simplest of cases, you can the following code to use
/// #GtkFileChooserDialog to select a file for opening:
/// </para>
/// <code>
/// GtkWidget *dialog;
/// GtkWidget *dialog;
/// GtkFileChooserAction action = GTK_FILE_CHOOSER_ACTION_OPEN;
/// gint res;
/// 
/// dialog = gtk_file_chooser_dialog_new (&quot;Open File&quot;,
///                                       parent_window,
///                                       action,
///                                       _(&quot;_Cancel&quot;),
///                                       GTK_RESPONSE_CANCEL,
///                                       _(&quot;_Open&quot;),
///                                       GTK_RESPONSE_ACCEPT,
///                                       NULL);
/// 
/// res = gtk_dialog_run (GTK_DIALOG (dialog));
/// if (res == GTK_RESPONSE_ACCEPT)
///   {
///     char *filename;
///     GtkFileChooser *chooser = GTK_FILE_CHOOSER (dialog);
///     filename = gtk_file_chooser_get_filename (chooser);
///     open_file (filename);
///     g_free (filename);
///   }
/// 
/// gtk_widget_destroy (dialog);
/// </code>
/// <para>
/// To use a dialog for saving, you can use this:
/// </para>
/// <code>
/// GtkWidget *dialog;
/// GtkWidget *dialog;
/// GtkFileChooser *chooser;
/// GtkFileChooserAction action = GTK_FILE_CHOOSER_ACTION_SAVE;
/// gint res;
/// 
/// dialog = gtk_file_chooser_dialog_new (&quot;Save File&quot;,
///                                       parent_window,
///                                       action,
///                                       _(&quot;_Cancel&quot;),
///                                       GTK_RESPONSE_CANCEL,
///                                       _(&quot;_Save&quot;),
///                                       GTK_RESPONSE_ACCEPT,
///                                       NULL);
/// chooser = GTK_FILE_CHOOSER (dialog);
/// 
/// gtk_file_chooser_set_do_overwrite_confirmation (chooser, TRUE);
/// 
/// if (user_edited_a_new_document)
///   gtk_file_chooser_set_current_name (chooser,
///                                      _(&quot;Untitled document&quot;));
/// else
///   gtk_file_chooser_set_filename (chooser,
///                                  existing_filename);
/// 
/// res = gtk_dialog_run (GTK_DIALOG (dialog));
/// if (res == GTK_RESPONSE_ACCEPT)
///   {
///     char *filename;
/// 
///     filename = gtk_file_chooser_get_filename (chooser);
///     save_to_file (filename);
///     g_free (filename);
///   }
/// 
/// gtk_widget_destroy (dialog);
/// </code>
/// <para>
/// ## Setting up a file chooser dialog ## {#gtkfilechooserdialog-setting-up}
/// </para>
/// <para>
/// There are various cases in which you may need to use a #GtkFileChooserDialog:
/// </para>
/// <para>
/// - To select a file for opening. Use #GTK_FILE_CHOOSER_ACTION_OPEN.
/// </para>
/// <para>
/// - To save a file for the first time. Use #GTK_FILE_CHOOSER_ACTION_SAVE,
///   and suggest a name such as “Untitled” with gtk_file_chooser_set_current_name().
/// </para>
/// <para>
/// - To save a file under a different name. Use #GTK_FILE_CHOOSER_ACTION_SAVE,
///   and set the existing filename with gtk_file_chooser_set_filename().
/// </para>
/// <para>
/// - To choose a folder instead of a file. Use #GTK_FILE_CHOOSER_ACTION_SELECT_FOLDER.
/// </para>
/// <para>
/// Note that old versions of the file chooser’s documentation suggested
/// using gtk_file_chooser_set_current_folder() in various
/// situations, with the intention of letting the application
/// suggest a reasonable default folder.  This is no longer
/// considered to be a good policy, as now the file chooser is
/// able to make good suggestions on its own.  In general, you
/// should only cause the file chooser to show a specific folder
/// when it is appropriate to use gtk_file_chooser_set_filename(),
/// i.e. when you are doing a Save As command and you already
/// have a file saved somewhere.
/// </para>
/// <para>
/// ## Response Codes ## {#gtkfilechooserdialog-responses}
/// </para>
/// <para>
/// #GtkFileChooserDialog inherits from #GtkDialog, so buttons that
/// go in its action area have response codes such as
/// #GTK_RESPONSE_ACCEPT and #GTK_RESPONSE_CANCEL.  For example, you
/// could call gtk_file_chooser_dialog_new() as follows:
/// </para>
/// <code>
/// GtkWidget *dialog;
/// GtkWidget *dialog;
/// GtkFileChooserAction action = GTK_FILE_CHOOSER_ACTION_OPEN;
/// 
/// dialog = gtk_file_chooser_dialog_new (&quot;Open File&quot;,
///                                       parent_window,
///                                       action,
///                                       _(&quot;_Cancel&quot;),
///                                       GTK_RESPONSE_CANCEL,
///                                       _(&quot;_Open&quot;),
///                                       GTK_RESPONSE_ACCEPT,
///                                       NULL);
/// </code>
/// <para>
/// This will create buttons for “Cancel” and “Open” that use stock
/// response identifiers from #GtkResponseType.  For most dialog
/// boxes you can use your own custom response codes rather than the
/// ones in #GtkResponseType, but #GtkFileChooserDialog assumes that
/// its “accept”-type action, e.g. an “Open” or “Save” button,
/// will have one of the following response codes:
/// </para>
/// <para>
/// - #GTK_RESPONSE_ACCEPT
/// - #GTK_RESPONSE_OK
/// - #GTK_RESPONSE_YES
/// - #GTK_RESPONSE_APPLY
/// </para>
/// <para>
/// This is because #GtkFileChooserDialog must intercept responses
/// and switch to folders if appropriate, rather than letting the
/// dialog terminate — the implementation uses these known
/// response codes to know which responses can be blocked if
/// appropriate.
/// </para>
/// <para>
/// To summarize, make sure you use a
/// [stock response code][gtkfilechooserdialog-responses]
/// when you use #GtkFileChooserDialog to ensure proper operation.
/// </para>
/// </summary>

public class GtkFileChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFileChooserHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkFileChooserDialog.  This function is analogous to
/// gtk_dialog_new_with_buttons().
/// </para>
/// </summary>

/// <param name="title">
/// Title of the dialog, or %NULL
/// </param>
/// <param name="parent">
/// Transient parent of the dialog, or %NULL
/// </param>
/// <param name="action">
/// Open or save mode for the dialog
/// </param>
/// <param name="first_button_text">
/// stock ID or text to go in the first button, or %NULL
/// </param>
/// <param name="@__arglist">
/// response ID for the first button, then additional (button, id) pairs, ending with %NULL
/// </param>
/// <return>
/// a new #GtkFileChooserDialog
/// </return>

	public static MentorLake.Gtk.GtkFileChooserDialogHandle New(string title, MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkFileChooserAction action, string first_button_text, IntPtr @__arglist)
	{
		return GtkFileChooserDialogHandleExterns.gtk_file_chooser_dialog_new(title, parent, action, first_button_text, @__arglist);
	}

}
public static class GtkFileChooserDialogHandleSignalExtensions
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
/// <code>
/// static GtkFileChooserConfirmation
/// static GtkFileChooserConfirmation
/// confirm_overwrite_callback (GtkFileChooser *chooser, gpointer data)
/// {
///   char *uri;
/// 
///   uri = gtk_file_chooser_get_uri (chooser);
/// 
///   if (is_uri_read_only (uri))
///     {
///       if (user_wants_to_replace_read_only_file (uri))
///         return GTK_FILE_CHOOSER_CONFIRMATION_ACCEPT_FILENAME;
///       else
///         return GTK_FILE_CHOOSER_CONFIRMATION_SELECT_AGAIN;
///     } else
///       return GTK_FILE_CHOOSER_CONFIRMATION_CONFIRM; // fall back to the default dialog
/// }
/// 
/// ...
/// 
/// chooser = gtk_file_chooser_dialog_new (...);
/// 
/// gtk_file_chooser_set_do_overwrite_confirmation (GTK_FILE_CHOOSER (dialog), TRUE);
/// g_signal_connect (chooser, &quot;confirm-overwrite&quot;,
///                   G_CALLBACK (confirm_overwrite_callback), NULL);
/// 
/// if (gtk_dialog_run (chooser) == GTK_RESPONSE_ACCEPT)
///         save_to_file (gtk_file_chooser_get_filename (GTK_FILE_CHOOSER (chooser));
/// 
/// gtk_widget_destroy (chooser);
/// </code>
/// </summary>

	public static IObservable<GtkFileChooserDialogHandleSignalStructs.ConfirmOverwriteSignal> Signal_ConfirmOverwrite(this GtkFileChooserDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserDialogHandleSignalStructs.ConfirmOverwriteSignal> obs) =>
		{
			GtkFileChooserDialogHandleSignalDelegates.confirm_overwrite handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserDialogHandleSignalStructs.ConfirmOverwriteSignal()
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

	public static IObservable<GtkFileChooserDialogHandleSignalStructs.CurrentFolderChangedSignal> Signal_CurrentFolderChanged(this GtkFileChooserDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserDialogHandleSignalStructs.CurrentFolderChangedSignal> obs) =>
		{
			GtkFileChooserDialogHandleSignalDelegates.current_folder_changed handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserDialogHandleSignalStructs.CurrentFolderChangedSignal()
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
/// This signal is emitted when the user &quot;activates&quot; a file in the file
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

	public static IObservable<GtkFileChooserDialogHandleSignalStructs.FileActivatedSignal> Signal_FileActivated(this GtkFileChooserDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserDialogHandleSignalStructs.FileActivatedSignal> obs) =>
		{
			GtkFileChooserDialogHandleSignalDelegates.file_activated handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserDialogHandleSignalStructs.FileActivatedSignal()
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

	public static IObservable<GtkFileChooserDialogHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkFileChooserDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserDialogHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkFileChooserDialogHandleSignalDelegates.selection_changed handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserDialogHandleSignalStructs.SelectionChangedSignal()
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

	public static IObservable<GtkFileChooserDialogHandleSignalStructs.UpdatePreviewSignal> Signal_UpdatePreview(this GtkFileChooserDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserDialogHandleSignalStructs.UpdatePreviewSignal> obs) =>
		{
			GtkFileChooserDialogHandleSignalDelegates.update_preview handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserDialogHandleSignalStructs.UpdatePreviewSignal()
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

public static class GtkFileChooserDialogHandleSignalStructs
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

public static class GtkFileChooserDialogHandleSignalDelegates
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
/// <code>
/// static GtkFileChooserConfirmation
/// static GtkFileChooserConfirmation
/// confirm_overwrite_callback (GtkFileChooser *chooser, gpointer data)
/// {
///   char *uri;
/// 
///   uri = gtk_file_chooser_get_uri (chooser);
/// 
///   if (is_uri_read_only (uri))
///     {
///       if (user_wants_to_replace_read_only_file (uri))
///         return GTK_FILE_CHOOSER_CONFIRMATION_ACCEPT_FILENAME;
///       else
///         return GTK_FILE_CHOOSER_CONFIRMATION_SELECT_AGAIN;
///     } else
///       return GTK_FILE_CHOOSER_CONFIRMATION_CONFIRM; // fall back to the default dialog
/// }
/// 
/// ...
/// 
/// chooser = gtk_file_chooser_dialog_new (...);
/// 
/// gtk_file_chooser_set_do_overwrite_confirmation (GTK_FILE_CHOOSER (dialog), TRUE);
/// g_signal_connect (chooser, &quot;confirm-overwrite&quot;,
///                   G_CALLBACK (confirm_overwrite_callback), NULL);
/// 
/// if (gtk_dialog_run (chooser) == GTK_RESPONSE_ACCEPT)
///         save_to_file (gtk_file_chooser_get_filename (GTK_FILE_CHOOSER (chooser));
/// 
/// gtk_widget_destroy (chooser);
/// </code>
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
/// This signal is emitted when the user &quot;activates&quot; a file in the file
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


public static class GtkFileChooserDialogHandleExtensions
{
}

internal class GtkFileChooserDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserDialogHandle>))]
	internal static extern MentorLake.Gtk.GtkFileChooserDialogHandle gtk_file_chooser_dialog_new(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkFileChooserAction action, string first_button_text, IntPtr @__arglist);

}
