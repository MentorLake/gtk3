namespace MentorLake.Gio;

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

public struct GOutputMessage
{
	public IntPtr address;
	public IntPtr vectors;
	public uint num_vectors;
	public uint bytes_sent;
	public IntPtr control_messages;
	public uint num_control_messages;
}
