namespace MentorLake.Gtk3.Gio;

public class GResourceHandle : BaseSafeHandle
{
	public static GResourceHandle NewFromData(GBytesHandle data, out GErrorHandle error)
	{
		return GResourceExterns.g_resource_new_from_data(data, out error);
	}

}


public static class GResourceHandleExtensions
{
	public static T sRegister<T>(this T resource) where T : GResourceHandle
	{
		GResourceExterns.g_resources_register(resource);
		return resource;
	}

	public static T sUnregister<T>(this T resource) where T : GResourceHandle
	{
		GResourceExterns.g_resources_unregister(resource);
		return resource;
	}

	public static IntPtr EnumerateChildren(this GResourceHandle resource, string path, GResourceLookupFlags lookup_flags, out GErrorHandle error)
	{
		return GResourceExterns.g_resource_enumerate_children(resource, path, lookup_flags, out error);
	}

	public static bool GetInfo(this GResourceHandle resource, string path, GResourceLookupFlags lookup_flags, out UIntPtr size, out uint flags, out GErrorHandle error)
	{
		return GResourceExterns.g_resource_get_info(resource, path, lookup_flags, out size, out flags, out error);
	}

	public static GBytesHandle LookupData(this GResourceHandle resource, string path, GResourceLookupFlags lookup_flags, out GErrorHandle error)
	{
		return GResourceExterns.g_resource_lookup_data(resource, path, lookup_flags, out error);
	}

	public static GInputStreamHandle OpenStream(this GResourceHandle resource, string path, GResourceLookupFlags lookup_flags, out GErrorHandle error)
	{
		return GResourceExterns.g_resource_open_stream(resource, path, lookup_flags, out error);
	}

	public static GResourceHandle Ref(this GResourceHandle resource)
	{
		return GResourceExterns.g_resource_ref(resource);
	}

	public static T Unref<T>(this T resource) where T : GResourceHandle
	{
		GResourceExterns.g_resource_unref(resource);
		return resource;
	}

	public static GResourceHandle Load(string filename, out GErrorHandle error)
	{
		return GResourceExterns.g_resource_load(filename, out error);
	}

}
internal class GResourceExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GResourceHandle g_resource_new_from_data(GBytesHandle data, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern void g_resources_register(GResourceHandle resource);

	[DllImport(Libraries.Gio)]
	internal static extern void g_resources_unregister(GResourceHandle resource);

	[DllImport(Libraries.Gio)]
	internal static extern IntPtr g_resource_enumerate_children(GResourceHandle resource, string path, GResourceLookupFlags lookup_flags, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_resource_get_info(GResourceHandle resource, string path, GResourceLookupFlags lookup_flags, out UIntPtr size, out uint flags, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GBytesHandle g_resource_lookup_data(GResourceHandle resource, string path, GResourceLookupFlags lookup_flags, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GInputStreamHandle g_resource_open_stream(GResourceHandle resource, string path, GResourceLookupFlags lookup_flags, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GResourceHandle g_resource_ref(GResourceHandle resource);

	[DllImport(Libraries.Gio)]
	internal static extern void g_resource_unref(GResourceHandle resource);

	[DllImport(Libraries.Gio)]
	internal static extern GResourceHandle g_resource_load(string filename, out GErrorHandle error);

}

public struct GResource
{
}
