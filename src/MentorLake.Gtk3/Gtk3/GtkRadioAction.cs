namespace MentorLake.Gtk3.Gtk3;

public class GtkRadioActionHandle : GtkToggleActionHandle, GtkBuildableHandle
{
	public static GtkRadioActionHandle New(string name, string label, string tooltip, string stock_id, int value)
	{
		return GtkRadioActionExterns.gtk_radio_action_new(name, label, tooltip, stock_id, value);
	}

}

public static class GtkRadioActionSignalExtensions
{

	public static IObservable<GtkRadioActionSignalStructs.ChangedSignal> Signal_Changed(this GtkRadioActionHandle instance)
	{
		return Observable.Create((IObserver<GtkRadioActionSignalStructs.ChangedSignal> obs) =>
		{
			GtkRadioActionSignalDelegates.changed handler = (GtkRadioActionHandle self, GtkRadioActionHandle current, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRadioActionSignalStructs.ChangedSignal()
				{
					Self = self, Current = current, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkRadioActionSignalStructs
{

public struct ChangedSignal
{
	public GtkRadioActionHandle Self;
	public GtkRadioActionHandle Current;
	public IntPtr UserData;
}
}

public static class GtkRadioActionSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkRadioActionHandle>))] GtkRadioActionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkRadioActionHandle>))] GtkRadioActionHandle current, IntPtr user_data);

}


public static class GtkRadioActionHandleExtensions
{
	public static int GetCurrentValue(this GtkRadioActionHandle action)
	{
		return GtkRadioActionExterns.gtk_radio_action_get_current_value(action);
	}

	public static GSListHandle GetGroup(this GtkRadioActionHandle action)
	{
		return GtkRadioActionExterns.gtk_radio_action_get_group(action);
	}

	public static T JoinGroup<T>(this T action, GtkRadioActionHandle group_source) where T : GtkRadioActionHandle
	{
		GtkRadioActionExterns.gtk_radio_action_join_group(action, group_source);
		return action;
	}

	public static T SetCurrentValue<T>(this T action, int current_value) where T : GtkRadioActionHandle
	{
		GtkRadioActionExterns.gtk_radio_action_set_current_value(action, current_value);
		return action;
	}

	public static T SetGroup<T>(this T action, GSListHandle group) where T : GtkRadioActionHandle
	{
		GtkRadioActionExterns.gtk_radio_action_set_group(action, group);
		return action;
	}

}

internal class GtkRadioActionExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRadioActionHandle gtk_radio_action_new(string name, string label, string tooltip, string stock_id, int value);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_radio_action_get_current_value(GtkRadioActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern GSListHandle gtk_radio_action_get_group(GtkRadioActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_radio_action_join_group(GtkRadioActionHandle action, GtkRadioActionHandle group_source);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_radio_action_set_current_value(GtkRadioActionHandle action, int current_value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_radio_action_set_group(GtkRadioActionHandle action, GSListHandle group);

}
