namespace MentorLake.GLib;


public class GTestLogBufferHandle : BaseSafeHandle
{
}


public static class GTestLogBufferExtensions
{
/// <summary>
/// <para>
/// Internal function for gtester to free test log messages, no ABI guarantees provided.
/// </para>
/// </summary>

/// <param name="tbuffer">
/// </param>

	public static void Free(this MentorLake.GLib.GTestLogBufferHandle tbuffer)
	{
		if (tbuffer.IsInvalid) throw new Exception("Invalid handle (GTestLogBuffer)");
		GTestLogBufferExterns.g_test_log_buffer_free(tbuffer);
	}

/// <summary>
/// <para>
/// Internal function for gtester to retrieve test log messages, no ABI guarantees provided.
/// </para>
/// </summary>

/// <param name="tbuffer">
/// </param>

	public static MentorLake.GLib.GTestLogMsgHandle Pop(this MentorLake.GLib.GTestLogBufferHandle tbuffer)
	{
		if (tbuffer.IsInvalid) throw new Exception("Invalid handle (GTestLogBuffer)");
		return GTestLogBufferExterns.g_test_log_buffer_pop(tbuffer);
	}

/// <summary>
/// <para>
/// Internal function for gtester to decode test log messages, no ABI guarantees provided.
/// </para>
/// </summary>

/// <param name="tbuffer">
/// </param>
/// <param name="n_bytes">
/// </param>
/// <param name="bytes">
/// </param>

	public static void Push(this MentorLake.GLib.GTestLogBufferHandle tbuffer, uint n_bytes, byte bytes)
	{
		if (tbuffer.IsInvalid) throw new Exception("Invalid handle (GTestLogBuffer)");
		GTestLogBufferExterns.g_test_log_buffer_push(tbuffer, n_bytes, bytes);
	}


	public static GTestLogBuffer Dereference(this GTestLogBufferHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTestLogBuffer>(x.DangerousGetHandle());
}
internal class GTestLogBufferExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_log_buffer_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestLogBufferHandle>))] MentorLake.GLib.GTestLogBufferHandle tbuffer);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestLogMsgHandle>))]
	internal static extern MentorLake.GLib.GTestLogMsgHandle g_test_log_buffer_pop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestLogBufferHandle>))] MentorLake.GLib.GTestLogBufferHandle tbuffer);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_log_buffer_push([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestLogBufferHandle>))] MentorLake.GLib.GTestLogBufferHandle tbuffer, uint n_bytes, byte bytes);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestLogBufferHandle>))]
	internal static extern MentorLake.GLib.GTestLogBufferHandle g_test_log_buffer_new();

}


public struct GTestLogBuffer
{
/// <summary>
/// <para>
/// Internal function for gtester to decode test log messages, no ABI guarantees provided.
/// </para>
/// </summary>


	public static MentorLake.GLib.GTestLogBufferHandle New()
	{
		return GTestLogBufferExterns.g_test_log_buffer_new();
	}

}
