namespace MentorLake.Gtk;

public class GtkRecentActionHandle : GtkActionHandle, GtkBuildableHandle, GtkRecentChooserHandle
{
	public static MentorLake.Gtk.GtkRecentActionHandle New(string name, string label, string tooltip, string stock_id)
	{
		return GtkRecentActionHandleExterns.gtk_recent_action_new(name, label, tooltip, stock_id);
	}

	public static MentorLake.Gtk.GtkRecentActionHandle NewForManager(string name, string label, string tooltip, string stock_id, MentorLake.Gtk.GtkRecentManagerHandle manager)
	{
		return GtkRecentActionHandleExterns.gtk_recent_action_new_for_manager(name, label, tooltip, stock_id, manager);
	}

}
public static class GtkRecentActionHandleSignalExtensions
{

	public static IObservable<GtkRecentActionHandleSignalStructs.ItemActivatedSignal> Signal_ItemActivated(this GtkRecentActionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentActionHandleSignalStructs.ItemActivatedSignal> obs) =>
		{
			GtkRecentActionHandleSignalDelegates.item_activated handler = ( MentorLake.Gtk.GtkRecentChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentActionHandleSignalStructs.ItemActivatedSignal()
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

	public static IObservable<GtkRecentActionHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkRecentActionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentActionHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkRecentActionHandleSignalDelegates.selection_changed handler = ( MentorLake.Gtk.GtkRecentChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentActionHandleSignalStructs.SelectionChangedSignal()
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

public static class GtkRecentActionHandleSignalStructs
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

public static class GtkRecentActionHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void item_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle self, IntPtr user_data);

}


public static class GtkRecentActionHandleExtensions
{
	public static bool GetShowNumbers(this MentorLake.Gtk.GtkRecentActionHandle action)
	{
		if (action.IsInvalid || action.IsClosed) throw new Exception("Invalid or closed handle (GtkRecentActionHandle)");
		return GtkRecentActionHandleExterns.gtk_recent_action_get_show_numbers(action);
	}

	public static T SetShowNumbers<T>(this T action, bool show_numbers) where T : GtkRecentActionHandle
	{
		if (action.IsInvalid || action.IsClosed) throw new Exception("Invalid or closed handle (GtkRecentActionHandle)");
		GtkRecentActionHandleExterns.gtk_recent_action_set_show_numbers(action, show_numbers);
		return action;
	}

}

internal class GtkRecentActionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentActionHandle gtk_recent_action_new(string name, string label, string tooltip, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentActionHandle gtk_recent_action_new_for_manager(string name, string label, string tooltip, string stock_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_action_get_show_numbers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentActionHandle>))] MentorLake.Gtk.GtkRecentActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_action_set_show_numbers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentActionHandle>))] MentorLake.Gtk.GtkRecentActionHandle action, bool show_numbers);

}
