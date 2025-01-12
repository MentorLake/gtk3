namespace MentorLake.Gtk3.Gtk3;

public class GtkRadioMenuItemHandle : GtkCheckMenuItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkRadioMenuItemHandle New(GSListHandle group)
	{
		return GtkRadioMenuItemExterns.gtk_radio_menu_item_new(group);
	}

	public static GtkRadioMenuItemHandle NewFromWidget(GtkRadioMenuItemHandle group)
	{
		return GtkRadioMenuItemExterns.gtk_radio_menu_item_new_from_widget(group);
	}

	public static GtkRadioMenuItemHandle NewWithLabel(GSListHandle group, string label)
	{
		return GtkRadioMenuItemExterns.gtk_radio_menu_item_new_with_label(group, label);
	}

	public static GtkRadioMenuItemHandle NewWithLabelFromWidget(GtkRadioMenuItemHandle group, string label)
	{
		return GtkRadioMenuItemExterns.gtk_radio_menu_item_new_with_label_from_widget(group, label);
	}

	public static GtkRadioMenuItemHandle NewWithMnemonic(GSListHandle group, string label)
	{
		return GtkRadioMenuItemExterns.gtk_radio_menu_item_new_with_mnemonic(group, label);
	}

	public static GtkRadioMenuItemHandle NewWithMnemonicFromWidget(GtkRadioMenuItemHandle group, string label)
	{
		return GtkRadioMenuItemExterns.gtk_radio_menu_item_new_with_mnemonic_from_widget(group, label);
	}

}

public static class GtkRadioMenuItemSignalExtensions
{

	public static IObservable<GtkRadioMenuItemSignalStructs.GroupChangedSignal> Signal_GroupChanged(this GtkRadioMenuItemHandle instance)
	{
		return Observable.Create((IObserver<GtkRadioMenuItemSignalStructs.GroupChangedSignal> obs) =>
		{
			GtkRadioMenuItemSignalDelegates.group_changed handler = (GtkRadioMenuItemHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRadioMenuItemSignalStructs.GroupChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "group_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkRadioMenuItemSignalStructs
{

public struct GroupChangedSignal
{
	public GtkRadioMenuItemHandle Self;
	public IntPtr UserData;
}
}

public static class GtkRadioMenuItemSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void group_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkRadioMenuItemHandle>))] GtkRadioMenuItemHandle self, IntPtr user_data);

}


public static class GtkRadioMenuItemHandleExtensions
{
	public static GSListHandle GetGroup(this GtkRadioMenuItemHandle radio_menu_item)
	{
		return GtkRadioMenuItemExterns.gtk_radio_menu_item_get_group(radio_menu_item);
	}

	public static T JoinGroup<T>(this T radio_menu_item, GtkRadioMenuItemHandle group_source) where T : GtkRadioMenuItemHandle
	{
		GtkRadioMenuItemExterns.gtk_radio_menu_item_join_group(radio_menu_item, group_source);
		return radio_menu_item;
	}

	public static T SetGroup<T>(this T radio_menu_item, GSListHandle group) where T : GtkRadioMenuItemHandle
	{
		GtkRadioMenuItemExterns.gtk_radio_menu_item_set_group(radio_menu_item, group);
		return radio_menu_item;
	}

}

internal class GtkRadioMenuItemExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioMenuItemHandle gtk_radio_menu_item_new(GSListHandle group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioMenuItemHandle gtk_radio_menu_item_new_from_widget(GtkRadioMenuItemHandle group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioMenuItemHandle gtk_radio_menu_item_new_with_label(GSListHandle group, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioMenuItemHandle gtk_radio_menu_item_new_with_label_from_widget(GtkRadioMenuItemHandle group, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioMenuItemHandle gtk_radio_menu_item_new_with_mnemonic(GSListHandle group, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioMenuItemHandle gtk_radio_menu_item_new_with_mnemonic_from_widget(GtkRadioMenuItemHandle group, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_radio_menu_item_get_group(GtkRadioMenuItemHandle radio_menu_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_radio_menu_item_join_group(GtkRadioMenuItemHandle radio_menu_item, GtkRadioMenuItemHandle group_source);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_radio_menu_item_set_group(GtkRadioMenuItemHandle radio_menu_item, GSListHandle group);

}
