namespace MentorLake.Gio;

/// <summary>
/// <para>
/// Class structure for #GSocketControlMessage.
/// </para>
/// </summary>

public class GSocketControlMessageClassHandle : BaseSafeHandle
{
}


public static class GSocketControlMessageClassExtensions
{

	public static GSocketControlMessageClass Dereference(this GSocketControlMessageClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSocketControlMessageClass>(x.DangerousGetHandle());
}
internal class GSocketControlMessageClassExterns
{
}

/// <summary>
/// <para>
/// Class structure for #GSocketControlMessage.
/// </para>
/// </summary>

public struct GSocketControlMessageClass
{
	
public GObjectClass parent_class;
	/// <summary>
/// <para>
/// gets the size of the message.
/// </para>
/// </summary>

public IntPtr get_size;
	/// <summary>
/// <para>
/// gets the protocol of the message.
/// </para>
/// </summary>

public IntPtr get_level;
	/// <summary>
/// <para>
/// gets the protocol specific type of the message.
/// </para>
/// </summary>

public IntPtr get_type;
	/// <summary>
/// <para>
/// Writes out the message data.
/// </para>
/// </summary>

public IntPtr serialize;
	/// <summary>
/// <para>
/// Tries to deserialize a message.
/// </para>
/// </summary>

public IntPtr deserialize;
	
public IntPtr _g_reserved1;
	
public IntPtr _g_reserved2;
	
public IntPtr _g_reserved3;
	
public IntPtr _g_reserved4;
	
public IntPtr _g_reserved5;
}
