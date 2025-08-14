namespace MentorLake.Gio;

/// <summary>
/// <para>
/// `GIOExtensionPoint` provides a mechanism for modules to extend the
/// functionality of the library or application that loaded it in an
/// organized fashion.
/// </para>
/// <para>
/// An extension point is identified by a name, and it may optionally
/// require that any implementation must be of a certain type (or derived
/// thereof). Use [func@Gio.IOExtensionPoint.register] to register an
/// extension point, and [method@Gio.IOExtensionPoint.set_required_type] to
/// set a required type.
/// </para>
/// <para>
/// A module can implement an extension point by specifying the
/// [type@GObject.Type] that implements the functionality. Additionally, each
/// implementation of an extension point has a name, and a priority. Use
/// [func@Gio.IOExtensionPoint.implement] to implement an extension point.
/// </para>
/// <para>
/// ```c
/// GIOExtensionPoint *ep;
/// </para>
/// <para>
/// // Register an extension point
/// ep = g_io_extension_point_register ("my-extension-point");
/// g_io_extension_point_set_required_type (ep, MY_TYPE_EXAMPLE);
/// ```
/// </para>
/// <para>
/// ```c
/// // Implement an extension point
/// G_DEFINE_TYPE (MyExampleImpl, my_example_impl, MY_TYPE_EXAMPLE)
/// g_io_extension_point_implement ("my-extension-point",
///                                 my_example_impl_get_type (),
///                                 "my-example",
///                                 10);
/// ```
/// </para>
/// <para>
///  It is up to the code that registered the extension point how
///  it uses the implementations that have been associated with it.
///  Depending on the use case, it may use all implementations, or
///  only the one with the highest priority, or pick a specific
///  one by name.
/// </para>
/// <para>
///  To avoid opening all modules just to find out what extension
///  points they implement, GIO makes use of a caching mechanism,
///  see [gio-querymodules](gio-querymodules.html).
///  You are expected to run this command after installing a
///  GIO module.
/// </para>
/// <para>
///  The `GIO_EXTRA_MODULES` environment variable can be used to
///  specify additional directories to automatically load modules
///  from. This environment variable has the same syntax as the
///  `PATH`. If two modules have the same base name in different
///  directories, then the latter one will be ignored. If additional
///  directories are specified GIO will load modules from the built-in
///  directory last.
/// </para>
/// </summary>

public class GIOExtensionPointHandle : BaseSafeHandle
{
}


public static class GIOExtensionPointExtensions
{
/// <summary>
/// <para>
/// Finds a #GIOExtension for an extension point by name.
/// </para>
/// </summary>

/// <param name="extension_point">
/// a #GIOExtensionPoint
/// </param>
/// <param name="name">
/// the name of the extension to get
/// </param>
/// <return>
/// the #GIOExtension for @extension_point that has the
///    given name, or %NULL if there is no extension with that name
/// </return>

	public static MentorLake.Gio.GIOExtensionHandle GetExtensionByName(this MentorLake.Gio.GIOExtensionPointHandle extension_point, string name)
	{
		if (extension_point.IsInvalid) throw new Exception("Invalid handle (GIOExtensionPoint)");
		return GIOExtensionPointExterns.g_io_extension_point_get_extension_by_name(extension_point, name);
	}

/// <summary>
/// <para>
/// Gets a list of all extensions that implement this extension point.
/// The list is sorted by priority, beginning with the highest priority.
/// </para>
/// </summary>

/// <param name="extension_point">
/// a #GIOExtensionPoint
/// </param>
/// <return>
/// a #GList of
///     #GIOExtensions. The list is owned by GIO and should not be
///     modified.
/// </return>

	public static MentorLake.GLib.GListHandle GetExtensions(this MentorLake.Gio.GIOExtensionPointHandle extension_point)
	{
		if (extension_point.IsInvalid) throw new Exception("Invalid handle (GIOExtensionPoint)");
		return GIOExtensionPointExterns.g_io_extension_point_get_extensions(extension_point);
	}

/// <summary>
/// <para>
/// Gets the required type for @extension_point.
/// </para>
/// </summary>

/// <param name="extension_point">
/// a #GIOExtensionPoint
/// </param>
/// <return>
/// the #GType that all implementations must have,
///   or %G_TYPE_INVALID if the extension point has no required type
/// </return>

	public static MentorLake.GObject.GType GetRequiredType(this MentorLake.Gio.GIOExtensionPointHandle extension_point)
	{
		if (extension_point.IsInvalid) throw new Exception("Invalid handle (GIOExtensionPoint)");
		return GIOExtensionPointExterns.g_io_extension_point_get_required_type(extension_point);
	}

/// <summary>
/// <para>
/// Sets the required type for @extension_point to @type.
/// All implementations must henceforth have this type.
/// </para>
/// </summary>

/// <param name="extension_point">
/// a #GIOExtensionPoint
/// </param>
/// <param name="type">
/// the #GType to require
/// </param>

	public static void SetRequiredType(this MentorLake.Gio.GIOExtensionPointHandle extension_point, MentorLake.GObject.GType type)
	{
		if (extension_point.IsInvalid) throw new Exception("Invalid handle (GIOExtensionPoint)");
		GIOExtensionPointExterns.g_io_extension_point_set_required_type(extension_point, type);
	}


