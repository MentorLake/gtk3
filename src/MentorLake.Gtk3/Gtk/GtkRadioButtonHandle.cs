namespace MentorLake.Gtk;

public class GtkRadioButtonHandle : GtkCheckButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkRadioButtonHandle New(MentorLake.GLib.GSListHandle group)
	{
		return GtkRadioButtonHandleExterns.gtk_radio_button_new(group);
	}

	public static MentorLake.Gtk.GtkRadioButtonHandle NewFromWidget(MentorLake.Gtk.GtkRadioButtonHandle radio_group_member)
	{
		return GtkRadioButtonHandleExterns.gtk_radio_button_new_from_widget(radio_group_member);
	}

	public static MentorLake.Gtk.GtkRadioButtonHandle NewWithLabel(MentorLake.GLib.GSListHandle group, string label)
	{
		return GtkRadioButtonHandleExterns.gtk_radio_button_new_with_label(group, label);
	}

	public static MentorLake.Gtk.GtkRadioButtonHandle NewWithLabelFromWidget(MentorLake.Gtk.GtkRadioButtonHandle radio_group_member, string label)
	{
		return GtkRadioButtonHandleExterns.gtk_radio_button_new_with_label_from_widget(radio_group_member, label);
	}

	public static MentorLake.Gtk.GtkRadioButtonHandle NewWithMnemonic(MentorLake.GLib.GSListHandle group, string label)
	{
		return GtkRadioButtonHandleExterns.gtk_radio_button_new_with_mnemonic(group, label);
	}

	public static MentorLake.Gtk.GtkRadioButtonHandle NewWithMnemonicFromWidget(MentorLake.Gtk.GtkRadioButtonHandle radio_group_member, string label)
	{
		return GtkRadioButtonHandleExterns.gtk_radio_button_new_with_mnemonic_from_widget(radio_group_member, label);
	}

}
public static class GtkRadioButtonHandleSignalExtensions
{

	public static IObservable<GtkRadioButtonHandleSignalStructs.GroupChangedSignal> Signal_GroupChanged(this GtkRadioButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRadioButtonHandleSignalStructs.GroupChangedSignal> obs) =>
		{
			GtkRadioButtonHandleSignalDelegates.group_changed handler = ( MentorLake.Gtk.GtkRadioButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRadioButtonHandleSignalStructs.GroupChangedSignal()
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

public static class GtkRadioButtonHandleSignalStructs
{

public class GroupChangedSignal
{
	public MentorLake.Gtk.GtkRadioButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkRadioButtonHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void group_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))] MentorLake.Gtk.GtkRadioButtonHandle self, IntPtr user_data);

}


public static class GtkRadioButtonHandleExtensions
{
	public static MentorLake.GLib.GSListHandle GetGroup(this MentorLake.Gtk.GtkRadioButtonHandle radio_button)
	{
		if (radio_button.IsInvalid || radio_button.IsClosed) throw new Exception("Invalid or closed handle (GtkRadioButtonHandle)");
		return GtkRadioButtonHandleExterns.gtk_radio_button_get_group(radio_button);
	}

	public static T JoinGroup<T>(this T radio_button, MentorLake.Gtk.GtkRadioButtonHandle group_source) where T : GtkRadioButtonHandle
	{
		if (radio_button.IsInvalid || radio_button.IsClosed) throw new Exception("Invalid or closed handle (GtkRadioButtonHandle)");
		GtkRadioButtonHandleExterns.gtk_radio_button_join_group(radio_button, group_source);
		return radio_button;
	}

	public static T SetGroup<T>(this T radio_button, MentorLake.GLib.GSListHandle group) where T : GtkRadioButtonHandle
	{
		if (radio_button.IsInvalid || radio_button.IsClosed) throw new Exception("Invalid or closed handle (GtkRadioButtonHandle)");
		GtkRadioButtonHandleExterns.gtk_radio_button_set_group(radio_button, group);
		return radio_button;
	}

}

internal class GtkRadioButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioButtonHandle gtk_radio_button_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioButtonHandle gtk_radio_button_new_from_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))] MentorLake.Gtk.GtkRadioButtonHandle radio_group_member);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioButtonHandle gtk_radio_button_new_with_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioButtonHandle gtk_radio_button_new_with_label_from_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))] MentorLake.Gtk.GtkRadioButtonHandle radio_group_member, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioButtonHandle gtk_radio_button_new_with_mnemonic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioButtonHandle gtk_radio_button_new_with_mnemonic_from_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))] MentorLake.Gtk.GtkRadioButtonHandle radio_group_member, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle gtk_radio_button_get_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))] MentorLake.Gtk.GtkRadioButtonHandle radio_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_radio_button_join_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))] MentorLake.Gtk.GtkRadioButtonHandle radio_button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))] MentorLake.Gtk.GtkRadioButtonHandle group_source);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_radio_button_set_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))] MentorLake.Gtk.GtkRadioButtonHandle radio_button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group);

}
