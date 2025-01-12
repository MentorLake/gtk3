namespace MentorLake.Gtk3.Gio;

public class GStaticResourceHandle : BaseSafeHandle
{
}


public static class GStaticResourceHandleExtensions
{
	public static T Fini<T>(this T static_resource) where T : GStaticResourceHandle
	{
		GStaticResourceExterns.g_static_resource_fini(static_resource);
		return static_resource;
	}

	public static GResourceHandle GetResource(this GStaticResourceHandle static_resource)
	{
		return GStaticResourceExterns.g_static_resource_get_resource(static_resource);
	}

	public static T Init<T>(this T static_resource) where T : GStaticResourceHandle
	{
		GStaticResourceExterns.g_static_resource_init(static_resource);
		return static_resource;
	}

}
internal class GStaticResourceExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern void g_static_resource_fini(GStaticResourceHandle static_resource);

	[DllImport(Libraries.Gio)]
	internal static extern GResourceHandle g_static_resource_get_resource(GStaticResourceHandle static_resource);

	[DllImport(Libraries.Gio)]
	internal static extern void g_static_resource_init(GStaticResourceHandle static_resource);

}

public struct GStaticResource
{
}
