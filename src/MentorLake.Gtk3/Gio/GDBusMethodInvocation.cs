namespace MentorLake.Gtk3.Gio;

public class GDBusMethodInvocationHandle : GObjectHandle
{
}

public static class GDBusMethodInvocationHandleExtensions
{
	public static GDBusConnectionHandle GDbusMethodInvocationGetConnection(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_connection(invocation);
	}

	public static string GDbusMethodInvocationGetInterfaceName(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_interface_name(invocation);
	}

	public static GDBusMessageHandle GDbusMethodInvocationGetMessage(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_message(invocation);
	}

	public static GDBusMethodInfoHandle GDbusMethodInvocationGetMethodInfo(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_method_info(invocation);
	}

	public static string GDbusMethodInvocationGetMethodName(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_method_name(invocation);
	}

	public static string GDbusMethodInvocationGetObjectPath(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_object_path(invocation);
	}

	public static GVariantHandle GDbusMethodInvocationGetParameters(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_parameters(invocation);
	}

	public static GDBusPropertyInfoHandle GDbusMethodInvocationGetPropertyInfo(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_property_info(invocation);
	}

	public static string GDbusMethodInvocationGetSender(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_sender(invocation);
	}

	public static IntPtr GDbusMethodInvocationGetUserData(this GDBusMethodInvocationHandle invocation)
	{
		return GDBusMethodInvocationExterns.g_dbus_method_invocation_get_user_data(invocation);
	}

	public static T GDbusMethodInvocationReturnDbusError<T>(this T invocation, string error_name, string error_message) where T : GDBusMethodInvocationHandle
	{
		GDBusMethodInvocationExterns.g_dbus_method_invocation_return_dbus_error(invocation, error_name, error_message);
		return invocation;
	}

	public static T GDbusMethodInvocationReturnError<T>(this T invocation, GQuark domain, int code, string format, IntPtr @__arglist) where T : GDBusMethodInvocationHandle
	{
		GDBusMethodInvocationExterns.g_dbus_method_invocation_return_error(invocation, domain, code, format, @__arglist);
		return invocation;
	}

	public static T GDbusMethodInvocationReturnErrorLiteral<T>(this T invocation, GQuark domain, int code, string message) where T : GDBusMethodInvocationHandle
	{
		GDBusMethodInvocationExterns.g_dbus_method_invocation_return_error_literal(invocation, domain, code, message);
		return invocation;
	}

	public static T GDbusMethodInvocationReturnErrorValist<T>(this T invocation, GQuark domain, int code, string format, IntPtr var_args) where T : GDBusMethodInvocationHandle
	{
		GDBusMethodInvocationExterns.g_dbus_method_invocation_return_error_valist(invocation, domain, code, format, var_args);
		return invocation;
	}

	public static T GDbusMethodInvocationReturnGerror<T>(this T invocation, GErrorHandle error) where T : GDBusMethodInvocationHandle
	{
		GDBusMethodInvocationExterns.g_dbus_method_invocation_return_gerror(invocation, error);
		return invocation;
	}

	public static T GDbusMethodInvocationReturnValue<T>(this T invocation, GVariantHandle parameters) where T : GDBusMethodInvocationHandle
	{
		GDBusMethodInvocationExterns.g_dbus_method_invocation_return_value(invocation, parameters);
		return invocation;
	}

	public static T GDbusMethodInvocationReturnValueWithUnixFdList<T>(this T invocation, GVariantHandle parameters, GUnixFDListHandle fd_list) where T : GDBusMethodInvocationHandle
	{
		GDBusMethodInvocationExterns.g_dbus_method_invocation_return_value_with_unix_fd_list(invocation, parameters, fd_list);
		return invocation;
	}

	public static T GDbusMethodInvocationTakeError<T>(this T invocation, GErrorHandle error) where T : GDBusMethodInvocationHandle
	{
		GDBusMethodInvocationExterns.g_dbus_method_invocation_take_error(invocation, error);
		return invocation;
	}

}

internal class GDBusMethodInvocationExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GDBusConnectionHandle g_dbus_method_invocation_get_connection(GDBusMethodInvocationHandle invocation);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_method_invocation_get_interface_name(GDBusMethodInvocationHandle invocation);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMessageHandle g_dbus_method_invocation_get_message(GDBusMethodInvocationHandle invocation);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusMethodInfoHandle g_dbus_method_invocation_get_method_info(GDBusMethodInvocationHandle invocation);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_method_invocation_get_method_name(GDBusMethodInvocationHandle invocation);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_method_invocation_get_object_path(GDBusMethodInvocationHandle invocation);

	[DllImport(Libraries.Gio)]
	internal static extern GVariantHandle g_dbus_method_invocation_get_parameters(GDBusMethodInvocationHandle invocation);

	[DllImport(Libraries.Gio)]
	internal static extern GDBusPropertyInfoHandle g_dbus_method_invocation_get_property_info(GDBusMethodInvocationHandle invocation);

	[DllImport(Libraries.Gio)]
	internal static extern string g_dbus_method_invocation_get_sender(GDBusMethodInvocationHandle invocation);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_dbus_method_invocation_get_user_data(GDBusMethodInvocationHandle invocation);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_invocation_return_dbus_error(GDBusMethodInvocationHandle invocation, string error_name, string error_message);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_invocation_return_error(GDBusMethodInvocationHandle invocation, GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_invocation_return_error_literal(GDBusMethodInvocationHandle invocation, GQuark domain, int code, string message);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_invocation_return_error_valist(GDBusMethodInvocationHandle invocation, GQuark domain, int code, string format, IntPtr var_args);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_invocation_return_gerror(GDBusMethodInvocationHandle invocation, GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_invocation_return_value(GDBusMethodInvocationHandle invocation, GVariantHandle parameters);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_invocation_return_value_with_unix_fd_list(GDBusMethodInvocationHandle invocation, GVariantHandle parameters, GUnixFDListHandle fd_list);

	[DllImport(Libraries.Gio)]
	internal static extern void g_dbus_method_invocation_take_error(GDBusMethodInvocationHandle invocation, GErrorHandle error);

}
