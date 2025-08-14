namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GNotification` is a mechanism for creating a notification to be shown
/// to the user — typically as a pop-up notification presented by the
/// desktop environment shell.
/// </para>
/// <para>
/// The key difference between `GNotification` and other similar APIs is
/// that, if supported by the desktop environment, notifications sent
/// with `GNotification` will persist after the application has exited,
/// and even across system reboots.
/// </para>
/// <para>
/// Since the user may click on a notification while the application is
/// not running, applications using `GNotification` should be able to be
/// started as a D-Bus service, using [class@Gio.Application].
/// </para>
/// <para>
/// In order for `GNotification` to work, the application must have installed
/// a `.desktop` file. For example:
/// ```
/// [Desktop Entry]
/// Name=Test Application
/// Comment=Description of what Test Application does
/// Exec=gnome-test-application
/// Icon=org.gnome.TestApplication
/// Terminal=false
/// Type=Application
/// Categories=GNOME;GTK;TestApplication Category;
/// StartupNotify=true
/// DBusActivatable=true
/// X-GNOME-UsesNotifications=true
/// ```
/// </para>
/// <para>
/// The `X-GNOME-UsesNotifications` key indicates to GNOME Control Center
/// that this application uses notifications, so it can be listed in the
/// Control Center’s ‘Notifications’ panel.
/// </para>
/// <para>
/// The `.desktop` file must be named as `org.gnome.TestApplication.desktop`,
/// where `org.gnome.TestApplication` is the ID passed to
/// [ctor@Gio.Application.new].
/// </para>
/// <para>
/// User interaction with a notification (either the default action, or
/// buttons) must be associated with actions on the application (ie:
/// `app.` actions).  It is not possible to route user interaction
/// through the notification itself, because the object will not exist if
/// the application is autostarted as a result of a notification being
/// clicked.
/// </para>
/// <para>
/// A notification can be sent with [method@Gio.Application.send_notification].
/// </para>
/// </summary>

public class GNotificationHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GNotification with @title as its title.
/// </para>
/// <para>
/// After populating @notification with more details, it can be sent to
/// the desktop shell with g_application_send_notification(). Changing
/// any properties after this call will not have any effect until
/// resending @notification.
/// </para>
/// </summary>

/// <param name="title">
/// the title of the notification
/// </param>
/// <return>
/// a new #GNotification instance
/// </return>

	public static MentorLake.Gio.GNotificationHandle New(string title)
	{
		return GNotificationHandleExterns.g_notification_new(title);
	}

}

public static class GNotificationHandleExtensions
{
/// <summary>
/// <para>
/// Adds a button to @notification that activates the action in
/// @detailed_action when clicked. That action must be an
/// application-wide action (starting with "app."). If @detailed_action
/// contains a target, the action will be activated with that target as
/// its parameter.
/// </para>
/// <para>
/// See g_action_parse_detailed_name() for a description of the format
/// for @detailed_action.
/// </para>
/// </summary>

/// <param name="notification">
/// a #GNotification
/// </param>
/// <param name="label">
/// label of the button
/// </param>
/// <param name="detailed_action">
/// a detailed action name
/// </param>

	public static T AddButton<T>(this T notification, string label, string detailed_action) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_add_button(notification, label, detailed_action);
		return notification;
	}

/// <summary>
/// <para>
/// Adds a button to @notification that activates @action when clicked.
/// @action must be an application-wide action (it must start with "app.").
/// </para>
/// <para>
/// If @target_format is given, it is used to collect remaining
/// positional parameters into a #GVariant instance, similar to
/// g_variant_new(). @action will be activated with that #GVariant as its
/// parameter.
/// </para>
/// </summary>

/// <param name="notification">
/// a #GNotification
/// </param>
/// <param name="label">
/// label of the button
/// </param>
/// <param name="action">
/// an action name
/// </param>
/// <param name="target_format">
/// a #GVariant format string, or %NULL
/// </param>
/// <param name="@__arglist">
/// positional parameters, as determined by @target_format
/// </param>

	public static T AddButtonWithTarget<T>(this T notification, string label, string action, string target_format, IntPtr @__arglist) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_add_button_with_target(notification, label, action, target_format, @__arglist);
		return notification;
	}

