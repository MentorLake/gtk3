namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The signal flags are used to specify a signal&apos;s behaviour.
/// </para>
/// </summary>

[Flags]
public enum GSignalFlags : uint
{
/// <summary>
/// <para>
/// Invoke the object method handler in the first emission stage.
/// </para>
/// </summary>

	G_SIGNAL_RUN_FIRST = 1,
/// <summary>
/// <para>
/// Invoke the object method handler in the third emission stage.
/// </para>
/// </summary>

	G_SIGNAL_RUN_LAST = 2,
/// <summary>
/// <para>
/// Invoke the object method handler in the last emission stage.
/// </para>
/// </summary>

	G_SIGNAL_RUN_CLEANUP = 4,
/// <summary>
/// <para>
/// Signals being emitted for an object while currently being in
///  emission for this very object will not be emitted recursively,
///  but instead cause the first emission to be restarted.
/// </para>
/// </summary>

	G_SIGNAL_NO_RECURSE = 8,
/// <summary>
/// <para>
/// This signal supports &quot;::detail&quot; appendices to the signal name
///  upon handler connections and emissions.
/// </para>
/// </summary>

	G_SIGNAL_DETAILED = 16,
/// <summary>
/// <para>
/// Action signals are signals that may freely be emitted on alive
///  objects from user code via g_signal_emit() and friends, without
///  the need of being embedded into extra code that performs pre or
///  post emission adjustments on the object. They can also be thought
///  of as object methods which can be called generically by
///  third-party code.
/// </para>
/// </summary>

	G_SIGNAL_ACTION = 32,
/// <summary>
/// <para>
/// No emissions hooks are supported for this signal.
/// </para>
/// </summary>

	G_SIGNAL_NO_HOOKS = 64,
/// <summary>
/// <para>
/// Varargs signal emission will always collect the
///   arguments, even if there are no signal handlers connected.  Since 2.30.
/// </para>
/// </summary>

	G_SIGNAL_MUST_COLLECT = 128,
/// <summary>
/// <para>
/// The signal is deprecated and will be removed
///   in a future version. A warning will be generated if it is connected while
///   running with G_ENABLE_DIAGNOSTIC=1.  Since 2.32.
/// </para>
/// </summary>

	G_SIGNAL_DEPRECATED = 256,
/// <summary>
/// <para>
/// Only used in #GSignalAccumulator accumulator
///   functions for the #GSignalInvocationHint::run_type field to mark the first
///   call to the accumulator function for a signal emission.  Since 2.68.
/// </para>
/// </summary>

	G_SIGNAL_ACCUMULATOR_FIRST_RUN = 131072
}
