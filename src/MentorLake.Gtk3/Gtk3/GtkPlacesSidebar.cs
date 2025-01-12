namespace MentorLake.Gtk3.Gtk3;

public class GtkPlacesSidebarHandle : GtkScrolledWindowHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkPlacesSidebarHandle New()
	{
		return GtkPlacesSidebarExterns.gtk_places_sidebar_new();
	}

}

public static class GtkPlacesSidebarSignalExtensions
{

	public static IObservable<GtkPlacesSidebarSignalStructs.DragActionAskSignal> Signal_DragActionAsk(this GtkPlacesSidebarHandle instance)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarSignalStructs.DragActionAskSignal> obs) =>
		{
			GtkPlacesSidebarSignalDelegates.drag_action_ask handler = (GtkPlacesSidebarHandle self, int actions, IntPtr user_data) =>
			{


				var signalStruct = new GtkPlacesSidebarSignalStructs.DragActionAskSignal()
				{
					Self = self, Actions = actions, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_action_ask", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPlacesSidebarSignalStructs.DragActionRequestedSignal> Signal_DragActionRequested(this GtkPlacesSidebarHandle instance)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarSignalStructs.DragActionRequestedSignal> obs) =>
		{
			GtkPlacesSidebarSignalDelegates.drag_action_requested handler = (GtkPlacesSidebarHandle self, GdkDragContextHandle context, GFileHandle dest_file, IntPtr source_file_list, IntPtr user_data) =>
			{


				var signalStruct = new GtkPlacesSidebarSignalStructs.DragActionRequestedSignal()
				{
					Self = self, Context = context, DestFile = dest_file, SourceFileList = source_file_list, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_action_requested", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPlacesSidebarSignalStructs.DragPerformDropSignal> Signal_DragPerformDrop(this GtkPlacesSidebarHandle instance)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarSignalStructs.DragPerformDropSignal> obs) =>
		{
			GtkPlacesSidebarSignalDelegates.drag_perform_drop handler = (GtkPlacesSidebarHandle self, GFileHandle dest_file, IntPtr source_file_list, int action, IntPtr user_data) =>
			{


				var signalStruct = new GtkPlacesSidebarSignalStructs.DragPerformDropSignal()
				{
					Self = self, DestFile = dest_file, SourceFileList = source_file_list, Action = action, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_perform_drop", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPlacesSidebarSignalStructs.MountSignal> Signal_Mount(this GtkPlacesSidebarHandle instance)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarSignalStructs.MountSignal> obs) =>
		{
			GtkPlacesSidebarSignalDelegates.mount handler = (GtkPlacesSidebarHandle self, GMountOperationHandle mount_operation, IntPtr user_data) =>
			{


				var signalStruct = new GtkPlacesSidebarSignalStructs.MountSignal()
				{
					Self = self, MountOperation = mount_operation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "mount", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPlacesSidebarSignalStructs.OpenLocationSignal> Signal_OpenLocation(this GtkPlacesSidebarHandle instance)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarSignalStructs.OpenLocationSignal> obs) =>
		{
			GtkPlacesSidebarSignalDelegates.open_location handler = (GtkPlacesSidebarHandle self, GFileHandle location, GtkPlacesOpenFlags open_flags, IntPtr user_data) =>
			{


				var signalStruct = new GtkPlacesSidebarSignalStructs.OpenLocationSignal()
				{
					Self = self, Location = location, OpenFlags = open_flags, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "open_location", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPlacesSidebarSignalStructs.PopulatePopupSignal> Signal_PopulatePopup(this GtkPlacesSidebarHandle instance)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarSignalStructs.PopulatePopupSignal> obs) =>
		{
			GtkPlacesSidebarSignalDelegates.populate_popup handler = (GtkPlacesSidebarHandle self, GtkWidgetHandle container, GFileHandle selected_item, GVolumeHandle selected_volume, IntPtr user_data) =>
			{


				var signalStruct = new GtkPlacesSidebarSignalStructs.PopulatePopupSignal()
				{
					Self = self, Container = container, SelectedItem = selected_item, SelectedVolume = selected_volume, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "populate_popup", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPlacesSidebarSignalStructs.ShowConnectToServerSignal> Signal_ShowConnectToServer(this GtkPlacesSidebarHandle instance)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarSignalStructs.ShowConnectToServerSignal> obs) =>
		{
			GtkPlacesSidebarSignalDelegates.show_connect_to_server handler = (GtkPlacesSidebarHandle self, IntPtr user_data) =>
			{


				var signalStruct = new GtkPlacesSidebarSignalStructs.ShowConnectToServerSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "show_connect_to_server", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPlacesSidebarSignalStructs.ShowEnterLocationSignal> Signal_ShowEnterLocation(this GtkPlacesSidebarHandle instance)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarSignalStructs.ShowEnterLocationSignal> obs) =>
		{
			GtkPlacesSidebarSignalDelegates.show_enter_location handler = (GtkPlacesSidebarHandle self, IntPtr user_data) =>
			{


				var signalStruct = new GtkPlacesSidebarSignalStructs.ShowEnterLocationSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "show_enter_location", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPlacesSidebarSignalStructs.ShowErrorMessageSignal> Signal_ShowErrorMessage(this GtkPlacesSidebarHandle instance)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarSignalStructs.ShowErrorMessageSignal> obs) =>
		{
			GtkPlacesSidebarSignalDelegates.show_error_message handler = (GtkPlacesSidebarHandle self, string primary, string secondary, IntPtr user_data) =>
			{


				var signalStruct = new GtkPlacesSidebarSignalStructs.ShowErrorMessageSignal()
				{
					Self = self, Primary = primary, Secondary = secondary, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "show_error_message", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPlacesSidebarSignalStructs.ShowOtherLocationsSignal> Signal_ShowOtherLocations(this GtkPlacesSidebarHandle instance)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarSignalStructs.ShowOtherLocationsSignal> obs) =>
		{
			GtkPlacesSidebarSignalDelegates.show_other_locations handler = (GtkPlacesSidebarHandle self, IntPtr user_data) =>
			{


				var signalStruct = new GtkPlacesSidebarSignalStructs.ShowOtherLocationsSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "show_other_locations", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPlacesSidebarSignalStructs.ShowOtherLocationsWithFlagsSignal> Signal_ShowOtherLocationsWithFlags(this GtkPlacesSidebarHandle instance)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarSignalStructs.ShowOtherLocationsWithFlagsSignal> obs) =>
		{
			GtkPlacesSidebarSignalDelegates.show_other_locations_with_flags handler = (GtkPlacesSidebarHandle self, GtkPlacesOpenFlags open_flags, IntPtr user_data) =>
			{


				var signalStruct = new GtkPlacesSidebarSignalStructs.ShowOtherLocationsWithFlagsSignal()
				{
					Self = self, OpenFlags = open_flags, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "show_other_locations_with_flags", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPlacesSidebarSignalStructs.ShowStarredLocationSignal> Signal_ShowStarredLocation(this GtkPlacesSidebarHandle instance)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarSignalStructs.ShowStarredLocationSignal> obs) =>
		{
			GtkPlacesSidebarSignalDelegates.show_starred_location handler = (GtkPlacesSidebarHandle self, GtkPlacesOpenFlags open_flags, IntPtr user_data) =>
			{


				var signalStruct = new GtkPlacesSidebarSignalStructs.ShowStarredLocationSignal()
				{
					Self = self, OpenFlags = open_flags, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "show_starred_location", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkPlacesSidebarSignalStructs.UnmountSignal> Signal_Unmount(this GtkPlacesSidebarHandle instance)
	{
		return Observable.Create((IObserver<GtkPlacesSidebarSignalStructs.UnmountSignal> obs) =>
		{
			GtkPlacesSidebarSignalDelegates.unmount handler = (GtkPlacesSidebarHandle self, GMountOperationHandle mount_operation, IntPtr user_data) =>
			{


				var signalStruct = new GtkPlacesSidebarSignalStructs.UnmountSignal()
				{
					Self = self, MountOperation = mount_operation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "unmount", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkPlacesSidebarSignalStructs
{

public struct DragActionAskSignal
{
	public GtkPlacesSidebarHandle Self;
	public int Actions;
	public IntPtr UserData;
	public int ReturnValue;
}

public struct DragActionRequestedSignal
{
	public GtkPlacesSidebarHandle Self;
	public GdkDragContextHandle Context;
	public GFileHandle DestFile;
	public IntPtr SourceFileList;
	public IntPtr UserData;
	public int ReturnValue;
}

public struct DragPerformDropSignal
{
	public GtkPlacesSidebarHandle Self;
	public GFileHandle DestFile;
	public IntPtr SourceFileList;
	public int Action;
	public IntPtr UserData;
}

public struct MountSignal
{
	public GtkPlacesSidebarHandle Self;
	public GMountOperationHandle MountOperation;
	public IntPtr UserData;
}

public struct OpenLocationSignal
{
	public GtkPlacesSidebarHandle Self;
	public GFileHandle Location;
	public GtkPlacesOpenFlags OpenFlags;
	public IntPtr UserData;
}

public struct PopulatePopupSignal
{
	public GtkPlacesSidebarHandle Self;
	public GtkWidgetHandle Container;
	public GFileHandle SelectedItem;
	public GVolumeHandle SelectedVolume;
	public IntPtr UserData;
}

public struct ShowConnectToServerSignal
{
	public GtkPlacesSidebarHandle Self;
	public IntPtr UserData;
}

public struct ShowEnterLocationSignal
{
	public GtkPlacesSidebarHandle Self;
	public IntPtr UserData;
}

public struct ShowErrorMessageSignal
{
	public GtkPlacesSidebarHandle Self;
	public string Primary;
	public string Secondary;
	public IntPtr UserData;
}

public struct ShowOtherLocationsSignal
{
	public GtkPlacesSidebarHandle Self;
	public IntPtr UserData;
}

public struct ShowOtherLocationsWithFlagsSignal
{
	public GtkPlacesSidebarHandle Self;
	public GtkPlacesOpenFlags OpenFlags;
	public IntPtr UserData;
}

public struct ShowStarredLocationSignal
{
	public GtkPlacesSidebarHandle Self;
	public GtkPlacesOpenFlags OpenFlags;
	public IntPtr UserData;
}

public struct UnmountSignal
{
	public GtkPlacesSidebarHandle Self;
	public GMountOperationHandle MountOperation;
	public IntPtr UserData;
}
}

public static class GtkPlacesSidebarSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int drag_action_ask([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPlacesSidebarHandle>))] GtkPlacesSidebarHandle self, int actions, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int drag_action_requested([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPlacesSidebarHandle>))] GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragContextHandle>))] GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GFileHandleImpl>))] GFileHandle dest_file, IntPtr source_file_list, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_perform_drop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPlacesSidebarHandle>))] GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GFileHandleImpl>))] GFileHandle dest_file, IntPtr source_file_list, int action, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPlacesSidebarHandle>))] GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GMountOperationHandle>))] GMountOperationHandle mount_operation, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void open_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPlacesSidebarHandle>))] GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GFileHandleImpl>))] GFileHandle location, GtkPlacesOpenFlags open_flags, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void populate_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPlacesSidebarHandle>))] GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GFileHandleImpl>))] GFileHandle selected_item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GVolumeHandleImpl>))] GVolumeHandle selected_volume, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_connect_to_server([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPlacesSidebarHandle>))] GtkPlacesSidebarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_enter_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPlacesSidebarHandle>))] GtkPlacesSidebarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_error_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPlacesSidebarHandle>))] GtkPlacesSidebarHandle self, string primary, string secondary, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_other_locations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPlacesSidebarHandle>))] GtkPlacesSidebarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_other_locations_with_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPlacesSidebarHandle>))] GtkPlacesSidebarHandle self, GtkPlacesOpenFlags open_flags, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_starred_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPlacesSidebarHandle>))] GtkPlacesSidebarHandle self, GtkPlacesOpenFlags open_flags, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unmount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkPlacesSidebarHandle>))] GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GMountOperationHandle>))] GMountOperationHandle mount_operation, IntPtr user_data);

}


