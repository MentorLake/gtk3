namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkPlacesSidebar is a widget that displays a list of frequently-used places in the
/// file system:  the user’s home directory, the user’s bookmarks, and volumes and drives.
/// This widget is used as a sidebar in #GtkFileChooser and may be used by file managers
/// and similar programs.
/// </para>
/// <para>
/// The places sidebar displays drives and volumes, and will automatically mount
/// or unmount them when the user selects them.
/// </para>
/// <para>
/// Applications can hook to various signals in the places sidebar to customize
/// its behavior.  For example, they can add extra commands to the context menu
/// of the sidebar.
/// </para>
/// <para>
/// While bookmarks are completely in control of the user, the places sidebar also
/// allows individual applications to provide extra shortcut folders that are unique
/// to each application.  For example, a Paint program may want to add a shortcut
/// for a Clipart folder.  You can do this with gtk_places_sidebar_add_shortcut().
/// </para>
/// <para>
/// To make use of the places sidebar, an application at least needs to connect
/// to the #GtkPlacesSidebar::open-location signal.  This is emitted when the
/// user selects in the sidebar a location to open.  The application should also
/// call gtk_places_sidebar_set_location() when it changes the currently-viewed
/// location.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// GtkPlacesSidebar uses a single CSS node with name placessidebar and style
/// class .sidebar.
/// </para>
/// <para>
/// Among the children of the places sidebar, the following style classes can
/// be used:
/// - .sidebar-new-bookmark-row for the 'Add new bookmark' row
/// - .sidebar-placeholder-row for a row that is a placeholder
/// - .has-open-popup when a popup is open for a row
/// </para>
/// </summary>

public class GtkPlacesSidebarHandle : GtkScrolledWindowHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkPlacesSidebar widget.
/// </para>
/// <para>
/// The application should connect to at least the
/// #GtkPlacesSidebar::open-location signal to be notified
/// when the user makes a selection in the sidebar.
/// </para>
/// </summary>

/// <return>
/// a newly created #GtkPlacesSidebar
/// </return>

	public static MentorLake.Gtk.GtkPlacesSidebarHandle New()
	{
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_new();
	}

}
public static class GtkPlacesSidebarHandleSignalExtensions
{
/// <summary>
/// <para>
/// The places sidebar emits this signal when it needs to ask the application
/// to pop up a menu to ask the user for which drag action to perform.
/// </para>
/// </summary>

