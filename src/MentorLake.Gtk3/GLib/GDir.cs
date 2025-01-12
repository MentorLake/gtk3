namespace MentorLake.Gtk3.GLib;

public class GDirHandle : BaseSafeHandle
{
	public static GDirHandle Open(string path, uint flags, out GErrorHandle error)
	{
		return GDirExterns.g_dir_open(path, flags, out error);
	}

}


public static class GDirHandleExtensions
{
	public static T Close<T>(this T dir) where T : GDirHandle
	{
		GDirExterns.g_dir_close(dir);
		return dir;
	}

	public static string ReadName(this GDirHandle dir)
	{
		return GDirExterns.g_dir_read_name(dir);
	}

	public static GDirHandle Ref(this GDirHandle dir)
	{
		return GDirExterns.g_dir_ref(dir);
	}

	public static T Rewind<T>(this T dir) where T : GDirHandle
	{
		GDirExterns.g_dir_rewind(dir);
		return dir;
	}

	public static T Unref<T>(this T dir) where T : GDirHandle
	{
		GDirExterns.g_dir_unref(dir);
		return dir;
	}

	public static string MakeTmp(string tmpl, out GErrorHandle error)
	{
		return GDirExterns.g_dir_make_tmp(tmpl, out error);
	}

}
internal class GDirExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GDirHandle g_dir_open(string path, uint flags, out GErrorHandle error);

	[DllImport(Libraries.GLib)]
	internal static extern void g_dir_close(GDirHandle dir);

	[DllImport(Libraries.GLib)]
	internal static extern string g_dir_read_name(GDirHandle dir);

	[DllImport(Libraries.GLib)]
	internal static extern GDirHandle g_dir_ref(GDirHandle dir);

	[DllImport(Libraries.GLib)]
	internal static extern void g_dir_rewind(GDirHandle dir);

	[DllImport(Libraries.GLib)]
	internal static extern void g_dir_unref(GDirHandle dir);

	[DllImport(Libraries.GLib)]
	internal static extern string g_dir_make_tmp(string tmpl, out GErrorHandle error);

}

public struct GDir
{
}
