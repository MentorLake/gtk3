namespace MentorLake.Gtk;

public class GtkNativeDialogHandle : GObjectHandle
{
}
public static class GtkNativeDialogHandleSignalExtensions
{

	public static IObservable<GtkNativeDialogHandleSignalStructs.ResponseSignal> Signal_Response(this GtkNativeDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNativeDialogHandleSignalStructs.ResponseSignal> obs) =>
		{
			GtkNativeDialogHandleSignalDelegates.response handler = ( MentorLake.Gtk.GtkNativeDialogHandle self,  MentorLake.Gtk.GtkResponseType response_id,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNativeDialogHandleSignalStructs.ResponseSignal()
				{
					Self = self, ResponseId = response_id, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "response", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkNativeDialogHandleSignalStructs
{

public class ResponseSignal
{
	public MentorLake.Gtk.GtkNativeDialogHandle Self;
	public MentorLake.Gtk.GtkResponseType ResponseId;
	public IntPtr UserData;
}
}

public static class GtkNativeDialogHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self, MentorLake.Gtk.GtkResponseType response_id, IntPtr user_data);

}


public static class GtkNativeDialogHandleExtensions
{
	public static T Destroy<T>(this T self) where T : GtkNativeDialogHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkNativeDialogHandle)");
		GtkNativeDialogHandleExterns.gtk_native_dialog_destroy(self);
		return self;
	}

	public static bool GetModal(this MentorLake.Gtk.GtkNativeDialogHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkNativeDialogHandle)");
		return GtkNativeDialogHandleExterns.gtk_native_dialog_get_modal(self);
	}

	public static string GetTitle(this MentorLake.Gtk.GtkNativeDialogHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkNativeDialogHandle)");
		return GtkNativeDialogHandleExterns.gtk_native_dialog_get_title(self);
	}

	public static MentorLake.Gtk.GtkWindowHandle GetTransientFor(this MentorLake.Gtk.GtkNativeDialogHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkNativeDialogHandle)");
		return GtkNativeDialogHandleExterns.gtk_native_dialog_get_transient_for(self);
	}

	public static bool GetVisible(this MentorLake.Gtk.GtkNativeDialogHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkNativeDialogHandle)");
		return GtkNativeDialogHandleExterns.gtk_native_dialog_get_visible(self);
	}

	public static T Hide<T>(this T self) where T : GtkNativeDialogHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkNativeDialogHandle)");
		GtkNativeDialogHandleExterns.gtk_native_dialog_hide(self);
		return self;
	}

	public static int Run(this MentorLake.Gtk.GtkNativeDialogHandle self)
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkNativeDialogHandle)");
		return GtkNativeDialogHandleExterns.gtk_native_dialog_run(self);
	}

	public static T SetModal<T>(this T self, bool modal) where T : GtkNativeDialogHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkNativeDialogHandle)");
		GtkNativeDialogHandleExterns.gtk_native_dialog_set_modal(self, modal);
		return self;
	}

	public static T SetTitle<T>(this T self, string title) where T : GtkNativeDialogHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkNativeDialogHandle)");
		GtkNativeDialogHandleExterns.gtk_native_dialog_set_title(self, title);
		return self;
	}

	public static T SetTransientFor<T>(this T self, MentorLake.Gtk.GtkWindowHandle parent) where T : GtkNativeDialogHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkNativeDialogHandle)");
		GtkNativeDialogHandleExterns.gtk_native_dialog_set_transient_for(self, parent);
		return self;
	}

	public static T Show<T>(this T self) where T : GtkNativeDialogHandle
	{
		if (self.IsInvalid || self.IsClosed) throw new Exception("Invalid or closed handle (GtkNativeDialogHandle)");
		GtkNativeDialogHandleExterns.gtk_native_dialog_show(self);
		return self;
	}

}

internal class GtkNativeDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_native_dialog_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_native_dialog_get_modal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_native_dialog_get_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWindowHandle gtk_native_dialog_get_transient_for([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_native_dialog_get_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_native_dialog_hide([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_native_dialog_run([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_native_dialog_set_modal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self, bool modal);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_native_dialog_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self, string title);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_native_dialog_set_transient_for([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_native_dialog_show([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNativeDialogHandle>))] MentorLake.Gtk.GtkNativeDialogHandle self);

}
