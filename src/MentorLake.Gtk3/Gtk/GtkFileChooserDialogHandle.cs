namespace MentorLake.Gtk;

public class GtkFileChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkFileChooserHandle
{
	public static MentorLake.Gtk.GtkFileChooserDialogHandle New(string title, MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkFileChooserAction action, string first_button_text, IntPtr @__arglist)
	{
		return GtkFileChooserDialogHandleExterns.gtk_file_chooser_dialog_new(title, parent, action, first_button_text, @__arglist);
	}

}
public static class GtkFileChooserDialogHandleSignalExtensions
{

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


public static class GtkFileChooserDialogHandleExtensions
{
}

internal class GtkFileChooserDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFileChooserDialogHandle gtk_file_chooser_dialog_new(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkFileChooserAction action, string first_button_text, IntPtr @__arglist);

}
