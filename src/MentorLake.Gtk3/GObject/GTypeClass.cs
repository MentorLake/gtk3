namespace MentorLake.GObject;

/// <summary>
/// <para>
/// An opaque structure used as the base of all classes.
/// </para>
/// </summary>

public class GTypeClassHandle : BaseSafeHandle
{
}


public static class GTypeClassExtensions
{
/// <summary>
/// <para>
/// Registers a private structure for an instantiatable type.
/// </para>
/// <para>
/// When an object is allocated, the private structures for
/// the type and all of its parent types are allocated
/// sequentially in the same memory block as the public
/// structures, and are zero-filled.
/// </para>
/// <para>
/// Note that the accumulated size of the private structures of
/// a type and all its parent types cannot exceed 64 KiB.
/// </para>
/// <para>
/// This function should be called in the type&apos;s class_init() function.
/// The private structure can be retrieved using the
/// G_TYPE_INSTANCE_GET_PRIVATE() macro.
/// </para>
/// <para>
/// The following example shows attaching a private structure
/// MyObjectPrivate to an object MyObject defined in the standard
/// GObject fashion in the type&apos;s class_init() function.
/// </para>
/// <para>
/// Note the use of a structure member &quot;priv&quot; to avoid the overhead
/// of repeatedly calling MY_OBJECT_GET_PRIVATE().
/// </para>
/// <code>
/// typedef struct _MyObject        MyObject;
/// typedef struct _MyObject        MyObject;
/// typedef struct _MyObjectPrivate MyObjectPrivate;
/// 
/// struct _MyObject {
///  GObject parent;
/// 
///  MyObjectPrivate *priv;
/// };
/// 
/// struct _MyObjectPrivate {
///   int some_field;
/// };
/// 
/// static void
/// my_object_class_init (MyObjectClass *klass)
/// {
///   g_type_class_add_private (klass, sizeof (MyObjectPrivate));
/// }
/// 
/// static void
/// my_object_init (MyObject *my_object)
/// {
///   my_object-&amp;gt;priv = G_TYPE_INSTANCE_GET_PRIVATE (my_object,
///                                                  MY_TYPE_OBJECT,
///                                                  MyObjectPrivate);
///   // my_object-&amp;gt;priv-&amp;gt;some_field will be automatically initialised to 0
/// }
/// 
/// static int
/// my_object_get_some_field (MyObject *my_object)
/// {
///   MyObjectPrivate *priv;
/// 
///   g_return_val_if_fail (MY_IS_OBJECT (my_object), 0);
/// 
///   priv = my_object-&amp;gt;priv;
/// 
///   return priv-&amp;gt;some_field;
/// }
/// </code>
/// </summary>

/// <param name="g_class">
/// class structure for an instantiatable
///    type
/// </param>
/// <param name="private_size">
/// size of private structure
/// </param>

	public static void AddPrivate(this MentorLake.GObject.GTypeClassHandle g_class, UIntPtr private_size)
	{
		if (g_class.IsInvalid) throw new Exception("Invalid handle (GTypeClass)");
		GTypeClassExterns.g_type_class_add_private(g_class, private_size);
	}

/// <summary>
/// <para>
/// Gets the offset of the private data for instances of @g_class.
/// </para>
/// <para>
/// This is how many bytes you should add to the instance pointer of a
/// class in order to get the private data for the type represented by
/// @g_class.
/// </para>
/// <para>
/// You can only call this function after you have registered a private
/// data area for @g_class using g_type_class_add_private().
/// </para>
/// </summary>

/// <param name="g_class">
/// a #GTypeClass
/// </param>
/// <return>
/// the offset, in bytes
/// </return>

	public static int GetInstancePrivateOffset(this MentorLake.GObject.GTypeClassHandle g_class)
	{
		if (g_class.IsInvalid) throw new Exception("Invalid handle (GTypeClass)");
		return GTypeClassExterns.g_type_class_get_instance_private_offset(g_class);
	}


/// <param name="klass">
/// </param>
/// <param name="private_type">
/// </param>

	public static IntPtr GetPrivate(this MentorLake.GObject.GTypeClassHandle klass, MentorLake.GObject.GType private_type)
	{
		if (klass.IsInvalid) throw new Exception("Invalid handle (GTypeClass)");
		return GTypeClassExterns.g_type_class_get_private(klass, private_type);
	}

/// <summary>
/// <para>
/// This is a convenience function often needed in class initializers.
/// It returns the class structure of the immediate parent type of the
/// class passed in.  Since derived classes hold a reference count on
/// their parent classes as long as they are instantiated, the returned
/// class will always exist.
/// </para>
/// <para>
/// This function is essentially equivalent to:
/// g_type_class_peek (g_type_parent (G_TYPE_FROM_CLASS (g_class)))
/// </para>
/// </summary>

/// <param name="g_class">
/// the #GTypeClass structure to
///     retrieve the parent class for
/// </param>
/// <return>
/// the parent class
///     of @g_class
/// </return>

