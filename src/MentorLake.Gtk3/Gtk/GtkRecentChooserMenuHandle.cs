namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkRecentChooserMenu is a widget suitable for displaying recently used files
/// inside a menu.  It can be used to set a sub-menu of a #GtkMenuItem using
/// gtk_menu_item_set_submenu(), or as the menu of a #GtkMenuToolButton.
/// </para>
/// <para>
/// Note that #GtkRecentChooserMenu does not have any methods of its own. Instead,
/// you should use the functions that work on a #GtkRecentChooser.
/// </para>
/// <para>
/// Note also that #GtkRecentChooserMenu does not support multiple filters, as it
/// has no way to let the user choose between them as the #GtkRecentChooserWidget
/// and #GtkRecentChooserDialog widgets do. Thus using gtk_recent_chooser_add_filter()
/// on a #GtkRecentChooserMenu widget will yield the same effects as using
/// gtk_recent_chooser_set_filter(), replacing any currently set filter
/// with the supplied filter; gtk_recent_chooser_remove_filter() will remove
/// any currently set #GtkRecentFilter object and will unset the current filter;
/// gtk_recent_chooser_list_filters() will return a list containing a single
/// #GtkRecentFilter object.
/// </para>
/// <para>
/// Recently used files are supported since GTK+ 2.10.
/// </para>
/// </summary>

public class GtkRecentChooserMenuHandle : GtkMenuHandle, AtkImplementorIfaceHandle, GtkActivatableHandle, GtkBuildableHandle, GtkRecentChooserHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkRecentChooserMenu widget.
/// </para>
/// <para>
/// This kind of widget shows the list of recently used resources as
/// a menu, each item as a menu item.  Each item inside the menu might
/// have an icon, representing its MIME type, and a number, for mnemonic
/// access.
/// </para>
/// <para>
/// This widget implements the #GtkRecentChooser interface.
/// </para>
/// <para>
/// This widget creates its own #GtkRecentManager object.  See the
/// gtk_recent_chooser_menu_new_for_manager() function to know how to create
/// a #GtkRecentChooserMenu widget bound to another #GtkRecentManager object.
/// </para>
/// </summary>

/// <return>
/// a new #GtkRecentChooserMenu
/// </return>

	public static MentorLake.Gtk.GtkRecentChooserMenuHandle New()
	{
		return GtkRecentChooserMenuHandleExterns.gtk_recent_chooser_menu_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkRecentChooserMenu widget using @manager as
/// the underlying recently used resources manager.
/// </para>
/// <para>
/// This is useful if you have implemented your own recent manager,
/// or if you have a customized instance of a #GtkRecentManager
/// object or if you wish to share a common #GtkRecentManager object
/// among multiple #GtkRecentChooser widgets.
/// </para>
/// </summary>

/// <param name="manager">
/// a #GtkRecentManager
/// </param>
/// <return>
/// a new #GtkRecentChooserMenu, bound to @manager.
/// </return>

	public static MentorLake.Gtk.GtkRecentChooserMenuHandle NewForManager(MentorLake.Gtk.GtkRecentManagerHandle manager)
	{
		return GtkRecentChooserMenuHandleExterns.gtk_recent_chooser_menu_new_for_manager(manager);
	}

}
public static class GtkRecentChooserMenuHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the user "activates" a recent item
/// in the recent chooser.  This can happen by double-clicking on an item
/// in the recently used resources list, or by pressing
/// `Enter`.
/// </para>
/// </summary>

	public static IObservable<GtkRecentChooserMenuHandleSignalStructs.ItemActivatedSignal> Signal_ItemActivated(this GtkRecentChooserMenuHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentChooserMenuHandleSignalStructs.ItemActivatedSignal> obs) =>
		{
			GtkRecentChooserMenuHandleSignalDelegates.item_activated handler = ( MentorLake.Gtk.GtkRecentChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentChooserMenuHandleSignalStructs.ItemActivatedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "item-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// This signal is emitted when there is a change in the set of
/// selected recently used resources.  This can happen when a user
/// modifies the selection with the mouse or the keyboard, or when
/// explicitly calling functions to change the selection.
/// </para>
/// </summary>

	public static IObservable<GtkRecentChooserMenuHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkRecentChooserMenuHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentChooserMenuHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkRecentChooserMenuHandleSignalDelegates.selection_changed handler = ( MentorLake.Gtk.GtkRecentChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentChooserMenuHandleSignalStructs.SelectionChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkRecentChooserMenuHandleSignalStructs
{

public class ItemActivatedSignal
{

	public MentorLake.Gtk.GtkRecentChooserHandle Self;

	public IntPtr UserData;
}

public class SelectionChangedSignal
{

	public MentorLake.Gtk.GtkRecentChooserHandle Self;

	public IntPtr UserData;
}
}

public static class GtkRecentChooserMenuHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the user "activates" a recent item
/// in the recent chooser.  This can happen by double-clicking on an item
/// in the recently used resources list, or by pressing
/// `Enter`.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void item_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when there is a change in the set of
/// selected recently used resources.  This can happen when a user
/// modifies the selection with the mouse or the keyboard, or when
/// explicitly calling functions to change the selection.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserHandleImpl>))] MentorLake.Gtk.GtkRecentChooserHandle self, IntPtr user_data);

}


public static class GtkRecentChooserMenuHandleExtensions
{
/// <summary>
/// <para>
/// Returns the value set by gtk_recent_chooser_menu_set_show_numbers().
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkRecentChooserMenu
/// </param>
/// <return>
/// %TRUE if numbers should be shown.
/// </return>

	public static bool GetShowNumbers(this MentorLake.Gtk.GtkRecentChooserMenuHandle menu)
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserMenuHandle)");
		return GtkRecentChooserMenuHandleExterns.gtk_recent_chooser_menu_get_show_numbers(menu);
	}

/// <summary>
/// <para>
/// Sets whether a number should be added to the items of @menu.  The
/// numbers are shown to provide a unique character for a mnemonic to
/// be used inside ten menu item’s label.  Only the first the items
/// get a number to avoid clashes.
/// </para>
/// </summary>

/// <param name="menu">
/// a #GtkRecentChooserMenu
/// </param>
/// <param name="show_numbers">
/// whether to show numbers
/// </param>

	public static T SetShowNumbers<T>(this T menu, bool show_numbers) where T : GtkRecentChooserMenuHandle
	{
		if (menu.IsInvalid) throw new Exception("Invalid handle (GtkRecentChooserMenuHandle)");
		GtkRecentChooserMenuHandleExterns.gtk_recent_chooser_menu_set_show_numbers(menu, show_numbers);
		return menu;
	}

}

internal class GtkRecentChooserMenuHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserMenuHandle>))]
	internal static extern MentorLake.Gtk.GtkRecentChooserMenuHandle gtk_recent_chooser_menu_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserMenuHandle>))]
	internal static extern MentorLake.Gtk.GtkRecentChooserMenuHandle gtk_recent_chooser_menu_new_for_manager([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_chooser_menu_get_show_numbers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserMenuHandle>))] MentorLake.Gtk.GtkRecentChooserMenuHandle menu);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_chooser_menu_set_show_numbers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentChooserMenuHandle>))] MentorLake.Gtk.GtkRecentChooserMenuHandle menu, bool show_numbers);

}
