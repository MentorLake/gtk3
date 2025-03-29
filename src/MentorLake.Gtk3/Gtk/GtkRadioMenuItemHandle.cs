namespace MentorLake.Gtk;

public class GtkRadioMenuItemHandle : GtkCheckMenuItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkRadioMenuItemHandle New(MentorLake.GLib.GSListHandle group)
	{
		return GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_new(group);
	}

	public static MentorLake.Gtk.GtkRadioMenuItemHandle NewFromWidget(MentorLake.Gtk.GtkRadioMenuItemHandle group)
	{
		return GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_new_from_widget(group);
	}

	public static MentorLake.Gtk.GtkRadioMenuItemHandle NewWithLabel(MentorLake.GLib.GSListHandle group, string label)
	{
		return GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_new_with_label(group, label);
	}

	public static MentorLake.Gtk.GtkRadioMenuItemHandle NewWithLabelFromWidget(MentorLake.Gtk.GtkRadioMenuItemHandle group, string label)
	{
		return GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_new_with_label_from_widget(group, label);
	}

	public static MentorLake.Gtk.GtkRadioMenuItemHandle NewWithMnemonic(MentorLake.GLib.GSListHandle group, string label)
	{
		return GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_new_with_mnemonic(group, label);
	}

	public static MentorLake.Gtk.GtkRadioMenuItemHandle NewWithMnemonicFromWidget(MentorLake.Gtk.GtkRadioMenuItemHandle group, string label)
	{
		return GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_new_with_mnemonic_from_widget(group, label);
	}

}
public static class GtkRadioMenuItemHandleSignalExtensions
{

	public static IObservable<GtkRadioMenuItemHandleSignalStructs.GroupChangedSignal> Signal_GroupChanged(this GtkRadioMenuItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRadioMenuItemHandleSignalStructs.GroupChangedSignal> obs) =>
		{
			GtkRadioMenuItemHandleSignalDelegates.group_changed handler = ( MentorLake.Gtk.GtkRadioMenuItemHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRadioMenuItemHandleSignalStructs.GroupChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "group-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkRadioMenuItemHandleSignalStructs
{

public struct GroupChangedSignal
{
	public MentorLake.Gtk.GtkRadioMenuItemHandle Self;
	public IntPtr UserData;
}
}

public static class GtkRadioMenuItemHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void group_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))] MentorLake.Gtk.GtkRadioMenuItemHandle self, IntPtr user_data);

}


public static class GtkRadioMenuItemHandleExtensions
{
	public static MentorLake.GLib.GSListHandle GetGroup(this MentorLake.Gtk.GtkRadioMenuItemHandle radio_menu_item)
	{
		if (radio_menu_item.IsInvalid || radio_menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkRadioMenuItemHandle)");
		return GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_get_group(radio_menu_item);
	}

	public static T JoinGroup<T>(this T radio_menu_item, MentorLake.Gtk.GtkRadioMenuItemHandle group_source) where T : GtkRadioMenuItemHandle
	{
		if (radio_menu_item.IsInvalid || radio_menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkRadioMenuItemHandle)");
		GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_join_group(radio_menu_item, group_source);
		return radio_menu_item;
	}

	public static T SetGroup<T>(this T radio_menu_item, MentorLake.GLib.GSListHandle group) where T : GtkRadioMenuItemHandle
	{
		if (radio_menu_item.IsInvalid || radio_menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkRadioMenuItemHandle)");
		GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_set_group(radio_menu_item, group);
		return radio_menu_item;
	}

}

internal class GtkRadioMenuItemHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioMenuItemHandle gtk_radio_menu_item_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioMenuItemHandle gtk_radio_menu_item_new_from_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))] MentorLake.Gtk.GtkRadioMenuItemHandle group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioMenuItemHandle gtk_radio_menu_item_new_with_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioMenuItemHandle gtk_radio_menu_item_new_with_label_from_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))] MentorLake.Gtk.GtkRadioMenuItemHandle group, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioMenuItemHandle gtk_radio_menu_item_new_with_mnemonic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioMenuItemHandle gtk_radio_menu_item_new_with_mnemonic_from_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))] MentorLake.Gtk.GtkRadioMenuItemHandle group, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle gtk_radio_menu_item_get_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))] MentorLake.Gtk.GtkRadioMenuItemHandle radio_menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_radio_menu_item_join_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))] MentorLake.Gtk.GtkRadioMenuItemHandle radio_menu_item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))] MentorLake.Gtk.GtkRadioMenuItemHandle group_source);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_radio_menu_item_set_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))] MentorLake.Gtk.GtkRadioMenuItemHandle radio_menu_item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group);

}
