namespace MentorLake.Gio;

public class GStaticResourceHandle : BaseSafeHandle
{
}


public static class GStaticResourceExtensions
{
	public static void Fini(this MentorLake.Gio.GStaticResourceHandle static_resource)
	{
		GStaticResourceExterns.g_static_resource_fini(static_resource);
	}

	public static MentorLake.Gio.GResourceHandle GetResource(this MentorLake.Gio.GStaticResourceHandle static_resource)
	{
		return GStaticResourceExterns.g_static_resource_get_resource(static_resource);
	}

	public static void Init(this MentorLake.Gio.GStaticResourceHandle static_resource)
	{
		GStaticResourceExterns.g_static_resource_init(static_resource);
	}


	public static GStaticResource Dereference(this GStaticResourceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GStaticResource>(x.DangerousGetHandle());
}
internal class GStaticResourceExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern void g_static_resource_fini([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GStaticResourceHandle>))] MentorLake.Gio.GStaticResourceHandle static_resource);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GResourceHandle g_static_resource_get_resource([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GStaticResourceHandle>))] MentorLake.Gio.GStaticResourceHandle static_resource);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_static_resource_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GStaticResourceHandle>))] MentorLake.Gio.GStaticResourceHandle static_resource);

}

public struct GStaticResource
{
}