public static class GtkPlacesSidebarHandleExtensions
{
	public static GtkPlacesSidebarHandle AddShortcut(this GtkPlacesSidebarHandle sidebar, GFileHandle location)
	{
		GtkPlacesSidebarExterns.gtk_places_sidebar_add_shortcut(sidebar, location);
		return sidebar;
	}

	public static bool GetLocalOnly(this GtkPlacesSidebarHandle sidebar)
	{
		return GtkPlacesSidebarExterns.gtk_places_sidebar_get_local_only(sidebar);
	}

	public static GFileHandle GetLocation(this GtkPlacesSidebarHandle sidebar)
	{
		return GtkPlacesSidebarExterns.gtk_places_sidebar_get_location(sidebar);
	}

	public static GFileHandle GetNthBookmark(this GtkPlacesSidebarHandle sidebar, int n)
	{
		return GtkPlacesSidebarExterns.gtk_places_sidebar_get_nth_bookmark(sidebar, n);
	}

	public static GtkPlacesOpenFlags GetOpenFlags(this GtkPlacesSidebarHandle sidebar)
	{
		return GtkPlacesSidebarExterns.gtk_places_sidebar_get_open_flags(sidebar);
	}

	public static bool GetShowConnectToServer(this GtkPlacesSidebarHandle sidebar)
	{
		return GtkPlacesSidebarExterns.gtk_places_sidebar_get_show_connect_to_server(sidebar);
	}

