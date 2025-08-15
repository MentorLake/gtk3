namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A #GtkRecentAction represents a list of recently used files, which
/// can be shown by widgets such as #GtkRecentChooserDialog or
/// #GtkRecentChooserMenu.
/// </para>
/// <para>
/// To construct a submenu showing recently used files, use a #GtkRecentAction
/// as the action for a `&amp;lt;menuitem&amp;gt;`. To construct a menu toolbutton showing
/// the recently used files in the popup menu, use a #GtkRecentAction as the
/// action for a `&amp;lt;toolitem&amp;gt;` element.
/// </para>
/// </summary>

public class GtkRecentActionHandle : GtkActionHandle, GtkBuildableHandle, GtkRecentChooserHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkRecentAction object. To add the action to
/// a #GtkActionGroup and set the accelerator for the action,
/// call gtk_action_group_add_action_with_accel().
/// </para>
/// </summary>

/// <param name="name">
/// a unique name for the action
/// </param>
/// <param name="label">
/// the label displayed in menu items and on buttons,
///   or %NULL
/// </param>
/// <param name="tooltip">
/// a tooltip for the action, or %NULL
/// </param>
/// <param name="stock_id">
/// the stock icon to display in widgets representing
///   the action, or %NULL
/// </param>
/// <return>
/// the newly created #GtkRecentAction.
/// </return>

	public static MentorLake.Gtk.GtkRecentActionHandle New(string name, string label, string tooltip, string stock_id)
	{
		return GtkRecentActionHandleExterns.gtk_recent_action_new(name, label, tooltip, stock_id);
	}

/// <summary>
/// <para>
/// Creates a new #GtkRecentAction object. To add the action to
/// a #GtkActionGroup and set the accelerator for the action,
/// call gtk_action_group_add_action_with_accel().
/// </para>
/// </summary>

/// <param name="name">
/// a unique name for the action
/// </param>
/// <param name="label">
/// the label displayed in menu items and on buttons,
///   or %NULL
/// </param>
/// <param name="tooltip">
/// a tooltip for the action, or %NULL
/// </param>
/// <param name="stock_id">
/// the stock icon to display in widgets representing
///   the action, or %NULL
/// </param>
/// <param name="manager">
/// a #GtkRecentManager, or %NULL for using the default
///   #GtkRecentManager
/// </param>
/// <return>
/// the newly created #GtkRecentAction
/// </return>

	public static MentorLake.Gtk.GtkRecentActionHandle NewForManager(string name, string label, string tooltip, string stock_id, MentorLake.Gtk.GtkRecentManagerHandle manager)
	{
		return GtkRecentActionHandleExterns.gtk_recent_action_new_for_manager(name, label, tooltip, stock_id, manager);
	}

}
public static class GtkRecentActionHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the user &quot;activates&quot; a recent item
/// in the recent chooser.  This can happen by double-clicking on an item
/// in the recently used resources list, or by pressing
/// `Enter`.
/// </para>
/// </summary>

	public static IObservable<GtkRecentActionHandleSignalStructs.ItemActivatedSignal> Signal_ItemActivated(this GtkRecentActionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentActionHandleSignalStructs.ItemActivatedSignal> obs) =>
		{
			GtkRecentActionHandleSignalDelegates.item_activated handler = ( MentorLake.Gtk.GtkRecentChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentActionHandleSignalStructs.ItemActivatedSignal()
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

	public static IObservable<GtkRecentActionHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this GtkRecentActionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRecentActionHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			GtkRecentActionHandleSignalDelegates.selection_changed handler = ( MentorLake.Gtk.GtkRecentChooserHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRecentActionHandleSignalStructs.SelectionChangedSignal()
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

public static class GtkRecentActionHandleSignalStructs
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

public static class GtkRecentActionHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the user &quot;activates&quot; a recent item
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


public static class GtkRecentActionHandleExtensions
{
/// <summary>
/// <para>
/// Returns the value set by gtk_recent_chooser_menu_set_show_numbers().
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkRecentAction
/// </param>
/// <return>
/// %TRUE if numbers should be shown.
/// </return>

	public static bool GetShowNumbers(this MentorLake.Gtk.GtkRecentActionHandle action)
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkRecentActionHandle)");
		return GtkRecentActionHandleExterns.gtk_recent_action_get_show_numbers(action);
	}

/// <summary>
/// <para>
/// Sets whether a number should be added to the items shown by the
/// widgets representing @action. The numbers are shown to provide
/// a unique character for a mnemonic to be used inside the menu item&apos;s
/// label. Only the first ten items get a number to avoid clashes.
/// </para>
/// </summary>

/// <param name="action">
/// a #GtkRecentAction
/// </param>
/// <param name="show_numbers">
/// %TRUE if the shown items should be numbered
/// </param>

	public static T SetShowNumbers<T>(this T action, bool show_numbers) where T : GtkRecentActionHandle
	{
		if (action.IsInvalid) throw new Exception("Invalid handle (GtkRecentActionHandle)");
		GtkRecentActionHandleExterns.gtk_recent_action_set_show_numbers(action, show_numbers);
		return action;
	}

}

internal class GtkRecentActionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRecentActionHandle>))]
	internal static extern MentorLake.Gtk.GtkRecentActionHandle gtk_recent_action_new(string name, string label, string tooltip, string stock_id);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRecentActionHandle>))]
	internal static extern MentorLake.Gtk.GtkRecentActionHandle gtk_recent_action_new_for_manager(string name, string label, string tooltip, string stock_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentManagerHandle>))] MentorLake.Gtk.GtkRecentManagerHandle manager);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_recent_action_get_show_numbers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentActionHandle>))] MentorLake.Gtk.GtkRecentActionHandle action);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_recent_action_set_show_numbers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRecentActionHandle>))] MentorLake.Gtk.GtkRecentActionHandle action, bool show_numbers);

}
