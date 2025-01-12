namespace MentorLake.Gtk3.Gtk3;

public class GtkToggleToolButtonHandle : GtkToolButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkToggleToolButtonHandle New()
	{
		return GtkToggleToolButtonExterns.gtk_toggle_tool_button_new();
	}

	public static GtkToggleToolButtonHandle NewFromStock(string stock_id)
	{
		return GtkToggleToolButtonExterns.gtk_toggle_tool_button_new_from_stock(stock_id);
	}

}

public static class GtkToggleToolButtonSignalExtensions
{

	public static IObservable<GtkToggleToolButtonSignalStructs.ToggledSignal> Signal_Toggled(this GtkToggleToolButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkToggleToolButtonSignalStructs.ToggledSignal> obs) =>
		{
			GtkToggleToolButtonSignalDelegates.toggled handler = (GtkToggleToolButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToggleToolButtonSignalStructs.ToggledSignal()
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

public static class GtkToggleToolButtonSignalStructs
{

public struct ToggledSignal
{
	public GtkToggleToolButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkToggleToolButtonSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkToggleToolButtonHandle>))] GtkToggleToolButtonHandle self, IntPtr user_data);

}


public static class GtkToggleToolButtonHandleExtensions
{
	public static bool GetActive(this GtkToggleToolButtonHandle button)
	{
		return GtkToggleToolButtonExterns.gtk_toggle_tool_button_get_active(button);
	}

	public static GtkToggleToolButtonHandle SetActive(this GtkToggleToolButtonHandle button, bool is_active)
	{
		GtkToggleToolButtonExterns.gtk_toggle_tool_button_set_active(button, is_active);
		return button;
	}

}

internal class GtkToggleToolButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToggleToolButtonHandle gtk_toggle_tool_button_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToggleToolButtonHandle gtk_toggle_tool_button_new_from_stock(string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_toggle_tool_button_get_active(GtkToggleToolButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_toggle_tool_button_set_active(GtkToggleToolButtonHandle button, bool is_active);

}
