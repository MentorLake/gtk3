namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A radio menu item is a check menu item that belongs to a group. At each
/// instant exactly one of the radio menu items from a group is selected.
/// </para>
/// <para>
/// The group list does not need to be freed, as each #GtkRadioMenuItem will
/// remove itself and its list item when it is destroyed.
/// </para>
/// <para>
/// The correct way to create a group of radio menu items is approximatively
/// this:
/// </para>
/// <para>
/// ## How to create a group of radio menu items.
/// </para>
/// <code>
/// GSList *group = NULL;
/// GSList *group = NULL;
/// GtkWidget *item;
/// gint i;
/// 
/// for (i = 0; i &amp;lt; 5; i++)
/// {
///   item = gtk_radio_menu_item_new_with_label (group, &quot;This is an example&quot;);
///   group = gtk_radio_menu_item_get_group (GTK_RADIO_MENU_ITEM (item));
///   if (i == 1)
///     gtk_check_menu_item_set_active (GTK_CHECK_MENU_ITEM (item), TRUE);
/// }
/// </code>
/// <para>
/// # CSS nodes
/// </para>
/// <code>
/// menuitem
/// menuitem
/// ├── radio.left
/// ╰── &amp;lt;child&amp;gt;
/// </code>
/// <para>
/// GtkRadioMenuItem has a main CSS node with name menuitem, and a subnode
/// with name radio, which gets the .left or .right style class.
/// </para>
/// </summary>

public class GtkRadioMenuItemHandle : GtkCheckMenuItemHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkRadioMenuItem.
/// </para>
/// </summary>

/// <param name="group">
/// the group to which the
///   radio menu item is to be attached, or %NULL
/// </param>
/// <return>
/// a new #GtkRadioMenuItem
/// </return>

	public static MentorLake.Gtk.GtkRadioMenuItemHandle New(MentorLake.GLib.GSListHandle group)
	{
		return GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_new(group);
	}

/// <summary>
/// <para>
/// Creates a new #GtkRadioMenuItem adding it to the same group as @group.
/// </para>
/// </summary>

/// <param name="group">
/// An existing #GtkRadioMenuItem
/// </param>
/// <return>
/// The new #GtkRadioMenuItem
/// </return>

	public static MentorLake.Gtk.GtkRadioMenuItemHandle NewFromWidget(MentorLake.Gtk.GtkRadioMenuItemHandle group)
	{
		return GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_new_from_widget(group);
	}

/// <summary>
/// <para>
/// Creates a new #GtkRadioMenuItem whose child is a simple #GtkLabel.
/// </para>
/// </summary>

/// <param name="group">
/// 
///         group the radio menu item is inside, or %NULL
/// </param>
/// <param name="label">
/// the text for the label
/// </param>
/// <return>
/// A new #GtkRadioMenuItem
/// </return>

	public static MentorLake.Gtk.GtkRadioMenuItemHandle NewWithLabel(MentorLake.GLib.GSListHandle group, string label)
	{
		return GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_new_with_label(group, label);
	}

/// <summary>
/// <para>
/// Creates a new GtkRadioMenuItem whose child is a simple GtkLabel.
/// The new #GtkRadioMenuItem is added to the same group as @group.
/// </para>
/// </summary>

/// <param name="group">
/// an existing #GtkRadioMenuItem
/// </param>
/// <param name="label">
/// the text for the label
/// </param>
/// <return>
/// The new #GtkRadioMenuItem
/// </return>

	public static MentorLake.Gtk.GtkRadioMenuItemHandle NewWithLabelFromWidget(MentorLake.Gtk.GtkRadioMenuItemHandle group, string label)
	{
		return GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_new_with_label_from_widget(group, label);
	}

/// <summary>
/// <para>
/// Creates a new #GtkRadioMenuItem containing a label. The label
/// will be created using gtk_label_new_with_mnemonic(), so underscores
/// in @label indicate the mnemonic for the menu item.
/// </para>
/// </summary>

/// <param name="group">
/// 
///         group the radio menu item is inside, or %NULL
/// </param>
/// <param name="label">
/// the text of the button, with an underscore in front of the
///         mnemonic character
/// </param>
/// <return>
/// a new #GtkRadioMenuItem
/// </return>

	public static MentorLake.Gtk.GtkRadioMenuItemHandle NewWithMnemonic(MentorLake.GLib.GSListHandle group, string label)
	{
		return GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_new_with_mnemonic(group, label);
	}

/// <summary>
/// <para>
/// Creates a new GtkRadioMenuItem containing a label. The label will be
/// created using gtk_label_new_with_mnemonic(), so underscores in label
/// indicate the mnemonic for the menu item.
/// </para>
/// <para>
/// The new #GtkRadioMenuItem is added to the same group as @group.
/// </para>
/// </summary>

/// <param name="group">
/// An existing #GtkRadioMenuItem
/// </param>
/// <param name="label">
/// the text of the button, with an underscore in front of the
///         mnemonic character
/// </param>
/// <return>
/// The new #GtkRadioMenuItem
/// </return>

	public static MentorLake.Gtk.GtkRadioMenuItemHandle NewWithMnemonicFromWidget(MentorLake.Gtk.GtkRadioMenuItemHandle group, string label)
	{
		return GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_new_with_mnemonic_from_widget(group, label);
	}

}
public static class GtkRadioMenuItemHandleSignalExtensions
{