	public static bool GetShowDesktop(this GtkPlacesSidebarHandle sidebar)
	{
		return GtkPlacesSidebarExterns.gtk_places_sidebar_get_show_desktop(sidebar);
	}

	public static bool GetShowEnterLocation(this GtkPlacesSidebarHandle sidebar)
	{
		return GtkPlacesSidebarExterns.gtk_places_sidebar_get_show_enter_location(sidebar);
	}

	public static bool GetShowOtherLocations(this GtkPlacesSidebarHandle sidebar)
	{
		return GtkPlacesSidebarExterns.gtk_places_sidebar_get_show_other_locations(sidebar);
	}

	public static bool GetShowRecent(this GtkPlacesSidebarHandle sidebar)
	{
		return GtkPlacesSidebarExterns.gtk_places_sidebar_get_show_recent(sidebar);
	}

	public static bool GetShowStarredLocation(this GtkPlacesSidebarHandle sidebar)
	{
		return GtkPlacesSidebarExterns.gtk_places_sidebar_get_show_starred_location(sidebar);
	}

	public static bool GetShowTrash(this GtkPlacesSidebarHandle sidebar)
	{
		return GtkPlacesSidebarExterns.gtk_places_sidebar_get_show_trash(sidebar);
	}

	public static GSListHandle ListShortcuts(this GtkPlacesSidebarHandle sidebar)
	{
		return GtkPlacesSidebarExterns.gtk_places_sidebar_list_shortcuts(sidebar);
	}

