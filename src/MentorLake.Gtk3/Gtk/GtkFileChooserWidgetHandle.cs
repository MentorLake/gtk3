namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkFileChooserWidget is a widget for choosing files.
/// It exposes the #GtkFileChooser interface, and you should
/// use the methods of this interface to interact with the
/// widget.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkFileChooserWidget has a single CSS node with name filechooser.
/// </para>
/// </summary>

public class GtkFileChooserWidgetHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFileChooserHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkFileChooserWidget. This is a file chooser widget that can
/// be embedded in custom windows, and it is the same widget that is used by
/// #GtkFileChooserDialog.
/// </para>
/// </summary>

/// <param name="action">
/// Open or save mode for the widget
/// </param>
/// <return>
/// a new #GtkFileChooserWidget
/// </return>

	public static MentorLake.Gtk.GtkFileChooserWidgetHandle New(MentorLake.Gtk.GtkFileChooserAction action)
	{
		return GtkFileChooserWidgetHandleExterns.gtk_file_chooser_widget_new(action);
	}

}
public static class GtkFileChooserWidgetHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::desktop-folder signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser show the user&apos;s Desktop
/// folder in the file list.
/// </para>
/// <para>
/// The default binding for this signal is `Alt + D`.
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.DesktopFolderSignal> Signal_DesktopFolder(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.DesktopFolderSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.desktop_folder handler = ( MentorLake.Gtk.GtkFileChooserWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.DesktopFolderSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "desktop-folder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::down-folder signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser go to a child of the current folder
/// in the file hierarchy. The subfolder that will be used is displayed in the
/// path bar widget of the file chooser. For example, if the path bar is showing
/// &quot;/foo/bar/baz&quot;, with bar currently displayed, then this will cause the file
/// chooser to switch to the &quot;baz&quot; subfolder.
/// </para>
/// <para>
/// The default binding for this signal is `Alt + Down`.
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.DownFolderSignal> Signal_DownFolder(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.DownFolderSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.down_folder handler = ( MentorLake.Gtk.GtkFileChooserWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.DownFolderSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "down-folder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::home-folder signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser show the user&apos;s home
/// folder in the file list.
/// </para>
/// <para>
/// The default binding for this signal is `Alt + Home`.
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.HomeFolderSignal> Signal_HomeFolder(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.HomeFolderSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.home_folder handler = ( MentorLake.Gtk.GtkFileChooserWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.HomeFolderSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "home-folder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::location-popup signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser show a &quot;Location&quot; prompt which
/// the user can use to manually type the name of the file he wishes to select.
/// </para>
/// <para>
/// The default bindings for this signal are `Control + L` with a @path string
/// of &quot;&quot; (the empty string).  It is also bound to `/` with a @path string of
/// &quot;`/`&quot; (a slash):  this lets you type `/` and immediately type a path name.
/// On Unix systems, this is bound to `~` (tilde) with a @path string of &quot;~&quot;
/// itself for access to home directories.
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.LocationPopupSignal> Signal_LocationPopup(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.LocationPopupSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.location_popup handler = ( MentorLake.Gtk.GtkFileChooserWidgetHandle self,  string path,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.LocationPopupSignal()
				{
					Self = self, Path = path, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "location-popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::location-popup-on-paste signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser show a &quot;Location&quot; prompt when the user
/// pastes into a #GtkFileChooserWidget.
/// </para>
/// <para>
/// The default binding for this signal is `Control + V`.
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.LocationPopupOnPasteSignal> Signal_LocationPopupOnPaste(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.LocationPopupOnPasteSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.location_popup_on_paste handler = ( MentorLake.Gtk.GtkFileChooserWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.LocationPopupOnPasteSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "location-popup-on-paste", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::location-toggle-popup signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to toggle the visibility of a &quot;Location&quot; prompt which the user
/// can use to manually type the name of the file he wishes to select.
/// </para>
/// <para>
/// The default binding for this signal is `Control + L`.
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.LocationTogglePopupSignal> Signal_LocationTogglePopup(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.LocationTogglePopupSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.location_toggle_popup handler = ( MentorLake.Gtk.GtkFileChooserWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.LocationTogglePopupSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "location-toggle-popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::places-shortcut signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to move the focus to the places sidebar.
/// </para>
/// <para>
/// The default binding for this signal is `Alt + P`.
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.PlacesShortcutSignal> Signal_PlacesShortcut(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.PlacesShortcutSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.places_shortcut handler = ( MentorLake.Gtk.GtkFileChooserWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.PlacesShortcutSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "places-shortcut", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::quick-bookmark signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser switch to the bookmark specified
/// in the @bookmark_index parameter. For example, if you have three bookmarks,
/// you can pass 0, 1, 2 to this signal to switch to each of them, respectively.
/// </para>
/// <para>
/// The default binding for this signal is `Alt + 1`, `Alt + 2`,
/// etc. until `Alt + 0`.  Note that in the default binding, that
/// `Alt + 1` is actually defined to switch to the bookmark at index
/// 0, and so on successively; `Alt + 0` is defined to switch to the
/// bookmark at index 10.
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.QuickBookmarkSignal> Signal_QuickBookmark(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.QuickBookmarkSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.quick_bookmark handler = ( MentorLake.Gtk.GtkFileChooserWidgetHandle self,  int bookmark_index,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.QuickBookmarkSignal()
				{
					Self = self, BookmarkIndex = bookmark_index, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "quick-bookmark", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::recent-shortcut signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser show the Recent location.
/// </para>
/// <para>
/// The default binding for this signal is `Alt + R`.
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.RecentShortcutSignal> Signal_RecentShortcut(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.RecentShortcutSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.recent_shortcut handler = ( MentorLake.Gtk.GtkFileChooserWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.RecentShortcutSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "recent-shortcut", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::search-shortcut signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser show the search entry.
/// </para>
/// <para>
/// The default binding for this signal is `Alt + S`.
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.SearchShortcutSignal> Signal_SearchShortcut(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.SearchShortcutSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.search_shortcut handler = ( MentorLake.Gtk.GtkFileChooserWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.SearchShortcutSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "search-shortcut", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::show-hidden signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser display hidden files.
/// </para>
/// <para>
/// The default binding for this signal is `Control + H`.
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.ShowHiddenSignal> Signal_ShowHidden(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.ShowHiddenSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.show_hidden handler = ( MentorLake.Gtk.GtkFileChooserWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.ShowHiddenSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show-hidden", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The ::up-folder signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser go to the parent of the current folder
/// in the file hierarchy.
/// </para>
/// <para>
/// The default binding for this signal is `Alt + Up`.
/// </para>
/// </summary>

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.UpFolderSignal> Signal_UpFolder(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.UpFolderSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.up_folder handler = ( MentorLake.Gtk.GtkFileChooserWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.UpFolderSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "up-folder", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.ConfirmOverwriteSignal> Signal_ConfirmOverwrite(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.ConfirmOverwriteSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.confirm_overwrite handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.ConfirmOverwriteSignal()
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

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.CurrentFolderChangedSignal> Signal_CurrentFolderChanged(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.CurrentFolderChangedSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.current_folder_changed handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.CurrentFolderChangedSignal()
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

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.FileActivatedSignal> Signal_FileActivated(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.FileActivatedSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.file_activated handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.FileActivatedSignal()
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

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.selection_changed handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.SelectionChangedSignal()
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

	public static IObservable<GtkFileChooserWidgetHandleSignalStructs.UpdatePreviewSignal> Signal_UpdatePreview(this GtkFileChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkFileChooserWidgetHandleSignalStructs.UpdatePreviewSignal> obs) =>
		{
			GtkFileChooserWidgetHandleSignalDelegates.update_preview handler = ( MentorLake.Gtk.GtkFileChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkFileChooserWidgetHandleSignalStructs.UpdatePreviewSignal()
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

public static class GtkFileChooserWidgetHandleSignalStructs
{

public class DesktopFolderSignal
{

	public MentorLake.Gtk.GtkFileChooserWidgetHandle Self;

	public IntPtr UserData;
}

public class DownFolderSignal
{

	public MentorLake.Gtk.GtkFileChooserWidgetHandle Self;

	public IntPtr UserData;
}

public class HomeFolderSignal
{

	public MentorLake.Gtk.GtkFileChooserWidgetHandle Self;

	public IntPtr UserData;
}

public class LocationPopupSignal
{

	public MentorLake.Gtk.GtkFileChooserWidgetHandle Self;
/// <summary>
/// <para>
/// a string that gets put in the text entry for the file name
/// </para>
/// </summary>

	public string Path;

	public IntPtr UserData;
}

public class LocationPopupOnPasteSignal
{

	public MentorLake.Gtk.GtkFileChooserWidgetHandle Self;

	public IntPtr UserData;
}

public class LocationTogglePopupSignal
{

	public MentorLake.Gtk.GtkFileChooserWidgetHandle Self;

	public IntPtr UserData;
}

public class PlacesShortcutSignal
{

	public MentorLake.Gtk.GtkFileChooserWidgetHandle Self;

	public IntPtr UserData;
}

public class QuickBookmarkSignal
{

	public MentorLake.Gtk.GtkFileChooserWidgetHandle Self;
/// <summary>
/// <para>
/// the number of the bookmark to switch to
/// </para>
/// </summary>

	public int BookmarkIndex;

	public IntPtr UserData;
}

public class RecentShortcutSignal
{

	public MentorLake.Gtk.GtkFileChooserWidgetHandle Self;

	public IntPtr UserData;
}

public class SearchShortcutSignal
{

	public MentorLake.Gtk.GtkFileChooserWidgetHandle Self;

	public IntPtr UserData;
}

public class ShowHiddenSignal
{

	public MentorLake.Gtk.GtkFileChooserWidgetHandle Self;

	public IntPtr UserData;
}

public class UpFolderSignal
{

	public MentorLake.Gtk.GtkFileChooserWidgetHandle Self;

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

public static class GtkFileChooserWidgetHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::desktop-folder signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser show the user&apos;s Desktop
/// folder in the file list.
/// </para>
/// <para>
/// The default binding for this signal is `Alt + D`.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void desktop_folder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::down-folder signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser go to a child of the current folder
/// in the file hierarchy. The subfolder that will be used is displayed in the
/// path bar widget of the file chooser. For example, if the path bar is showing
/// &quot;/foo/bar/baz&quot;, with bar currently displayed, then this will cause the file
/// chooser to switch to the &quot;baz&quot; subfolder.
/// </para>
/// <para>
/// The default binding for this signal is `Alt + Down`.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void down_folder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::home-folder signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser show the user&apos;s home
/// folder in the file list.
/// </para>
/// <para>
/// The default binding for this signal is `Alt + Home`.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void home_folder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::location-popup signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser show a &quot;Location&quot; prompt which
/// the user can use to manually type the name of the file he wishes to select.
/// </para>
/// <para>
/// The default bindings for this signal are `Control + L` with a @path string
/// of &quot;&quot; (the empty string).  It is also bound to `/` with a @path string of
/// &quot;`/`&quot; (a slash):  this lets you type `/` and immediately type a path name.
/// On Unix systems, this is bound to `~` (tilde) with a @path string of &quot;~&quot;
/// itself for access to home directories.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="path">
/// a string that gets put in the text entry for the file name
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void location_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, string path, IntPtr user_data);


/// <summary>
/// <para>
/// The ::location-popup-on-paste signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser show a &quot;Location&quot; prompt when the user
/// pastes into a #GtkFileChooserWidget.
/// </para>
/// <para>
/// The default binding for this signal is `Control + V`.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void location_popup_on_paste([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::location-toggle-popup signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to toggle the visibility of a &quot;Location&quot; prompt which the user
/// can use to manually type the name of the file he wishes to select.
/// </para>
/// <para>
/// The default binding for this signal is `Control + L`.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void location_toggle_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::places-shortcut signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to move the focus to the places sidebar.
/// </para>
/// <para>
/// The default binding for this signal is `Alt + P`.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void places_shortcut([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::quick-bookmark signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser switch to the bookmark specified
/// in the @bookmark_index parameter. For example, if you have three bookmarks,
/// you can pass 0, 1, 2 to this signal to switch to each of them, respectively.
/// </para>
/// <para>
/// The default binding for this signal is `Alt + 1`, `Alt + 2`,
/// etc. until `Alt + 0`.  Note that in the default binding, that
/// `Alt + 1` is actually defined to switch to the bookmark at index
/// 0, and so on successively; `Alt + 0` is defined to switch to the
/// bookmark at index 10.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="bookmark_index">
/// the number of the bookmark to switch to
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void quick_bookmark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, int bookmark_index, IntPtr user_data);


/// <summary>
/// <para>
/// The ::recent-shortcut signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser show the Recent location.
/// </para>
/// <para>
/// The default binding for this signal is `Alt + R`.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void recent_shortcut([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::search-shortcut signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser show the search entry.
/// </para>
/// <para>
/// The default binding for this signal is `Alt + S`.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void search_shortcut([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::show-hidden signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser display hidden files.
/// </para>
/// <para>
/// The default binding for this signal is `Control + H`.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_hidden([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::up-folder signal is a [keybinding signal][GtkBindingSignal]
/// which gets emitted when the user asks for it.
/// </para>
/// <para>
/// This is used to make the file chooser go to the parent of the current folder
/// in the file hierarchy.
/// </para>
/// <para>
/// The default binding for this signal is `Alt + Up`.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void up_folder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


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


public static class GtkFileChooserWidgetHandleExtensions
{
}

internal class GtkFileChooserWidgetHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkFileChooserWidgetHandle gtk_file_chooser_widget_new(MentorLake.Gtk.GtkFileChooserAction action);

}