	public static IObservable<GtkRadioMenuItemHandleSignalStructs.GroupChangedSignal> Signal_GroupChanged(this GtkRadioMenuItemHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRadioMenuItemHandleSignalStructs.GroupChangedSignal> obs) =>
		{
			GtkRadioMenuItemHandleSignalDelegates.group_changed handler = ( MentorLake.Gtk.GtkRadioMenuItemHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRadioMenuItemHandleSignalStructs.GroupChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "group-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkRadioMenuItemHandleSignalStructs
{

public class GroupChangedSignal
{

	public MentorLake.Gtk.GtkRadioMenuItemHandle Self;

	public IntPtr UserData;
}
}

public static class GtkRadioMenuItemHandleSignalDelegates
{


/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void group_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))] MentorLake.Gtk.GtkRadioMenuItemHandle self, IntPtr user_data);

}


public static class GtkRadioMenuItemHandleExtensions
{
/// <summary>
/// <para>
/// Returns the group to which the radio menu item belongs, as a #GList of
/// #GtkRadioMenuItem. The list belongs to GTK+ and should not be freed.
/// </para>
/// </summary>

/// <param name="radio_menu_item">
/// a #GtkRadioMenuItem
/// </param>
/// <return>
/// the group
///     of @radio_menu_item
/// </return>

	public static MentorLake.GLib.GSListHandle GetGroup(this MentorLake.Gtk.GtkRadioMenuItemHandle radio_menu_item)
	{
		if (radio_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkRadioMenuItemHandle)");
		return GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_get_group(radio_menu_item);
	}

/// <summary>
/// <para>
/// Joins a #GtkRadioMenuItem object to the group of another #GtkRadioMenuItem
/// object.
/// </para>
/// <para>
/// This function should be used by language bindings to avoid the memory
/// manangement of the opaque #GSList of gtk_radio_menu_item_get_group()
/// and gtk_radio_menu_item_set_group().
/// </para>
/// <para>
/// A common way to set up a group of #GtkRadioMenuItem instances is:
/// </para>
/// <code>
///   GtkRadioMenuItem *last_item = NULL;
///   GtkRadioMenuItem *last_item = NULL;
/// 
///   while ( ...more items to add... )
///     {
///       GtkRadioMenuItem *radio_item;
/// 
///       radio_item = gtk_radio_menu_item_new (...);
/// 
///       gtk_radio_menu_item_join_group (radio_item, last_item);
///       last_item = radio_item;
///     }
/// </code>
/// </summary>

/// <param name="radio_menu_item">
/// a #GtkRadioMenuItem
/// </param>
/// <param name="group_source">
/// a #GtkRadioMenuItem whose group we are
///   joining, or %NULL to remove the @radio_menu_item from its current
///   group
/// </param>

	public static T JoinGroup<T>(this T radio_menu_item, MentorLake.Gtk.GtkRadioMenuItemHandle group_source) where T : GtkRadioMenuItemHandle
	{
		if (radio_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkRadioMenuItemHandle)");
		GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_join_group(radio_menu_item, group_source);
		return radio_menu_item;
	}

/// <summary>
/// <para>
/// Sets the group of a radio menu item, or changes it.
/// </para>
/// </summary>

/// <param name="radio_menu_item">
/// a #GtkRadioMenuItem.
/// </param>
/// <param name="group">
/// the new group, or %NULL.
/// </param>

	public static T SetGroup<T>(this T radio_menu_item, MentorLake.GLib.GSListHandle group) where T : GtkRadioMenuItemHandle
	{
		if (radio_menu_item.IsInvalid) throw new Exception("Invalid handle (GtkRadioMenuItemHandle)");
		GtkRadioMenuItemHandleExterns.gtk_radio_menu_item_set_group(radio_menu_item, group);
		return radio_menu_item;
	}

}

internal class GtkRadioMenuItemHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioMenuItemHandle gtk_radio_menu_item_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioMenuItemHandle gtk_radio_menu_item_new_from_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))] MentorLake.Gtk.GtkRadioMenuItemHandle group);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioMenuItemHandle gtk_radio_menu_item_new_with_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group, string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioMenuItemHandle gtk_radio_menu_item_new_with_label_from_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))] MentorLake.Gtk.GtkRadioMenuItemHandle group, string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioMenuItemHandle gtk_radio_menu_item_new_with_mnemonic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group, string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioMenuItemHandle gtk_radio_menu_item_new_with_mnemonic_from_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))] MentorLake.Gtk.GtkRadioMenuItemHandle group, string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_radio_menu_item_get_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))] MentorLake.Gtk.GtkRadioMenuItemHandle radio_menu_item);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_radio_menu_item_join_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))] MentorLake.Gtk.GtkRadioMenuItemHandle radio_menu_item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))] MentorLake.Gtk.GtkRadioMenuItemHandle group_source);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_radio_menu_item_set_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioMenuItemHandle>))] MentorLake.Gtk.GtkRadioMenuItemHandle radio_menu_item, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group);

}
