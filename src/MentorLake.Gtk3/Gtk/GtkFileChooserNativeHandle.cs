namespace MentorLake.Gtk;

public class GtkFileChooserNativeHandle : GtkNativeDialogHandle, GtkFileChooserHandle
{
	public static MentorLake.Gtk.GtkFileChooserNativeHandle New(string title, MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkFileChooserAction action, string accept_label, string cancel_label)
	{
		return GtkFileChooserNativeHandleExterns.gtk_file_chooser_native_new(title, parent, action, accept_label, cancel_label);
	}

}
public static class GtkFileChooserNativeHandleSignalExtensions
{

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


public static class GtkFileChooserNativeHandleExtensions
{
	public static string GetAcceptLabel(this MentorLake.Gtk.GtkFileChooserNativeHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserNativeHandle)");
		return GtkFileChooserNativeHandleExterns.gtk_file_chooser_native_get_accept_label(self);
	}

	public static string GetCancelLabel(this MentorLake.Gtk.GtkFileChooserNativeHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserNativeHandle)");
		return GtkFileChooserNativeHandleExterns.gtk_file_chooser_native_get_cancel_label(self);
	}

	public static T SetAcceptLabel<T>(this T self, string accept_label) where T : GtkFileChooserNativeHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserNativeHandle)");
		GtkFileChooserNativeHandleExterns.gtk_file_chooser_native_set_accept_label(self, accept_label);
		return self;
	}

	public static T SetCancelLabel<T>(this T self, string cancel_label) where T : GtkFileChooserNativeHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkFileChooserNativeHandle)");
		GtkFileChooserNativeHandleExterns.gtk_file_chooser_native_set_cancel_label(self, cancel_label);
		return self;
	}

}

internal class GtkFileChooserNativeHandleExterns
{
	[DllImport(GtkLibrary.Name)]
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
