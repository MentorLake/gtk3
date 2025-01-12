namespace MentorLake.Gtk3.GLib;

public class GPathBufHandle : BaseSafeHandle
{
}


public static class GPathBufHandleExtensions
{
	public static T Clear<T>(this T buf) where T : GPathBufHandle
	{
		GPathBufExterns.g_path_buf_clear(buf);
		return buf;
	}

	public static string ClearToPath(this GPathBufHandle buf)
	{
		return GPathBufExterns.g_path_buf_clear_to_path(buf);
	}

	public static GPathBufHandle Copy(this GPathBufHandle buf)
	{
		return GPathBufExterns.g_path_buf_copy(buf);
	}

	public static T Free<T>(this T buf) where T : GPathBufHandle
	{
		GPathBufExterns.g_path_buf_free(buf);
		return buf;
	}

	public static string FreeToPath(this GPathBufHandle buf)
	{
		return GPathBufExterns.g_path_buf_free_to_path(buf);
	}

	public static GPathBufHandle Init(this GPathBufHandle buf)
	{
		return GPathBufExterns.g_path_buf_init(buf);
	}

	public static GPathBufHandle InitFromPath(this GPathBufHandle buf, string path)
	{
		return GPathBufExterns.g_path_buf_init_from_path(buf, path);
	}

	public static bool Pop(this GPathBufHandle buf)
	{
		return GPathBufExterns.g_path_buf_pop(buf);
	}

	public static GPathBufHandle Push(this GPathBufHandle buf, string path)
	{
		return GPathBufExterns.g_path_buf_push(buf, path);
	}

	public static bool SetExtension(this GPathBufHandle buf, string extension)
	{
		return GPathBufExterns.g_path_buf_set_extension(buf, extension);
	}

	public static bool SetFilename(this GPathBufHandle buf, string file_name)
	{
		return GPathBufExterns.g_path_buf_set_filename(buf, file_name);
	}

	public static string ToPath(this GPathBufHandle buf)
	{
		return GPathBufExterns.g_path_buf_to_path(buf);
	}

	public static bool Equal(IntPtr v1, IntPtr v2)
	{
		return GPathBufExterns.g_path_buf_equal(v1, v2);
	}

	public static GPathBufHandle New()
	{
		return GPathBufExterns.g_path_buf_new();
	}

	public static GPathBufHandle NewFromPath(string path)
	{
		return GPathBufExterns.g_path_buf_new_from_path(path);
	}

}
internal class GPathBufExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_path_buf_clear(GPathBufHandle buf);

	[DllImport(Libraries.GLib)]
	internal static extern string g_path_buf_clear_to_path(GPathBufHandle buf);

	[DllImport(Libraries.GLib)]
	internal static extern GPathBufHandle g_path_buf_copy(GPathBufHandle buf);

	[DllImport(Libraries.GLib)]
	internal static extern void g_path_buf_free(GPathBufHandle buf);

	[DllImport(Libraries.GLib)]
	internal static extern string g_path_buf_free_to_path(GPathBufHandle buf);

	[DllImport(Libraries.GLib)]
	internal static extern GPathBufHandle g_path_buf_init(GPathBufHandle buf);

	[DllImport(Libraries.GLib)]
	internal static extern GPathBufHandle g_path_buf_init_from_path(GPathBufHandle buf, string path);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_path_buf_pop(GPathBufHandle buf);

	[DllImport(Libraries.GLib)]
	internal static extern GPathBufHandle g_path_buf_push(GPathBufHandle buf, string path);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_path_buf_set_extension(GPathBufHandle buf, string extension);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_path_buf_set_filename(GPathBufHandle buf, string file_name);

	[DllImport(Libraries.GLib)]
	internal static extern string g_path_buf_to_path(GPathBufHandle buf);

	[DllImport(Libraries.GLib)]
	internal static extern bool g_path_buf_equal(IntPtr v1, IntPtr v2);

	[DllImport(Libraries.GLib)]
	internal static extern GPathBufHandle g_path_buf_new();

	[DllImport(Libraries.GLib)]
	internal static extern GPathBufHandle g_path_buf_new_from_path(string path);

}

public struct GPathBuf
{
}
