namespace MentorLake.GLib;

public class GTestLogBufferHandle : BaseSafeHandle
{
}


public static class GTestLogBufferExtensions
{
	public static void Free(this MentorLake.GLib.GTestLogBufferHandle tbuffer)
	{
		GTestLogBufferExterns.g_test_log_buffer_free(tbuffer);
	}

	public static MentorLake.GLib.GTestLogMsgHandle Pop(this MentorLake.GLib.GTestLogBufferHandle tbuffer)
	{
		return GTestLogBufferExterns.g_test_log_buffer_pop(tbuffer);
	}

	public static void Push(this MentorLake.GLib.GTestLogBufferHandle tbuffer, uint n_bytes, byte bytes)
	{
		GTestLogBufferExterns.g_test_log_buffer_push(tbuffer, n_bytes, bytes);
	}


	public static GTestLogBuffer Dereference(this GTestLogBufferHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTestLogBuffer>(x.DangerousGetHandle());
}
internal class GTestLogBufferExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_log_buffer_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestLogBufferHandle>))] MentorLake.GLib.GTestLogBufferHandle tbuffer);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTestLogMsgHandle g_test_log_buffer_pop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestLogBufferHandle>))] MentorLake.GLib.GTestLogBufferHandle tbuffer);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_log_buffer_push([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestLogBufferHandle>))] MentorLake.GLib.GTestLogBufferHandle tbuffer, uint n_bytes, byte bytes);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GTestLogBufferHandle g_test_log_buffer_new();

}

public struct GTestLogBuffer
{
	public static MentorLake.GLib.GTestLogBufferHandle New()
	{
		return GTestLogBufferExterns.g_test_log_buffer_new();
	}

}
