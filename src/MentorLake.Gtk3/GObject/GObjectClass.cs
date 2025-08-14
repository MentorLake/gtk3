namespace MentorLake.GObject;

/// <summary>
/// <para>
/// The class structure for the GObject type.
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// // Example of implementing a singleton using a constructor.
/// static MySingleton *the_singleton = NULL;
/// </para>
/// <para>
/// static GObject*
/// my_singleton_constructor (GType                  type,
///                           guint                  n_construct_params,
///                           GObjectConstructParam *construct_params)
/// {
///   GObject *object;
/// </para>
/// <para>
///   if (!the_singleton)
///     {
///       object = G_OBJECT_CLASS (parent_class)->constructor (type,
///                                                            n_construct_params,
///                                                            construct_params);
///       the_singleton = MY_SINGLETON (object);
///     }
///   else
///     object = g_object_ref (G_OBJECT (the_singleton));
/// </para>
/// <para>
///   return object;
/// }
/// ]|
/// </para>
/// </summary>

public class GObjectClassHandle : BaseSafeHandle
{
}


public static class GObjectClassExtensions
{
/// <summary>
/// <para>
/// Looks up the #GParamSpec for a property of a class.
/// </para>
/// </summary>

/// <param name="oclass">
/// a #GObjectClass
/// </param>
/// <param name="property_name">
/// the name of the property to look up
/// </param>
/// <return>
/// the #GParamSpec for the property, or
///          %NULL if the class doesn't have a property of that name
/// </return>

	public static MentorLake.GObject.GParamSpecHandle FindProperty(this MentorLake.GObject.GObjectClassHandle oclass, string property_name)
	{
		if (oclass.IsInvalid) throw new Exception("Invalid handle (GObjectClass)");
		return GObjectClassExterns.g_object_class_find_property(oclass, property_name);
	}

/// <summary>
/// <para>
/// Installs new properties from an array of #GParamSpecs.
/// </para>
/// <para>
/// All properties should be installed during the class initializer.  It
/// is possible to install properties after that, but doing so is not
/// recommend, and specifically, is not guaranteed to be thread-safe vs.
/// use of properties on the same type on other threads.
/// </para>
/// <para>
/// The property id of each property is the index of each #GParamSpec in
/// the @pspecs array.
/// </para>
/// <para>
/// The property id of 0 is treated specially by #GObject and it should not
/// be used to store a #GParamSpec.
/// </para>
/// <para>
/// This function should be used if you plan to use a static array of
/// #GParamSpecs and g_object_notify_by_pspec(). For instance, this
/// class initialization:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// typedef enum {
///   PROP_FOO = 1,
///   PROP_BAR,
///   N_PROPERTIES
/// } MyObjectProperty;
/// </para>
/// <para>
/// static GParamSpec *obj_properties[N_PROPERTIES] = { NULL, };
/// </para>
/// <para>
/// static void
/// my_object_class_init (MyObjectClass *klass)
/// {
///   GObjectClass *gobject_class = G_OBJECT_CLASS (klass);
/// </para>
/// <para>
///   obj_properties[PROP_FOO] =
///     g_param_spec_int ("foo", NULL, NULL,
///                       -1, G_MAXINT,
///                       0,
///                       G_PARAM_READWRITE | G_PARAM_STATIC_STRINGS);
/// </para>
/// <para>
///   obj_properties[PROP_BAR] =
///     g_param_spec_string ("bar", NULL, NULL,
///                          NULL,
///                          G_PARAM_READWRITE | G_PARAM_STATIC_STRINGS);
/// </para>
/// <para>
///   gobject_class->set_property = my_object_set_property;
///   gobject_class->get_property = my_object_get_property;
///   g_object_class_install_properties (gobject_class,
///                                      G_N_ELEMENTS (obj_properties),
///                                      obj_properties);
/// }
/// ]|
/// </para>
/// <para>
/// allows calling g_object_notify_by_pspec() to notify of property changes:
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// void
/// my_object_set_foo (MyObject *self, gint foo)
/// {
///   if (self->foo != foo)
///     {
///       self->foo = foo;
///       g_object_notify_by_pspec (G_OBJECT (self), obj_properties[PROP_FOO]);
///     }
///  }
/// ]|
/// </para>
/// </summary>

/// <param name="oclass">
/// a #GObjectClass
/// </param>
/// <param name="n_pspecs">
/// the length of the #GParamSpecs array
/// </param>
/// <param name="pspecs">
/// the #GParamSpecs array
///   defining the new properties
/// </param>

