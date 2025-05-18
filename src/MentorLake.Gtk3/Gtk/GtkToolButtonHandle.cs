namespace MentorLake.Gtk;

public class GtkToolButtonHandle : GtkToolItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkToolButtonHandle New(MentorLake.Gtk.GtkWidgetHandle icon_widget, string label)
	{
		return GtkToolButtonHandleExterns.gtk_tool_button_new(icon_widget, label);
	}

	public static MentorLake.Gtk.GtkToolButtonHandle NewFromStock(string stock_id)
	{
		return GtkToolButtonHandleExterns.gtk_tool_button_new_from_stock(stock_id);
	}

}
public static class GtkToolButtonHandleSignalExtensions
{

	public static IObservable<GtkToolButtonHandleSignalStructs.ClickedSignal> Signal_Clicked(this GtkToolButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkToolButtonHandleSignalStructs.ClickedSignal> obs) =>
		{
			GtkToolButtonHandleSignalDelegates.clicked handler = ( MentorLake.Gtk.GtkToolButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkToolButtonHandleSignalStructs.ClickedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "clicked", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkToolButtonHandleSignalStructs
{

public class ClickedSignal
{
	public MentorLake.Gtk.GtkToolButtonHandle Self;
	public IntPtr UserData;
}
}

public static class GtkToolButtonHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void clicked([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle self, IntPtr user_data);

}


public static class GtkToolButtonHandleExtensions
{
	public static string GetIconName(this MentorLake.Gtk.GtkToolButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		return GtkToolButtonHandleExterns.gtk_tool_button_get_icon_name(button);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetIconWidget(this MentorLake.Gtk.GtkToolButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		return GtkToolButtonHandleExterns.gtk_tool_button_get_icon_widget(button);
	}

	public static string GetLabel(this MentorLake.Gtk.GtkToolButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		return GtkToolButtonHandleExterns.gtk_tool_button_get_label(button);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetLabelWidget(this MentorLake.Gtk.GtkToolButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		return GtkToolButtonHandleExterns.gtk_tool_button_get_label_widget(button);
	}

	public static string GetStockId(this MentorLake.Gtk.GtkToolButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		return GtkToolButtonHandleExterns.gtk_tool_button_get_stock_id(button);
	}

	public static bool GetUseUnderline(this MentorLake.Gtk.GtkToolButtonHandle button)
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		return GtkToolButtonHandleExterns.gtk_tool_button_get_use_underline(button);
	}

	public static T SetIconName<T>(this T button, string icon_name) where T : GtkToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		GtkToolButtonHandleExterns.gtk_tool_button_set_icon_name(button, icon_name);
		return button;
	}

	public static T SetIconWidget<T>(this T button, MentorLake.Gtk.GtkWidgetHandle icon_widget) where T : GtkToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		GtkToolButtonHandleExterns.gtk_tool_button_set_icon_widget(button, icon_widget);
		return button;
	}

	public static T SetLabel<T>(this T button, string label) where T : GtkToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		GtkToolButtonHandleExterns.gtk_tool_button_set_label(button, label);
		return button;
	}

	public static T SetLabelWidget<T>(this T button, MentorLake.Gtk.GtkWidgetHandle label_widget) where T : GtkToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		GtkToolButtonHandleExterns.gtk_tool_button_set_label_widget(button, label_widget);
		return button;
	}

	public static T SetStockId<T>(this T button, string stock_id) where T : GtkToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		GtkToolButtonHandleExterns.gtk_tool_button_set_stock_id(button, stock_id);
		return button;
	}

	public static T SetUseUnderline<T>(this T button, bool use_underline) where T : GtkToolButtonHandle
	{
		if (button.IsInvalid) throw new Exception("Invalid handle (GtkToolButtonHandle)");
		GtkToolButtonHandleExterns.gtk_tool_button_set_use_underline(button, use_underline);
		return button;
	}

}

internal class GtkToolButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkToolButtonHandle gtk_tool_button_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle icon_widget, string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkToolButtonHandle gtk_tool_button_new_from_stock(string stock_id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tool_button_get_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tool_button_get_icon_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tool_button_get_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_tool_button_get_label_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_tool_button_get_stock_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tool_button_get_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_button_set_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button, string icon_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_button_set_icon_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle icon_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_button_set_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_button_set_label_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle label_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_button_set_stock_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tool_button_set_use_underline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkToolButtonHandle>))] MentorLake.Gtk.GtkToolButtonHandle button, bool use_underline);

}