	public static MentorLake.GObject.GTypeClassHandle PeekParent(this MentorLake.GObject.GTypeClassHandle g_class)
	{
		if (g_class.IsInvalid) throw new Exception("Invalid handle (GTypeClass)");
		return GTypeClassExterns.g_type_class_peek_parent(g_class);
	}

/// <summary>
/// <para>
/// Decrements the reference count of the class structure being passed in.
/// Once the last reference count of a class has been released, classes
/// may be finalized by the type system, so further dereferencing of a
/// class pointer after g_type_class_unref() are invalid.
/// </para>
/// </summary>

/// <param name="g_class">
/// a #GTypeClass structure to unref
/// </param>

	public static void Unref(this MentorLake.GObject.GTypeClassHandle g_class)
	{
		if (g_class.IsInvalid) throw new Exception("Invalid handle (GTypeClass)");
		GTypeClassExterns.g_type_class_unref(g_class);
	}

/// <summary>
/// <para>
/// A variant of g_type_class_unref() for use in #GTypeClassCacheFunc
/// implementations. It unreferences a class without consulting the chain
/// of #GTypeClassCacheFuncs, avoiding the recursion which would occur
/// otherwise.
/// </para>
/// </summary>

/// <param name="g_class">
/// a #GTypeClass structure to unref
/// </param>

	public static void UnrefUncached(this MentorLake.GObject.GTypeClassHandle g_class)
	{
		if (g_class.IsInvalid) throw new Exception("Invalid handle (GTypeClass)");
		GTypeClassExterns.g_type_class_unref_uncached(g_class);
	}


	public static GTypeClass Dereference(this GTypeClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeClass>(x.DangerousGetHandle());
}
internal class GTypeClassExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_class_add_private([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class, UIntPtr private_size);

	[DllImport(GObjectLibrary.Name)]
	internal static extern int g_type_class_get_instance_private_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_type_class_get_private([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle klass, MentorLake.GObject.GType private_type);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))]
	internal static extern MentorLake.GObject.GTypeClassHandle g_type_class_peek_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_class_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_class_unref_uncached([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_class_adjust_private_offset(IntPtr g_class, int private_size_or_offset);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))]
	internal static extern MentorLake.GObject.GTypeClassHandle g_type_class_peek(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))]
	internal static extern MentorLake.GObject.GTypeClassHandle g_type_class_peek_static(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))]
	internal static extern MentorLake.GObject.GTypeClassHandle g_type_class_ref(MentorLake.GObject.GType type);

}

/// <summary>
/// <para>
/// An opaque structure used as the base of all classes.
/// </para>
/// </summary>

public struct GTypeClass
{

/// <param name="g_class">
/// </param>
/// <param name="private_size_or_offset">
/// </param>

	public static void AdjustPrivateOffset(IntPtr g_class, int private_size_or_offset)
	{
		GTypeClassExterns.g_type_class_adjust_private_offset(g_class, private_size_or_offset);
	}

/// <summary>
/// <para>
/// This function is essentially the same as g_type_class_ref(),
/// except that the classes reference count isn&apos;t incremented.
/// As a consequence, this function may return %NULL if the class
/// of the type passed in does not currently exist (hasn&apos;t been
/// referenced before).
/// </para>
/// </summary>

/// <param name="type">
/// type ID of a classed type
/// </param>
/// <return>
/// the #GTypeClass
///     structure for the given type ID or %NULL if the class does not
///     currently exist
/// </return>

	public static MentorLake.GObject.GTypeClassHandle Peek(MentorLake.GObject.GType type)
	{
		return GTypeClassExterns.g_type_class_peek(type);
	}

/// <summary>
/// <para>
/// A more efficient version of g_type_class_peek() which works only for
/// static types.
/// </para>
/// </summary>

/// <param name="type">
/// type ID of a classed type
/// </param>
/// <return>
/// the #GTypeClass
///     structure for the given type ID or %NULL if the class does not
///     currently exist or is dynamically loaded
/// </return>

	public static MentorLake.GObject.GTypeClassHandle PeekStatic(MentorLake.GObject.GType type)
	{
		return GTypeClassExterns.g_type_class_peek_static(type);
	}

/// <summary>
/// <para>
/// Increments the reference count of the class structure belonging to
/// @type. This function will demand-create the class if it doesn&apos;t
/// exist already.
/// </para>
/// </summary>

/// <param name="type">
/// type ID of a classed type
/// </param>
/// <return>
/// the #GTypeClass
///     structure for the given type ID
/// </return>

	public static MentorLake.GObject.GTypeClassHandle Ref(MentorLake.GObject.GType type)
	{
		return GTypeClassExterns.g_type_class_ref(type);
	}

}
