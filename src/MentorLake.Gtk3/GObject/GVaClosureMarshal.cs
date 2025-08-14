namespace MentorLake.GObject;

/// <summary>
/// <para>
/// This is the signature of va_list marshaller functions, an optional
/// marshaller that can be used in some situations to avoid
/// marshalling the signal argument into GValues.
/// </para>
/// </summary>

/// <param name="closure">
/// the #GClosure to which the marshaller belongs
/// </param>
/// <param name="return_value">
/// a #GValue to store the return
///  value. May be %NULL if the callback of @closure doesn't return a
///  value.
/// </param>
/// <param name="instance">
/// the instance on which the closure is
///  invoked.
/// </param>
/// <param name="args">
/// va_list of arguments to be passed to the closure.
/// </param>
/// <param name="marshal_data">
/// additional data specified when
///  registering the marshaller, see g_closure_set_marshal() and
///  g_closure_set_meta_marshal()
/// </param>
/// <param name="n_params">
/// the length of the @param_types array
/// </param>
/// <param name="param_types">
/// the #GType of each argument from
///  @args.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GVaClosureMarshal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle return_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, IntPtr args, IntPtr marshal_data, int n_params, MentorLake.GObject.GType[] param_types);
