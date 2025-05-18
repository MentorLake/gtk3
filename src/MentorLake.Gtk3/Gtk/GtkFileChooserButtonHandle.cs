namespace MentorLake.Gtk;

public class GtkFileChooserButtonHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFileChooserHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkFileChooserButtonHandle New(string title, MentorLake.Gtk.GtkFileChooserAction action)
	{
		return GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_new(title, action);
	}

	public static MentorLake.Gtk.GtkFileChooserButtonHandle NewWithDialog(MentorLake.Gtk.GtkWidgetHandle dialog)
	{
		return GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_new_with_dialog(dialog);
	}

}
public static class GtkFileChooserButtonHandleSignalExtensions
{

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

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void file_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFileChooserButtonHandle>))] MentorLake.Gtk.GtkFileChooserButtonHandle self, IntPtr user_data);


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


public static class GtkFileChooserButtonHandleExtensions
{
	public static bool GetFocusOnClick(this MentorLake.Gtk.GtkFileChooserButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserButtonHandle)");
		return GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_get_focus_on_click(button);
	}

	public static string GetTitle(this MentorLake.Gtk.GtkFileChooserButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserButtonHandle)");
		return GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_get_title(button);
	}

	public static int GetWidthChars(this MentorLake.Gtk.GtkFileChooserButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserButtonHandle)");
		return GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_get_width_chars(button);
	}

	public static T SetFocusOnClick<T>(this T button, bool focus_on_click) where T : GtkFileChooserButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserButtonHandle)");
		GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_set_focus_on_click(button, focus_on_click);
		return button;
	}

	public static T SetTitle<T>(this T button, string title) where T : GtkFileChooserButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkFileChooserButtonHandle)");
		GtkFileChooserButtonHandleExterns.gtk_file_chooser_button_set_title(button, title);
		return button;
	}

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