	public static GtkPlacesSidebarHandle RemoveShortcut(this GtkPlacesSidebarHandle sidebar, GFileHandle location)
	{
		GtkPlacesSidebarExterns.gtk_places_sidebar_remove_shortcut(sidebar, location);
		return sidebar;
	}

	public static GtkPlacesSidebarHandle SetDropTargetsVisible(this GtkPlacesSidebarHandle sidebar, bool visible, GdkDragContextHandle context)
	{
		GtkPlacesSidebarExterns.gtk_places_sidebar_set_drop_targets_visible(sidebar, visible, context);
		return sidebar;
	}

	public static GtkPlacesSidebarHandle SetLocalOnly(this GtkPlacesSidebarHandle sidebar, bool local_only)
	{
		GtkPlacesSidebarExterns.gtk_places_sidebar_set_local_only(sidebar, local_only);
		return sidebar;
	}

	public static GtkPlacesSidebarHandle SetLocation(this GtkPlacesSidebarHandle sidebar, GFileHandle location)
	{
		GtkPlacesSidebarExterns.gtk_places_sidebar_set_location(sidebar, location);
		return sidebar;
	}

	public static GtkPlacesSidebarHandle SetOpenFlags(this GtkPlacesSidebarHandle sidebar, GtkPlacesOpenFlags flags)
	{
		GtkPlacesSidebarExterns.gtk_places_sidebar_set_open_flags(sidebar, flags);
		return sidebar;
	}

	public static GtkPlacesSidebarHandle SetShowConnectToServer(this GtkPlacesSidebarHandle sidebar, bool show_connect_to_server)
	{
		GtkPlacesSidebarExterns.gtk_places_sidebar_set_show_connect_to_server(sidebar, show_connect_to_server);
		return sidebar;
	}

	public static GtkPlacesSidebarHandle SetShowDesktop(this GtkPlacesSidebarHandle sidebar, bool show_desktop)
	{
		GtkPlacesSidebarExterns.gtk_places_sidebar_set_show_desktop(sidebar, show_desktop);
		return sidebar;
	}

