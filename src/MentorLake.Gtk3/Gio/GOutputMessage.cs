namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Structure used for scatter/gather data output when sending multiple
/// messages or packets in one go. You generally pass in an array of
/// #GOutputVectors and the operation will use all the buffers as if they
/// were one buffer.
/// </para>
/// <para>
/// If @address is %NULL then the message is sent to the default receiver
/// (as previously set by g_socket_connect()).
/// </para>
/// </summary>

public class GOutputMessageHandle : BaseSafeHandle
{
}


public static class GOutputMessageExtensions
{

	public static GOutputMessage Dereference(this GOutputMessageHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GOutputMessage>(x.DangerousGetHandle());
}
internal class GOutputMessageExterns
{
}

/// <summary>
/// <para>
/// Structure used for scatter/gather data output when sending multiple
/// messages or packets in one go. You generally pass in an array of
/// #GOutputVectors and the operation will use all the buffers as if they
/// were one buffer.
/// </para>
/// <para>
/// If @address is %NULL then the message is sent to the default receiver
/// (as previously set by g_socket_connect()).
/// </para>
/// </summary>

public struct GOutputMessage
{
	/// <summary>
/// <para>
/// a #GSocketAddress, or %NULL
/// </para>
/// </summary>

public IntPtr address;
	/// <summary>
/// <para>
/// pointer to an array of output vectors
/// </para>
/// </summary>

public IntPtr vectors;
	/// <summary>
/// <para>
/// the number of output vectors pointed to by @vectors.
/// </para>
/// </summary>

public uint num_vectors;
	/// <summary>
/// <para>
/// initialize to 0. Will be set to the number of bytes
///     that have been sent
/// </para>
/// </summary>

public uint bytes_sent;
	/// <summary>
/// <para>
/// a pointer
///   to an array of #GSocketControlMessages, or %NULL.
/// </para>
/// </summary>

public IntPtr control_messages;
	/// <summary>
/// <para>
/// number of elements in @control_messages.
/// </para>
/// </summary>

public uint num_control_messages;
}
