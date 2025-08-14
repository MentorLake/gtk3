namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A simple function pointer to get invoked when the signal is emitted.
/// </para>
/// <para>
/// Emission hooks allow you to tie a hook to the signal type, so that it will
/// trap all emissions of that signal, from any object.
/// </para>
/// <para>
/// You may not attach these to signals created with the %G_SIGNAL_NO_HOOKS flag.
/// </para>
/// </summary>

/// <param name="ihint">
/// Signal invocation hint, see #GSignalInvocationHint.
/// </param>
/// <param name="n_param_values">
/// the number of parameters to the function, including
///  the instance on which the signal was emitted.
/// </param>
/// <param name="param_values">
/// the instance on which
///  the signal was emitted, followed by the parameters of the emission.
/// </param>
/// <param name="data">
/// user data associated with the hook.
/// </param>
/// <return>
/// whether it wants to stay connected. If it returns %FALSE, the signal
///  hook is disconnected (and destroyed).
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GSignalEmissionHook([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalInvocationHintHandle>))] MentorLake.GObject.GSignalInvocationHintHandle ihint, uint n_param_values, MentorLake.GObject.GValue[] param_values, IntPtr data);