	public static GtkPlacesSidebarHandle SetShowEnterLocation(this GtkPlacesSidebarHandle sidebar, bool show_enter_location)
	{
		GtkPlacesSidebarExterns.gtk_places_sidebar_set_show_enter_location(sidebar, show_enter_location);
		return sidebar;
	}

	public static GtkPlacesSidebarHandle SetShowOtherLocations(this GtkPlacesSidebarHandle sidebar, bool show_other_locations)
	{
		GtkPlacesSidebarExterns.gtk_places_sidebar_set_show_other_locations(sidebar, show_other_locations);
		return sidebar;
	}

	public static GtkPlacesSidebarHandle SetShowRecent(this GtkPlacesSidebarHandle sidebar, bool show_recent)
	{
		GtkPlacesSidebarExterns.gtk_places_sidebar_set_show_recent(sidebar, show_recent);
		return sidebar;
	}

	public static GtkPlacesSidebarHandle SetShowStarredLocation(this GtkPlacesSidebarHandle sidebar, bool show_starred_location)
	{
		GtkPlacesSidebarExterns.gtk_places_sidebar_set_show_starred_location(sidebar, show_starred_location);
		return sidebar;
	}

	public static GtkPlacesSidebarHandle SetShowTrash(this GtkPlacesSidebarHandle sidebar, bool show_trash)
	{
		GtkPlacesSidebarExterns.gtk_places_sidebar_set_show_trash(sidebar, show_trash);
		return sidebar;
	}

}

internal class GtkPlacesSidebarExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPlacesSidebarHandle gtk_places_sidebar_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_places_sidebar_add_shortcut(GtkPlacesSidebarHandle sidebar, GFileHandle location);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_places_sidebar_get_local_only(GtkPlacesSidebarHandle sidebar);

	[DllImport(Libraries.Gtk3)]
	internal static extern GFileHandle gtk_places_sidebar_get_location(GtkPlacesSidebarHandle sidebar);

	[DllImport(Libraries.Gtk3)]
	internal static extern GFileHandle gtk_places_sidebar_get_nth_bookmark(GtkPlacesSidebarHandle sidebar, int n);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPlacesOpenFlags gtk_places_sidebar_get_open_flags(GtkPlacesSidebarHandle sidebar);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_places_sidebar_get_show_connect_to_server(GtkPlacesSidebarHandle sidebar);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_places_sidebar_get_show_desktop(GtkPlacesSidebarHandle sidebar);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_places_sidebar_get_show_enter_location(GtkPlacesSidebarHandle sidebar);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_places_sidebar_get_show_other_locations(GtkPlacesSidebarHandle sidebar);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_places_sidebar_get_show_recent(GtkPlacesSidebarHandle sidebar);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_places_sidebar_get_show_starred_location(GtkPlacesSidebarHandle sidebar);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_places_sidebar_get_show_trash(GtkPlacesSidebarHandle sidebar);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_places_sidebar_list_shortcuts(GtkPlacesSidebarHandle sidebar);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_places_sidebar_remove_shortcut(GtkPlacesSidebarHandle sidebar, GFileHandle location);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_places_sidebar_set_drop_targets_visible(GtkPlacesSidebarHandle sidebar, bool visible, GdkDragContextHandle context);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_places_sidebar_set_local_only(GtkPlacesSidebarHandle sidebar, bool local_only);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_places_sidebar_set_location(GtkPlacesSidebarHandle sidebar, GFileHandle location);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_places_sidebar_set_open_flags(GtkPlacesSidebarHandle sidebar, GtkPlacesOpenFlags flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_places_sidebar_set_show_connect_to_server(GtkPlacesSidebarHandle sidebar, bool show_connect_to_server);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_places_sidebar_set_show_desktop(GtkPlacesSidebarHandle sidebar, bool show_desktop);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_places_sidebar_set_show_enter_location(GtkPlacesSidebarHandle sidebar, bool show_enter_location);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_places_sidebar_set_show_other_locations(GtkPlacesSidebarHandle sidebar, bool show_other_locations);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_places_sidebar_set_show_recent(GtkPlacesSidebarHandle sidebar, bool show_recent);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_places_sidebar_set_show_starred_location(GtkPlacesSidebarHandle sidebar, bool show_starred_location);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_places_sidebar_set_show_trash(GtkPlacesSidebarHandle sidebar, bool show_trash);

}
