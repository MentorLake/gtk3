namespace MentorLake.Gtk;

public class GtkRadioActionHandle : GtkToggleActionHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkRadioActionHandle New(string name, string label, string tooltip, string stock_id, int value)
	{
		return GtkRadioActionHandleExterns.gtk_radio_action_new(name, label, tooltip, stock_id, value);
	}

}
public static class GtkRadioActionHandleSignalExtensions
{

	public static IObservable<GtkRadioActionHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkRadioActionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRadioActionHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkRadioActionHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkRadioActionHandle self,  MentorLake.Gtk.GtkRadioActionHandle current,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRadioActionHandleSignalStructs.ChangedSignal()
				{
					Self = self, Current = current, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkRadioActionHandleSignalStructs
{

public struct ChangedSignal
{
	public MentorLake.Gtk.GtkRadioActionHandle Self;
	public MentorLake.Gtk.GtkRadioActionHandle Current;
	public IntPtr UserData;
}
}

public static class GtkRadioActionHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))] MentorLake.Gtk.GtkRadioActionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))] MentorLake.Gtk.GtkRadioActionHandle current, IntPtr user_data);

}


public static class GtkRadioActionHandleExtensions
{
	public static int GetCurrentValue(this MentorLake.Gtk.GtkRadioActionHandle action)
	{
		return GtkRadioActionHandleExterns.gtk_radio_action_get_current_value(action);
	}

	public static MentorLake.GLib.GSListHandle GetGroup(this MentorLake.Gtk.GtkRadioActionHandle action)
	{
		return GtkRadioActionHandleExterns.gtk_radio_action_get_group(action);
	}

	public static T JoinGroup<T>(this T action, MentorLake.Gtk.GtkRadioActionHandle group_source) where T : GtkRadioActionHandle
	{
		GtkRadioActionHandleExterns.gtk_radio_action_join_group(action, group_source);
		return action;
	}

	public static T SetCurrentValue<T>(this T action, int current_value) where T : GtkRadioActionHandle
	{
		GtkRadioActionHandleExterns.gtk_radio_action_set_current_value(action, current_value);
		return action;
	}

	public static T SetGroup<T>(this T action, MentorLake.GLib.GSListHandle group) where T : GtkRadioActionHandle
	{
		GtkRadioActionHandleExterns.gtk_radio_action_set_group(action, group);
		return action;
	}

}

internal class GtkRadioActionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRadioActionHandle gtk_radio_action_new(string name, string label, string tooltip, string stock_id, int value);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_radio_action_get_current_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))] MentorLake.Gtk.GtkRadioActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GSListHandle gtk_radio_action_get_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))] MentorLake.Gtk.GtkRadioActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_radio_action_join_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))] MentorLake.Gtk.GtkRadioActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))] MentorLake.Gtk.GtkRadioActionHandle group_source);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_radio_action_set_current_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))] MentorLake.Gtk.GtkRadioActionHandle action, int current_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_radio_action_set_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioActionHandle>))] MentorLake.Gtk.GtkRadioActionHandle action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group);

}
