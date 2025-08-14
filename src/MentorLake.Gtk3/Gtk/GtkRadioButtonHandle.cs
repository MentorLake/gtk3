namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// A single radio button performs the same basic function as a #GtkCheckButton,
/// as its position in the object hierarchy reflects. It is only when multiple
/// radio buttons are grouped together that they become a different user
/// interface component in their own right.
/// </para>
/// <para>
/// Every radio button is a member of some group of radio buttons. When one is
/// selected, all other radio buttons in the same group are deselected. A
/// #GtkRadioButton is one way of giving the user a choice from many options.
/// </para>
/// <para>
/// Radio button widgets are created with gtk_radio_button_new(), passing %NULL
/// as the argument if this is the first radio button in a group. In subsequent
/// calls, the group you wish to add this button to should be passed as an
/// argument. Optionally, gtk_radio_button_new_with_label() can be used if you
/// want a text label on the radio button.
/// </para>
/// <para>
/// Alternatively, when adding widgets to an existing group of radio buttons,
/// use gtk_radio_button_new_from_widget() with a #GtkRadioButton that already
/// has a group assigned to it. The convenience function
/// gtk_radio_button_new_with_label_from_widget() is also provided.
/// </para>
/// <para>
/// To retrieve the group a #GtkRadioButton is assigned to, use
/// gtk_radio_button_get_group().
/// </para>
/// <para>
/// To remove a #GtkRadioButton from one group and make it part of a new one,
/// use gtk_radio_button_set_group().
/// </para>
/// <para>
/// The group list does not need to be freed, as each #GtkRadioButton will remove
/// itself and its list item when it is destroyed.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// |[<!-- language="plain" -->
/// radiobutton
/// ├── radio
/// ╰── <child>
/// ]|
/// </para>
/// <para>
/// A GtkRadioButton with indicator (see gtk_toggle_button_set_mode()) has a
/// main CSS node with name radiobutton and a subnode with name radio.
/// </para>
/// <para>
/// |[<!-- language="plain" -->
/// button.radio
/// ├── radio
/// ╰── <child>
/// ]|
/// </para>
/// <para>
/// A GtkRadioButton without indicator changes the name of its main node
/// to button and adds a .radio style class to it. The subnode is invisible
/// in this case.
/// </para>
/// <para>
/// ## How to create a group of two radio buttons.
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// void create_radio_buttons (void) {
/// </para>
/// <para>
///    GtkWidget *window, *radio1, *radio2, *box, *entry;
///    window = gtk_window_new (GTK_WINDOW_TOPLEVEL);
///    box = gtk_box_new (GTK_ORIENTATION_VERTICAL, 2);
///    gtk_box_set_homogeneous (GTK_BOX (box), TRUE);
/// </para>
/// <para>
///    // Create a radio button with a GtkEntry widget
///    radio1 = gtk_radio_button_new (NULL);
///    entry = gtk_entry_new ();
///    gtk_container_add (GTK_CONTAINER (radio1), entry);
/// </para>
/// <para>
/// </para>
/// <para>
///    // Create a radio button with a label
///    radio2 = gtk_radio_button_new_with_label_from_widget (GTK_RADIO_BUTTON (radio1),
///                                                          "I’m the second radio button.");
/// </para>
/// <para>
///    // Pack them into a box, then show all the widgets
///    gtk_box_pack_start (GTK_BOX (box), radio1);
///    gtk_box_pack_start (GTK_BOX (box), radio2);
///    gtk_container_add (GTK_CONTAINER (window), box);
///    gtk_widget_show_all (window);
///    return;
/// }
/// ]|
/// </para>
/// <para>
/// When an unselected button in the group is clicked the clicked button
/// receives the #GtkToggleButton::toggled signal, as does the previously
/// selected button.
/// Inside the #GtkToggleButton::toggled handler, gtk_toggle_button_get_active()
/// can be used to determine if the button has been selected or deselected.
/// </para>
/// </summary>

public class GtkRadioButtonHandle : GtkCheckButtonHandle, AtkImplementorIfaceHandle, GtkActionableHandle, GtkActivatableHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkRadioButton. To be of any practical value, a widget should
/// then be packed into the radio button.
/// </para>
/// </summary>

/// <param name="group">
/// an existing
///         radio button group, or %NULL if you are creating a new group.
/// </param>
/// <return>
/// a new radio button
/// </return>

	public static MentorLake.Gtk.GtkRadioButtonHandle New(MentorLake.GLib.GSListHandle group)
	{
		return GtkRadioButtonHandleExterns.gtk_radio_button_new(group);
	}

