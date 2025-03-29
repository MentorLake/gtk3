namespace MentorLake.Gtk;

public class GtkMenuToolButtonHandle : GtkToolButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkMenuToolButtonHandle New(MentorLake.Gtk.GtkWidgetHandle icon_widget, string label)
	{
		return GtkMenuToolButtonHandleExterns.gtk_menu_tool_button_new(icon_widget, label);
	}

	public static MentorLake.Gtk.GtkMenuToolButtonHandle NewFromStock(string stock_id)
	{
		return GtkMenuToolButtonHandleExterns.gtk_menu_tool_button_new_from_stock(stock_id);
	}

}
public static class GtkMenuToolButtonHandleSignalExtensions
{

	public static IObservable<GtkMenuToolButtonHandleSignalStructs.ShowMenuSignal> Signal_ShowMenu(this GtkMenuToolButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkMenuToolButtonHandleSignalStructs.ShowMenuSignal> obs) =>
		{
			GtkMenuToolButtonHandleSignalDelegates.show_menu handler = ( MentorLake.Gtk.GtkMenuToolButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkMenuToolButtonHandleSignalStructs.ShowMenuSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show-menu", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkMenuToolButtonHandleSignalStructs
{

public struct ShowMenuSignal
{
	public MentorLake.Gtk.GtkMenuToolButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkMenuToolButtonHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuToolButtonHandle>))] MentorLake.Gtk.GtkMenuToolButtonHandle self, IntPtr user_data);

}


public static class GtkMenuToolButtonHandleExtensions
{
	public static MentorLake.Gtk.GtkWidgetHandle GetMenu(this MentorLake.Gtk.GtkMenuToolButtonHandle button)
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuToolButtonHandle)");
		return GtkMenuToolButtonHandleExterns.gtk_menu_tool_button_get_menu(button);
	}

	public static T SetArrowTooltipMarkup<T>(this T button, string markup) where T : GtkMenuToolButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuToolButtonHandle)");
		GtkMenuToolButtonHandleExterns.gtk_menu_tool_button_set_arrow_tooltip_markup(button, markup);
		return button;
	}

	public static T SetArrowTooltipText<T>(this T button, string text) where T : GtkMenuToolButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuToolButtonHandle)");
		GtkMenuToolButtonHandleExterns.gtk_menu_tool_button_set_arrow_tooltip_text(button, text);
		return button;
	}

	public static T SetMenu<T>(this T button, MentorLake.Gtk.GtkWidgetHandle menu) where T : GtkMenuToolButtonHandle
	{
		if (button.IsInvalid || button.IsClosed) throw new Exception("Invalid or closed handle (GtkMenuToolButtonHandle)");
		GtkMenuToolButtonHandleExterns.gtk_menu_tool_button_set_menu(button, menu);
		return button;
	}

}

internal class GtkMenuToolButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkMenuToolButtonHandle gtk_menu_tool_button_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle icon_widget, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkMenuToolButtonHandle gtk_menu_tool_button_new_from_stock(string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_menu_tool_button_get_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuToolButtonHandle>))] MentorLake.Gtk.GtkMenuToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_tool_button_set_arrow_tooltip_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuToolButtonHandle>))] MentorLake.Gtk.GtkMenuToolButtonHandle button, string markup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_tool_button_set_arrow_tooltip_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuToolButtonHandle>))] MentorLake.Gtk.GtkMenuToolButtonHandle button, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_menu_tool_button_set_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMenuToolButtonHandle>))] MentorLake.Gtk.GtkMenuToolButtonHandle button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu);

}
