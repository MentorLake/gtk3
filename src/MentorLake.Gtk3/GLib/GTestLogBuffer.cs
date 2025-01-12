namespace MentorLake.Gtk3.GLib;

public class GTestLogBufferHandle : BaseSafeHandle
{
}


public static class GTestLogBufferHandleExtensions
{
	public static GTestLogBufferHandle Free(this GTestLogBufferHandle tbuffer)
	{
		GTestLogBufferExterns.g_test_log_buffer_free(tbuffer);
		return tbuffer;
	}

	public static GTestLogMsgHandle Pop(this GTestLogBufferHandle tbuffer)
	{
		return GTestLogBufferExterns.g_test_log_buffer_pop(tbuffer);
	}

	public static GTestLogBufferHandle Push(this GTestLogBufferHandle tbuffer, uint n_bytes, ref byte bytes)
	{
		GTestLogBufferExterns.g_test_log_buffer_push(tbuffer, n_bytes, ref bytes);
		return tbuffer;
	}

	public static GTestLogBufferHandle New()
	{
		return GTestLogBufferExterns.g_test_log_buffer_new();
	}

}
internal class GTestLogBufferExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_test_log_buffer_free(GTestLogBufferHandle tbuffer);

	[DllImport(Libraries.GLib)]
	internal static extern GTestLogMsgHandle g_test_log_buffer_pop(GTestLogBufferHandle tbuffer);

	[DllImport(Libraries.GLib)]
	internal static extern void g_test_log_buffer_push(GTestLogBufferHandle tbuffer, uint n_bytes, ref byte bytes);

	[DllImport(Libraries.GLib)]
	internal static extern GTestLogBufferHandle g_test_log_buffer_new();

}

public struct GTestLogBuffer
{
}