/// <summary>
/// <para>
/// Creates a new #GtkRadioButton, adding it to the same group as
/// @radio_group_member. As with gtk_radio_button_new(), a widget
/// should be packed into the radio button.
/// </para>
/// </summary>

/// <param name="radio_group_member">
/// an existing #GtkRadioButton.
/// </param>
/// <return>
/// a new radio button.
/// </return>

	public static MentorLake.Gtk.GtkRadioButtonHandle NewFromWidget(MentorLake.Gtk.GtkRadioButtonHandle radio_group_member)
	{
		return GtkRadioButtonHandleExterns.gtk_radio_button_new_from_widget(radio_group_member);
	}

/// <summary>
/// <para>
/// Creates a new #GtkRadioButton with a text label.
/// </para>
/// </summary>

/// <param name="group">
/// an existing
///         radio button group, or %NULL if you are creating a new group.
/// </param>
/// <param name="label">
/// the text label to display next to the radio button.
/// </param>
/// <return>
/// a new radio button.
/// </return>

	public static MentorLake.Gtk.GtkRadioButtonHandle NewWithLabel(MentorLake.GLib.GSListHandle group, string label)
	{
		return GtkRadioButtonHandleExterns.gtk_radio_button_new_with_label(group, label);
	}

/// <summary>
/// <para>
/// Creates a new #GtkRadioButton with a text label, adding it to
/// the same group as @radio_group_member.
/// </para>
/// </summary>

/// <param name="radio_group_member">
/// widget to get radio group from or %NULL
/// </param>
/// <param name="label">
/// a text string to display next to the radio button.
/// </param>
/// <return>
/// a new radio button.
/// </return>

	public static MentorLake.Gtk.GtkRadioButtonHandle NewWithLabelFromWidget(MentorLake.Gtk.GtkRadioButtonHandle radio_group_member, string label)
	{
		return GtkRadioButtonHandleExterns.gtk_radio_button_new_with_label_from_widget(radio_group_member, label);
	}

/// <summary>
/// <para>
/// Creates a new #GtkRadioButton containing a label, adding it to the same
/// group as @group. The label will be created using
/// gtk_label_new_with_mnemonic(), so underscores in @label indicate the
/// mnemonic for the button.
/// </para>
/// </summary>

/// <param name="group">
/// the radio button
///         group, or %NULL
/// </param>
/// <param name="label">
/// the text of the button, with an underscore in front of the
///         mnemonic character
/// </param>
/// <return>
/// a new #GtkRadioButton
/// </return>

	public static MentorLake.Gtk.GtkRadioButtonHandle NewWithMnemonic(MentorLake.GLib.GSListHandle group, string label)
	{
		return GtkRadioButtonHandleExterns.gtk_radio_button_new_with_mnemonic(group, label);
	}

/// <summary>
/// <para>
/// Creates a new #GtkRadioButton containing a label. The label
/// will be created using gtk_label_new_with_mnemonic(), so underscores
/// in @label indicate the mnemonic for the button.
/// </para>
/// </summary>

