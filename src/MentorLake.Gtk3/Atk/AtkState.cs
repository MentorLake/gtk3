namespace MentorLake.Atk;

/// <summary>
/// <para>
/// An AtkState describes a single state of an object.
/// </para>
/// <para>
/// An AtkState describes a single state of an object. The full set of states
/// that apply to an object at a given time are contained in its #AtkStateSet.
/// </para>
/// <para>
/// See [id@atk_object_ref_state_set] and [id@atk_object_notify_state_change]
/// </para>
/// </summary>

public struct AtkState
{
	public ulong Value;
}

/// <summary>
/// <para>
/// An AtkState describes a single state of an object.
/// </para>
/// <para>
/// An AtkState describes a single state of an object. The full set of states
/// that apply to an object at a given time are contained in its #AtkStateSet.
/// </para>
/// <para>
/// See [id@atk_object_ref_state_set] and [id@atk_object_notify_state_change]
/// </para>
/// </summary>

public class AtkStateHandle : BaseSafeHandle
{
}

public static class AtkStateHandleExtensions
{
	public static AtkState Dereference(this AtkStateHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkState>(x.DangerousGetHandle());
	public static ulong DereferenceValue(this AtkStateHandle x) => x.Dereference().Value;
}
