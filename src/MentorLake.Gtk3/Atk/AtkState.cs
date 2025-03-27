namespace MentorLake.Atk;

public struct AtkState
{
	public ulong Value;
}

public class AtkStateHandle : BaseSafeHandle
{
}

public static class AtkStateHandleExtensions
{
	public static AtkState Dereference(this AtkStateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkState>(x.DangerousGetHandle());
	public static ulong DereferenceValue(this AtkStateHandle x) => x.Dereference().Value;
}
