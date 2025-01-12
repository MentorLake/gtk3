namespace MentorLake.Gtk3.Gtk3;

public class GtkToggleButtonHandle : GtkButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkToggleButtonHandle New()
	{
		return GtkToggleButtonExterns.gtk_toggle_button_new();
	}

	public static GtkToggleButtonHandle NewWithLabel(string label)
	{
		return GtkToggleButtonExterns.gtk_toggle_button_new_with_label(label);
	}

	public static GtkToggleButtonHandle NewWithMnemonic(string label)
	{
		return GtkToggleButtonExterns.gtk_toggle_button_new_with_mnemonic(label);
	}

}

public static class GtkToggleButtonSignalExtensions
{

	public static IObservable<GtkToggleButtonSignalStructs.ToggledSignal> Signal_Toggled(this GtkToggleButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkToggleButtonSignalStructs.ToggledSignal> obs) =>
		{
			GtkToggleButtonSignalDelegates.toggled handler = (GtkToggleButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToggleButtonSignalStructs.ToggledSignal()
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

public static class GtkToggleButtonSignalStructs
{

public struct ToggledSignal
{
	public GtkToggleButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkToggleButtonSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkToggleButtonHandle>))] GtkToggleButtonHandle self, IntPtr user_data);

}


public static class GtkToggleButtonHandleExtensions
{
	public static bool GetActive(this GtkToggleButtonHandle toggle_button)
	{
		return GtkToggleButtonExterns.gtk_toggle_button_get_active(toggle_button);
	}

	public static bool GetInconsistent(this GtkToggleButtonHandle toggle_button)
	{
		return GtkToggleButtonExterns.gtk_toggle_button_get_inconsistent(toggle_button);
	}

	public static bool GetMode(this GtkToggleButtonHandle toggle_button)
	{
		return GtkToggleButtonExterns.gtk_toggle_button_get_mode(toggle_button);
	}

	public static GtkToggleButtonHandle SetActive(this GtkToggleButtonHandle toggle_button, bool is_active)
	{
		GtkToggleButtonExterns.gtk_toggle_button_set_active(toggle_button, is_active);
		return toggle_button;
	}

	public static GtkToggleButtonHandle SetInconsistent(this GtkToggleButtonHandle toggle_button, bool setting)
	{
		GtkToggleButtonExterns.gtk_toggle_button_set_inconsistent(toggle_button, setting);
		return toggle_button;
	}

	public static GtkToggleButtonHandle SetMode(this GtkToggleButtonHandle toggle_button, bool draw_indicator)
	{
		GtkToggleButtonExterns.gtk_toggle_button_set_mode(toggle_button, draw_indicator);
		return toggle_button;
	}

	public static GtkToggleButtonHandle Toggled(this GtkToggleButtonHandle toggle_button)
	{
		GtkToggleButtonExterns.gtk_toggle_button_toggled(toggle_button);
		return toggle_button;
	}

}

internal class GtkToggleButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToggleButtonHandle gtk_toggle_button_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToggleButtonHandle gtk_toggle_button_new_with_label(string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToggleButtonHandle gtk_toggle_button_new_with_mnemonic(string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_toggle_button_get_active(GtkToggleButtonHandle toggle_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_toggle_button_get_inconsistent(GtkToggleButtonHandle toggle_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_toggle_button_get_mode(GtkToggleButtonHandle toggle_button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_toggle_button_set_active(GtkToggleButtonHandle toggle_button, bool is_active);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_toggle_button_set_inconsistent(GtkToggleButtonHandle toggle_button, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_toggle_button_set_mode(GtkToggleButtonHandle toggle_button, bool draw_indicator);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_toggle_button_toggled(GtkToggleButtonHandle toggle_button);

}
