namespace MentorLake.PangoOT;

public struct PangoOTTag
{
	public uint Value;
}

public class PangoOTTagHandle : BaseSafeHandle
{
}

public static class PangoOTTagHandleExtensions
{
	public static PangoOTTag Dereference(this PangoOTTagHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<PangoOTTag>(x.DangerousGetHandle());
	public static uint DereferenceValue(this PangoOTTagHandle x) => x.Dereference().Value;
}