/// <summary>
/// <para>
/// Adds a button to @notification that activates @action when clicked.
/// @action must be an application-wide action (it must start with "app.").
/// </para>
/// <para>
/// If @target is non-%NULL, @action will be activated with @target as
/// its parameter.
/// </para>
/// </summary>

/// <param name="notification">
/// a #GNotification
/// </param>
/// <param name="label">
/// label of the button
/// </param>
/// <param name="action">
/// an action name
/// </param>
/// <param name="target">
/// a #GVariant to use as @action's parameter, or %NULL
/// </param>

	public static T AddButtonWithTargetValue<T>(this T notification, string label, string action, MentorLake.GLib.GVariantHandle target) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_add_button_with_target_value(notification, label, action, target);
		return notification;
	}

/// <summary>
/// <para>
/// Sets the body of @notification to @body.
/// </para>
/// </summary>

/// <param name="notification">
/// a #GNotification
/// </param>
/// <param name="body">
/// the new body for @notification, or %NULL
/// </param>

	public static T SetBody<T>(this T notification, string body) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_body(notification, body);
		return notification;
	}

/// <summary>
/// <para>
/// Sets the type of @notification to @category. Categories have a main
/// type like `email`, `im` or `device` and can have a detail separated
/// by a `.`, e.g. `im.received` or `email.arrived`. Setting the category
/// helps the notification server to select proper feedback to the user.
/// </para>
/// <para>
/// Standard categories are [listed in the specification](https://specifications.freedesktop.org/notification-spec/latest/ar01s06.html).
/// </para>
/// </summary>

/// <param name="notification">
/// a #GNotification
/// </param>
/// <param name="category">
/// the category for @notification, or %NULL for no category
/// </param>

	public static T SetCategory<T>(this T notification, string category) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_category(notification, category);
		return notification;
	}

/// <summary>
/// <para>
/// Sets the default action of @notification to @detailed_action. This
/// action is activated when the notification is clicked on.
/// </para>
/// <para>
/// The action in @detailed_action must be an application-wide action (it
/// must start with "app."). If @detailed_action contains a target, the
/// given action will be activated with that target as its parameter.
/// See g_action_parse_detailed_name() for a description of the format
/// for @detailed_action.
/// </para>
/// <para>
/// When no default action is set, the application that the notification
/// was sent on is activated.
/// </para>
/// </summary>

/// <param name="notification">
/// a #GNotification
/// </param>
/// <param name="detailed_action">
/// a detailed action name
/// </param>

	public static T SetDefaultAction<T>(this T notification, string detailed_action) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_default_action(notification, detailed_action);
		return notification;
	}

/// <summary>
/// <para>
/// Sets the default action of @notification to @action. This action is
/// activated when the notification is clicked on. It must be an
/// application-wide action (it must start with "app.").
/// </para>
/// <para>
/// If @target_format is given, it is used to collect remaining
/// positional parameters into a #GVariant instance, similar to
/// g_variant_new(). @action will be activated with that #GVariant as its
/// parameter.
/// </para>
/// <para>
/// When no default action is set, the application that the notification
/// was sent on is activated.
/// </para>
/// </summary>

/// <param name="notification">
/// a #GNotification
/// </param>
/// <param name="action">
/// an action name
/// </param>
/// <param name="target_format">
/// a #GVariant format string, or %NULL
/// </param>
/// <param name="@__arglist">
/// positional parameters, as determined by @target_format
/// </param>

	public static T SetDefaultActionAndTarget<T>(this T notification, string action, string target_format, IntPtr @__arglist) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_default_action_and_target(notification, action, target_format, @__arglist);
		return notification;
	}

