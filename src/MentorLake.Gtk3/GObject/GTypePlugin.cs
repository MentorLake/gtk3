namespace MentorLake.Gtk3.GObject;

public interface GTypePluginHandle
{
}

internal class GTypePluginHandleImpl : BaseSafeHandle, GTypePluginHandle
{
}

public static class GTypePluginHandleExtensions
{
	public static T CompleteInterfaceInfo<T>(this T plugin, GType instance_type, GType interface_type, GInterfaceInfoHandle info) where T : GTypePluginHandle
	{
		GTypePluginExterns.g_type_plugin_complete_interface_info(plugin, instance_type, interface_type, info);
		return plugin;
	}

	public static T CompleteTypeInfo<T>(this T plugin, GType g_type, GTypeInfoHandle info, GTypeValueTableHandle value_table) where T : GTypePluginHandle
	{
		GTypePluginExterns.g_type_plugin_complete_type_info(plugin, g_type, info, value_table);
		return plugin;
	}

	public static T Unuse<T>(this T plugin) where T : GTypePluginHandle
	{
		GTypePluginExterns.g_type_plugin_unuse(plugin);
		return plugin;
	}

	public static T Use<T>(this T plugin) where T : GTypePluginHandle
	{
		GTypePluginExterns.g_type_plugin_use(plugin);
		return plugin;
	}

}

internal class GTypePluginExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern void g_type_plugin_complete_interface_info(GTypePluginHandle plugin, GType instance_type, GType interface_type, GInterfaceInfoHandle info);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_plugin_complete_type_info(GTypePluginHandle plugin, GType g_type, GTypeInfoHandle info, GTypeValueTableHandle value_table);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_plugin_unuse(GTypePluginHandle plugin);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_plugin_use(GTypePluginHandle plugin);

}
