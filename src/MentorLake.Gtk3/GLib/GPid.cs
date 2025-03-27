namespace MentorLake.GLib;

public struct GPid
{
	public int Value;
}

public class GPidHandle : BaseSafeHandle
{
}

public static class GPidHandleExtensions
{
	public static GPid Dereference(this GPidHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GPid>(x.DangerousGetHandle());
	public static int DereferenceValue(this GPidHandle x) => x.Dereference().Value;
}
