namespace MentorLake.Atk;

public struct AtkAttributeSet
{
	public MentorLake.GLib.GSList Value;
}

public class AtkAttributeSetHandle : BaseSafeHandle
{
}

public static class AtkAttributeSetHandleExtensions
{
	public static AtkAttributeSet Dereference(this AtkAttributeSetHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkAttributeSet>(x.DangerousGetHandle());
	public static MentorLake.GLib.GSList DereferenceValue(this AtkAttributeSetHandle x) => x.Dereference().Value;
}
