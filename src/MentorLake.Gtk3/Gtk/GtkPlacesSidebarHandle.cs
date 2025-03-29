namespace MentorLake.Gtk;

public class GtkPlacesSidebarHandle : GtkScrolledWindowHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkPlacesSidebarHandle New()
	{
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_new();
	}

}
public static class GtkPlacesSidebarHandleSignalExtensions
{

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

public struct DragActionAskSignal
{
	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
	public int Actions;
	public IntPtr UserData;
	public int ReturnValue;
}

public struct DragActionRequestedSignal
{
	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
	public MentorLake.Gdk.GdkDragContextHandle Context;
	public MentorLake.Gio.GFileHandle DestFile;
	public MentorLake.GLib.GListHandle SourceFileList;
	public IntPtr UserData;
	public int ReturnValue;
}

public struct DragPerformDropSignal
{
	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
	public MentorLake.Gio.GFileHandle DestFile;
	public MentorLake.GLib.GListHandle SourceFileList;
	public int Action;
	public IntPtr UserData;
}

public struct MountSignal
{
	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
	public MentorLake.Gio.GMountOperationHandle MountOperation;
	public IntPtr UserData;
}

public struct OpenLocationSignal
{
	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
	public MentorLake.Gio.GFileHandle Location;
	public MentorLake.Gtk.GtkPlacesOpenFlags OpenFlags;
	public IntPtr UserData;
}

public struct PopulatePopupSignal
{
	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Container;
	public MentorLake.Gio.GFileHandle SelectedItem;
	public MentorLake.Gio.GVolumeHandle SelectedVolume;
	public IntPtr UserData;
}

public struct ShowConnectToServerSignal
{
	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
	public IntPtr UserData;
}

public struct ShowEnterLocationSignal
{
	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
	public IntPtr UserData;
}

public struct ShowErrorMessageSignal
{
	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
	public string Primary;
	public string Secondary;
	public IntPtr UserData;
}

public struct ShowOtherLocationsSignal
{
	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
	public IntPtr UserData;
}

public struct ShowOtherLocationsWithFlagsSignal
{
	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
	public MentorLake.Gtk.GtkPlacesOpenFlags OpenFlags;
	public IntPtr UserData;
}

public struct ShowStarredLocationSignal
{
	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
	public MentorLake.Gtk.GtkPlacesOpenFlags OpenFlags;
	public IntPtr UserData;
}

public struct UnmountSignal
{
	public MentorLake.Gtk.GtkPlacesSidebarHandle Self;
	public MentorLake.Gio.GMountOperationHandle MountOperation;
	public IntPtr UserData;
}
}

public static class GtkPlacesSidebarHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int drag_action_ask([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, int actions, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int drag_action_requested([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle dest_file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle source_file_list, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_perform_drop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle dest_file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle source_file_list, int action, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void mount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void open_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle location, MentorLake.Gtk.GtkPlacesOpenFlags open_flags, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void populate_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle container, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle selected_item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GVolumeHandleImpl>))] MentorLake.Gio.GVolumeHandle selected_volume, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_connect_to_server([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_enter_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_error_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, string primary, string secondary, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_other_locations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_other_locations_with_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, MentorLake.Gtk.GtkPlacesOpenFlags open_flags, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_starred_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, MentorLake.Gtk.GtkPlacesOpenFlags open_flags, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unmount([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GMountOperationHandle>))] MentorLake.Gio.GMountOperationHandle mount_operation, IntPtr user_data);

}


