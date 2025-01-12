namespace MentorLake.Gtk3.Gtk3;

public class GtkToolButtonHandle : GtkToolItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkToolButtonHandle New(GtkWidgetHandle icon_widget, string label)
	{
		return GtkToolButtonExterns.gtk_tool_button_new(icon_widget, label);
	}

	public static GtkToolButtonHandle NewFromStock(string stock_id)
	{
		return GtkToolButtonExterns.gtk_tool_button_new_from_stock(stock_id);
	}

}

public static class GtkToolButtonSignalExtensions
{

	public static IObservable<GtkToolButtonSignalStructs.ClickedSignal> Signal_Clicked(this GtkToolButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkToolButtonSignalStructs.ClickedSignal> obs) =>
		{
			GtkToolButtonSignalDelegates.clicked handler = (GtkToolButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolButtonSignalStructs.ClickedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "clicked", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkToolButtonSignalStructs
{

public struct ClickedSignal
{
	public GtkToolButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkToolButtonSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void clicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkToolButtonHandle>))] GtkToolButtonHandle self, IntPtr user_data);

}


public static class GtkToolButtonHandleExtensions
{
	public static string GetIconName(this GtkToolButtonHandle button)
	{
		return GtkToolButtonExterns.gtk_tool_button_get_icon_name(button);
	}

	public static GtkWidgetHandle GetIconWidget(this GtkToolButtonHandle button)
	{
		return GtkToolButtonExterns.gtk_tool_button_get_icon_widget(button);
	}

	public static string GetLabel(this GtkToolButtonHandle button)
	{
		return GtkToolButtonExterns.gtk_tool_button_get_label(button);
	}

	public static GtkWidgetHandle GetLabelWidget(this GtkToolButtonHandle button)
	{
		return GtkToolButtonExterns.gtk_tool_button_get_label_widget(button);
	}

	public static string GetStockId(this GtkToolButtonHandle button)
	{
		return GtkToolButtonExterns.gtk_tool_button_get_stock_id(button);
	}

	public static bool GetUseUnderline(this GtkToolButtonHandle button)
	{
		return GtkToolButtonExterns.gtk_tool_button_get_use_underline(button);
	}

	public static T SetIconName<T>(this T button, string icon_name) where T : GtkToolButtonHandle
	{
		GtkToolButtonExterns.gtk_tool_button_set_icon_name(button, icon_name);
		return button;
	}

	public static T SetIconWidget<T>(this T button, GtkWidgetHandle icon_widget) where T : GtkToolButtonHandle
	{
		GtkToolButtonExterns.gtk_tool_button_set_icon_widget(button, icon_widget);
		return button;
	}

	public static T SetLabel<T>(this T button, string label) where T : GtkToolButtonHandle
	{
		GtkToolButtonExterns.gtk_tool_button_set_label(button, label);
		return button;
	}

	public static T SetLabelWidget<T>(this T button, GtkWidgetHandle label_widget) where T : GtkToolButtonHandle
	{
		GtkToolButtonExterns.gtk_tool_button_set_label_widget(button, label_widget);
		return button;
	}

	public static T SetStockId<T>(this T button, string stock_id) where T : GtkToolButtonHandle
	{
		GtkToolButtonExterns.gtk_tool_button_set_stock_id(button, stock_id);
		return button;
	}

	public static T SetUseUnderline<T>(this T button, bool use_underline) where T : GtkToolButtonHandle
	{
		GtkToolButtonExterns.gtk_tool_button_set_use_underline(button, use_underline);
		return button;
	}

}

internal class GtkToolButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToolButtonHandle gtk_tool_button_new(GtkWidgetHandle icon_widget, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkToolButtonHandle gtk_tool_button_new_from_stock(string stock_id);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tool_button_get_icon_name(GtkToolButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_tool_button_get_icon_widget(GtkToolButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tool_button_get_label(GtkToolButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_tool_button_get_label_widget(GtkToolButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tool_button_get_stock_id(GtkToolButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_tool_button_get_use_underline(GtkToolButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_button_set_icon_name(GtkToolButtonHandle button, string icon_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_button_set_icon_widget(GtkToolButtonHandle button, GtkWidgetHandle icon_widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_button_set_label(GtkToolButtonHandle button, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_button_set_label_widget(GtkToolButtonHandle button, GtkWidgetHandle label_widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_button_set_stock_id(GtkToolButtonHandle button, string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_tool_button_set_use_underline(GtkToolButtonHandle button, bool use_underline);

}
