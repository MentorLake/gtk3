namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Structure used for scatter/gather data input when receiving multiple
/// messages or packets in one go. You generally pass in an array of empty
/// #GInputVectors and the operation will use all the buffers as if they
/// were one buffer, and will set @bytes_received to the total number of bytes
/// received across all #GInputVectors.
/// </para>
/// <para>
/// This structure closely mirrors `struct mmsghdr` and `struct msghdr` from
/// the POSIX sockets API (see `man 2 recvmmsg`).
/// </para>
/// <para>
/// If @address is non-%NULL then it is set to the source address the message
/// was received from, and the caller must free it afterwards.
/// </para>
/// <para>
/// If @control_messages is non-%NULL then it is set to an array of control
/// messages received with the message (if any), and the caller must free it
/// afterwards. @num_control_messages is set to the number of elements in
/// this array, which may be zero.
/// </para>
/// <para>
/// Flags relevant to this message will be returned in @flags. For example,
/// `MSG_EOR` or `MSG_TRUNC`.
/// </para>
/// </summary>

public class GInputMessageHandle : BaseSafeHandle
{
}


public static class GInputMessageExtensions
{

	public static GInputMessage Dereference(this GInputMessageHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GInputMessage>(x.DangerousGetHandle());
}
internal class GInputMessageExterns
{
}

/// <summary>
/// <para>
/// Structure used for scatter/gather data input when receiving multiple
/// messages or packets in one go. You generally pass in an array of empty
/// #GInputVectors and the operation will use all the buffers as if they
/// were one buffer, and will set @bytes_received to the total number of bytes
/// received across all #GInputVectors.
/// </para>
/// <para>
/// This structure closely mirrors `struct mmsghdr` and `struct msghdr` from
/// the POSIX sockets API (see `man 2 recvmmsg`).
/// </para>
/// <para>
/// If @address is non-%NULL then it is set to the source address the message
/// was received from, and the caller must free it afterwards.
/// </para>
/// <para>
/// If @control_messages is non-%NULL then it is set to an array of control
/// messages received with the message (if any), and the caller must free it
/// afterwards. @num_control_messages is set to the number of elements in
/// this array, which may be zero.
/// </para>
/// <para>
/// Flags relevant to this message will be returned in @flags. For example,
/// `MSG_EOR` or `MSG_TRUNC`.
/// </para>
/// </summary>

public struct GInputMessage
{
	/// <summary>
/// <para>
/// return location
///   for a #GSocketAddress, or %NULL
/// </para>
/// </summary>

public IntPtr address;
	/// <summary>
/// <para>
/// pointer to an
///   array of input vectors
/// </para>
/// </summary>

[MarshalAs(UnmanagedType.ByValArray)] public GInputVector[] vectors;
	/// <summary>
/// <para>
/// the number of input vectors pointed to by @vectors
/// </para>
/// </summary>

public uint num_vectors;
	/// <summary>
/// <para>
/// will be set to the number of bytes that have been
///   received
/// </para>
/// </summary>

public UIntPtr bytes_received;
	/// <summary>
/// <para>
/// collection of #GSocketMsgFlags for the received message,
///   outputted by the call
/// </para>
/// </summary>

public int flags;
	/// <summary>
/// <para>
/// return location for a
///   caller-allocated array of #GSocketControlMessages, or %NULL
/// </para>
/// </summary>

public IntPtr control_messages;
	/// <summary>
/// <para>
/// return location for the number of
///   elements in @control_messages
/// </para>
/// </summary>

public IntPtr num_control_messages;
}
