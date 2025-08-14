namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The type of value transformation functions which can be registered with
/// g_value_register_transform_func().
/// </para>
/// <para>
/// @dest_value will be initialized to the correct destination type.
/// </para>
/// </summary>

/// <param name="src_value">
/// Source value.
/// </param>
/// <param name="dest_value">
/// Target value.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GValueTransform([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle src_value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle dest_value);
