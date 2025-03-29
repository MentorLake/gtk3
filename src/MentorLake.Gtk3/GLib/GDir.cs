namespace MentorLake.GLib;

public class GDirHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GDirHandle Open(string path, uint flags)
	{
		var externCallResult = GDirExterns.g_dir_open(path, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}


public static class GDirExtensions
{
	public static void Close(this MentorLake.GLib.GDirHandle dir)
	{
		GDirExterns.g_dir_close(dir);
	}

	public static string ReadName(this MentorLake.GLib.GDirHandle dir)
	{
		return GDirExterns.g_dir_read_name(dir);
	}

	public static MentorLake.GLib.GDirHandle Ref(this MentorLake.GLib.GDirHandle dir)
	{
		return GDirExterns.g_dir_ref(dir);
	}

	public static void Rewind(this MentorLake.GLib.GDirHandle dir)
	{
		GDirExterns.g_dir_rewind(dir);
	}

	public static void Unref(this MentorLake.GLib.GDirHandle dir)
	{
		GDirExterns.g_dir_unref(dir);
	}


	public static GDir Dereference(this GDirHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDir>(x.DangerousGetHandle());
}
internal class GDirExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDirHandle g_dir_open(string path, uint flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_dir_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDirHandle>))] MentorLake.GLib.GDirHandle dir);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dir_read_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDirHandle>))] MentorLake.GLib.GDirHandle dir);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GDirHandle g_dir_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDirHandle>))] MentorLake.GLib.GDirHandle dir);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_dir_rewind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDirHandle>))] MentorLake.GLib.GDirHandle dir);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_dir_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDirHandle>))] MentorLake.GLib.GDirHandle dir);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_dir_make_tmp(string tmpl, out MentorLake.GLib.GErrorHandle error);

}

public struct GDir
{
	public static string MakeTmp(string tmpl)
	{
		var externCallResult = GDirExterns.g_dir_make_tmp(tmpl, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}
