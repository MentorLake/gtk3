namespace MentorLake.Gtk3.Gtk3;

public class GtkCheckMenuItemHandle : GtkMenuItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static GtkCheckMenuItemHandle New()
	{
		return GtkCheckMenuItemExterns.gtk_check_menu_item_new();
	}

	public static GtkCheckMenuItemHandle NewWithLabel(string label)
	{
		return GtkCheckMenuItemExterns.gtk_check_menu_item_new_with_label(label);
	}

	public static GtkCheckMenuItemHandle NewWithMnemonic(string label)
	{
		return GtkCheckMenuItemExterns.gtk_check_menu_item_new_with_mnemonic(label);
	}

}

public static class GtkCheckMenuItemSignalExtensions
{

	public static IObservable<GtkCheckMenuItemSignalStructs.ToggledSignal> Signal_Toggled(this GtkCheckMenuItemHandle instance)
	{
		return Observable.Create((IObserver<GtkCheckMenuItemSignalStructs.ToggledSignal> obs) =>
		{
			GtkCheckMenuItemSignalDelegates.toggled handler = (GtkCheckMenuItemHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCheckMenuItemSignalStructs.ToggledSignal()
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

public static class GtkCheckMenuItemSignalStructs
{

public struct ToggledSignal
{
	public GtkCheckMenuItemHandle Self;
	public IntPtr UserData;
}
}

public static class GtkCheckMenuItemSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkCheckMenuItemHandle>))] GtkCheckMenuItemHandle self, IntPtr user_data);

}


public static class GtkCheckMenuItemHandleExtensions
{
	public static bool GetActive(this GtkCheckMenuItemHandle check_menu_item)
	{
		return GtkCheckMenuItemExterns.gtk_check_menu_item_get_active(check_menu_item);
	}

	public static bool GetDrawAsRadio(this GtkCheckMenuItemHandle check_menu_item)
	{
		return GtkCheckMenuItemExterns.gtk_check_menu_item_get_draw_as_radio(check_menu_item);
	}

	public static bool GetInconsistent(this GtkCheckMenuItemHandle check_menu_item)
	{
		return GtkCheckMenuItemExterns.gtk_check_menu_item_get_inconsistent(check_menu_item);
	}

	public static T SetActive<T>(this T check_menu_item, bool is_active) where T : GtkCheckMenuItemHandle
	{
		GtkCheckMenuItemExterns.gtk_check_menu_item_set_active(check_menu_item, is_active);
		return check_menu_item;
	}

	public static T SetDrawAsRadio<T>(this T check_menu_item, bool draw_as_radio) where T : GtkCheckMenuItemHandle
	{
		GtkCheckMenuItemExterns.gtk_check_menu_item_set_draw_as_radio(check_menu_item, draw_as_radio);
		return check_menu_item;
	}

	public static T SetInconsistent<T>(this T check_menu_item, bool setting) where T : GtkCheckMenuItemHandle
	{
		GtkCheckMenuItemExterns.gtk_check_menu_item_set_inconsistent(check_menu_item, setting);
		return check_menu_item;
	}

	public static T Toggled<T>(this T check_menu_item) where T : GtkCheckMenuItemHandle
	{
		GtkCheckMenuItemExterns.gtk_check_menu_item_toggled(check_menu_item);
		return check_menu_item;
	}

}

internal class GtkCheckMenuItemExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCheckMenuItemHandle gtk_check_menu_item_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCheckMenuItemHandle gtk_check_menu_item_new_with_label(string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkCheckMenuItemHandle gtk_check_menu_item_new_with_mnemonic(string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_check_menu_item_get_active(GtkCheckMenuItemHandle check_menu_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_check_menu_item_get_draw_as_radio(GtkCheckMenuItemHandle check_menu_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_check_menu_item_get_inconsistent(GtkCheckMenuItemHandle check_menu_item);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_check_menu_item_set_active(GtkCheckMenuItemHandle check_menu_item, bool is_active);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_check_menu_item_set_draw_as_radio(GtkCheckMenuItemHandle check_menu_item, bool draw_as_radio);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_check_menu_item_set_inconsistent(GtkCheckMenuItemHandle check_menu_item, bool setting);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_check_menu_item_toggled(GtkCheckMenuItemHandle check_menu_item);

}
