namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The type used for marshaller functions.
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn&apos;t return a
///  value.
/// </param>
/// <param name="n_param_values">
/// the length of the @param_values array
/// </param>
/// <param name="param_values">
/// an array of
///  #GValues holding the arguments on which to invoke the
///  callback of @closure
/// </param>
/// <param name="invocation_hint">
/// the invocation hint given as the
///  last argument to g_closure_invoke()
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GClosureMarshal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, uint n_param_values, MentorLake.GObject.GValue[] param_values, IntPtr invocation_hint, IntPtr marshal_data);
