namespace MentorLake.Gtk3.Gtk3;

public class GtkRadioButtonHandle : GtkCheckButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkRadioButtonHandle New(GSListHandle group)
	{
		return GtkRadioButtonExterns.gtk_radio_button_new(group);
	}

	public static GtkRadioButtonHandle NewFromWidget(GtkRadioButtonHandle radio_group_member)
	{
		return GtkRadioButtonExterns.gtk_radio_button_new_from_widget(radio_group_member);
	}

	public static GtkRadioButtonHandle NewWithLabel(GSListHandle group, string label)
	{
		return GtkRadioButtonExterns.gtk_radio_button_new_with_label(group, label);
	}

	public static GtkRadioButtonHandle NewWithLabelFromWidget(GtkRadioButtonHandle radio_group_member, string label)
	{
		return GtkRadioButtonExterns.gtk_radio_button_new_with_label_from_widget(radio_group_member, label);
	}

	public static GtkRadioButtonHandle NewWithMnemonic(GSListHandle group, string label)
	{
		return GtkRadioButtonExterns.gtk_radio_button_new_with_mnemonic(group, label);
	}

	public static GtkRadioButtonHandle NewWithMnemonicFromWidget(GtkRadioButtonHandle radio_group_member, string label)
	{
		return GtkRadioButtonExterns.gtk_radio_button_new_with_mnemonic_from_widget(radio_group_member, label);
	}

}

public static class GtkRadioButtonSignalExtensions
{

	public static IObservable<GtkRadioButtonSignalStructs.GroupChangedSignal> Signal_GroupChanged(this GtkRadioButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkRadioButtonSignalStructs.GroupChangedSignal> obs) =>
		{
			GtkRadioButtonSignalDelegates.group_changed handler = (GtkRadioButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRadioButtonSignalStructs.GroupChangedSignal()
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

public static class GtkRadioButtonSignalStructs
{

public struct GroupChangedSignal
{
	public GtkRadioButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkRadioButtonSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void group_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkRadioButtonHandle>))] GtkRadioButtonHandle self, IntPtr user_data);

}


public static class GtkRadioButtonHandleExtensions
{
	public static GSListHandle GetGroup(this GtkRadioButtonHandle radio_button)
	{
		return GtkRadioButtonExterns.gtk_radio_button_get_group(radio_button);
	}

	public static T JoinGroup<T>(this T radio_button, GtkRadioButtonHandle group_source) where T : GtkRadioButtonHandle
	{
		GtkRadioButtonExterns.gtk_radio_button_join_group(radio_button, group_source);
		return radio_button;
	}

	public static T SetGroup<T>(this T radio_button, GSListHandle group) where T : GtkRadioButtonHandle
	{
		GtkRadioButtonExterns.gtk_radio_button_set_group(radio_button, group);
		return radio_button;
	}

}

internal class GtkRadioButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioButtonHandle gtk_radio_button_new(GSListHandle group);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioButtonHandle gtk_radio_button_new_from_widget(GtkRadioButtonHandle radio_group_member);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioButtonHandle gtk_radio_button_new_with_label(GSListHandle group, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioButtonHandle gtk_radio_button_new_with_label_from_widget(GtkRadioButtonHandle radio_group_member, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioButtonHandle gtk_radio_button_new_with_mnemonic(GSListHandle group, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioButtonHandle gtk_radio_button_new_with_mnemonic_from_widget(GtkRadioButtonHandle radio_group_member, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_radio_button_get_group(GtkRadioButtonHandle radio_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_radio_button_join_group(GtkRadioButtonHandle radio_button, GtkRadioButtonHandle group_source);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_radio_button_set_group(GtkRadioButtonHandle radio_button, GSListHandle group);

}
