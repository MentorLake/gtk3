namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The #GSignalInvocationHint structure is used to pass on additional information
/// to callbacks during a signal emission.
/// </para>
/// </summary>

public class GSignalInvocationHintHandle : BaseSafeHandle
{
}


public static class GSignalInvocationHintExtensions
{

	public static GSignalInvocationHint Dereference(this GSignalInvocationHintHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSignalInvocationHint>(x.DangerousGetHandle());
}
internal class GSignalInvocationHintExterns
{
}

/// <summary>
/// <para>
/// The #GSignalInvocationHint structure is used to pass on additional information
/// to callbacks during a signal emission.
/// </para>
/// </summary>

public struct GSignalInvocationHint
{
	/// <summary>
/// <para>
/// The signal id of the signal invoking the callback
/// </para>
/// </summary>

public uint signal_id;
	/// <summary>
/// <para>
/// The detail passed on for this emission
/// </para>
/// </summary>

public GQuark detail;
	/// <summary>
/// <para>
/// The stage the signal emission is currently in, this
///  field will contain one of %G_SIGNAL_RUN_FIRST,
///  %G_SIGNAL_RUN_LAST or %G_SIGNAL_RUN_CLEANUP and %G_SIGNAL_ACCUMULATOR_FIRST_RUN.
///  %G_SIGNAL_ACCUMULATOR_FIRST_RUN is only set for the first run of the accumulator
///  function for a signal emission.
/// </para>
/// </summary>

public GSignalFlags run_type;
}
