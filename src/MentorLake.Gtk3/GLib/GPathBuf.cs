namespace MentorLake.GLib;

public class GPathBufHandle : BaseSafeHandle
{
}


public static class GPathBufExtensions
{
	public static void Clear(this MentorLake.GLib.GPathBufHandle buf)
	{
		GPathBufExterns.g_path_buf_clear(buf);
	}

	public static string ClearToPath(this MentorLake.GLib.GPathBufHandle buf)
	{
		return GPathBufExterns.g_path_buf_clear_to_path(buf);
	}

	public static MentorLake.GLib.GPathBufHandle Copy(this MentorLake.GLib.GPathBufHandle buf)
	{
		return GPathBufExterns.g_path_buf_copy(buf);
	}

	public static void Free(this MentorLake.GLib.GPathBufHandle buf)
	{
		GPathBufExterns.g_path_buf_free(buf);
	}

	public static string FreeToPath(this MentorLake.GLib.GPathBufHandle buf)
	{
		return GPathBufExterns.g_path_buf_free_to_path(buf);
	}

	public static MentorLake.GLib.GPathBufHandle Init(this MentorLake.GLib.GPathBufHandle buf)
	{
		return GPathBufExterns.g_path_buf_init(buf);
	}

	public static MentorLake.GLib.GPathBufHandle InitFromPath(this MentorLake.GLib.GPathBufHandle buf, string path)
	{
		return GPathBufExterns.g_path_buf_init_from_path(buf, path);
	}

	public static bool Pop(this MentorLake.GLib.GPathBufHandle buf)
	{
		return GPathBufExterns.g_path_buf_pop(buf);
	}

	public static MentorLake.GLib.GPathBufHandle Push(this MentorLake.GLib.GPathBufHandle buf, string path)
	{
		return GPathBufExterns.g_path_buf_push(buf, path);
	}

	public static bool SetExtension(this MentorLake.GLib.GPathBufHandle buf, string extension)
	{
		return GPathBufExterns.g_path_buf_set_extension(buf, extension);
	}

	public static bool SetFilename(this MentorLake.GLib.GPathBufHandle buf, string file_name)
	{
		return GPathBufExterns.g_path_buf_set_filename(buf, file_name);
	}

	public static string ToPath(this MentorLake.GLib.GPathBufHandle buf)
	{
		return GPathBufExterns.g_path_buf_to_path(buf);
	}


	public static GPathBuf Dereference(this GPathBufHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPathBuf>(x.DangerousGetHandle());
}
internal class GPathBufExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_path_buf_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_path_buf_clear_to_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPathBufHandle g_path_buf_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_path_buf_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_path_buf_free_to_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPathBufHandle g_path_buf_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPathBufHandle g_path_buf_init_from_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf, string path);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_path_buf_pop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPathBufHandle g_path_buf_push([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf, string path);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_path_buf_set_extension([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf, string extension);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_path_buf_set_filename([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf, string file_name);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_path_buf_to_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPathBufHandle>))] MentorLake.GLib.GPathBufHandle buf);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_path_buf_equal(IntPtr v1, IntPtr v2);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPathBufHandle g_path_buf_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GPathBufHandle g_path_buf_new_from_path(string path);

}

public struct GPathBuf
{
	public static bool Equal(IntPtr v1, IntPtr v2)
	{
		return GPathBufExterns.g_path_buf_equal(v1, v2);
	}

	public static MentorLake.GLib.GPathBufHandle New()
	{
		return GPathBufExterns.g_path_buf_new();
	}

	public static MentorLake.GLib.GPathBufHandle NewFromPath(string path)
	{
		return GPathBufExterns.g_path_buf_new_from_path(path);
	}

}
