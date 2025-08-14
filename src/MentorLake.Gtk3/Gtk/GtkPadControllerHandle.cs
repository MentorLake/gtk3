namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkPadController is an event controller for the pads found in drawing
/// tablets (The collection of buttons and tactile sensors often found around
/// the stylus-sensitive area).
/// </para>
/// <para>
/// These buttons and sensors have no implicit meaning, and by default they
/// perform no action, this event controller is provided to map those to
/// #GAction objects, thus letting the application give those a more semantic
/// meaning.
/// </para>
/// <para>
/// Buttons and sensors are not constrained to triggering a single action, some
/// %GDK_SOURCE_TABLET_PAD devices feature multiple "modes", all these input
/// elements have one current mode, which may determine the final action
/// being triggered. Pad devices often divide buttons and sensors into groups,
/// all elements in a group share the same current mode, but different groups
/// may have different modes. See gdk_device_pad_get_n_groups() and
/// gdk_device_pad_get_group_n_modes().
/// </para>
/// <para>
/// Each of the actions that a given button/strip/ring performs for a given
/// mode is defined by #GtkPadActionEntry, it contains an action name that
/// will be looked up in the given #GActionGroup and activated whenever the
/// specified input element and mode are triggered.
/// </para>
/// <para>
/// A simple example of #GtkPadController usage, assigning button 1 in all
/// modes and pad devices to an "invert-selection" action:
/// |[
///   GtkPadActionEntry *pad_actions[] = {
///     { GTK_PAD_ACTION_BUTTON, 1, -1, "Invert selection", "pad-actions.invert-selection" },
///     …
///   };
/// </para>
/// <para>
///   …
///   action_group = g_simple_action_group_new ();
///   action = g_simple_action_new ("pad-actions.invert-selection", NULL);
///   g_signal_connect (action, "activate", on_invert_selection_activated, NULL);
///   g_action_map_add_action (G_ACTION_MAP (action_group), action);
///   …
///   pad_controller = gtk_pad_controller_new (window, action_group, NULL);
/// ]|
/// </para>
/// <para>
/// The actions belonging to rings/strips will be activated with a parameter
/// of type %G_VARIANT_TYPE_DOUBLE bearing the value of the given axis, it
/// is required that those are made stateful and accepting this #GVariantType.
/// </para>
/// </summary>

public class GtkPadControllerHandle : GtkEventControllerHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkPadController that will associate events from @pad to
/// actions. A %NULL pad may be provided so the controller manages all pad devices
/// generically, it is discouraged to mix #GtkPadController objects with %NULL
/// and non-%NULL @pad argument on the same @window, as execution order is not
/// guaranteed.
/// </para>
/// <para>
/// The #GtkPadController is created with no mapped actions. In order to map pad
/// events to actions, use gtk_pad_controller_set_action_entries() or
/// gtk_pad_controller_set_action().
/// </para>
/// </summary>

/// <param name="window">
/// a #GtkWindow
/// </param>
/// <param name="group">
/// #GActionGroup to trigger actions from
/// </param>
/// <param name="pad">
/// A %GDK_SOURCE_TABLET_PAD device, or %NULL to handle all pads
/// </param>
/// <return>
/// A newly created #GtkPadController
/// </return>

	public static MentorLake.Gtk.GtkPadControllerHandle New(MentorLake.Gtk.GtkWindowHandle window, MentorLake.Gio.GActionGroupHandle group, MentorLake.Gdk.GdkDeviceHandle pad)
	{
		return GtkPadControllerHandleExterns.gtk_pad_controller_new(window, group, pad);
	}

}

public static class GtkPadControllerHandleExtensions
{
/// <summary>
/// <para>
/// Adds an individual action to @controller. This action will only be activated
/// if the given button/ring/strip number in @index is interacted while
/// the current mode is @mode. -1 may be used for simple cases, so the action
/// is triggered on all modes.
/// </para>
/// <para>
/// The given @label should be considered user-visible, so internationalization
/// rules apply. Some windowing systems may be able to use those for user
/// feedback.
/// </para>
/// </summary>

/// <param name="controller">
/// a #GtkPadController
/// </param>
/// <param name="type">
/// the type of pad feature that will trigger this action
/// </param>
/// <param name="index">
/// the 0-indexed button/ring/strip number that will trigger this action
/// </param>
/// <param name="mode">
/// the mode that will trigger this action, or -1 for all modes.
/// </param>
/// <param name="label">
/// Human readable description of this action, this string should
///   be deemed user-visible.
/// </param>
/// <param name="action_name">
/// action name that will be activated in the #GActionGroup
/// </param>

	public static T SetAction<T>(this T controller, MentorLake.Gtk.GtkPadActionType type, int index, int mode, string label, string action_name) where T : GtkPadControllerHandle
	{
		if (controller.IsInvalid) throw new Exception("Invalid handle (GtkPadControllerHandle)");
		GtkPadControllerHandleExterns.gtk_pad_controller_set_action(controller, type, index, mode, label, action_name);
		return controller;
	}

/// <summary>
/// <para>
/// This is a convenience function to add a group of action entries on
/// @controller. See #GtkPadActionEntry and gtk_pad_controller_set_action().
/// </para>
/// </summary>

/// <param name="controller">
/// a #GtkPadController
/// </param>
/// <param name="entries">
/// the action entries to set on @controller
/// </param>
/// <param name="n_entries">
/// the number of elements in @entries
/// </param>

	public static T SetActionEntries<T>(this T controller, MentorLake.Gtk.GtkPadActionEntry[] entries, int n_entries) where T : GtkPadControllerHandle
	{
		if (controller.IsInvalid) throw new Exception("Invalid handle (GtkPadControllerHandle)");
		GtkPadControllerHandleExterns.gtk_pad_controller_set_action_entries(controller, entries, n_entries);
		return controller;
	}

}

internal class GtkPadControllerHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkPadControllerHandle>))]
	internal static extern MentorLake.Gtk.GtkPadControllerHandle gtk_pad_controller_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle window, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle group, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle pad);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_pad_controller_set_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPadControllerHandle>))] MentorLake.Gtk.GtkPadControllerHandle controller, MentorLake.Gtk.GtkPadActionType type, int index, int mode, string label, string action_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_pad_controller_set_action_entries([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPadControllerHandle>))] MentorLake.Gtk.GtkPadControllerHandle controller, MentorLake.Gtk.GtkPadActionEntry[] entries, int n_entries);

}
