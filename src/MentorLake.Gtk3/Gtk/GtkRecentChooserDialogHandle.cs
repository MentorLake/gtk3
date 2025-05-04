namespace MentorLake.Gtk;

public class GtkRecentChooserDialogHandle : GtkDialogHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkRecentChooserHandle
{
	public static MentorLake.Gtk.GtkRecentChooserDialogHandle New(string title, MentorLake.Gtk.GtkWindowHandle parent, string first_button_text, IntPtr @__arglist)
	{
		return GtkRecentChooserDialogHandleExterns.gtk_recent_chooser_dialog_new(title, parent, first_button_text, @__arglist);
	}

	public static MentorLake.Gtk.GtkRecentChooserDialogHandle NewForManager(string title, MentorLake.Gtk.GtkWindowHandle parent, MentorLake.Gtk.GtkRecentManagerHandle manager, string first_button_text, IntPtr @__arglist)
	{
		return GtkRecentChooserDialogHandleExterns.gtk_recent_chooser_dialog_new_for_manager(title, parent, manager, first_button_text, @__arglist);
	}

}
public static class GtkRecentChooserDialogHandleSignalExtensions
{

	public static IObservable<GtkRecentChooserDialogHandleSignalStructs.ItemActivatedSignal> Signal_ItemActivated(this GtkRecentChooserDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentChooserDialogHandleSignalStructs.ItemActivatedSignal> obs) =>
		{
			GtkRecentChooserDialogHandleSignalDelegates.item_activated handler = ( MentorLake.Gtk.GtkRecentChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentChooserDialogHandleSignalStructs.ItemActivatedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "item-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkRecentChooserDialogHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkRecentChooserDialogHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentChooserDialogHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkRecentChooserDialogHandleSignalDelegates.selection_changed handler = ( MentorLake.Gtk.GtkRecentChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentChooserDialogHandleSignalStructs.SelectionChangedSignal()
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
}

public static class GtkRecentChooserDialogHandleSignalStructs
{

public class ItemActivatedSignal
{
	public MentorLake.Gtk.GtkRecentChooserHandle Self;
	public IntPtr UserData;
}

public class SelectionChangedSignal
{
	public MentorLake.Gtk.GtkRecentChooserHandle Self;
	public IntPtr UserData;
}
}

public static class GtkRecentChooserDialogHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void item_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle self, IntPtr user_data);

}


public static class GtkRecentChooserDialogHandleExtensions
{
}

internal class GtkRecentChooserDialogHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentChooserDialogHandle gtk_recent_chooser_dialog_new(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, string first_button_text, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentChooserDialogHandle gtk_recent_chooser_dialog_new_for_manager(string title, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle parent, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager, string first_button_text, IntPtr @__arglist);

}