public static class GtkPlacesSidebarHandleExtensions
{
	public static T AddShortcut<T>(this T sidebar, MentorLake.Gio.GFileHandle location) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_add_shortcut(sidebar, location);
		return sidebar;
	}

	public static bool GetLocalOnly(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_local_only(sidebar);
	}

	public static MentorLake.Gio.GFileHandle GetLocation(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_location(sidebar);
	}

	public static MentorLake.Gio.GFileHandle GetNthBookmark(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, int n)
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_nth_bookmark(sidebar, n);
	}

	public static MentorLake.Gtk.GtkPlacesOpenFlags GetOpenFlags(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_open_flags(sidebar);
	}

	public static bool GetShowConnectToServer(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_show_connect_to_server(sidebar);
	}

	public static bool GetShowDesktop(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_show_desktop(sidebar);
	}

	public static bool GetShowEnterLocation(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_show_enter_location(sidebar);
	}

	public static bool GetShowOtherLocations(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_show_other_locations(sidebar);
	}

	public static bool GetShowRecent(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_show_recent(sidebar);
	}

	public static bool GetShowStarredLocation(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_show_starred_location(sidebar);
	}

	public static bool GetShowTrash(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_get_show_trash(sidebar);
	}

	public static MentorLake.GLib.GSListHandle ListShortcuts(this MentorLake.Gtk.GtkPlacesSidebarHandle sidebar)
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		return GtkPlacesSidebarHandleExterns.gtk_places_sidebar_list_shortcuts(sidebar);
	}

	public static T RemoveShortcut<T>(this T sidebar, MentorLake.Gio.GFileHandle location) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_remove_shortcut(sidebar, location);
		return sidebar;
	}

	public static T SetDropTargetsVisible<T>(this T sidebar, bool visible, MentorLake.Gdk.GdkDragContextHandle context) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_drop_targets_visible(sidebar, visible, context);
		return sidebar;
	}

	public static T SetLocalOnly<T>(this T sidebar, bool local_only) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_local_only(sidebar, local_only);
		return sidebar;
	}

	public static T SetLocation<T>(this T sidebar, MentorLake.Gio.GFileHandle location) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_location(sidebar, location);
		return sidebar;
	}

	public static T SetOpenFlags<T>(this T sidebar, MentorLake.Gtk.GtkPlacesOpenFlags flags) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_open_flags(sidebar, flags);
		return sidebar;
	}

	public static T SetShowConnectToServer<T>(this T sidebar, bool show_connect_to_server) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_show_connect_to_server(sidebar, show_connect_to_server);
		return sidebar;
	}

	public static T SetShowDesktop<T>(this T sidebar, bool show_desktop) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_show_desktop(sidebar, show_desktop);
		return sidebar;
	}

	public static T SetShowEnterLocation<T>(this T sidebar, bool show_enter_location) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_show_enter_location(sidebar, show_enter_location);
		return sidebar;
	}

	public static T SetShowOtherLocations<T>(this T sidebar, bool show_other_locations) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_show_other_locations(sidebar, show_other_locations);
		return sidebar;
	}

	public static T SetShowRecent<T>(this T sidebar, bool show_recent) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_show_recent(sidebar, show_recent);
		return sidebar;
	}

	public static T SetShowStarredLocation<T>(this T sidebar, bool show_starred_location) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_show_starred_location(sidebar, show_starred_location);
		return sidebar;
	}

	public static T SetShowTrash<T>(this T sidebar, bool show_trash) where T : GtkPlacesSidebarHandle
	{
		if (sidebar.IsInvalid || sidebar.IsClosed) throw new Exception("Invalid or closed handle (GtkPlacesSidebarHandle)");
		GtkPlacesSidebarHandleExterns.gtk_places_sidebar_set_show_trash(sidebar, show_trash);
		return sidebar;
	}

}

internal class GtkPlacesSidebarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPlacesSidebarHandle gtk_places_sidebar_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_places_sidebar_add_shortcut([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GFileHandleImpl>))] MentorLake.Gio.GFileHandle location);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_places_sidebar_get_local_only([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GFileHandle gtk_places_sidebar_get_location([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlacesSidebarHandle>))] MentorLake.Gtk.GtkPlacesSidebarHandle sidebar);

	[DllImport(GtkLibrary.Name)]
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
