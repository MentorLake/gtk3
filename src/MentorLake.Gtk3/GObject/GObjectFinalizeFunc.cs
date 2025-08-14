namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The type of the @finalize function of #GObjectClass.
/// </para>
/// </summary>

/// <param name="@object">
/// the #GObject being finalized
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GObjectFinalizeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);
