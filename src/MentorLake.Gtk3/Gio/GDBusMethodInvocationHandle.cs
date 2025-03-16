namespace MentorLake.Gio;

public class GDBusMethodInvocationHandle : GObjectHandle
{
}

public static class GDBusMethodInvocationHandleExtensions
{
	public static MentorLake.Gio.GDBusConnectionHandle GetConnection(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_connection(invocation);
	}

	public static string GetInterfaceName(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_interface_name(invocation);
	}

	public static MentorLake.Gio.GDBusMessageHandle GetMessage(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_message(invocation);
	}

	public static MentorLake.Gio.GDBusMethodInfoHandle GetMethodInfo(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_method_info(invocation);
	}

	public static string GetMethodName(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_method_name(invocation);
	}

	public static string GetObjectPath(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_object_path(invocation);
	}

	public static MentorLake.GLib.GVariantHandle GetParameters(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_parameters(invocation);
	}

	public static MentorLake.Gio.GDBusPropertyInfoHandle GetPropertyInfo(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_property_info(invocation);
	}

	public static string GetSender(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_sender(invocation);
	}

	public static IntPtr GetUserData(this MentorLake.Gio.GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_get_user_data(invocation);
	}

	public static T ReturnDbusError<T>(this T invocation, string error_name, string error_message) where T : GDBusMethodInvocationHandle
	{
		GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_return_dbus_error(invocation, error_name, error_message);
		return invocation;
	}

	public static T ReturnError<T>(this T invocation, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist) where T : GDBusMethodInvocationHandle
	{
		GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_return_error(invocation, domain, code, format, @__arglist);
		return invocation;
	}

	public static T ReturnErrorLiteral<T>(this T invocation, MentorLake.GLib.GQuark domain, int code, string message) where T : GDBusMethodInvocationHandle
	{
		GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_return_error_literal(invocation, domain, code, message);
		return invocation;
	}

	public static T ReturnErrorValist<T>(this T invocation, MentorLake.GLib.GQuark domain, int code, string format, IntPtr var_args) where T : GDBusMethodInvocationHandle
	{
		GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_return_error_valist(invocation, domain, code, format, var_args);
		return invocation;
	}

	public static T ReturnGerror<T>(this T invocation, MentorLake.GLib.GErrorHandle error) where T : GDBusMethodInvocationHandle
	{
		GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_return_gerror(invocation, error);
		return invocation;
	}

	public static T ReturnValue<T>(this T invocation, MentorLake.GLib.GVariantHandle parameters) where T : GDBusMethodInvocationHandle
	{
		GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_return_value(invocation, parameters);
		return invocation;
	}

	public static T ReturnValueWithUnixFdList<T>(this T invocation, MentorLake.GLib.GVariantHandle parameters, MentorLake.Gio.GUnixFDListHandle fd_list) where T : GDBusMethodInvocationHandle
	{
		GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_return_value_with_unix_fd_list(invocation, parameters, fd_list);
		return invocation;
	}

	public static T TakeError<T>(this T invocation, MentorLake.GLib.GErrorHandle error) where T : GDBusMethodInvocationHandle
	{
		GDBusMethodInvocationHandleExterns.g_dbus_method_invocation_take_error(invocation, error);
		return invocation;
	}

}

internal class GDBusMethodInvocationHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_method_invocation_get_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_method_invocation_get_interface_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusMessageHandle g_dbus_method_invocation_get_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusMethodInfoHandle g_dbus_method_invocation_get_method_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_method_invocation_get_method_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_method_invocation_get_object_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GVariantHandle g_dbus_method_invocation_get_parameters([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusPropertyInfoHandle g_dbus_method_invocation_get_property_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dbus_method_invocation_get_sender([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	internal static extern IntPtr g_dbus_method_invocation_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_invocation_return_dbus_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, string error_name, string error_message);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_invocation_return_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_invocation_return_error_literal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, MentorLake.GLib.GQuark domain, int code, string message);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_invocation_return_error_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, MentorLake.GLib.GQuark domain, int code, string format, IntPtr var_args);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_invocation_return_gerror([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_invocation_return_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_invocation_return_value_with_unix_fd_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GUnixFDListHandle>))] MentorLake.Gio.GUnixFDListHandle fd_list);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_method_invocation_take_error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusMethodInvocationHandle>))] MentorLake.Gio.GDBusMethodInvocationHandle invocation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

}
