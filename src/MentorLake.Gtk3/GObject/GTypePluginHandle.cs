namespace MentorLake.GObject;

public interface GTypePluginHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GTypePluginHandleImpl : BaseSafeHandle, GTypePluginHandle
{
}

public static class GTypePluginHandleExtensions
{
	public static T CompleteInterfaceInfo<T>(this T plugin, MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type, MentorLake.GObject.GInterfaceInfoHandle info) where T : GTypePluginHandle
	{
		if (plugin.IsInvalid || plugin.IsClosed) throw new Exception("Invalid or closed handle (GTypePluginHandle)");
		GTypePluginHandleExterns.g_type_plugin_complete_interface_info(plugin, instance_type, interface_type, info);
		return plugin;
	}

	public static T CompleteTypeInfo<T>(this T plugin, MentorLake.GObject.GType g_type, MentorLake.GObject.GTypeInfoHandle info, MentorLake.GObject.GTypeValueTableHandle value_table) where T : GTypePluginHandle
	{
		if (plugin.IsInvalid || plugin.IsClosed) throw new Exception("Invalid or closed handle (GTypePluginHandle)");
		GTypePluginHandleExterns.g_type_plugin_complete_type_info(plugin, g_type, info, value_table);
		return plugin;
	}

	public static T Unuse<T>(this T plugin) where T : GTypePluginHandle
	{
		if (plugin.IsInvalid || plugin.IsClosed) throw new Exception("Invalid or closed handle (GTypePluginHandle)");
		GTypePluginHandleExterns.g_type_plugin_unuse(plugin);
		return plugin;
	}

	public static T Use<T>(this T plugin) where T : GTypePluginHandle
	{
		if (plugin.IsInvalid || plugin.IsClosed) throw new Exception("Invalid or closed handle (GTypePluginHandle)");
		GTypePluginHandleExterns.g_type_plugin_use(plugin);
		return plugin;
	}

}

internal class GTypePluginHandleExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_plugin_complete_interface_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))] MentorLake.GObject.GTypePluginHandle plugin, MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GInterfaceInfoHandle>))] MentorLake.GObject.GInterfaceInfoHandle info);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_plugin_complete_type_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))] MentorLake.GObject.GTypePluginHandle plugin, MentorLake.GObject.GType g_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInfoHandle>))] MentorLake.GObject.GTypeInfoHandle info, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeValueTableHandle>))] MentorLake.GObject.GTypeValueTableHandle value_table);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_plugin_unuse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))] MentorLake.GObject.GTypePluginHandle plugin);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_plugin_use([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))] MentorLake.GObject.GTypePluginHandle plugin);

}
