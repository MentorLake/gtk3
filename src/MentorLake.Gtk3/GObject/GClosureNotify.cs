namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The type used for the various notification callbacks which can be registered
/// on closures.
/// </para>
/// </summary>

/// <param name="data">
/// data specified when registering the notification callback
/// </param>
/// <param name="closure">
/// the #GClosure on which the notification is emitted
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GClosureNotify(IntPtr data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle closure);
