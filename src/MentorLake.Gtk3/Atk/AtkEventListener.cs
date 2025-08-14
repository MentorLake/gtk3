namespace MentorLake.Atk;

/// <summary>
/// <para>
/// A function which is called when an object emits a matching event,
/// as used in #atk_add_focus_tracker.
/// Currently the only events for which object-specific handlers are
/// supported are events of type "focus:".  Most clients of ATK will prefer to
/// attach signal handlers for the various ATK signals instead.
/// </para>
/// <para>
/// see [id@atk_add_focus_tracker]
/// </para>
/// </summary>

/// <param name="obj">
/// An #AtkObject instance for whom the callback will be called when
/// the specified event (e.g. 'focus:') takes place.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void AtkEventListener([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle obj);
