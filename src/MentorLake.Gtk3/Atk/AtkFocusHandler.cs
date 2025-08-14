namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The type of callback function used for
/// atk_component_add_focus_handler() and
/// atk_component_remove_focus_handler()
/// </para>
/// </summary>

/// <param name="@object">
/// the #AtkObject that receives/lose the focus
/// </param>
/// <param name="focus_in">
/// TRUE if the object receives the focus
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void AtkFocusHandler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle @object, bool focus_in);