	public static IObservable<GtkPlacesSidebarHandleSignalStructs.DragActionAskSignal> Signal_DragActionAsk(this GtkPlacesSidebarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarHandleSignalStructs.DragActionAskSignal> obs) =>
		{
			GtkPlacesSidebarHandleSignalDelegates.drag_action_ask handler = ( MentorLake.Gtk.GtkPlacesSidebarHandle self,  int actions,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlacesSidebarHandleSignalStructs.DragActionAskSignal()
				{
					Self = self, Actions = actions, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-action-ask", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// When the user starts a drag-and-drop operation and the sidebar needs
/// to ask the application for which drag action to perform, then the
/// sidebar will emit this signal.
/// </para>
/// <para>
/// The application can evaluate the @context for customary actions, or
/// it can check the type of the files indicated by @source_file_list against the
/// possible actions for the destination @dest_file.
/// </para>
/// <para>
/// The drag action to use must be the return value of the signal handler.
/// </para>
/// </summary>

	public static IObservable<GtkPlacesSidebarHandleSignalStructs.DragActionRequestedSignal> Signal_DragActionRequested(this GtkPlacesSidebarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarHandleSignalStructs.DragActionRequestedSignal> obs) =>
		{
			GtkPlacesSidebarHandleSignalDelegates.drag_action_requested handler = ( MentorLake.Gtk.GtkPlacesSidebarHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  MentorLake.Gio.GFileHandle dest_file,  MentorLake.GLib.GListHandle source_file_list,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlacesSidebarHandleSignalStructs.DragActionRequestedSignal()
				{
					Self = self, Context = context, DestFile = dest_file, SourceFileList = source_file_list, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-action-requested", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The places sidebar emits this signal when the user completes a
/// drag-and-drop operation and one of the sidebar's items is the
/// destination.  This item is in the @dest_file, and the
/// @source_file_list has the list of files that are dropped into it and
/// which should be copied/moved/etc. based on the specified @action.
/// </para>
/// </summary>

	public static IObservable<GtkPlacesSidebarHandleSignalStructs.DragPerformDropSignal> Signal_DragPerformDrop(this GtkPlacesSidebarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarHandleSignalStructs.DragPerformDropSignal> obs) =>
		{
			GtkPlacesSidebarHandleSignalDelegates.drag_perform_drop handler = ( MentorLake.Gtk.GtkPlacesSidebarHandle self,  MentorLake.Gio.GFileHandle dest_file,  MentorLake.GLib.GListHandle source_file_list,  int action,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlacesSidebarHandleSignalStructs.DragPerformDropSignal()
				{
					Self = self, DestFile = dest_file, SourceFileList = source_file_list, Action = action, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-perform-drop", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The places sidebar emits this signal when it starts a new operation
/// because the user clicked on some location that needs mounting.
/// In this way the application using the #GtkPlacesSidebar can track the
/// progress of the operation and, for example, show a notification.
/// </para>
/// </summary>

	public static IObservable<GtkPlacesSidebarHandleSignalStructs.MountSignal> Signal_Mount(this GtkPlacesSidebarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarHandleSignalStructs.MountSignal> obs) =>
		{
			GtkPlacesSidebarHandleSignalDelegates.mount handler = ( MentorLake.Gtk.GtkPlacesSidebarHandle self,  MentorLake.Gio.GMountOperationHandle mount_operation,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlacesSidebarHandleSignalStructs.MountSignal()
				{
					Self = self, MountOperation = mount_operation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "mount", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The places sidebar emits this signal when the user selects a location
/// in it.  The calling application should display the contents of that
/// location; for example, a file manager should show a list of files in
/// the specified location.
/// </para>
/// </summary>

	public static IObservable<GtkPlacesSidebarHandleSignalStructs.OpenLocationSignal> Signal_OpenLocation(this GtkPlacesSidebarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarHandleSignalStructs.OpenLocationSignal> obs) =>
		{
			GtkPlacesSidebarHandleSignalDelegates.open_location handler = ( MentorLake.Gtk.GtkPlacesSidebarHandle self,  MentorLake.Gio.GFileHandle location,  MentorLake.Gtk.GtkPlacesOpenFlags open_flags,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlacesSidebarHandleSignalStructs.OpenLocationSignal()
				{
					Self = self, Location = location, OpenFlags = open_flags, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "open-location", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The places sidebar emits this signal when the user invokes a contextual
/// popup on one of its items. In the signal handler, the application may
/// add extra items to the menu as appropriate. For example, a file manager
/// may want to add a "Properties" command to the menu.
/// </para>
/// <para>
/// It is not necessary to store the @selected_item for each menu item;
/// during their callbacks, the application can use gtk_places_sidebar_get_location()
/// to get the file to which the item refers.
/// </para>
/// <para>
/// The @selected_item argument may be %NULL in case the selection refers to
/// a volume. In this case, @selected_volume will be non-%NULL. In this case,
/// the calling application will have to g_object_ref() the @selected_volume and
/// keep it around to use it in the callback.
/// </para>
/// <para>
/// The @container and all its contents are destroyed after the user
/// dismisses the popup. The popup is re-created (and thus, this signal is
/// emitted) every time the user activates the contextual menu.
/// </para>
/// <para>
/// Before 3.18, the @container always was a #GtkMenu, and you were expected
/// to add your items as #GtkMenuItems. Since 3.18, the popup may be implemented
/// as a #GtkPopover, in which case @container will be something else, e.g. a
/// #GtkBox, to which you may add #GtkModelButtons or other widgets, such as
/// #GtkEntries, #GtkSpinButtons, etc. If your application can deal with this
/// situation, you can set #GtkPlacesSidebar::populate-all to %TRUE to request
/// that this signal is emitted for populating popovers as well.
/// </para>
/// </summary>

	public static IObservable<GtkPlacesSidebarHandleSignalStructs.PopulatePopupSignal> Signal_PopulatePopup(this GtkPlacesSidebarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarHandleSignalStructs.PopulatePopupSignal> obs) =>
		{
			GtkPlacesSidebarHandleSignalDelegates.populate_popup handler = ( MentorLake.Gtk.GtkPlacesSidebarHandle self,  MentorLake.Gtk.GtkWidgetHandle container,  MentorLake.Gio.GFileHandle selected_item,  MentorLake.Gio.GVolumeHandle selected_volume,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlacesSidebarHandleSignalStructs.PopulatePopupSignal()
				{
					Self = self, Container = container, SelectedItem = selected_item, SelectedVolume = selected_volume, UserData = user_data
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
/// <summary>
/// <para>
/// The places sidebar emits this signal when it needs the calling
/// application to present an way to connect directly to a network server.
/// For example, the application may bring up a dialog box asking for
/// a URL like "sftp://ftp.example.com".  It is up to the application to create
/// the corresponding mount by using, for example, g_file_mount_enclosing_volume().
/// </para>
/// </summary>

	public static IObservable<GtkPlacesSidebarHandleSignalStructs.ShowConnectToServerSignal> Signal_ShowConnectToServer(this GtkPlacesSidebarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarHandleSignalStructs.ShowConnectToServerSignal> obs) =>
		{
			GtkPlacesSidebarHandleSignalDelegates.show_connect_to_server handler = ( MentorLake.Gtk.GtkPlacesSidebarHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlacesSidebarHandleSignalStructs.ShowConnectToServerSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show-connect-to-server", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The places sidebar emits this signal when it needs the calling
/// application to present an way to directly enter a location.
/// For example, the application may bring up a dialog box asking for
/// a URL like "http://http.example.com".
/// </para>
/// </summary>

	public static IObservable<GtkPlacesSidebarHandleSignalStructs.ShowEnterLocationSignal> Signal_ShowEnterLocation(this GtkPlacesSidebarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarHandleSignalStructs.ShowEnterLocationSignal> obs) =>
		{
			GtkPlacesSidebarHandleSignalDelegates.show_enter_location handler = ( MentorLake.Gtk.GtkPlacesSidebarHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlacesSidebarHandleSignalStructs.ShowEnterLocationSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show-enter-location", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The places sidebar emits this signal when it needs the calling
/// application to present an error message.  Most of these messages
/// refer to mounting or unmounting media, for example, when a drive
/// cannot be started for some reason.
/// </para>
/// </summary>

	public static IObservable<GtkPlacesSidebarHandleSignalStructs.ShowErrorMessageSignal> Signal_ShowErrorMessage(this GtkPlacesSidebarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarHandleSignalStructs.ShowErrorMessageSignal> obs) =>
		{
			GtkPlacesSidebarHandleSignalDelegates.show_error_message handler = ( MentorLake.Gtk.GtkPlacesSidebarHandle self,  string primary,  string secondary,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlacesSidebarHandleSignalStructs.ShowErrorMessageSignal()
				{
					Self = self, Primary = primary, Secondary = secondary, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show-error-message", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The places sidebar emits this signal when it needs the calling
/// application to present a way to show other locations e.g. drives
/// and network access points.
/// For example, the application may bring up a page showing persistent
/// volumes and discovered network addresses.
/// </para>
/// </summary>

	public static IObservable<GtkPlacesSidebarHandleSignalStructs.ShowOtherLocationsSignal> Signal_ShowOtherLocations(this GtkPlacesSidebarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarHandleSignalStructs.ShowOtherLocationsSignal> obs) =>
		{
			GtkPlacesSidebarHandleSignalDelegates.show_other_locations handler = ( MentorLake.Gtk.GtkPlacesSidebarHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlacesSidebarHandleSignalStructs.ShowOtherLocationsSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show-other-locations", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The places sidebar emits this signal when it needs the calling
/// application to present a way to show other locations e.g. drives
/// and network access points.
/// For example, the application may bring up a page showing persistent
/// volumes and discovered network addresses.
/// </para>
/// </summary>

	public static IObservable<GtkPlacesSidebarHandleSignalStructs.ShowOtherLocationsWithFlagsSignal> Signal_ShowOtherLocationsWithFlags(this GtkPlacesSidebarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarHandleSignalStructs.ShowOtherLocationsWithFlagsSignal> obs) =>
		{
			GtkPlacesSidebarHandleSignalDelegates.show_other_locations_with_flags handler = ( MentorLake.Gtk.GtkPlacesSidebarHandle self,  MentorLake.Gtk.GtkPlacesOpenFlags open_flags,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlacesSidebarHandleSignalStructs.ShowOtherLocationsWithFlagsSignal()
				{
					Self = self, OpenFlags = open_flags, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show-other-locations-with-flags", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The places sidebar emits this signal when it needs the calling
/// application to present a way to show the starred files. In GNOME,
/// starred files are implemented by setting the nao:predefined-tag-favorite
/// tag in the tracker database.
/// </para>
/// </summary>

	public static IObservable<GtkPlacesSidebarHandleSignalStructs.ShowStarredLocationSignal> Signal_ShowStarredLocation(this GtkPlacesSidebarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarHandleSignalStructs.ShowStarredLocationSignal> obs) =>
		{
			GtkPlacesSidebarHandleSignalDelegates.show_starred_location handler = ( MentorLake.Gtk.GtkPlacesSidebarHandle self,  MentorLake.Gtk.GtkPlacesOpenFlags open_flags,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlacesSidebarHandleSignalStructs.ShowStarredLocationSignal()
				{
					Self = self, OpenFlags = open_flags, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show-starred-location", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The places sidebar emits this signal when it starts a new operation
/// because the user for example ejected some drive or unmounted a mount.
/// In this way the application using the #GtkPlacesSidebar can track the
/// progress of the operation and, for example, show a notification.
/// </para>
/// </summary>

	public static IObservable<GtkPlacesSidebarHandleSignalStructs.UnmountSignal> Signal_Unmount(this GtkPlacesSidebarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarHandleSignalStructs.UnmountSignal> obs) =>
		{
			GtkPlacesSidebarHandleSignalDelegates.unmount handler = ( MentorLake.Gtk.GtkPlacesSidebarHandle self,  MentorLake.Gio.GMountOperationHandle mount_operation,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkPlacesSidebarHandleSignalStructs.UnmountSignal()
				{
					Self = self, MountOperation = mount_operation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "unmount", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkPlacesSidebarHandleSignalStructs
{

public class DragActionAskSignal
{

	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
/// <summary>
/// <para>
/// Possible drag actions that need to be asked for.
/// </para>
/// </summary>

	public int Actions;

	public IntPtr UserData;
/// <summary>
/// <para>
/// the final drag action that the sidebar should pass to the drag side
/// of the drag-and-drop operation.
/// </para>
/// </summary>

	public int ReturnValue;
}

public class DragActionRequestedSignal
{

	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
/// <summary>
/// <para>
/// #GdkDragContext with information about the drag operation
/// </para>
/// </summary>

	public MentorLake.Gdk.GdkDragContextHandle Context;
/// <summary>
/// <para>
/// #GFile with the tentative location that is being hovered for a drop
/// </para>
/// </summary>

	public MentorLake.Gio.GFileHandle DestFile;
/// <summary>
/// <para>
/// </para>
/// <para>
///   List of #GFile that are being dragged
/// </para>
/// </summary>

	public MentorLake.GLib.GListHandle SourceFileList;

	public IntPtr UserData;
/// <summary>
/// <para>
/// The drag action to use, for example, #GDK_ACTION_COPY
/// or #GDK_ACTION_MOVE, or 0 if no action is allowed here (i.e. drops
/// are not allowed in the specified @dest_file).
/// </para>
/// </summary>

	public int ReturnValue;
}

public class DragPerformDropSignal
{

	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
/// <summary>
/// <para>
/// Destination #GFile.
/// </para>
/// </summary>

	public MentorLake.Gio.GFileHandle DestFile;
/// <summary>
/// <para>
/// </para>
/// <para>
///   #GList of #GFile that got dropped.
/// </para>
/// </summary>

	public MentorLake.GLib.GListHandle SourceFileList;
/// <summary>
/// <para>
/// Drop action to perform.
/// </para>
/// </summary>

	public int Action;

	public IntPtr UserData;
}

public class MountSignal
{

	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
/// <summary>
/// <para>
/// the #GMountOperation that is going to start.
/// </para>
/// </summary>

	public MentorLake.Gio.GMountOperationHandle MountOperation;

	public IntPtr UserData;
}

public class OpenLocationSignal
{

	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
/// <summary>
/// <para>
/// #GFile to which the caller should switch.
/// </para>
/// </summary>

	public MentorLake.Gio.GFileHandle Location;
/// <summary>
/// <para>
/// a single value from #GtkPlacesOpenFlags specifying how the @location should be opened.
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPlacesOpenFlags OpenFlags;

	public IntPtr UserData;
}

public class PopulatePopupSignal
{

	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
/// <summary>
/// <para>
/// a #GtkMenu or another #GtkContainer
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkWidgetHandle Container;
/// <summary>
/// <para>
/// #GFile with the item to which
///     the popup should refer, or %NULL in the case of a @selected_volume.
/// </para>
/// </summary>

	public MentorLake.Gio.GFileHandle SelectedItem;
/// <summary>
/// <para>
/// #GVolume if the selected
///     item is a volume, or %NULL if it is a file.
/// </para>
/// </summary>

	public MentorLake.Gio.GVolumeHandle SelectedVolume;

	public IntPtr UserData;
}

public class ShowConnectToServerSignal
{

	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;

	public IntPtr UserData;
}

public class ShowEnterLocationSignal
{

	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;

	public IntPtr UserData;
}

public class ShowErrorMessageSignal
{

	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
/// <summary>
/// <para>
/// primary message with a summary of the error to show.
/// </para>
/// </summary>

	public string Primary;
/// <summary>
/// <para>
/// secondary message with details of the error to show.
/// </para>
/// </summary>

	public string Secondary;

	public IntPtr UserData;
}

public class ShowOtherLocationsSignal
{

	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;

	public IntPtr UserData;
}

public class ShowOtherLocationsWithFlagsSignal
{

	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
/// <summary>
/// <para>
/// a single value from #GtkPlacesOpenFlags specifying how it should be opened.
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPlacesOpenFlags OpenFlags;

	public IntPtr UserData;
}

public class ShowStarredLocationSignal
{

	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
/// <summary>
/// <para>
/// a single value from #GtkPlacesOpenFlags specifying how the
///   starred file should be opened.
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkPlacesOpenFlags OpenFlags;

	public IntPtr UserData;
}

public class UnmountSignal
{

	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
/// <summary>
/// <para>
/// the #GMountOperation that is going to start.
/// </para>
/// </summary>

	public MentorLake.Gio.GMountOperationHandle MountOperation;

	public IntPtr UserData;
}
}

public static class GtkPlacesSidebarHandleSignalDelegates
{

/// <summary>
/// <para>
/// The places sidebar emits this signal when it needs to ask the application
/// to pop up a menu to ask the user for which drag action to perform.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="actions">
/// Possible drag actions that need to be asked for.
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// the final drag action that the sidebar should pass to the drag side
/// of the drag-and-drop operation.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int drag_action_ask([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, int actions, IntPtr user_data);


/// <summary>
/// <para>
/// When the user starts a drag-and-drop operation and the sidebar needs
/// to ask the application for which drag action to perform, then the
/// sidebar will emit this signal.
/// </para>
/// <para>
/// The application can evaluate the @context for customary actions, or
/// it can check the type of the files indicated by @source_file_list against the
/// possible actions for the destination @dest_file.
/// </para>
/// <para>
/// The drag action to use must be the return value of the signal handler.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="context">
/// #GdkDragContext with information about the drag operation
/// </param>
/// <param name="dest_file">
/// #GFile with the tentative location that is being hovered for a drop
/// </param>
/// <param name="source_file_list">
/// 
///   List of #GFile that are being dragged
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// The drag action to use, for example, #GDK_ACTION_COPY
/// or #GDK_ACTION_MOVE, or 0 if no action is allowed here (i.e. drops
/// are not allowed in the specified @dest_file).
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int drag_action_requested([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle dest_file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle source_file_list, IntPtr user_data);


/// <summary>
/// <para>
/// The places sidebar emits this signal when the user completes a
/// drag-and-drop operation and one of the sidebar's items is the
/// destination.  This item is in the @dest_file, and the
/// @source_file_list has the list of files that are dropped into it and
/// which should be copied/moved/etc. based on the specified @action.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="dest_file">
/// Destination #GFile.
/// </param>
/// <param name="source_file_list">
/// 
///   #GList of #GFile that got dropped.
/// </param>
/// <param name="action">
/// Drop action to perform.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_perform_drop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle dest_file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle source_file_list, int action, IntPtr user_data);


/// <summary>
/// <para>
/// The places sidebar emits this signal when it starts a new operation
/// because the user clicked on some location that needs mounting.
/// In this way the application using the #GtkPlacesSidebar can track the
/// progress of the operation and, for example, show a notification.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="mount_operation">
/// the #GMountOperation that is going to start.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, IntPtr user_data);


/// <summary>
/// <para>
/// The places sidebar emits this signal when the user selects a location
/// in it.  The calling application should display the contents of that
/// location; for example, a file manager should show a list of files in
/// the specified location.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="location">
/// #GFile to which the caller should switch.
/// </param>
/// <param name="open_flags">
/// a single value from #GtkPlacesOpenFlags specifying how the @location should be opened.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void open_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle location, MentorLake.Gtk.GtkPlacesOpenFlags open_flags, IntPtr user_data);


/// <summary>
/// <para>
/// The places sidebar emits this signal when the user invokes a contextual
/// popup on one of its items. In the signal handler, the application may
/// add extra items to the menu as appropriate. For example, a file manager
/// may want to add a "Properties" command to the menu.
/// </para>
/// <para>
/// It is not necessary to store the @selected_item for each menu item;
/// during their callbacks, the application can use gtk_places_sidebar_get_location()
/// to get the file to which the item refers.
/// </para>
/// <para>
/// The @selected_item argument may be %NULL in case the selection refers to
/// a volume. In this case, @selected_volume will be non-%NULL. In this case,
/// the calling application will have to g_object_ref() the @selected_volume and
/// keep it around to use it in the callback.
/// </para>
/// <para>
/// The @container and all its contents are destroyed after the user
/// dismisses the popup. The popup is re-created (and thus, this signal is
/// emitted) every time the user activates the contextual menu.
/// </para>
/// <para>
/// Before 3.18, the @container always was a #GtkMenu, and you were expected
/// to add your items as #GtkMenuItems. Since 3.18, the popup may be implemented
/// as a #GtkPopover, in which case @container will be something else, e.g. a
/// #GtkBox, to which you may add #GtkModelButtons or other widgets, such as
/// #GtkEntries, #GtkSpinButtons, etc. If your application can deal with this
/// situation, you can set #GtkPlacesSidebar::populate-all to %TRUE to request
/// that this signal is emitted for populating popovers as well.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="container">
/// a #GtkMenu or another #GtkContainer
/// </param>
/// <param name="selected_item">
/// #GFile with the item to which
///     the popup should refer, or %NULL in the case of a @selected_volume.
/// </param>
/// <param name="selected_volume">
/// #GVolume if the selected
///     item is a volume, or %NULL if it is a file.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void populate_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle selected_item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle selected_volume, IntPtr user_data);


/// <summary>
/// <para>
/// The places sidebar emits this signal when it needs the calling
/// application to present an way to connect directly to a network server.
/// For example, the application may bring up a dialog box asking for
/// a URL like "sftp://ftp.example.com".  It is up to the application to create
/// the corresponding mount by using, for example, g_file_mount_enclosing_volume().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_connect_to_server([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The places sidebar emits this signal when it needs the calling
/// application to present an way to directly enter a location.
/// For example, the application may bring up a dialog box asking for
/// a URL like "http://http.example.com".
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_enter_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The places sidebar emits this signal when it needs the calling
/// application to present an error message.  Most of these messages
/// refer to mounting or unmounting media, for example, when a drive
/// cannot be started for some reason.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="primary">
/// primary message with a summary of the error to show.
/// </param>
/// <param name="secondary">
/// secondary message with details of the error to show.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_error_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, string primary, string secondary, IntPtr user_data);


/// <summary>
/// <para>
/// The places sidebar emits this signal when it needs the calling
/// application to present a way to show other locations e.g. drives
/// and network access points.
/// For example, the application may bring up a page showing persistent
/// volumes and discovered network addresses.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_other_locations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The places sidebar emits this signal when it needs the calling
/// application to present a way to show other locations e.g. drives
/// and network access points.
/// For example, the application may bring up a page showing persistent
/// volumes and discovered network addresses.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="open_flags">
/// a single value from #GtkPlacesOpenFlags specifying how it should be opened.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_other_locations_with_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, MentorLake.Gtk.GtkPlacesOpenFlags open_flags, IntPtr user_data);


/// <summary>
/// <para>
/// The places sidebar emits this signal when it needs the calling
/// application to present a way to show the starred files. In GNOME,
/// starred files are implemented by setting the nao:predefined-tag-favorite
/// tag in the tracker database.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="open_flags">
/// a single value from #GtkPlacesOpenFlags specifying how the
///   starred file should be opened.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_starred_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, MentorLake.Gtk.GtkPlacesOpenFlags open_flags, IntPtr user_data);


/// <summary>
/// <para>
/// The places sidebar emits this signal when it starts a new operation
/// because the user for example ejected some drive or unmounted a mount.
/// In this way the application using the #GtkPlacesSidebar can track the
/// progress of the operation and, for example, show a notification.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="mount_operation">
/// the #GMountOperation that is going to start.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unmount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, IntPtr user_data);

}


public static class GtkPlacesSidebarHandleExtensions
{
/// <summary>
/// <para>
/// Applications may want to present some folders in the places sidebar if
/// they could be immediately useful to users.  For example, a drawing
/// program could add a “/usr/share/clipart” location when the sidebar is
/// being used in an “Insert Clipart” dialog box.
/// </para>
/// <para>
/// This function adds the specified @location to a special place for immutable
/// shortcuts.  The shortcuts are application-specific; they are not shared
/// across applications, and they are not persistent.  If this function
/// is called multiple times with different locations, then they are added
/// to the sidebar’s list in the same order as the function is called.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <param name="location">
/// location to add as an application-specific shortcut
/// </param>

	public static T AddShortcut<T>(this T sidebar, MentorLake.Gio.GFileHandle location) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_add_shortcut(sidebar, location);
		return sidebar;
	}

/// <summary>
/// <para>
/// Returns the value previously set with gtk_places_sidebar_set_local_only().
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <return>
/// %TRUE if the sidebar will only show local files.
/// </return>

	public static bool GetLocalOnly(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_local_only(sidebar);
	}

/// <summary>
/// <para>
/// Gets the currently selected location in the @sidebar. This can be %NULL when
/// nothing is selected, for example, when gtk_places_sidebar_set_location() has
/// been called with a location that is not among the sidebar’s list of places to
/// show.
/// </para>
/// <para>
/// You can use this function to get the selection in the @sidebar.  Also, if you
/// connect to the #GtkPlacesSidebar::populate-popup signal, you can use this
/// function to get the location that is being referred to during the callbacks
/// for your menu items.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <return>
/// a #GFile with the selected location, or
/// %NULL if nothing is visually selected.
/// </return>

	public static MentorLake.Gio.GFileHandle GetLocation(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_location(sidebar);
	}

/// <summary>
/// <para>
/// This function queries the bookmarks added by the user to the places sidebar,
/// and returns one of them.  This function is used by #GtkFileChooser to implement
/// the “Alt-1”, “Alt-2”, etc. shortcuts, which activate the cooresponding bookmark.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <param name="n">
/// index of the bookmark to query
/// </param>
/// <return>
/// The bookmark specified by the index @n, or
/// %NULL if no such index exist.  Note that the indices start at 0, even though
/// the file chooser starts them with the keyboard shortcut "Alt-1".
/// </return>

	public static MentorLake.Gio.GFileHandle GetNthBookmark(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, int n)
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_nth_bookmark(sidebar, n);
	}

/// <summary>
/// <para>
/// Gets the open flags.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a #GtkPlacesSidebar
/// </param>
/// <return>
/// the #GtkPlacesOpenFlags of @sidebar
/// </return>

	public static MentorLake.Gtk.GtkPlacesOpenFlags GetOpenFlags(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_open_flags(sidebar);
	}

/// <summary>
/// <para>
/// Returns the value previously set with gtk_places_sidebar_set_show_connect_to_server()
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <return>
/// %TRUE if the sidebar will display a “Connect to Server” item.
/// </return>

	public static bool GetShowConnectToServer(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_show_connect_to_server(sidebar);
	}

/// <summary>
/// <para>
/// Returns the value previously set with gtk_places_sidebar_set_show_desktop()
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <return>
/// %TRUE if the sidebar will display a builtin shortcut to the desktop folder.
/// </return>

	public static bool GetShowDesktop(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_show_desktop(sidebar);
	}

/// <summary>
/// <para>
/// Returns the value previously set with gtk_places_sidebar_set_show_enter_location()
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <return>
/// %TRUE if the sidebar will display an “Enter Location” item.
/// </return>

	public static bool GetShowEnterLocation(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_show_enter_location(sidebar);
	}

/// <summary>
/// <para>
/// Returns the value previously set with gtk_places_sidebar_set_show_other_locations()
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <return>
/// %TRUE if the sidebar will display an “Other Locations” item.
/// </return>

	public static bool GetShowOtherLocations(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_show_other_locations(sidebar);
	}

/// <summary>
/// <para>
/// Returns the value previously set with gtk_places_sidebar_set_show_recent()
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <return>
/// %TRUE if the sidebar will display a builtin shortcut for recent files
/// </return>

	public static bool GetShowRecent(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_show_recent(sidebar);
	}

/// <summary>
/// <para>
/// Returns the value previously set with gtk_places_sidebar_set_show_starred_location()
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <return>
/// %TRUE if the sidebar will display a Starred item.
/// </return>

	public static bool GetShowStarredLocation(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_show_starred_location(sidebar);
	}

/// <summary>
/// <para>
/// Returns the value previously set with gtk_places_sidebar_set_show_trash()
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <return>
/// %TRUE if the sidebar will display a “Trash” item.
/// </return>

	public static bool GetShowTrash(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_show_trash(sidebar);
	}

/// <summary>
/// <para>
/// Gets the list of shortcuts.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <return>
/// 
///     A #GSList of #GFile of the locations that have been added as
///     application-specific shortcuts with gtk_places_sidebar_add_shortcut().
///     To free this list, you can use
/// |[<!-- language="C" -->
/// g_slist_free_full (list, (GDestroyNotify) g_object_unref);
/// ]|
/// </return>

	public static MentorLake.GLib.GSListHandle ListShortcuts(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_list_shortcuts(sidebar);
	}

/// <summary>
/// <para>
/// Removes an application-specific shortcut that has been previously been
/// inserted with gtk_places_sidebar_add_shortcut().  If the @location is not a
/// shortcut in the sidebar, then nothing is done.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <param name="location">
/// location to remove
/// </param>

	public static T RemoveShortcut<T>(this T sidebar, MentorLake.Gio.GFileHandle location) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_remove_shortcut(sidebar, location);
		return sidebar;
	}

/// <summary>
/// <para>
/// Make the GtkPlacesSidebar show drop targets, so it can show the available
/// drop targets and a "new bookmark" row. This improves the Drag-and-Drop
/// experience of the user and allows applications to show all available
/// drop targets at once.
/// </para>
/// <para>
/// This needs to be called when the application is aware of an ongoing drag
/// that might target the sidebar. The drop-targets-visible state will be unset
/// automatically if the drag finishes in the GtkPlacesSidebar. You only need
/// to unset the state when the drag ends on some other widget on your application.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar.
/// </param>
/// <param name="visible">
/// whether to show the valid targets or not.
/// </param>
/// <param name="context">
/// drag context used to ask the source about the action that wants to
///     perform, so hints are more accurate.
/// </param>

	public static T SetDropTargetsVisible<T>(this T sidebar, bool visible, MentorLake.Gdk.GdkDragContextHandle context) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_drop_targets_visible(sidebar, visible, context);
		return sidebar;
	}

/// <summary>
/// <para>
/// Sets whether the @sidebar should only show local files.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <param name="local_only">
/// whether to show only local files
/// </param>

	public static T SetLocalOnly<T>(this T sidebar, bool local_only) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_local_only(sidebar, local_only);
		return sidebar;
	}

/// <summary>
/// <para>
/// Sets the location that is being shown in the widgets surrounding the
/// @sidebar, for example, in a folder view in a file manager.  In turn, the
/// @sidebar will highlight that location if it is being shown in the list of
/// places, or it will unhighlight everything if the @location is not among the
/// places in the list.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <param name="location">
/// location to select, or %NULL for no current path
/// </param>

	public static T SetLocation<T>(this T sidebar, MentorLake.Gio.GFileHandle location) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_location(sidebar, location);
		return sidebar;
	}

/// <summary>
/// <para>
/// Sets the way in which the calling application can open new locations from
/// the places sidebar.  For example, some applications only open locations
/// “directly” into their main view, while others may support opening locations
/// in a new notebook tab or a new window.
/// </para>
/// <para>
/// This function is used to tell the places @sidebar about the ways in which the
/// application can open new locations, so that the sidebar can display (or not)
/// the “Open in new tab” and “Open in new window” menu items as appropriate.
/// </para>
/// <para>
/// When the #GtkPlacesSidebar::open-location signal is emitted, its flags
/// argument will be set to one of the @flags that was passed in
/// gtk_places_sidebar_set_open_flags().
/// </para>
/// <para>
/// Passing 0 for @flags will cause #GTK_PLACES_OPEN_NORMAL to always be sent
/// to callbacks for the “open-location” signal.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <param name="flags">
/// Bitmask of modes in which the calling application can open locations
/// </param>

	public static T SetOpenFlags<T>(this T sidebar, MentorLake.Gtk.GtkPlacesOpenFlags flags) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_open_flags(sidebar, flags);
		return sidebar;
	}

/// <summary>
/// <para>
/// Sets whether the @sidebar should show an item for connecting to a network server;
/// this is off by default. An application may want to turn this on if it implements
/// a way for the user to connect to network servers directly.
/// </para>
/// <para>
/// If you enable this, you should connect to the
/// #GtkPlacesSidebar::show-connect-to-server signal.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <param name="show_connect_to_server">
/// whether to show an item for the Connect to Server command
/// </param>

	public static T SetShowConnectToServer<T>(this T sidebar, bool show_connect_to_server) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_show_connect_to_server(sidebar, show_connect_to_server);
		return sidebar;
	}

/// <summary>
/// <para>
/// Sets whether the @sidebar should show an item for the Desktop folder.
/// The default value for this option is determined by the desktop
/// environment and the user’s configuration, but this function can be
/// used to override it on a per-application basis.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <param name="show_desktop">
/// whether to show an item for the Desktop folder
/// </param>

	public static T SetShowDesktop<T>(this T sidebar, bool show_desktop) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_show_desktop(sidebar, show_desktop);
		return sidebar;
	}

/// <summary>
/// <para>
/// Sets whether the @sidebar should show an item for entering a location;
/// this is off by default. An application may want to turn this on if manually
/// entering URLs is an expected user action.
/// </para>
/// <para>
/// If you enable this, you should connect to the
/// #GtkPlacesSidebar::show-enter-location signal.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <param name="show_enter_location">
/// whether to show an item to enter a location
/// </param>

	public static T SetShowEnterLocation<T>(this T sidebar, bool show_enter_location) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_show_enter_location(sidebar, show_enter_location);
		return sidebar;
	}

/// <summary>
/// <para>
/// Sets whether the @sidebar should show an item for the application to show
/// an Other Locations view; this is off by default. When set to %TRUE, persistent
/// devices such as hard drives are hidden, otherwise they are shown in the sidebar.
/// An application may want to turn this on if it implements a way for the user to
/// see and interact with drives and network servers directly.
/// </para>
/// <para>
/// If you enable this, you should connect to the
/// #GtkPlacesSidebar::show-other-locations signal.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <param name="show_other_locations">
/// whether to show an item for the Other Locations view
/// </param>

	public static T SetShowOtherLocations<T>(this T sidebar, bool show_other_locations) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_show_other_locations(sidebar, show_other_locations);
		return sidebar;
	}

/// <summary>
/// <para>
/// Sets whether the @sidebar should show an item for recent files.
/// The default value for this option is determined by the desktop
/// environment, but this function can be used to override it on a
/// per-application basis.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <param name="show_recent">
/// whether to show an item for recent files
/// </param>

	public static T SetShowRecent<T>(this T sidebar, bool show_recent) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_show_recent(sidebar, show_recent);
		return sidebar;
	}

/// <summary>
/// <para>
/// If you enable this, you should connect to the
/// #GtkPlacesSidebar::show-starred-location signal.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <param name="show_starred_location">
/// whether to show an item for Starred files
/// </param>

	public static T SetShowStarredLocation<T>(this T sidebar, bool show_starred_location) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_show_starred_location(sidebar, show_starred_location);
		return sidebar;
	}

/// <summary>
/// <para>
/// Sets whether the @sidebar should show an item for the Trash location.
/// </para>
/// </summary>

/// <param name="sidebar">
/// a places sidebar
/// </param>
/// <param name="show_trash">
/// whether to show an item for the Trash location
/// </param>

	public static T SetShowTrash<T>(this T sidebar, bool show_trash) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid) throw new Exception("Invalid handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_show_trash(sidebar, show_trash);
		return sidebar;
	}

}

internal class GtkPlacesSidebarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))]
	internal static extern MentorLake.Gtk.GtkPlacesSidebarHandle gtk_places_sidebar_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_places_sidebar_add_shortcut([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle location);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_places_sidebar_get_local_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle gtk_places_sidebar_get_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))]
	internal static extern MentorLake.Gio.GFileHandle gtk_places_sidebar_get_nth_bookmark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, int n);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPlacesOpenFlags gtk_places_sidebar_get_open_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_places_sidebar_get_show_connect_to_server([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_places_sidebar_get_show_desktop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_places_sidebar_get_show_enter_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_places_sidebar_get_show_other_locations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_places_sidebar_get_show_recent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_places_sidebar_get_show_starred_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_places_sidebar_get_show_trash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_places_sidebar_list_shortcuts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_places_sidebar_remove_shortcut([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle location);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_places_sidebar_set_drop_targets_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, bool visible, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_places_sidebar_set_local_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, bool local_only);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_places_sidebar_set_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle location);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_places_sidebar_set_open_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, MentorLake.Gtk.GtkPlacesOpenFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_places_sidebar_set_show_connect_to_server([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, bool show_connect_to_server);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_places_sidebar_set_show_desktop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, bool show_desktop);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_places_sidebar_set_show_enter_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, bool show_enter_location);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_places_sidebar_set_show_other_locations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, bool show_other_locations);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_places_sidebar_set_show_recent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, bool show_recent);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_places_sidebar_set_show_starred_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, bool show_starred_location);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_places_sidebar_set_show_trash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, bool show_trash);

}
