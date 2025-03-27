namespace MentorLake.GLib;

public struct GQuark
{
	public uint Value;
}

public class GQuarkHandle : BaseSafeHandle
{
}

public static class GQuarkHandleExtensions
{
	public static GQuark Dereference(this GQuarkHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GQuark>(x.DangerousGetHandle());
	public static uint DereferenceValue(this GQuarkHandle x) => x.Dereference().Value;
}
