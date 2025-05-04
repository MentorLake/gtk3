namespace MentorLake.Gtk;

public class GtkCheckMenuItemHandle : GtkMenuItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkCheckMenuItemHandle New()
	{
		return GtkCheckMenuItemHandleExterns.gtk_check_menu_item_new();
	}

	public static MentorLake.Gtk.GtkCheckMenuItemHandle NewWithLabel(string label)
	{
		return GtkCheckMenuItemHandleExterns.gtk_check_menu_item_new_with_label(label);
	}

	public static MentorLake.Gtk.GtkCheckMenuItemHandle NewWithMnemonic(string label)
	{
		return GtkCheckMenuItemHandleExterns.gtk_check_menu_item_new_with_mnemonic(label);
	}

}
public static class GtkCheckMenuItemHandleSignalExtensions
{

	public static IObservable<GtkCheckMenuItemHandleSignalStructs.ToggledSignal> Signal_Toggled(this GtkCheckMenuItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkCheckMenuItemHandleSignalStructs.ToggledSignal> obs) =>
		{
			GtkCheckMenuItemHandleSignalDelegates.toggled handler = ( MentorLake.Gtk.GtkCheckMenuItemHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkCheckMenuItemHandleSignalStructs.ToggledSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "toggled", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkCheckMenuItemHandleSignalStructs
{

public class ToggledSignal
{
	public MentorLake.Gtk.GtkCheckMenuItemHandle Self;
	public IntPtr UserData;
}
}

public static class GtkCheckMenuItemHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCheckMenuItemHandle>))] MentorLake.Gtk.GtkCheckMenuItemHandle self, IntPtr user_data);

}


public static class GtkCheckMenuItemHandleExtensions
{
	public static bool GetActive(this MentorLake.Gtk.GtkCheckMenuItemHandle check_menu_item)
	{
		if (check_menu_item.IsInvalid || check_menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkCheckMenuItemHandle)");
		return GtkCheckMenuItemHandleExterns.gtk_check_menu_item_get_active(check_menu_item);
	}

	public static bool GetDrawAsRadio(this MentorLake.Gtk.GtkCheckMenuItemHandle check_menu_item)
	{
		if (check_menu_item.IsInvalid || check_menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkCheckMenuItemHandle)");
		return GtkCheckMenuItemHandleExterns.gtk_check_menu_item_get_draw_as_radio(check_menu_item);
	}

	public static bool GetInconsistent(this MentorLake.Gtk.GtkCheckMenuItemHandle check_menu_item)
	{
		if (check_menu_item.IsInvalid || check_menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkCheckMenuItemHandle)");
		return GtkCheckMenuItemHandleExterns.gtk_check_menu_item_get_inconsistent(check_menu_item);
	}

	public static T SetActive<T>(this T check_menu_item, bool is_active) where T : GtkCheckMenuItemHandle
	{
		if (check_menu_item.IsInvalid || check_menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkCheckMenuItemHandle)");
		GtkCheckMenuItemHandleExterns.gtk_check_menu_item_set_active(check_menu_item, is_active);
		return check_menu_item;
	}

	public static T SetDrawAsRadio<T>(this T check_menu_item, bool draw_as_radio) where T : GtkCheckMenuItemHandle
	{
		if (check_menu_item.IsInvalid || check_menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkCheckMenuItemHandle)");
		GtkCheckMenuItemHandleExterns.gtk_check_menu_item_set_draw_as_radio(check_menu_item, draw_as_radio);
		return check_menu_item;
	}

	public static T SetInconsistent<T>(this T check_menu_item, bool setting) where T : GtkCheckMenuItemHandle
	{
		if (check_menu_item.IsInvalid || check_menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkCheckMenuItemHandle)");
		GtkCheckMenuItemHandleExterns.gtk_check_menu_item_set_inconsistent(check_menu_item, setting);
		return check_menu_item;
	}

	public static T Toggled<T>(this T check_menu_item) where T : GtkCheckMenuItemHandle
	{
		if (check_menu_item.IsInvalid || check_menu_item.IsClosed) throw new Exception("Invalid or closed handle (GtkCheckMenuItemHandle)");
		GtkCheckMenuItemHandleExterns.gtk_check_menu_item_toggled(check_menu_item);
		return check_menu_item;
	}

}

internal class GtkCheckMenuItemHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCheckMenuItemHandle gtk_check_menu_item_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCheckMenuItemHandle gtk_check_menu_item_new_with_label(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkCheckMenuItemHandle gtk_check_menu_item_new_with_mnemonic(string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_check_menu_item_get_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCheckMenuItemHandle>))] MentorLake.Gtk.GtkCheckMenuItemHandle check_menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_check_menu_item_get_draw_as_radio([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCheckMenuItemHandle>))] MentorLake.Gtk.GtkCheckMenuItemHandle check_menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_check_menu_item_get_inconsistent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCheckMenuItemHandle>))] MentorLake.Gtk.GtkCheckMenuItemHandle check_menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_check_menu_item_set_active([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCheckMenuItemHandle>))] MentorLake.Gtk.GtkCheckMenuItemHandle check_menu_item, bool is_active);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_check_menu_item_set_draw_as_radio([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCheckMenuItemHandle>))] MentorLake.Gtk.GtkCheckMenuItemHandle check_menu_item, bool draw_as_radio);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_check_menu_item_set_inconsistent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCheckMenuItemHandle>))] MentorLake.Gtk.GtkCheckMenuItemHandle check_menu_item, bool setting);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_check_menu_item_toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCheckMenuItemHandle>))] MentorLake.Gtk.GtkCheckMenuItemHandle check_menu_item);

}
