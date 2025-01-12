namespace MentorLake.Gtk3.Gtk3;

public class GtkToggleActionHandle : GtkActionHandle, GtkBuildableHandle
{
	public static GtkToggleActionHandle New(string name, string label, string tooltip, string stock_id)
	{
		return GtkToggleActionExterns.gtk_toggle_action_new(name, label, tooltip, stock_id);
	}

}

public static class GtkToggleActionSignalExtensions
{

	public static IObservable<GtkToggleActionSignalStructs.ToggledSignal> Signal_Toggled(this GtkToggleActionHandle instance)
	{
		return Observable.Create((IObserver<GtkToggleActionSignalStructs.ToggledSignal> obs) =>
		{
			GtkToggleActionSignalDelegates.toggled handler = (GtkToggleActionHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToggleActionSignalStructs.ToggledSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "toggled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkToggleActionSignalStructs
{

public struct ToggledSignal
{
	public GtkToggleActionHandle Self;
	public IntPtr UserData;
}
}

public static class GtkToggleActionSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkToggleActionHandle>))] GtkToggleActionHandle self, IntPtr user_data);

}


public static class GtkToggleActionHandleExtensions
{
	public static bool GetActive(this GtkToggleActionHandle action)
	{
		return GtkToggleActionExterns.gtk_toggle_action_get_active(action);
	}

	public static bool GetDrawAsRadio(this GtkToggleActionHandle action)
	{
		return GtkToggleActionExterns.gtk_toggle_action_get_draw_as_radio(action);
	}

	public static T SetActive<T>(this T action, bool is_active) where T : GtkToggleActionHandle
	{
		GtkToggleActionExterns.gtk_toggle_action_set_active(action, is_active);
		return action;
	}

	public static T SetDrawAsRadio<T>(this T action, bool draw_as_radio) where T : GtkToggleActionHandle
	{
		GtkToggleActionExterns.gtk_toggle_action_set_draw_as_radio(action, draw_as_radio);
		return action;
	}

	public static T Toggled<T>(this T action) where T : GtkToggleActionHandle
	{
		GtkToggleActionExterns.gtk_toggle_action_toggled(action);
		return action;
	}

}

internal class GtkToggleActionExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToggleActionHandle gtk_toggle_action_new(string name, string label, string tooltip, string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_toggle_action_get_active(GtkToggleActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_toggle_action_get_draw_as_radio(GtkToggleActionHandle action);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_toggle_action_set_active(GtkToggleActionHandle action, bool is_active);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_toggle_action_set_draw_as_radio(GtkToggleActionHandle action, bool draw_as_radio);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_toggle_action_toggled(GtkToggleActionHandle action);

}
