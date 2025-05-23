namespace MentorLake.GLibUnix;

public class GUnixPipeHandle : BaseSafeHandle
{
}


public static class GUnixPipeExtensions
{

	public static GUnixPipe Dereference(this GUnixPipeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GUnixPipe>(x.DangerousGetHandle());
}
internal class GUnixPipeExterns
{
	[DllImport(GLibUnixLibrary.Name)]
	internal static extern void g_unix_pipe_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUnixPipeHandle>))] MentorLake.GLib.GUnixPipeHandle self);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern bool g_unix_pipe_close([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUnixPipeHandle>))] MentorLake.GLib.GUnixPipeHandle self, MentorLake.GLib.GUnixPipeEnd end, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern int g_unix_pipe_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUnixPipeHandle>))] MentorLake.GLib.GUnixPipeHandle self, MentorLake.GLib.GUnixPipeEnd end);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern bool g_unix_pipe_open([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUnixPipeHandle>))] MentorLake.GLib.GUnixPipeHandle self, int flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibUnixLibrary.Name)]
	internal static extern int g_unix_pipe_steal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUnixPipeHandle>))] MentorLake.GLib.GUnixPipeHandle self, MentorLake.GLib.GUnixPipeEnd end);

}

public struct GUnixPipe
{
	[MarshalAs(UnmanagedType.ByValArray)] public int[] fds;
	public static void Clear(MentorLake.GLib.GUnixPipeHandle self)
	{
		GUnixPipeExterns.g_unix_pipe_clear(self);
	}

	public static bool Close(MentorLake.GLib.GUnixPipeHandle self, MentorLake.GLib.GUnixPipeEnd end)
	{
		var externCallResult = GUnixPipeExterns.g_unix_pipe_close(self, end, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static int Get(MentorLake.GLib.GUnixPipeHandle self, MentorLake.GLib.GUnixPipeEnd end)
	{
		return GUnixPipeExterns.g_unix_pipe_get(self, end);
	}

	public static bool Open(MentorLake.GLib.GUnixPipeHandle self, int flags)
	{
		var externCallResult = GUnixPipeExterns.g_unix_pipe_open(self, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static int Steal(MentorLake.GLib.GUnixPipeHandle self, MentorLake.GLib.GUnixPipeEnd end)
	{
		return GUnixPipeExterns.g_unix_pipe_steal(self, end);
	}

}
