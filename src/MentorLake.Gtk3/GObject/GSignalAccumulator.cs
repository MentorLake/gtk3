namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The signal accumulator is a special callback function that can be used
/// to collect return values of the various callbacks that are called
/// during a signal emission.
/// </para>
/// <para>
/// The signal accumulator is specified at signal creation time, if it is
/// left %NULL, no accumulation of callback return values is performed.
/// The return value of signal emissions is then the value returned by the
/// last callback.
/// </para>
/// </summary>

/// <param name="ihint">
/// Signal invocation hint, see #GSignalInvocationHint.
/// </param>
/// <param name="return_accu">
/// Accumulator to collect callback return values in, this
///  is the return value of the current signal emission.
/// </param>
/// <param name="handler_return">
/// A #GValue holding the return value of the signal handler.
/// </param>
/// <param name="data">
/// Callback data that was specified when creating the signal.
/// </param>
/// <return>
/// The accumulator function returns whether the signal emission
///  should be aborted. Returning %TRUE will continue with
///  the signal emission. Returning %FALSE will abort the current emission.
///  Since 2.62, returning %FALSE will skip to the CLEANUP stage. In this case,
///  emission will occur as normal in the CLEANUP stage and the handler&apos;s
///  return value will be accumulated.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GSignalAccumulator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GSignalInvocationHintHandle>))] MentorLake.GObject.GSignalInvocationHintHandle ihint, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_accu, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle handler_return, IntPtr data);
