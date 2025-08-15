namespace MentorLake.Atk;

/// <summary>
/// <para>
/// An AtkPropertyChangeHandler is a function which is executed when an
/// AtkObject&apos;s property changes value. It is specified in a call to
/// atk_object_connect_property_change_handler().
/// </para>
/// </summary>

/// <param name="obj">
/// atkobject which property changes
/// </param>
/// <param name="vals">
/// values changed
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void AtkPropertyChangeHandler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkPropertyValuesHandle>))] MentorLake.Atk.AtkPropertyValuesHandle vals);
