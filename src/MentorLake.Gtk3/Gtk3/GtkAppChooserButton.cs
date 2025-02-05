namespace MentorLake.Gtk3.Gtk3;

public class GtkAppChooserButtonHandle : GtkComboBoxHandle, AtkImplementorIfaceHandle, GtkAppChooserHandle, GtkBuildableHandle, GtkCellEditableHandle, GtkCellLayoutHandle
{
	public static GtkAppChooserButtonHandle New(string content_type)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_new(content_type);
	}

}

public static class GtkAppChooserButtonSignalExtensions
{

	public static IObservable<GtkAppChooserButtonSignalStructs.CustomItemActivatedSignal> Signal_CustomItemActivated(this GtkAppChooserButtonHandle instance)
	{
		return Observable.Create((IObserver<GtkAppChooserButtonSignalStructs.CustomItemActivatedSignal> obs) =>
		{
			GtkAppChooserButtonSignalDelegates.custom_item_activated handler = (GtkAppChooserButtonHandle self, string item_name, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkAppChooserButtonSignalStructs.CustomItemActivatedSignal()
				{
					Self = self, ItemName = item_name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "custom_item_activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkAppChooserButtonSignalStructs
{

public struct CustomItemActivatedSignal
{
	public GtkAppChooserButtonHandle Self;
	public string ItemName;
	public IntPtr UserData;
}
}

public static class GtkAppChooserButtonSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void custom_item_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAppChooserButtonHandle>))] GtkAppChooserButtonHandle self, string item_name, IntPtr user_data);

}


public static class GtkAppChooserButtonHandleExtensions
{
	public static T AppendCustomItem<T>(this T self, string name, string label, GIconHandle icon) where T : GtkAppChooserButtonHandle
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_append_custom_item(self, name, label, icon);
		return self;
	}

	public static T AppendSeparator<T>(this T self) where T : GtkAppChooserButtonHandle
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_append_separator(self);
		return self;
	}

	public static string GetHeading(this GtkAppChooserButtonHandle self)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_get_heading(self);
	}

	public static bool GetShowDefaultItem(this GtkAppChooserButtonHandle self)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_get_show_default_item(self);
	}

	public static bool GetShowDialogItem(this GtkAppChooserButtonHandle self)
	{
		return GtkAppChooserButtonExterns.gtk_app_chooser_button_get_show_dialog_item(self);
	}

	public static T SetActiveCustomItem<T>(this T self, string name) where T : GtkAppChooserButtonHandle
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_active_custom_item(self, name);
		return self;
	}

	public static T SetHeading<T>(this T self, string heading) where T : GtkAppChooserButtonHandle
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_heading(self, heading);
		return self;
	}

	public static T SetShowDefaultItem<T>(this T self, bool setting) where T : GtkAppChooserButtonHandle
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_show_default_item(self, setting);
		return self;
	}

	public static T SetShowDialogItem<T>(this T self, bool setting) where T : GtkAppChooserButtonHandle
	{
		GtkAppChooserButtonExterns.gtk_app_chooser_button_set_show_dialog_item(self, setting);
		return self;
	}

}

internal class GtkAppChooserButtonExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAppChooserButtonHandle gtk_app_chooser_button_new(string content_type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_app_chooser_button_append_custom_item(GtkAppChooserButtonHandle self, string name, string label, GIconHandle icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_app_chooser_button_append_separator(GtkAppChooserButtonHandle self);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_app_chooser_button_get_heading(GtkAppChooserButtonHandle self);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_app_chooser_button_get_show_default_item(GtkAppChooserButtonHandle self);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_app_chooser_button_get_show_dialog_item(GtkAppChooserButtonHandle self);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_app_chooser_button_set_active_custom_item(GtkAppChooserButtonHandle self, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_app_chooser_button_set_heading(GtkAppChooserButtonHandle self, string heading);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_app_chooser_button_set_show_default_item(GtkAppChooserButtonHandle self, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_app_chooser_button_set_show_dialog_item(GtkAppChooserButtonHandle self, bool setting);

}
