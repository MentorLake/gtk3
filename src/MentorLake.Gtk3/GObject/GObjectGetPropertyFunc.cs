namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The type of the @get_property function of #GObjectClass.
/// </para>
/// </summary>

/// <param name="@object">
/// a #GObject
/// </param>
/// <param name="property_id">
/// the numeric id under which the property was registered with
///  g_object_class_install_property().
/// </param>
/// <param name="value">
/// a #GValue to return the property value in
/// </param>
/// <param name="pspec">
/// the #GParamSpec describing the property
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GObjectGetPropertyFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, uint property_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);
