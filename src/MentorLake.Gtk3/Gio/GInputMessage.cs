namespace MentorLake.Gtk3.Gio;

public class GInputMessageHandle : BaseSafeHandle
{
}


public static class GInputMessageHandleExtensions
{
}
internal class GInputMessageExterns
{
}

public struct GInputMessage
{
	public IntPtr address;
	public GInputVectorHandle vectors;
	public uint num_vectors;
	public UIntPtr bytes_received;
	public int flags;
	public IntPtr control_messages;
	public uint[] num_control_messages;
}
