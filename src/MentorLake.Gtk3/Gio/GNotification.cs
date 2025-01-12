namespace MentorLake.Gtk3.Gio;

public class GNotificationHandle : GObjectHandle
{
	public static GNotificationHandle New(string title)
	{
		return GNotificationExterns.g_notification_new(title);
	}

}

public static class GNotificationHandleExtensions
{
	public static T AddButton<T>(this T notification, string label, string detailed_action) where T : GNotificationHandle
	{
		GNotificationExterns.g_notification_add_button(notification, label, detailed_action);
		return notification;
	}

	public static T AddButtonWithTarget<T>(this T notification, string label, string action, string target_format, IntPtr @__arglist) where T : GNotificationHandle
	{
		GNotificationExterns.g_notification_add_button_with_target(notification, label, action, target_format, @__arglist);
		return notification;
	}

	public static T AddButtonWithTargetValue<T>(this T notification, string label, string action, GVariantHandle target) where T : GNotificationHandle
	{
		GNotificationExterns.g_notification_add_button_with_target_value(notification, label, action, target);
		return notification;
	}

	public static T SetBody<T>(this T notification, string body) where T : GNotificationHandle
	{
		GNotificationExterns.g_notification_set_body(notification, body);
		return notification;
	}

	public static T SetCategory<T>(this T notification, string category) where T : GNotificationHandle
	{
		GNotificationExterns.g_notification_set_category(notification, category);
		return notification;
	}

	public static T SetDefaultAction<T>(this T notification, string detailed_action) where T : GNotificationHandle
	{
		GNotificationExterns.g_notification_set_default_action(notification, detailed_action);
		return notification;
	}

	public static T SetDefaultActionAndTarget<T>(this T notification, string action, string target_format, IntPtr @__arglist) where T : GNotificationHandle
	{
		GNotificationExterns.g_notification_set_default_action_and_target(notification, action, target_format, @__arglist);
		return notification;
	}

	public static T SetDefaultActionAndTargetValue<T>(this T notification, string action, GVariantHandle target) where T : GNotificationHandle
	{
		GNotificationExterns.g_notification_set_default_action_and_target_value(notification, action, target);
		return notification;
	}

	public static T SetIcon<T>(this T notification, GIconHandle icon) where T : GNotificationHandle
	{
		GNotificationExterns.g_notification_set_icon(notification, icon);
		return notification;
	}

	public static T SetPriority<T>(this T notification, GNotificationPriority priority) where T : GNotificationHandle
	{
		GNotificationExterns.g_notification_set_priority(notification, priority);
		return notification;
	}

	public static T SetTitle<T>(this T notification, string title) where T : GNotificationHandle
	{
		GNotificationExterns.g_notification_set_title(notification, title);
		return notification;
	}

	public static T SetUrgent<T>(this T notification, bool urgent) where T : GNotificationHandle
	{
		GNotificationExterns.g_notification_set_urgent(notification, urgent);
		return notification;
	}

}

internal class GNotificationExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GNotificationHandle g_notification_new(string title);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_add_button(GNotificationHandle notification, string label, string detailed_action);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_add_button_with_target(GNotificationHandle notification, string label, string action, string target_format, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_add_button_with_target_value(GNotificationHandle notification, string label, string action, GVariantHandle target);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_body(GNotificationHandle notification, string body);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_category(GNotificationHandle notification, string category);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_default_action(GNotificationHandle notification, string detailed_action);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_default_action_and_target(GNotificationHandle notification, string action, string target_format, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_default_action_and_target_value(GNotificationHandle notification, string action, GVariantHandle target);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_icon(GNotificationHandle notification, GIconHandle icon);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_priority(GNotificationHandle notification, GNotificationPriority priority);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_title(GNotificationHandle notification, string title);

	[DllImport(Libraries.Gio)]
	internal static extern void g_notification_set_urgent(GNotificationHandle notification, bool urgent);

}