	public static void InstallProperties(this MentorLake.GObject.GObjectClassHandle oclass, uint n_pspecs, MentorLake.GObject.GParamSpecHandle[] pspecs)
	{
		if (oclass.IsInvalid) throw new Exception("Invalid handle (GObjectClass)");
		GObjectClassExterns.g_object_class_install_properties(oclass, n_pspecs, pspecs);
	}

/// <summary>
/// <para>
/// Installs a new property.
/// </para>
/// <para>
/// All properties should be installed during the class initializer.  It
/// is possible to install properties after that, but doing so is not
/// recommend, and specifically, is not guaranteed to be thread-safe vs.
/// use of properties on the same type on other threads.
/// </para>
/// <para>
/// Note that it is possible to redefine a property in a derived class,
/// by installing a property with the same name. This can be useful at times,
/// e.g. to change the range of allowed values or the default value.
/// </para>
/// </summary>

/// <param name="oclass">
/// a #GObjectClass
/// </param>
/// <param name="property_id">
/// the id for the new property
/// </param>
/// <param name="pspec">
/// the #GParamSpec for the new property
/// </param>

	public static void InstallProperty(this MentorLake.GObject.GObjectClassHandle oclass, uint property_id, MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (oclass.IsInvalid) throw new Exception("Invalid handle (GObjectClass)");
		GObjectClassExterns.g_object_class_install_property(oclass, property_id, pspec);
	}

/// <summary>
/// <para>
/// Get an array of #GParamSpec* for all properties of a class.
/// </para>
/// </summary>

/// <param name="oclass">
/// a #GObjectClass
/// </param>
/// <param name="n_properties">
/// return location for the length of the returned array
/// </param>
/// <return>
/// an array of
///          #GParamSpec* which should be freed after use
/// </return>

	public static MentorLake.GObject.GParamSpecHandle[] ListProperties(this MentorLake.GObject.GObjectClassHandle oclass, out uint n_properties)
	{
		if (oclass.IsInvalid) throw new Exception("Invalid handle (GObjectClass)");
		return GObjectClassExterns.g_object_class_list_properties(oclass, out n_properties);
	}

/// <summary>
/// <para>
/// Registers @property_id as referring to a property with the name
/// @name in a parent class or in an interface implemented by @oclass.
/// This allows this class to "override" a property implementation in
/// a parent class or to provide the implementation of a property from
/// an interface.
/// </para>
/// <para>
/// Internally, overriding is implemented by creating a property of type
/// #GParamSpecOverride; generally operations that query the properties of
/// the object class, such as g_object_class_find_property() or
/// g_object_class_list_properties() will return the overridden
/// property. However, in one case, the @construct_properties argument of
/// the @constructor virtual function, the #GParamSpecOverride is passed
/// instead, so that the @param_id field of the #GParamSpec will be
/// correct.  For virtually all uses, this makes no difference. If you
/// need to get the overridden property, you can call
/// g_param_spec_get_redirect_target().
/// </para>
/// </summary>

/// <param name="oclass">
/// a #GObjectClass
/// </param>
/// <param name="property_id">
/// the new property ID
/// </param>
/// <param name="name">
/// the name of a property registered in a parent class or
///  in an interface of this class.
/// </param>

	public static void OverrideProperty(this MentorLake.GObject.GObjectClassHandle oclass, uint property_id, string name)
	{
		if (oclass.IsInvalid) throw new Exception("Invalid handle (GObjectClass)");
		GObjectClassExterns.g_object_class_override_property(oclass, property_id, name);
	}


