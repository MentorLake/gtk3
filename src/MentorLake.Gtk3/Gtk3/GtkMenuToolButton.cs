namespace MentorLake.Gtk3.Gtk3;

public class GtkMenuToolButtonHandle : GtkToolButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkMenuToolButtonHandle New(GtkWidgetHandle icon_widget, string label)
	{
		return GtkMenuToolButtonExterns.gtk_menu_tool_button_new(icon_widget, label);
	}

	public static GtkMenuToolButtonHandle NewFromStock(string stock_id)
	{
		return GtkMenuToolButtonExterns.gtk_menu_tool_button_new_from_stock(stock_id);
	}

}

public static class GtkMenuToolButtonSignalExtensions
{

	public static IObservable<GtkMenuToolButtonSignalStructs.ShowMenuSignal> Signal_ShowMenu(this GtkMenuToolButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkMenuToolButtonSignalStructs.ShowMenuSignal> obs) =>
		{
			GtkMenuToolButtonSignalDelegates.show_menu handler = (GtkMenuToolButtonHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuToolButtonSignalStructs.ShowMenuSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "show_menu", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkMenuToolButtonSignalStructs
{

public struct ShowMenuSignal
{
	public GtkMenuToolButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkMenuToolButtonSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkMenuToolButtonHandle>))] GtkMenuToolButtonHandle self, IntPtr user_data);

}


public static class GtkMenuToolButtonHandleExtensions
{
	public static GtkWidgetHandle GetMenu(this GtkMenuToolButtonHandle button)
	{
		return GtkMenuToolButtonExterns.gtk_menu_tool_button_get_menu(button);
	}

	public static T SetArrowTooltipMarkup<T>(this T button, string markup) where T : GtkMenuToolButtonHandle
	{
		GtkMenuToolButtonExterns.gtk_menu_tool_button_set_arrow_tooltip_markup(button, markup);
		return button;
	}

	public static T SetArrowTooltipText<T>(this T button, string text) where T : GtkMenuToolButtonHandle
	{
		GtkMenuToolButtonExterns.gtk_menu_tool_button_set_arrow_tooltip_text(button, text);
		return button;
	}

	public static T SetMenu<T>(this T button, GtkWidgetHandle menu) where T : GtkMenuToolButtonHandle
	{
		GtkMenuToolButtonExterns.gtk_menu_tool_button_set_menu(button, menu);
		return button;
	}

}

internal class GtkMenuToolButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkMenuToolButtonHandle gtk_menu_tool_button_new(GtkWidgetHandle icon_widget, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkMenuToolButtonHandle gtk_menu_tool_button_new_from_stock(string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_menu_tool_button_get_menu(GtkMenuToolButtonHandle button);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_tool_button_set_arrow_tooltip_markup(GtkMenuToolButtonHandle button, string markup);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_tool_button_set_arrow_tooltip_text(GtkMenuToolButtonHandle button, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_menu_tool_button_set_menu(GtkMenuToolButtonHandle button, GtkWidgetHandle menu);

}
