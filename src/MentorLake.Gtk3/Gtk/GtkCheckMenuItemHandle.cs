namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkCheckMenuItem is a menu item that maintains the state of a boolean
/// value in addition to a #GtkMenuItem usual role in activating application
/// code.
/// </para>
/// <para>
/// A check box indicating the state of the boolean value is displayed
/// at the left side of the #GtkMenuItem.  Activating the #GtkMenuItem
/// toggles the value.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// |[<!-- language="plain" -->
/// menuitem
/// ├── check.left
/// ╰── <child>
/// ]|
/// </para>
/// <para>
/// GtkCheckMenuItem has a main CSS node with name menuitem, and a subnode
/// with name check, which gets the .left or .right style class.
/// </para>
/// </summary>

public class GtkCheckMenuItemHandle : GtkMenuItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkCheckMenuItem.
/// </para>
/// </summary>

/// <return>
/// a new #GtkCheckMenuItem.
/// </return>

	public static MentorLake.Gtk.GtkCheckMenuItemHandle New()
	{
		return GtkCheckMenuItemHandleExterns.gtk_check_menu_item_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkCheckMenuItem with a label.
/// </para>
/// </summary>

/// <param name="label">
/// the string to use for the label.
/// </param>
/// <return>
/// a new #GtkCheckMenuItem.
/// </return>

	public static MentorLake.Gtk.GtkCheckMenuItemHandle NewWithLabel(string label)
	{
		return GtkCheckMenuItemHandleExterns.gtk_check_menu_item_new_with_label(label);
	}

/// <summary>
/// <para>
/// Creates a new #GtkCheckMenuItem containing a label. The label
/// will be created using gtk_label_new_with_mnemonic(), so underscores
/// in @label indicate the mnemonic for the menu item.
/// </para>
/// </summary>

/// <param name="label">
/// The text of the button, with an underscore in front of the
///     character
/// </param>
/// <return>
/// a new #GtkCheckMenuItem
/// </return>

	public static MentorLake.Gtk.GtkCheckMenuItemHandle NewWithMnemonic(string label)
	{
		return GtkCheckMenuItemHandleExterns.gtk_check_menu_item_new_with_mnemonic(label);
	}

}
public static class GtkCheckMenuItemHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the state of the check box is changed.
/// </para>
/// <para>
/// A signal handler can use gtk_check_menu_item_get_active()
/// to discover the new state.
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// This signal is emitted when the state of the check box is changed.
/// </para>
/// <para>
/// A signal handler can use gtk_check_menu_item_get_active()
/// to discover the new state.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void toggled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCheckMenuItemHandle>))] MentorLake.Gtk.GtkCheckMenuItemHandle self, IntPtr user_data);

}


public static class GtkCheckMenuItemHandleExtensions
{
/// <summary>
/// <para>
/// Returns whether the check menu item is active. See
/// gtk_check_menu_item_set_active ().
/// </para>
/// </summary>

/// <param name="check_menu_item">
/// a #GtkCheckMenuItem
/// </param>
/// <return>
/// %TRUE if the menu item is checked.
/// </return>

	public static bool GetActive(this MentorLake.Gtk.GtkCheckMenuItemHandle check_menu_item)
	{
		if (check_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkCheckMenuItemHandle)");
		return GtkCheckMenuItemHandleExterns.gtk_check_menu_item_get_active(check_menu_item);
	}

/// <summary>
/// <para>
/// Returns whether @check_menu_item looks like a #GtkRadioMenuItem
/// </para>
/// </summary>

/// <param name="check_menu_item">
/// a #GtkCheckMenuItem
/// </param>
/// <return>
/// Whether @check_menu_item looks like a #GtkRadioMenuItem
/// </return>