	public static GObjectClass Dereference(this GObjectClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GObjectClass>(x.DangerousGetHandle());
}
internal class GObjectClassExterns
{
	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_object_class_find_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectClassHandle>))] MentorLake.GObject.GObjectClassHandle oclass, string property_name);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_class_install_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectClassHandle>))] MentorLake.GObject.GObjectClassHandle oclass, uint n_pspecs, [MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle[] pspecs);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_class_install_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectClassHandle>))] MentorLake.GObject.GObjectClassHandle oclass, uint property_id, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle[] g_object_class_list_properties([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectClassHandle>))] MentorLake.GObject.GObjectClassHandle oclass, out uint n_properties);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_object_class_override_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectClassHandle>))] MentorLake.GObject.GObjectClassHandle oclass, uint property_id, string name);

}

/// <summary>
/// <para>
/// The class structure for the GObject type.
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// // Example of implementing a singleton using a constructor.
/// static MySingleton *the_singleton = NULL;
/// </para>
/// <para>
/// static GObject*
/// my_singleton_constructor (GType                  type,
///                           guint                  n_construct_params,
///                           GObjectConstructParam *construct_params)
/// {
///   GObject *object;
/// </para>
/// <para>
///   if (!the_singleton)
///     {
///       object = G_OBJECT_CLASS (parent_class)->constructor (type,
///                                                            n_construct_params,
///                                                            construct_params);
///       the_singleton = MY_SINGLETON (object);
///     }
///   else
///     object = g_object_ref (G_OBJECT (the_singleton));
/// </para>
/// <para>
///   return object;
/// }
/// ]|
/// </para>
/// </summary>

public struct GObjectClass
{
	/// <summary>
/// <para>
/// the parent class
/// </para>
/// </summary>

public GTypeClass g_type_class;
	/// <summary>
/// <para>
/// the @constructor function is called by g_object_new () to
///  complete the object initialization after all the construction properties are
///  set. The first thing a @constructor implementation must do is chain up to the
///  @constructor of the parent class. Overriding @constructor should be rarely
///  needed, e.g. to handle construct properties, or to implement singletons.
/// </para>
/// </summary>

public IntPtr constructor;
	/// <summary>
/// <para>
/// the generic setter for all properties of this type. Should be
///  overridden for every type with properties. If implementations of
///  @set_property don't emit property change notification explicitly, this will
///  be done implicitly by the type system. However, if the notify signal is
///  emitted explicitly, the type system will not emit it a second time.
/// </para>
/// </summary>

public IntPtr set_property;
	/// <summary>
/// <para>
/// the generic getter for all properties of this type. Should be
///  overridden for every type with properties.
/// </para>
/// </summary>

public IntPtr get_property;
	/// <summary>
/// <para>
/// the @dispose function is supposed to drop all references to other
///  objects, but keep the instance otherwise intact, so that client method
///  invocations still work. It may be run multiple times (due to reference
///  loops). Before returning, @dispose should chain up to the @dispose method
///  of the parent class.
/// </para>
/// </summary>

public IntPtr dispose;
	/// <summary>
/// <para>
/// instance finalization function, should finish the finalization of
///  the instance begun in @dispose and chain up to the @finalize method of the
///  parent class.
/// </para>
/// </summary>

public IntPtr finalize;
	/// <summary>
/// <para>
/// emits property change notification for a bunch
///  of properties. Overriding @dispatch_properties_changed should be rarely
///  needed.
/// </para>
/// </summary>

public IntPtr dispatch_properties_changed;
	/// <summary>
/// <para>
/// the class closure for the notify signal
/// </para>
/// </summary>

public IntPtr notify;
	/// <summary>
/// <para>
/// the @constructed function is called by g_object_new() as the
///  final step of the object creation process.  At the point of the call, all
///  construction properties have been set on the object.  The purpose of this
///  call is to allow for object initialisation steps that can only be performed
///  after construction properties have been set.  @constructed implementors
///  should chain up to the @constructed call of their parent class to allow it
///  to complete its initialisation.
/// </para>
/// </summary>

public IntPtr constructed;
}