/// <param name="radio_group_member">
/// widget to get radio group from or %NULL
/// </param>
/// <param name="label">
/// the text of the button, with an underscore in front of the
///         mnemonic character
/// </param>
/// <return>
/// a new #GtkRadioButton
/// </return>

	public static MentorLake.Gtk.GtkRadioButtonHandle NewWithMnemonicFromWidget(MentorLake.Gtk.GtkRadioButtonHandle radio_group_member, string label)
	{
		return GtkRadioButtonHandleExterns.gtk_radio_button_new_with_mnemonic_from_widget(radio_group_member, label);
	}

}
public static class GtkRadioButtonHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when the group of radio buttons that a radio button belongs
/// to changes. This is emitted when a radio button switches from
/// being alone to being part of a group of 2 or more buttons, or
/// vice-versa, and when a button is moved from one group of 2 or
/// more buttons to a different one, but not when the composition
/// of the group that a button belongs to changes.
/// </para>
/// </summary>

	public static IObservable<GtkRadioButtonHandleSignalStructs.GroupChangedSignal> Signal_GroupChanged(this GtkRadioButtonHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkRadioButtonHandleSignalStructs.GroupChangedSignal> obs) =>
		{
			GtkRadioButtonHandleSignalDelegates.group_changed handler = ( MentorLake.Gtk.GtkRadioButtonHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkRadioButtonHandleSignalStructs.GroupChangedSignal()
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

public static class GtkRadioButtonHandleSignalStructs
{

public class GroupChangedSignal
{

	public MentorLake.Gtk.GtkRadioButtonHandle Self;

	public IntPtr UserData;
}
}

public static class GtkRadioButtonHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when the group of radio buttons that a radio button belongs
/// to changes. This is emitted when a radio button switches from
/// being alone to being part of a group of 2 or more buttons, or
/// vice-versa, and when a button is moved from one group of 2 or
/// more buttons to a different one, but not when the composition
/// of the group that a button belongs to changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void group_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))] MentorLake.Gtk.GtkRadioButtonHandle self, IntPtr user_data);

}


public static class GtkRadioButtonHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the group assigned to a radio button.
/// </para>
/// </summary>

/// <param name="radio_button">
/// a #GtkRadioButton.
/// </param>
/// <return>
/// a linked list
/// containing all the radio buttons in the same group
/// as @radio_button. The returned list is owned by the radio button
/// and must not be modified or freed.
/// </return>

	public static MentorLake.GLib.GSListHandle GetGroup(this MentorLake.Gtk.GtkRadioButtonHandle radio_button)
	{
		if (radio_button.IsInvalid) throw new Exception("Invalid handle (GtkRadioButtonHandle)");
		return GtkRadioButtonHandleExterns.gtk_radio_button_get_group(radio_button);
	}

/// <summary>
/// <para>
/// Joins a #GtkRadioButton object to the group of another #GtkRadioButton object
/// </para>
/// <para>
/// Use this in language bindings instead of the gtk_radio_button_get_group()
/// and gtk_radio_button_set_group() methods
/// </para>
/// <para>
/// A common way to set up a group of radio buttons is the following:
/// |[<!-- language="C" -->
///   GtkRadioButton *radio_button;
///   GtkRadioButton *last_button;
/// </para>
/// <para>
///   while (some_condition)
///     {
///        radio_button = gtk_radio_button_new (NULL);
/// </para>
/// <para>
///        gtk_radio_button_join_group (radio_button, last_button);
///        last_button = radio_button;
///     }
/// ]|
/// </para>
/// </summary>

/// <param name="radio_button">
/// the #GtkRadioButton object
/// </param>
/// <param name="group_source">
/// a radio button object whos group we are
///   joining, or %NULL to remove the radio button from its group
/// </param>

	public static T JoinGroup<T>(this T radio_button, MentorLake.Gtk.GtkRadioButtonHandle group_source) where T : GtkRadioButtonHandle
	{
		if (radio_button.IsInvalid) throw new Exception("Invalid handle (GtkRadioButtonHandle)");
		GtkRadioButtonHandleExterns.gtk_radio_button_join_group(radio_button, group_source);
		return radio_button;
	}

/// <summary>
/// <para>
/// Sets a #GtkRadioButton’s group. It should be noted that this does not change
/// the layout of your interface in any way, so if you are changing the group,
/// it is likely you will need to re-arrange the user interface to reflect these
/// changes.
/// </para>
/// </summary>

/// <param name="radio_button">
/// a #GtkRadioButton.
/// </param>
/// <param name="group">
/// an existing radio
///     button group, such as one returned from gtk_radio_button_get_group(), or %NULL.
/// </param>

	public static T SetGroup<T>(this T radio_button, MentorLake.GLib.GSListHandle group) where T : GtkRadioButtonHandle
	{
		if (radio_button.IsInvalid) throw new Exception("Invalid handle (GtkRadioButtonHandle)");
		GtkRadioButtonHandleExterns.gtk_radio_button_set_group(radio_button, group);
		return radio_button;
	}

}

internal class GtkRadioButtonHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioButtonHandle gtk_radio_button_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioButtonHandle gtk_radio_button_new_from_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))] MentorLake.Gtk.GtkRadioButtonHandle radio_group_member);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioButtonHandle gtk_radio_button_new_with_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group, string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioButtonHandle gtk_radio_button_new_with_label_from_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))] MentorLake.Gtk.GtkRadioButtonHandle radio_group_member, string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioButtonHandle gtk_radio_button_new_with_mnemonic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group, string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))]
	internal static extern MentorLake.Gtk.GtkRadioButtonHandle gtk_radio_button_new_with_mnemonic_from_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))] MentorLake.Gtk.GtkRadioButtonHandle radio_group_member, string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle gtk_radio_button_get_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))] MentorLake.Gtk.GtkRadioButtonHandle radio_button);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_radio_button_join_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))] MentorLake.Gtk.GtkRadioButtonHandle radio_button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))] MentorLake.Gtk.GtkRadioButtonHandle group_source);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_radio_button_set_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRadioButtonHandle>))] MentorLake.Gtk.GtkRadioButtonHandle radio_button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle group);

}
