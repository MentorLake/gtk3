namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A function to be called to transform @from_value to @to_value.
/// </para>
/// <para>
/// If this is the @transform_to function of a binding, then @from_value
/// is the @source_property on the @source object, and @to_value is the
/// @target_property on the @target object. If this is the
/// @transform_from function of a %G_BINDING_BIDIRECTIONAL binding,
/// then those roles are reversed.
/// </para>
/// </summary>

/// <param name="binding">
/// a #GBinding
/// </param>
/// <param name="from_value">
/// the #GValue containing the value to transform
/// </param>
/// <param name="to_value">
/// the #GValue in which to store the transformed value
/// </param>
/// <param name="user_data">
/// data passed to the transform function
/// </param>
/// <return>
/// %TRUE if the transformation was successful, and %FALSE
///   otherwise
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GBindingTransformFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingHandle>))] MentorLake.GObject.GBindingHandle binding, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle from_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle to_value, IntPtr user_data);
