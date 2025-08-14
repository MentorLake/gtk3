namespace MentorLake.GObject;

/// <summary>
/// <para>
/// An opaque structure used as the base of all interface types.
/// </para>
/// </summary>

public class GTypeInterfaceHandle : BaseSafeHandle
{
}


public static class GTypeInterfaceExtensions
{
/// <summary>
/// <para>
/// Returns the corresponding #GTypeInterface structure of the parent type
/// of the instance type to which @g_iface belongs. This is useful when
/// deriving the implementation of an interface from the parent type and
/// then possibly overriding some methods.
/// </para>
/// </summary>

/// <param name="g_iface">
/// a #GTypeInterface structure
/// </param>
/// <return>
/// the
///     corresponding #GTypeInterface structure of the parent type of the
///     instance type to which @g_iface belongs, or %NULL if the parent
///     type doesn't conform to the interface
/// </return>

	public static MentorLake.GObject.GTypeInterfaceHandle PeekParent(this MentorLake.GObject.GTypeInterfaceHandle g_iface)
	{
		if (g_iface.IsInvalid) throw new Exception("Invalid handle (GTypeInterface)");
		return GTypeInterfaceExterns.g_type_interface_peek_parent(g_iface);
	}


	public static GTypeInterface Dereference(this GTypeInterfaceHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeInterface>(x.DangerousGetHandle());
}
internal class GTypeInterfaceExterns
{
	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))]
	internal static extern MentorLake.GObject.GTypeInterfaceHandle g_type_interface_peek_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))] MentorLake.GObject.GTypeInterfaceHandle g_iface);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_interface_add_prerequisite(MentorLake.GObject.GType interface_type, MentorLake.GObject.GType prerequisite_type);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypePluginHandleImpl>))]
	internal static extern MentorLake.GObject.GTypePluginHandle g_type_interface_get_plugin(MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_type_interface_instantiatable_prerequisite(MentorLake.GObject.GType interface_type);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeInterfaceHandle>))]
	internal static extern MentorLake.GObject.GTypeInterfaceHandle g_type_interface_peek([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle instance_class, MentorLake.GObject.GType iface_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GType[] g_type_interface_prerequisites(MentorLake.GObject.GType interface_type, out uint n_prerequisites);

}

/// <summary>
/// <para>
/// An opaque structure used as the base of all interface types.
/// </para>
/// </summary>

public struct GTypeInterface
{
/// <summary>
/// <para>
/// Adds @prerequisite_type to the list of prerequisites of @interface_type.
/// This means that any type implementing @interface_type must also implement
/// @prerequisite_type. Prerequisites can be thought of as an alternative to
/// interface derivation (which GType doesn't support). An interface can have
/// at most one instantiatable prerequisite type.
/// </para>
/// </summary>

/// <param name="interface_type">
/// #GType value of an interface type
/// </param>
/// <param name="prerequisite_type">
/// #GType value of an interface or instantiatable type
/// </param>

	public static void AddPrerequisite(MentorLake.GObject.GType interface_type, MentorLake.GObject.GType prerequisite_type)
	{
		GTypeInterfaceExterns.g_type_interface_add_prerequisite(interface_type, prerequisite_type);
	}

/// <summary>
/// <para>
/// Returns the #GTypePlugin structure for the dynamic interface
/// @interface_type which has been added to @instance_type, or %NULL
/// if @interface_type has not been added to @instance_type or does
/// not have a #GTypePlugin structure. See g_type_add_interface_dynamic().
/// </para>
/// </summary>

/// <param name="instance_type">
/// #GType of an instantiatable type
/// </param>
/// <param name="interface_type">
/// #GType of an interface type
/// </param>
/// <return>
/// the #GTypePlugin for the dynamic
///     interface @interface_type of @instance_type
/// </return>

	public static MentorLake.GObject.GTypePluginHandle GetPlugin(MentorLake.GObject.GType instance_type, MentorLake.GObject.GType interface_type)
	{
		return GTypeInterfaceExterns.g_type_interface_get_plugin(instance_type, interface_type);
	}

/// <summary>
/// <para>
/// Returns the most specific instantiatable prerequisite of an
/// interface type. If the interface type has no instantiatable
/// prerequisite, %G_TYPE_INVALID is returned.
/// </para>
/// <para>
/// See g_type_interface_add_prerequisite() for more information
/// about prerequisites.
/// </para>
/// </summary>

/// <param name="interface_type">
/// an interface type
/// </param>
/// <return>
/// the instantiatable prerequisite type or %G_TYPE_INVALID if none
/// </return>

	public static MentorLake.GObject.GType InstantiatablePrerequisite(MentorLake.GObject.GType interface_type)
	{
		return GTypeInterfaceExterns.g_type_interface_instantiatable_prerequisite(interface_type);
	}

/// <summary>
/// <para>
/// Returns the #GTypeInterface structure of an interface to which the
/// passed in class conforms.
/// </para>
/// </summary>

/// <param name="instance_class">
/// a #GTypeClass structure
/// </param>
/// <param name="iface_type">
/// an interface ID which this class conforms to
/// </param>
/// <return>
/// the #GTypeInterface
///     structure of @iface_type if implemented by @instance_class, %NULL
///     otherwise
/// </return>

	public static MentorLake.GObject.GTypeInterfaceHandle Peek(MentorLake.GObject.GTypeClassHandle instance_class, MentorLake.GObject.GType iface_type)
	{
		return GTypeInterfaceExterns.g_type_interface_peek(instance_class, iface_type);
	}

/// <summary>
/// <para>
/// Returns the prerequisites of an interfaces type.
/// </para>
/// </summary>

/// <param name="interface_type">
/// an interface type
/// </param>
/// <param name="n_prerequisites">
/// location to return the number
///     of prerequisites, or %NULL
/// </param>
/// <return>
/// a
///     newly-allocated zero-terminated array of #GType containing
///     the prerequisites of @interface_type
/// </return>

	public static MentorLake.GObject.GType[] Prerequisites(MentorLake.GObject.GType interface_type, out uint n_prerequisites)
	{
		return GTypeInterfaceExterns.g_type_interface_prerequisites(interface_type, out n_prerequisites);
	}

}
