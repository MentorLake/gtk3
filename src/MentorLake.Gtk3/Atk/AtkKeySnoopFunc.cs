namespace MentorLake.Atk;

/// <summary>
/// <para>
/// An #AtkKeySnoopFunc is a type of callback which is called whenever a key event occurs,
/// if registered via atk_add_key_event_listener.  It allows for pre-emptive
/// interception of key events via the return code as described below.
/// </para>
/// </summary>

/// <param name="@event">
/// an AtkKeyEventStruct containing information about the key event for which
/// notification is being given.
/// </param>
/// <param name="user_data">
/// a block of data which will be passed to the event listener, on notification.
/// </param>
/// <return>
/// TRUE (nonzero) if the event emission should be stopped and the event
/// discarded without being passed to the normal GUI recipient; FALSE (zero) if the
/// event dispatch to the client application should proceed as normal.
/// 
/// see [id@atk_add_key_event_listener]
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate int AtkKeySnoopFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkKeyEventStructHandle>))] MentorLake.Atk.AtkKeyEventStructHandle @event, IntPtr user_data);
