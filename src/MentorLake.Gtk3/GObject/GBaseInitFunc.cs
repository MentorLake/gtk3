namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A callback function used by the type system to do base initialization
/// of the class structures of derived types.
/// </para>
/// <para>
/// This function is called as part of the initialization process of all derived
/// classes and should reallocate or reset all dynamic class members copied over
/// from the parent class.
/// </para>
/// <para>
/// For example, class members (such as strings) that are not sufficiently
/// handled by a plain memory copy of the parent class into the derived class
/// have to be altered. See GClassInitFunc() for a discussion of the class
/// initialization process.
/// </para>
/// </summary>

/// <param name="g_class">
/// The #GTypeClass structure to initialize
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBaseInitFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class);
