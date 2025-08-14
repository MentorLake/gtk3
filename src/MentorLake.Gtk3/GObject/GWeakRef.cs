namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A structure containing a weak reference to a #GObject.
/// </para>
/// <para>
/// A `GWeakRef` can either be empty (i.e. point to %NULL), or point to an
/// object for as long as at least one "strong" reference to that object
/// exists. Before the object's #GObjectClass.dispose method is called,
/// every #GWeakRef associated with becomes empty (i.e. points to %NULL).
/// </para>
/// <para>
/// Like #GValue, #GWeakRef can be statically allocated, stack- or
/// heap-allocated, or embedded in larger structures.
/// </para>
/// <para>
/// Unlike g_object_weak_ref() and g_object_add_weak_pointer(), this weak
/// reference is thread-safe: converting a weak pointer to a reference is
/// atomic with respect to invalidation of weak pointers to destroyed
/// objects.
/// </para>
/// <para>
/// If the object's #GObjectClass.dispose method results in additional
/// references to the object being held (‘re-referencing’), any #GWeakRefs taken
/// before it was disposed will continue to point to %NULL.  Any #GWeakRefs taken
/// during disposal and after re-referencing, or after disposal has returned due
/// to the re-referencing, will continue to point to the object until its refcount
/// goes back to zero, at which point they too will be invalidated.
/// </para>
/// <para>
/// It is invalid to take a #GWeakRef on an object during #GObjectClass.dispose
/// without first having or creating a strong reference to the object.
/// </para>
/// </summary>

public class GWeakRefHandle : BaseSafeHandle
{
}


public static class GWeakRefExtensions
{
/// <summary>
/// <para>
/// Frees resources associated with a non-statically-allocated #GWeakRef.
/// After this call, the #GWeakRef is left in an undefined state.
/// </para>
/// <para>
/// You should only call this on a #GWeakRef that previously had
/// g_weak_ref_init() called on it.
/// </para>
/// </summary>

/// <param name="weak_ref">
/// location of a weak reference, which
///  may be empty
/// </param>

	public static void Clear(this MentorLake.GObject.GWeakRefHandle weak_ref)
	{
		if (weak_ref.IsInvalid) throw new Exception("Invalid handle (GWeakRef)");
		GWeakRefExterns.g_weak_ref_clear(weak_ref);
	}

/// <summary>
/// <para>
/// If @weak_ref is not empty, atomically acquire a strong
/// reference to the object it points to, and return that reference.
/// </para>
/// <para>
/// This function is needed because of the potential race between taking
/// the pointer value and g_object_ref() on it, if the object was losing
/// its last reference at the same time in a different thread.
/// </para>
/// <para>
/// The caller should release the resulting reference in the usual way,
/// by using g_object_unref().
/// </para>
/// </summary>

/// <param name="weak_ref">
/// location of a weak reference to a #GObject
/// </param>
/// <return>
/// the object pointed to
///     by @weak_ref, or %NULL if it was empty
/// </return>

	public static MentorLake.GObject.GObjectHandle Get(this MentorLake.GObject.GWeakRefHandle weak_ref)
	{
		if (weak_ref.IsInvalid) throw new Exception("Invalid handle (GWeakRef)");
		return GWeakRefExterns.g_weak_ref_get(weak_ref);
	}

/// <summary>
/// <para>
/// Initialise a non-statically-allocated #GWeakRef.
/// </para>
/// <para>
/// This function also calls g_weak_ref_set() with @object on the
/// freshly-initialised weak reference.
/// </para>
/// <para>
/// This function should always be matched with a call to
/// g_weak_ref_clear().  It is not necessary to use this function for a
/// #GWeakRef in static storage because it will already be
/// properly initialised.  Just use g_weak_ref_set() directly.
/// </para>
/// </summary>

/// <param name="weak_ref">
/// uninitialized or empty location for a weak reference
/// </param>
/// <param name="@object">
/// a #GObject or %NULL
/// </param>

	public static void Init(this MentorLake.GObject.GWeakRefHandle weak_ref, MentorLake.GObject.GObjectHandle @object)
	{
		if (weak_ref.IsInvalid) throw new Exception("Invalid handle (GWeakRef)");
		GWeakRefExterns.g_weak_ref_init(weak_ref, @object);
	}

/// <summary>
/// <para>
/// Change the object to which @weak_ref points, or set it to
/// %NULL.
/// </para>
/// <para>
/// You must own a strong reference on @object while calling this
/// function.
/// </para>
/// </summary>

/// <param name="weak_ref">
/// location for a weak reference
/// </param>
/// <param name="@object">
/// a #GObject or %NULL
/// </param>

	public static void Set(this MentorLake.GObject.GWeakRefHandle weak_ref, MentorLake.GObject.GObjectHandle @object)
	{
		if (weak_ref.IsInvalid) throw new Exception("Invalid handle (GWeakRef)");
		GWeakRefExterns.g_weak_ref_set(weak_ref, @object);
	}


	public static GWeakRef Dereference(this GWeakRefHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GWeakRef>(x.DangerousGetHandle());
}
internal class GWeakRefExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_weak_ref_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GWeakRefHandle>))] MentorLake.GObject.GWeakRefHandle weak_ref);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_weak_ref_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GWeakRefHandle>))] MentorLake.GObject.GWeakRefHandle weak_ref);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_weak_ref_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GWeakRefHandle>))] MentorLake.GObject.GWeakRefHandle weak_ref, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_weak_ref_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GWeakRefHandle>))] MentorLake.GObject.GWeakRefHandle weak_ref, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

}

/// <summary>
/// <para>
/// A structure containing a weak reference to a #GObject.
/// </para>
/// <para>
/// A `GWeakRef` can either be empty (i.e. point to %NULL), or point to an
/// object for as long as at least one "strong" reference to that object
/// exists. Before the object's #GObjectClass.dispose method is called,
/// every #GWeakRef associated with becomes empty (i.e. points to %NULL).
/// </para>
/// <para>
/// Like #GValue, #GWeakRef can be statically allocated, stack- or
/// heap-allocated, or embedded in larger structures.
/// </para>
/// <para>
/// Unlike g_object_weak_ref() and g_object_add_weak_pointer(), this weak
/// reference is thread-safe: converting a weak pointer to a reference is
/// atomic with respect to invalidation of weak pointers to destroyed
/// objects.
/// </para>
/// <para>
/// If the object's #GObjectClass.dispose method results in additional
/// references to the object being held (‘re-referencing’), any #GWeakRefs taken
/// before it was disposed will continue to point to %NULL.  Any #GWeakRefs taken
/// during disposal and after re-referencing, or after disposal has returned due
/// to the re-referencing, will continue to point to the object until its refcount
/// goes back to zero, at which point they too will be invalidated.
/// </para>
/// <para>
/// It is invalid to take a #GWeakRef on an object during #GObjectClass.dispose
/// without first having or creating a strong reference to the object.
/// </para>
/// </summary>

public struct GWeakRef
{
}
