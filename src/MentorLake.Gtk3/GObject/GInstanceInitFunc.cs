namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A callback function used by the type system to initialize a new
/// instance of a type.
/// </para>
/// <para>
/// This function initializes all instance members and allocates any resources
/// required by it.
/// </para>
/// <para>
/// Initialization of a derived instance involves calling all its parent
/// types instance initializers, so the class member of the instance
/// is altered during its initialization to always point to the class that
/// belongs to the type the current initializer was introduced for.
/// </para>
/// <para>
/// The extended members of @instance are guaranteed to have been filled with
/// zeros before this function is called.
/// </para>
/// </summary>

/// <param name="instance">
/// The instance to initialize
/// </param>
/// <param name="g_class">
/// The class of the type the instance is
///    created for
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GInstanceInitFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInstanceHandle>))] MentorLake.GObject.GTypeInstanceHandle instance, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class);
