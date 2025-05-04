namespace MentorLake.Gtk;

public class GtkRecentChooserMenuHandle : GtkMenuHandle, AtkImplementorIfaceHandle, GtkActivatableHandle, GtkBuildableHandle, GtkRecentChooserHandle
{
	public static MentorLake.Gtk.GtkRecentChooserMenuHandle New()
	{
		return GtkRecentChooserMenuHandleExterns.gtk_recent_chooser_menu_new();
	}

	public static MentorLake.Gtk.GtkRecentChooserMenuHandle NewForManager(MentorLake.Gtk.GtkRecentManagerHandle manager)
	{
		return GtkRecentChooserMenuHandleExterns.gtk_recent_chooser_menu_new_for_manager(manager);
	}

}
public static class GtkRecentChooserMenuHandleSignalExtensions
{

	public static IObservable<GtkRecentChooserMenuHandleSignalStructs.ItemActivatedSignal> Signal_ItemActivated(this GtkRecentChooserMenuHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentChooserMenuHandleSignalStructs.ItemActivatedSignal> obs) =>
		{
			GtkRecentChooserMenuHandleSignalDelegates.item_activated handler = ( MentorLake.Gtk.GtkRecentChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentChooserMenuHandleSignalStructs.ItemActivatedSignal()
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

	public static IObservable<GtkRecentChooserMenuHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkRecentChooserMenuHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentChooserMenuHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkRecentChooserMenuHandleSignalDelegates.selection_changed handler = ( MentorLake.Gtk.GtkRecentChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentChooserMenuHandleSignalStructs.SelectionChangedSignal()
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

public static class GtkRecentChooserMenuHandleSignalStructs
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

public static class GtkRecentChooserMenuHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void item_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle self, IntPtr user_data);

}


public static class GtkRecentChooserMenuHandleExtensions
{
	public static bool GetShowNumbers(this MentorLake.Gtk.GtkRecentChooserMenuHandle menu)
	{
		if (menu.IsInvalid || menu.IsClosed) throw new Exception("Invalid or closed handle (GtkRecentChooserMenuHandle)");
		return GtkRecentChooserMenuHandleExterns.gtk_recent_chooser_menu_get_show_numbers(menu);
	}

	public static T SetShowNumbers<T>(this T menu, bool show_numbers) where T : GtkRecentChooserMenuHandle
	{
		if (menu.IsInvalid || menu.IsClosed) throw new Exception("Invalid or closed handle (GtkRecentChooserMenuHandle)");
		GtkRecentChooserMenuHandleExterns.gtk_recent_chooser_menu_set_show_numbers(menu, show_numbers);
		return menu;
	}

}

internal class GtkRecentChooserMenuHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentChooserMenuHandle gtk_recent_chooser_menu_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRecentChooserMenuHandle gtk_recent_chooser_menu_new_for_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_chooser_menu_get_show_numbers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserMenuHandle>))] MentorLake.Gtk.GtkRecentChooserMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_menu_set_show_numbers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserMenuHandle>))] MentorLake.Gtk.GtkRecentChooserMenuHandle menu, bool show_numbers);

}
