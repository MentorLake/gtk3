namespace MentorLake.Atk;

/// <summary>
/// <para>
/// An #AtkEventListenerInit function is a special function that is
/// called in order to initialize the per-object event registration system
/// used by #AtkEventListener, if any preparation is required.
/// </para>
/// <para>
/// see [id@atk_focus_tracker_init]
/// </para>
/// </summary>


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void AtkEventListenerInit();