/// <summary>
/// <para>
/// Sets the default action of @notification to @action. This action is
/// activated when the notification is clicked on. It must be an
/// application-wide action (start with "app.").
/// </para>
/// <para>
/// If @target is non-%NULL, @action will be activated with @target as
/// its parameter. If @target is floating, it will be consumed.
/// </para>
/// <para>
/// When no default action is set, the application that the notification
/// was sent on is activated.
/// </para>
/// </summary>

/// <param name="notification">
/// a #GNotification
/// </param>
/// <param name="action">
/// an action name
/// </param>
/// <param name="target">
/// a #GVariant to use as @action's parameter, or %NULL
/// </param>

	public static T SetDefaultActionAndTargetValue<T>(this T notification, string action, MentorLake.GLib.GVariantHandle target) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_default_action_and_target_value(notification, action, target);
		return notification;
	}

/// <summary>
/// <para>
/// Sets the icon of @notification to @icon.
/// </para>
/// </summary>

/// <param name="notification">
/// a #GNotification
/// </param>
/// <param name="icon">
/// the icon to be shown in @notification, as a #GIcon
/// </param>

	public static T SetIcon<T>(this T notification, MentorLake.Gio.GIconHandle icon) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_icon(notification, icon);
		return notification;
	}

/// <summary>
/// <para>
/// Sets the priority of @notification to @priority. See
/// #GNotificationPriority for possible values.
/// </para>
/// </summary>

/// <param name="notification">
/// a #GNotification
/// </param>
/// <param name="priority">
/// a #GNotificationPriority
/// </param>

	public static T SetPriority<T>(this T notification, MentorLake.Gio.GNotificationPriority priority) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_priority(notification, priority);
		return notification;
	}

/// <summary>
/// <para>
/// Sets the title of @notification to @title.
/// </para>
/// </summary>

/// <param name="notification">
/// a #GNotification
/// </param>
/// <param name="title">
/// the new title for @notification
/// </param>

	public static T SetTitle<T>(this T notification, string title) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_title(notification, title);
		return notification;
	}

/// <summary>
/// <para>
/// Deprecated in favor of g_notification_set_priority().
/// </para>
/// </summary>

/// <param name="notification">
/// a #GNotification
/// </param>
/// <param name="urgent">
/// %TRUE if @notification is urgent
/// </param>

	public static T SetUrgent<T>(this T notification, bool urgent) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_urgent(notification, urgent);
		return notification;
	}

}

internal class GNotificationHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GNotificationHandle>))]
	internal static extern MentorLake.Gio.GNotificationHandle g_notification_new(string title);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_notification_add_button([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNotificationHandle>))] MentorLake.Gio.GNotificationHandle notification, string label, string detailed_action);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_notification_add_button_with_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNotificationHandle>))] MentorLake.Gio.GNotificationHandle notification, string label, string action, string target_format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_notification_add_button_with_target_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNotificationHandle>))] MentorLake.Gio.GNotificationHandle notification, string label, string action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle target);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_notification_set_body([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNotificationHandle>))] MentorLake.Gio.GNotificationHandle notification, string body);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_notification_set_category([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNotificationHandle>))] MentorLake.Gio.GNotificationHandle notification, string category);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_notification_set_default_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNotificationHandle>))] MentorLake.Gio.GNotificationHandle notification, string detailed_action);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_notification_set_default_action_and_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNotificationHandle>))] MentorLake.Gio.GNotificationHandle notification, string action, string target_format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_notification_set_default_action_and_target_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNotificationHandle>))] MentorLake.Gio.GNotificationHandle notification, string action, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle target);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_notification_set_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNotificationHandle>))] MentorLake.Gio.GNotificationHandle notification, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_notification_set_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNotificationHandle>))] MentorLake.Gio.GNotificationHandle notification, MentorLake.Gio.GNotificationPriority priority);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_notification_set_title([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNotificationHandle>))] MentorLake.Gio.GNotificationHandle notification, string title);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_notification_set_urgent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GNotificationHandle>))] MentorLake.Gio.GNotificationHandle notification, bool urgent);

}
