namespace MentorLake.Gio;

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

public struct GInputMessage
{
	public IntPtr address;
	[MarshalAs(UnmanagedType.ByValArray)] public GInputVector[] vectors;
	public uint num_vectors;
	public UIntPtr bytes_received;
	public int flags;
	public IntPtr control_messages;
	public IntPtr num_control_messages;
}
