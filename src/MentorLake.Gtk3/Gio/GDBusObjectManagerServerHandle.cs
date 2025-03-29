namespace MentorLake.Gio;

public class GDBusObjectManagerServerHandle : GObjectHandle, GDBusObjectManagerHandle
{
	public static MentorLake.Gio.GDBusObjectManagerServerHandle New(string object_path)
	{
		return GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_new(object_path);
	}

}

public static class GDBusObjectManagerServerHandleExtensions
{
	public static T Export<T>(this T manager, MentorLake.Gio.GDBusObjectSkeletonHandle @object) where T : GDBusObjectManagerServerHandle
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectManagerServerHandle)");
		GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_export(manager, @object);
		return manager;
	}

	public static T ExportUniquely<T>(this T manager, MentorLake.Gio.GDBusObjectSkeletonHandle @object) where T : GDBusObjectManagerServerHandle
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectManagerServerHandle)");
		GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_export_uniquely(manager, @object);
		return manager;
	}

	public static MentorLake.Gio.GDBusConnectionHandle GetConnection(this MentorLake.Gio.GDBusObjectManagerServerHandle manager)
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectManagerServerHandle)");
		return GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_get_connection(manager);
	}

	public static bool IsExported(this MentorLake.Gio.GDBusObjectManagerServerHandle manager, MentorLake.Gio.GDBusObjectSkeletonHandle @object)
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectManagerServerHandle)");
		return GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_is_exported(manager, @object);
	}

	public static T SetConnection<T>(this T manager, MentorLake.Gio.GDBusConnectionHandle connection) where T : GDBusObjectManagerServerHandle
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectManagerServerHandle)");
		GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_set_connection(manager, connection);
		return manager;
	}

	public static bool Unexport(this MentorLake.Gio.GDBusObjectManagerServerHandle manager, string object_path)
	{
		if (manager.IsInvalid || manager.IsClosed) throw new Exception("Invalid or closed handle (GDBusObjectManagerServerHandle)");
		return GDBusObjectManagerServerHandleExterns.g_dbus_object_manager_server_unexport(manager, object_path);
	}

}

internal class GDBusObjectManagerServerHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusObjectManagerServerHandle g_dbus_object_manager_server_new(string object_path);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_manager_server_export([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))] MentorLake.Gio.GDBusObjectSkeletonHandle @object);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_manager_server_export_uniquely([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))] MentorLake.Gio.GDBusObjectSkeletonHandle @object);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GDBusConnectionHandle g_dbus_object_manager_server_get_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_object_manager_server_is_exported([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectSkeletonHandle>))] MentorLake.Gio.GDBusObjectSkeletonHandle @object);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_dbus_object_manager_server_set_connection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusConnectionHandle>))] MentorLake.Gio.GDBusConnectionHandle connection);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_dbus_object_manager_server_unexport([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDBusObjectManagerServerHandle>))] MentorLake.Gio.GDBusObjectManagerServerHandle manager, string object_path);

}