	public static bool GetDrawAsRadio(this MentorLake.Gtk.GtkCheckMenuItemHandle check_menu_item)
	{
		if (check_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkCheckMenuItemHandle)");
		return GtkCheckMenuItemHandleExterns.gtk_check_menu_item_get_draw_as_radio(check_menu_item);
	}

/// <summary>
/// <para>
/// Retrieves the value set by gtk_check_menu_item_set_inconsistent().
/// </para>
/// </summary>

/// <param name="check_menu_item">
/// a #GtkCheckMenuItem
/// </param>
/// <return>
/// %TRUE if inconsistent
/// </return>

	public static bool GetInconsistent(this MentorLake.Gtk.GtkCheckMenuItemHandle check_menu_item)
	{
		if (check_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkCheckMenuItemHandle)");
		return GtkCheckMenuItemHandleExterns.gtk_check_menu_item_get_inconsistent(check_menu_item);
	}

/// <summary>
/// <para>
/// Sets the active state of the menu item’s check box.
/// </para>
/// </summary>

/// <param name="check_menu_item">
/// a #GtkCheckMenuItem.
/// </param>
/// <param name="is_active">
/// boolean value indicating whether the check box is active.
/// </param>

	public static T SetActive<T>(this T check_menu_item, bool is_active) where T : GtkCheckMenuItemHandle
	{
		if (check_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkCheckMenuItemHandle)");
		GtkCheckMenuItemHandleExterns.gtk_check_menu_item_set_active(check_menu_item, is_active);
		return check_menu_item;
	}

/// <summary>
/// <para>
/// Sets whether @check_menu_item is drawn like a #GtkRadioMenuItem
/// </para>
/// </summary>

/// <param name="check_menu_item">
/// a #GtkCheckMenuItem
/// </param>
/// <param name="draw_as_radio">
/// whether @check_menu_item is drawn like a #GtkRadioMenuItem
/// </param>

	public static T SetDrawAsRadio<T>(this T check_menu_item, bool draw_as_radio) where T : GtkCheckMenuItemHandle
	{
		if (check_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkCheckMenuItemHandle)");
		GtkCheckMenuItemHandleExterns.gtk_check_menu_item_set_draw_as_radio(check_menu_item, draw_as_radio);
		return check_menu_item;
	}

/// <summary>
/// <para>
/// If the user has selected a range of elements (such as some text or
/// spreadsheet cells) that are affected by a boolean setting, and the
/// current values in that range are inconsistent, you may want to
/// display the check in an “in between” state. This function turns on
/// “in between” display.  Normally you would turn off the inconsistent
/// state again if the user explicitly selects a setting. This has to be
/// done manually, gtk_check_menu_item_set_inconsistent() only affects
/// visual appearance, it doesn’t affect the semantics of the widget.
/// </para>
/// </summary>

/// <param name="check_menu_item">
/// a #GtkCheckMenuItem
/// </param>
/// <param name="setting">
/// %TRUE to display an “inconsistent” third state check
/// </param>

	public static T SetInconsistent<T>(this T check_menu_item, bool setting) where T : GtkCheckMenuItemHandle
	{
		if (check_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkCheckMenuItemHandle)");
		GtkCheckMenuItemHandleExterns.gtk_check_menu_item_set_inconsistent(check_menu_item, setting);
		return check_menu_item;
	}

/// <summary>
/// <para>
/// Emits the #GtkCheckMenuItem::toggled signal.
/// </para>
/// </summary>

/// <param name="check_menu_item">
/// a #GtkCheckMenuItem.
/// </param>

	public static T Toggled<T>(this T check_menu_item) where T : GtkCheckMenuItemHandle
	{
		if (check_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkCheckMenuItemHandle)");
		GtkCheckMenuItemHandleExterns.gtk_check_menu_item_toggled(check_menu_item);
		return check_menu_item;
	}

}

internal class GtkCheckMenuItemHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCheckMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkCheckMenuItemHandle gtk_check_menu_item_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCheckMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkCheckMenuItemHandle gtk_check_menu_item_new_with_label(string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkCheckMenuItemHandle>))]
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
