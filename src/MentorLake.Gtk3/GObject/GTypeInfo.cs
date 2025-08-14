namespace MentorLake.GObject;

/// <summary>
/// <para>
/// This structure is used to provide the type system with the information
/// required to initialize and destruct (finalize) a type's class and
/// its instances.
/// </para>
/// <para>
/// The initialized structure is passed to the g_type_register_static() function
/// (or is copied into the provided #GTypeInfo structure in the
/// g_type_plugin_complete_type_info()). The type system will perform a deep
/// copy of this structure, so its memory does not need to be persistent
/// across invocation of g_type_register_static().
/// </para>
/// </summary>

public class GTypeInfoHandle : BaseSafeHandle
{
}


public static class GTypeInfoExtensions
{

	public static GTypeInfo Dereference(this GTypeInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeInfo>(x.DangerousGetHandle());
}
internal class GTypeInfoExterns
{
}

/// <summary>
/// <para>
/// This structure is used to provide the type system with the information
/// required to initialize and destruct (finalize) a type's class and
/// its instances.
/// </para>
/// <para>
/// The initialized structure is passed to the g_type_register_static() function
/// (or is copied into the provided #GTypeInfo structure in the
/// g_type_plugin_complete_type_info()). The type system will perform a deep
/// copy of this structure, so its memory does not need to be persistent
/// across invocation of g_type_register_static().
/// </para>
/// </summary>

public struct GTypeInfo
{
	/// <summary>
/// <para>
/// Size of the class structure (required for interface, classed and instantiatable types)
/// </para>
/// </summary>

public ushort class_size;
	/// <summary>
/// <para>
/// Location of the base initialization function (optional)
/// </para>
/// </summary>

public GBaseInitFunc base_init;
	/// <summary>
/// <para>
/// Location of the base finalization function (optional)
/// </para>
/// </summary>

public GBaseFinalizeFunc base_finalize;
	/// <summary>
/// <para>
/// Location of the class initialization function for
///  classed and instantiatable types. Location of the default vtable
///  initialization function for interface types. (optional) This function
///  is used both to fill in virtual functions in the class or default vtable,
///  and to do type-specific setup such as registering signals and object
///  properties.
/// </para>
/// </summary>

public GClassInitFunc class_init;
	/// <summary>
/// <para>
/// Location of the class finalization function for
///  classed and instantiatable types. Location of the default vtable
///  finalization function for interface types. (optional)
/// </para>
/// </summary>

public GClassFinalizeFunc class_finalize;
	/// <summary>
/// <para>
/// User-supplied data passed to the class init/finalize functions
/// </para>
/// </summary>

public IntPtr class_data;
	/// <summary>
/// <para>
/// Size of the instance (object) structure (required for instantiatable types only)
/// </para>
/// </summary>

public ushort instance_size;
	/// <summary>
/// <para>
/// Prior to GLib 2.10, it specified the number of pre-allocated (cached) instances to reserve memory for (0 indicates no caching). Since GLib 2.10 this field is ignored.
/// </para>
/// </summary>

public ushort n_preallocs;
	/// <summary>
/// <para>
/// Location of the instance initialization function (optional, for instantiatable types only)
/// </para>
/// </summary>

public GInstanceInitFunc instance_init;
	/// <summary>
/// <para>
/// A #GTypeValueTable function table for generic handling of GValues
///  of this type (usually only useful for fundamental types)
/// </para>
/// </summary>

public IntPtr value_table;
}
