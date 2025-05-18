namespace MentorLake.Gio;

public class GNotificationHandle : GObjectHandle
{
	public static MentorLake.Gio.GNotificationHandle New(string title)
	{
		return GNotificationHandleExterns.g_notification_new(title);
	}

}

public static class GNotificationHandleExtensions
{
	public static T AddButton<T>(this T notification, string label, string detailed_action) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_add_button(notification, label, detailed_action);
		return notification;
	}

	public static T AddButtonWithTarget<T>(this T notification, string label, string action, string target_format, IntPtr @__arglist) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_add_button_with_target(notification, label, action, target_format, @__arglist);
		return notification;
	}

	public static T AddButtonWithTargetValue<T>(this T notification, string label, string action, MentorLake.GLib.GVariantHandle target) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_add_button_with_target_value(notification, label, action, target);
		return notification;
	}

	public static T SetBody<T>(this T notification, string body) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_body(notification, body);
		return notification;
	}

	public static T SetCategory<T>(this T notification, string category) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_category(notification, category);
		return notification;
	}

	public static T SetDefaultAction<T>(this T notification, string detailed_action) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_default_action(notification, detailed_action);
		return notification;
	}

	public static T SetDefaultActionAndTarget<T>(this T notification, string action, string target_format, IntPtr @__arglist) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_default_action_and_target(notification, action, target_format, @__arglist);
		return notification;
	}

	public static T SetDefaultActionAndTargetValue<T>(this T notification, string action, MentorLake.GLib.GVariantHandle target) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_default_action_and_target_value(notification, action, target);
		return notification;
	}

	public static T SetIcon<T>(this T notification, MentorLake.Gio.GIconHandle icon) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_icon(notification, icon);
		return notification;
	}

	public static T SetPriority<T>(this T notification, MentorLake.Gio.GNotificationPriority priority) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_priority(notification, priority);
		return notification;
	}

	public static T SetTitle<T>(this T notification, string title) where T : GNotificationHandle
	{
		if (notification.IsInvalid) throw new Exception("Invalid handle (GNotificationHandle)");
		GNotificationHandleExterns.g_notification_set_title(notification, title);
		return notification;
	}

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
