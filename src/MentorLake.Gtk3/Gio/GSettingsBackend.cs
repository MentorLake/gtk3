namespace MentorLake.Gtk3.Gio;

public class GSettingsBackendHandle : GObjectHandle
{
	public static void FlattenTree(GTreeHandle tree, out string path, out string[] keys, out GVariantHandle[] values)
	{
		GSettingsBackendExterns.g_settings_backend_flatten_tree(tree, out path, out keys, out values);
	}

	public static GSettingsBackendHandle GetDefault()
	{
		return GSettingsBackendExterns.g_settings_backend_get_default();
	}

}

public static class GSettingsBackendHandleExtensions
{
	public static T Changed<T>(this T backend, string key, IntPtr origin_tag) where T : GSettingsBackendHandle
	{
		GSettingsBackendExterns.g_settings_backend_changed(backend, key, origin_tag);
		return backend;
	}

	public static T ChangedTree<T>(this T backend, GTreeHandle tree, IntPtr origin_tag) where T : GSettingsBackendHandle
	{
		GSettingsBackendExterns.g_settings_backend_changed_tree(backend, tree, origin_tag);
		return backend;
	}

	public static T KeysChanged<T>(this T backend, string path, string items, IntPtr origin_tag) where T : GSettingsBackendHandle
	{
		GSettingsBackendExterns.g_settings_backend_keys_changed(backend, path, items, origin_tag);
		return backend;
	}

	public static T PathChanged<T>(this T backend, string path, IntPtr origin_tag) where T : GSettingsBackendHandle
	{
		GSettingsBackendExterns.g_settings_backend_path_changed(backend, path, origin_tag);
		return backend;
	}

	public static T PathWritableChanged<T>(this T backend, string path) where T : GSettingsBackendHandle
	{
		GSettingsBackendExterns.g_settings_backend_path_writable_changed(backend, path);
		return backend;
	}

	public static T WritableChanged<T>(this T backend, string key) where T : GSettingsBackendHandle
	{
		GSettingsBackendExterns.g_settings_backend_writable_changed(backend, key);
		return backend;
	}

}

internal class GSettingsBackendExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_backend_changed(GSettingsBackendHandle backend, string key, IntPtr origin_tag);

	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_backend_changed_tree(GSettingsBackendHandle backend, GTreeHandle tree, IntPtr origin_tag);

	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_backend_keys_changed(GSettingsBackendHandle backend, string path, string items, IntPtr origin_tag);

	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_backend_path_changed(GSettingsBackendHandle backend, string path, IntPtr origin_tag);

	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_backend_path_writable_changed(GSettingsBackendHandle backend, string path);

	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_backend_writable_changed(GSettingsBackendHandle backend, string key);

	[DllImport(Libraries.Gio)]
	internal static extern void g_settings_backend_flatten_tree(GTreeHandle tree, out string path, out string[] keys, out GVariantHandle[] values);

	[DllImport(Libraries.Gio)]
	internal static extern GSettingsBackendHandle g_settings_backend_get_default();

}
