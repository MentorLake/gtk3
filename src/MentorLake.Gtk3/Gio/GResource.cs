namespace MentorLake.Gio;

public class GResourceHandle : BaseSafeHandle
{
	public static MentorLake.Gio.GResourceHandle NewFromData(MentorLake.GLib.GBytesHandle data)
	{
		var externCallResult = GResourceExterns.g_resource_new_from_data(data, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}


public static class GResourceExtensions
{
	public static void Register(this MentorLake.Gio.GResourceHandle resource)
	{
		if (resource.IsInvalid || resource.IsClosed) throw new Exception("Invalid or closed handle (GResource)");
		GResourceExterns.g_resources_register(resource);
	}

	public static void Unregister(this MentorLake.Gio.GResourceHandle resource)
	{
		if (resource.IsInvalid || resource.IsClosed) throw new Exception("Invalid or closed handle (GResource)");
		GResourceExterns.g_resources_unregister(resource);
	}

	public static string[] EnumerateChildren(this MentorLake.Gio.GResourceHandle resource, string path, MentorLake.Gio.GResourceLookupFlags lookup_flags)
	{
		if (resource.IsInvalid || resource.IsClosed) throw new Exception("Invalid or closed handle (GResource)");
		var externCallResult = GResourceExterns.g_resource_enumerate_children(resource, path, lookup_flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool GetInfo(this MentorLake.Gio.GResourceHandle resource, string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out UIntPtr size, out uint flags)
	{
		if (resource.IsInvalid || resource.IsClosed) throw new Exception("Invalid or closed handle (GResource)");
		var externCallResult = GResourceExterns.g_resource_get_info(resource, path, lookup_flags, out size, out flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static bool HasChildren(this MentorLake.Gio.GResourceHandle resource, string path)
	{
		if (resource.IsInvalid || resource.IsClosed) throw new Exception("Invalid or closed handle (GResource)");
		return GResourceExterns.g_resource_has_children(resource, path);
	}

	public static MentorLake.GLib.GBytesHandle LookupData(this MentorLake.Gio.GResourceHandle resource, string path, MentorLake.Gio.GResourceLookupFlags lookup_flags)
	{
		if (resource.IsInvalid || resource.IsClosed) throw new Exception("Invalid or closed handle (GResource)");
		var externCallResult = GResourceExterns.g_resource_lookup_data(resource, path, lookup_flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GInputStreamHandle OpenStream(this MentorLake.Gio.GResourceHandle resource, string path, MentorLake.Gio.GResourceLookupFlags lookup_flags)
	{
		if (resource.IsInvalid || resource.IsClosed) throw new Exception("Invalid or closed handle (GResource)");
		var externCallResult = GResourceExterns.g_resource_open_stream(resource, path, lookup_flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.Gio.GResourceHandle Ref(this MentorLake.Gio.GResourceHandle resource)
	{
		if (resource.IsInvalid || resource.IsClosed) throw new Exception("Invalid or closed handle (GResource)");
		return GResourceExterns.g_resource_ref(resource);
	}

	public static void Unref(this MentorLake.Gio.GResourceHandle resource)
	{
		if (resource.IsInvalid || resource.IsClosed) throw new Exception("Invalid or closed handle (GResource)");
		GResourceExterns.g_resource_unref(resource);
	}


	public static GResource Dereference(this GResourceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GResource>(x.DangerousGetHandle());
}
internal class GResourceExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GResourceHandle g_resource_new_from_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle data, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resources_register([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resources_unregister([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_resource_enumerate_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource, string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_resource_get_info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource, string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out UIntPtr size, out uint flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_resource_has_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource, string path);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle g_resource_lookup_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource, string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GInputStreamHandle g_resource_open_stream([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource, string path, MentorLake.Gio.GResourceLookupFlags lookup_flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GResourceHandle g_resource_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_resource_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GResourceHandle>))] MentorLake.Gio.GResourceHandle resource);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.Gio.GResourceHandle g_resource_load(string filename, out MentorLake.GLib.GErrorHandle error);

}

public struct GResource
{
	public static MentorLake.Gio.GResourceHandle Load(string filename)
	{
		var externCallResult = GResourceExterns.g_resource_load(filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}
