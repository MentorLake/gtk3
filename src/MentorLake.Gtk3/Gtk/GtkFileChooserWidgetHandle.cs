namespace MentorLake.Gtk;

public class GtkFileChooserWidgetHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFileChooserHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkFileChooserWidgetHandle New(MentorLake.Gtk.GtkFileChooserAction action)
	{
		return GtkFileChooserWidgetHandleExterns.gtk_file_chooser_widget_new(action);
	}

}
public static class GtkFileChooserWidgetHandleSignalExtensions
{

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

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void desktop_folder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void down_folder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void home_folder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void location_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, string path, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void location_popup_on_paste([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void location_toggle_popup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void places_shortcut([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void quick_bookmark([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, int bookmark_index, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void recent_shortcut([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void search_shortcut([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_hidden([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void up_folder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserWidgetHandle>))] MentorLake.Gtk.GtkFileChooserWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gtk.GtkFileChooserConfirmation confirm_overwrite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void current_folder_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void file_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserHandleImpl>))] MentorLake.Gtk.GtkFileChooserHandle self, IntPtr user_data);


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
