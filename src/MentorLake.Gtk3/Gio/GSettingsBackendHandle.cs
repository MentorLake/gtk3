namespace MentorLake.Gio;

public class GSettingsBackendHandle : GObjectHandle
{
	public static void FlattenTree(MentorLake.GLib.GTreeHandle tree, out string path, out string[] keys, out MentorLake.GLib.GVariantHandle[] values)
	{
		GSettingsBackendHandleExterns.g_settings_backend_flatten_tree(tree, out path, out keys, out values);
	}

	public static MentorLake.Gio.GSettingsBackendHandle GetDefault()
	{
		return GSettingsBackendHandleExterns.g_settings_backend_get_default();
	}

}

public static class GSettingsBackendHandleExtensions
{
	public static T Changed<T>(this T backend, string key, IntPtr origin_tag) where T : GSettingsBackendHandle
	{
		GSettingsBackendHandleExterns.g_settings_backend_changed(backend, key, origin_tag);
		return backend;
	}

	public static T ChangedTree<T>(this T backend, MentorLake.GLib.GTreeHandle tree, IntPtr origin_tag) where T : GSettingsBackendHandle
	{
		GSettingsBackendHandleExterns.g_settings_backend_changed_tree(backend, tree, origin_tag);
		return backend;
	}

	public static T KeysChanged<T>(this T backend, string path, string[] items, IntPtr origin_tag) where T : GSettingsBackendHandle
	{
		GSettingsBackendHandleExterns.g_settings_backend_keys_changed(backend, path, items, origin_tag);
		return backend;
	}

	public static T PathChanged<T>(this T backend, string path, IntPtr origin_tag) where T : GSettingsBackendHandle
	{
		GSettingsBackendHandleExterns.g_settings_backend_path_changed(backend, path, origin_tag);
		return backend;
	}

	public static T PathWritableChanged<T>(this T backend, string path) where T : GSettingsBackendHandle
	{
		GSettingsBackendHandleExterns.g_settings_backend_path_writable_changed(backend, path);
		return backend;
	}

	public static T WritableChanged<T>(this T backend, string key) where T : GSettingsBackendHandle
	{
		GSettingsBackendHandleExterns.g_settings_backend_writable_changed(backend, key);
		return backend;
	}

}

internal class GSettingsBackendHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_backend_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsBackendHandle>))] MentorLake.Gio.GSettingsBackendHandle backend, string key, IntPtr origin_tag);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_backend_changed_tree([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsBackendHandle>))] MentorLake.Gio.GSettingsBackendHandle backend, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, IntPtr origin_tag);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_backend_keys_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsBackendHandle>))] MentorLake.Gio.GSettingsBackendHandle backend, string path, string[] items, IntPtr origin_tag);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_backend_path_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsBackendHandle>))] MentorLake.Gio.GSettingsBackendHandle backend, string path, IntPtr origin_tag);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_backend_path_writable_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsBackendHandle>))] MentorLake.Gio.GSettingsBackendHandle backend, string path);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_backend_writable_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSettingsBackendHandle>))] MentorLake.Gio.GSettingsBackendHandle backend, string key);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_settings_backend_flatten_tree([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTreeHandle>))] MentorLake.GLib.GTreeHandle tree, out string path, out string[] keys, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] out MentorLake.GLib.GVariantHandle[] values);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GSettingsBackendHandle g_settings_backend_get_default();

}
