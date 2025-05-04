namespace MentorLake.Gtk;

public class GtkRecentChooserWidgetHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle, GtkRecentChooserHandle
{
	public static MentorLake.Gtk.GtkRecentChooserWidgetHandle New()
	{
		return GtkRecentChooserWidgetHandleExterns.gtk_recent_chooser_widget_new();
	}

	public static MentorLake.Gtk.GtkRecentChooserWidgetHandle NewForManager(MentorLake.Gtk.GtkRecentManagerHandle manager)
	{
		return GtkRecentChooserWidgetHandleExterns.gtk_recent_chooser_widget_new_for_manager(manager);
	}

}
public static class GtkRecentChooserWidgetHandleSignalExtensions
{

	public static IObservable<GtkRecentChooserWidgetHandleSignalStructs.ItemActivatedSignal> Signal_ItemActivated(this GtkRecentChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentChooserWidgetHandleSignalStructs.ItemActivatedSignal> obs) =>
		{
			GtkRecentChooserWidgetHandleSignalDelegates.item_activated handler = ( MentorLake.Gtk.GtkRecentChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentChooserWidgetHandleSignalStructs.ItemActivatedSignal()
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

	public static IObservable<GtkRecentChooserWidgetHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkRecentChooserWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentChooserWidgetHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkRecentChooserWidgetHandleSignalDelegates.selection_changed handler = ( MentorLake.Gtk.GtkRecentChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentChooserWidgetHandleSignalStructs.SelectionChangedSignal()
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

public static class GtkRecentChooserWidgetHandleSignalStructs
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

public static class GtkRecentChooserWidgetHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void item_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle self, IntPtr user_data);

}


public static class GtkRecentChooserWidgetHandleExtensions
{
}

internal class GtkRecentChooserWidgetHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentChooserWidgetHandle gtk_recent_chooser_widget_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentChooserWidgetHandle gtk_recent_chooser_widget_new_for_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager);

}
