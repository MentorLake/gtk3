namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Provides an interface for socket-like objects which have datagram semantics,
/// following the Berkeley sockets API. The interface methods are thin wrappers
/// around the corresponding virtual methods, and no pre-processing of inputs is
/// implemented — so implementations of this API must handle all functionality
/// documented in the interface methods.
/// </para>
/// </summary>

public class GDatagramBasedInterfaceHandle : BaseSafeHandle
{
}


public static class GDatagramBasedInterfaceExtensions
{

	public static GDatagramBasedInterface Dereference(this GDatagramBasedInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GDatagramBasedInterface>(x.DangerousGetHandle());
}
internal class GDatagramBasedInterfaceExterns
{
}

/// <summary>
/// <para>
/// Provides an interface for socket-like objects which have datagram semantics,
/// following the Berkeley sockets API. The interface methods are thin wrappers
/// around the corresponding virtual methods, and no pre-processing of inputs is
/// implemented — so implementations of this API must handle all functionality
/// documented in the interface methods.
/// </para>
/// </summary>

public struct GDatagramBasedInterface
{
	/// <summary>
/// <para>
/// The parent interface.
/// </para>
/// </summary>

public GTypeInterface g_iface;
	/// <summary>
/// <para>
/// Virtual method for g_datagram_based_receive_messages().
/// </para>
/// </summary>

public IntPtr receive_messages;
	/// <summary>
/// <para>
/// Virtual method for g_datagram_based_send_messages().
/// </para>
/// </summary>

public IntPtr send_messages;
	/// <summary>
/// <para>
/// Virtual method for g_datagram_based_create_source().
/// </para>
/// </summary>

public IntPtr create_source;
	/// <summary>
/// <para>
/// Virtual method for g_datagram_based_condition_check().
/// </para>
/// </summary>

public IntPtr condition_check;
	/// <summary>
/// <para>
/// Virtual method for
///   g_datagram_based_condition_wait().
/// </para>
/// </summary>

public IntPtr condition_wait;
}
