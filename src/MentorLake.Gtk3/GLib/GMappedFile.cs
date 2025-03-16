namespace MentorLake.GLib;

public class GMappedFileHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GMappedFileHandle New(char filename, bool writable)
	{
		return GMappedFileExterns.g_mapped_file_new(filename, writable);
	}

	public static MentorLake.GLib.GMappedFileHandle NewFromFd(int fd, bool writable)
	{
		return GMappedFileExterns.g_mapped_file_new_from_fd(fd, writable);
	}

}


public static class GMappedFileExtensions
{
	public static void Free(this MentorLake.GLib.GMappedFileHandle file)
	{
		GMappedFileExterns.g_mapped_file_free(file);
	}

	public static MentorLake.GLib.GBytesHandle GetBytes(this MentorLake.GLib.GMappedFileHandle file)
	{
		return GMappedFileExterns.g_mapped_file_get_bytes(file);
	}

	public static string GetContents(this MentorLake.GLib.GMappedFileHandle file)
	{
		return GMappedFileExterns.g_mapped_file_get_contents(file);
	}

	public static UIntPtr GetLength(this MentorLake.GLib.GMappedFileHandle file)
	{
		return GMappedFileExterns.g_mapped_file_get_length(file);
	}

	public static MentorLake.GLib.GMappedFileHandle Ref(this MentorLake.GLib.GMappedFileHandle file)
	{
		return GMappedFileExterns.g_mapped_file_ref(file);
	}

	public static void Unref(this MentorLake.GLib.GMappedFileHandle file)
	{
		GMappedFileExterns.g_mapped_file_unref(file);
	}


	public static GMappedFile Dereference(this GMappedFileHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMappedFile>(x.DangerousGetHandle());
}
internal class GMappedFileExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMappedFileHandle g_mapped_file_new(char filename, bool writable);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMappedFileHandle g_mapped_file_new_from_fd(int fd, bool writable);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mapped_file_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMappedFileHandle>))] MentorLake.GLib.GMappedFileHandle file);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GBytesHandle g_mapped_file_get_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMappedFileHandle>))] MentorLake.GLib.GMappedFileHandle file);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_mapped_file_get_contents([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMappedFileHandle>))] MentorLake.GLib.GMappedFileHandle file);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_mapped_file_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMappedFileHandle>))] MentorLake.GLib.GMappedFileHandle file);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GMappedFileHandle g_mapped_file_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMappedFileHandle>))] MentorLake.GLib.GMappedFileHandle file);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_mapped_file_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMappedFileHandle>))] MentorLake.GLib.GMappedFileHandle file);

}

public struct GMappedFile
{
}