	public static GIOExtensionPoint Dereference(this GIOExtensionPointHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GIOExtensionPoint>(x.DangerousGetHandle());
}
internal class GIOExtensionPointExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionHandle>))]
	internal static extern MentorLake.Gio.GIOExtensionHandle g_io_extension_point_get_extension_by_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionPointHandle>))] MentorLake.Gio.GIOExtensionPointHandle extension_point, string name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_io_extension_point_get_extensions([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionPointHandle>))] MentorLake.Gio.GIOExtensionPointHandle extension_point);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GObject.GType g_io_extension_point_get_required_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionPointHandle>))] MentorLake.Gio.GIOExtensionPointHandle extension_point);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_io_extension_point_set_required_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionPointHandle>))] MentorLake.Gio.GIOExtensionPointHandle extension_point, MentorLake.GObject.GType type);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionHandle>))]
	internal static extern MentorLake.Gio.GIOExtensionHandle g_io_extension_point_implement(string extension_point_name, MentorLake.GObject.GType type, string extension_name, int priority);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionPointHandle>))]
	internal static extern MentorLake.Gio.GIOExtensionPointHandle g_io_extension_point_lookup(string name);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIOExtensionPointHandle>))]
	internal static extern MentorLake.Gio.GIOExtensionPointHandle g_io_extension_point_register(string name);

}

/// <summary>
/// <para>
/// `GIOExtensionPoint` provides a mechanism for modules to extend the
/// functionality of the library or application that loaded it in an
/// organized fashion.
/// </para>
/// <para>
/// An extension point is identified by a name, and it may optionally
/// require that any implementation must be of a certain type (or derived
/// thereof). Use [func@Gio.IOExtensionPoint.register] to register an
/// extension point, and [method@Gio.IOExtensionPoint.set_required_type] to
/// set a required type.
/// </para>
/// <para>
/// A module can implement an extension point by specifying the
/// [type@GObject.Type] that implements the functionality. Additionally, each
/// implementation of an extension point has a name, and a priority. Use
/// [func@Gio.IOExtensionPoint.implement] to implement an extension point.
/// </para>
/// <para>
/// ```c
/// GIOExtensionPoint *ep;
/// </para>
/// <para>
/// // Register an extension point
/// ep = g_io_extension_point_register ("my-extension-point");
/// g_io_extension_point_set_required_type (ep, MY_TYPE_EXAMPLE);
/// ```
/// </para>
/// <para>
/// ```c
/// // Implement an extension point
/// G_DEFINE_TYPE (MyExampleImpl, my_example_impl, MY_TYPE_EXAMPLE)
/// g_io_extension_point_implement ("my-extension-point",
///                                 my_example_impl_get_type (),
///                                 "my-example",
///                                 10);
/// ```
/// </para>
/// <para>
///  It is up to the code that registered the extension point how
///  it uses the implementations that have been associated with it.
///  Depending on the use case, it may use all implementations, or
///  only the one with the highest priority, or pick a specific
///  one by name.
/// </para>
/// <para>
///  To avoid opening all modules just to find out what extension
///  points they implement, GIO makes use of a caching mechanism,
///  see [gio-querymodules](gio-querymodules.html).
///  You are expected to run this command after installing a
///  GIO module.
/// </para>
/// <para>
///  The `GIO_EXTRA_MODULES` environment variable can be used to
///  specify additional directories to automatically load modules
///  from. This environment variable has the same syntax as the
///  `PATH`. If two modules have the same base name in different
///  directories, then the latter one will be ignored. If additional
///  directories are specified GIO will load modules from the built-in
///  directory last.
/// </para>
/// </summary>

public struct GIOExtensionPoint
{
/// <summary>
/// <para>
/// Registers @type as extension for the extension point with name
/// @extension_point_name.
/// </para>
/// <para>
/// If @type has already been registered as an extension for this
/// extension point, the existing #GIOExtension object is returned.
/// </para>
/// </summary>

/// <param name="extension_point_name">
/// the name of the extension point
/// </param>
/// <param name="type">
/// the #GType to register as extension
/// </param>
/// <param name="extension_name">
/// the name for the extension
/// </param>
/// <param name="priority">
/// the priority for the extension
/// </param>
/// <return>
/// a #GIOExtension object for #GType
/// </return>

	public static MentorLake.Gio.GIOExtensionHandle Implement(string extension_point_name, MentorLake.GObject.GType type, string extension_name, int priority)
	{
		return GIOExtensionPointExterns.g_io_extension_point_implement(extension_point_name, type, extension_name, priority);
	}

/// <summary>
/// <para>
/// Looks up an existing extension point.
/// </para>
/// </summary>

/// <param name="name">
/// the name of the extension point
/// </param>
/// <return>
/// the #GIOExtensionPoint, or %NULL if there
///    is no registered extension point with the given name.
/// </return>

	public static MentorLake.Gio.GIOExtensionPointHandle Lookup(string name)
	{
		return GIOExtensionPointExterns.g_io_extension_point_lookup(name);
	}

/// <summary>
/// <para>
/// Registers an extension point.
/// </para>
/// </summary>

/// <param name="name">
/// The name of the extension point
/// </param>
/// <return>
/// the new #GIOExtensionPoint. This object is
///    owned by GIO and should not be freed.
/// </return>

	public static MentorLake.Gio.GIOExtensionPointHandle Register(string name)
	{
		return GIOExtensionPointExterns.g_io_extension_point_register(name);
	}

}
