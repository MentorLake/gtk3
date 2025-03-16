namespace MentorLake.Gio;

public class GActionEntryHandle : BaseSafeHandle
{
}


public static class GActionEntryExtensions
{

	public static GActionEntry Dereference(this GActionEntryHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GActionEntry>(x.DangerousGetHandle());
}
internal class GActionEntryExterns
{
}

public struct GActionEntry
{
	public string name;
	public IntPtr activate;
	public string parameter_type;
	public string state;
	public IntPtr change_state;
}
