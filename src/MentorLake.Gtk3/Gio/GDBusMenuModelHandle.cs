namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GDBusMenuModel` is an implementation of [class@Gio.MenuModel] that can be
/// used as a proxy for a menu model that is exported over D-Bus with
/// [method@Gio.DBusConnection.export_menu_model].
/// </para>
/// </summary>

public class GDBusMenuModelHandle : GMenuModelHandle
{
/// <summary>
/// <para>
/// Obtains a #GDBusMenuModel for the menu model which is exported
/// at the given @bus_name and @object_path.
/// </para>
/// <para>
/// The thread default main context is taken at the time of this call.
/// All signals on the menu model (and any linked models) are reported
/// with respect to this context.  All calls on the returned menu model
/// (and linked models) must also originate from this same context, with
/// the thread default main context unchanged.
/// </para>
/// </summary>

/// <param name="connection">
/// a #GDBusConnection
/// </param>
/// <param name="bus_name">
/// the bus name which exports the menu model
///     or %NULL if @connection is not a message bus connection
/// </param>
/// <param name="object_path">
/// the object path at which the menu model is exported
/// </param>
/// <return>
/// a #GDBusMenuModel object. Free with
///     g_object_unref().
/// </return>

	public static MentorLake.Gio.GDBusMenuModelHandle Get(MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path)
	{
		return GDBusMenuModelHandleExterns.g_dbus_menu_model_get(connection, bus_name, object_path);
	}

}

public static class GDBusMenuModelHandleExtensions
{
}

internal class GDBusMenuModelHandleExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gio.GDBusMenuModelHandle>))]
	internal static extern MentorLake.Gio.GDBusMenuModelHandle g_dbus_menu_model_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection, string bus_name, string object_path);

}
