namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A #GParamSpecPool maintains a collection of #GParamSpecs which can be
/// quickly accessed by owner and name.
/// </para>
/// <para>
/// The implementation of the #GObject property system uses such a pool to
/// store the #GParamSpecs of the properties all object types.
/// </para>
/// </summary>

public class GParamSpecPoolHandle : BaseSafeHandle
{
}


public static class GParamSpecPoolExtensions
{
/// <summary>
/// <para>
/// Frees the resources allocated by a #GParamSpecPool.
/// </para>
/// </summary>

/// <param name="pool">
/// a #GParamSpecPool
/// </param>

	public static void Free(this MentorLake.GObject.GParamSpecPoolHandle pool)
	{
		if (pool.IsInvalid) throw new Exception("Invalid handle (GParamSpecPool)");
		GParamSpecPoolExterns.g_param_spec_pool_free(pool);
	}

/// <summary>
/// <para>
/// Inserts a #GParamSpec in the pool.
/// </para>
/// </summary>

/// <param name="pool">
/// a #GParamSpecPool.
/// </param>
/// <param name="pspec">
/// the #GParamSpec to insert
/// </param>
/// <param name="owner_type">
/// a #GType identifying the owner of @pspec
/// </param>

	public static void Insert(this MentorLake.GObject.GParamSpecPoolHandle pool, MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GObject.GType owner_type)
	{
		if (pool.IsInvalid) throw new Exception("Invalid handle (GParamSpecPool)");
		GParamSpecPoolExterns.g_param_spec_pool_insert(pool, pspec, owner_type);
	}

/// <summary>
/// <para>
/// Gets an array of all #GParamSpecs owned by @owner_type in
/// the pool.
/// </para>
/// </summary>

/// <param name="pool">
/// a #GParamSpecPool
/// </param>
/// <param name="owner_type">
/// the owner to look for
/// </param>
/// <param name="n_pspecs_p">
/// return location for the length of the returned array
/// </param>
/// <return>
/// a newly
///          allocated array containing pointers to all #GParamSpecs
///          owned by @owner_type in the pool
/// </return>

	public static MentorLake.GObject.GParamSpecHandle[] List(this MentorLake.GObject.GParamSpecPoolHandle pool, MentorLake.GObject.GType owner_type, out uint n_pspecs_p)
	{
		if (pool.IsInvalid) throw new Exception("Invalid handle (GParamSpecPool)");
		return GParamSpecPoolExterns.g_param_spec_pool_list(pool, owner_type, out n_pspecs_p);
	}

/// <summary>
/// <para>
/// Gets an #GList of all #GParamSpecs owned by @owner_type in
/// the pool.
/// </para>
/// </summary>

/// <param name="pool">
/// a #GParamSpecPool
/// </param>
/// <param name="owner_type">
/// the owner to look for
/// </param>
/// <return>
/// a
///          #GList of all #GParamSpecs owned by @owner_type in
///          the pool#GParamSpecs.
/// </return>

	public static MentorLake.GLib.GListHandle ListOwned(this MentorLake.GObject.GParamSpecPoolHandle pool, MentorLake.GObject.GType owner_type)
	{
		if (pool.IsInvalid) throw new Exception("Invalid handle (GParamSpecPool)");
		return GParamSpecPoolExterns.g_param_spec_pool_list_owned(pool, owner_type);
	}

/// <summary>
/// <para>
/// Looks up a #GParamSpec in the pool.
/// </para>
/// </summary>

/// <param name="pool">
/// a #GParamSpecPool
/// </param>
/// <param name="param_name">
/// the name to look for
/// </param>
/// <param name="owner_type">
/// the owner to look for
/// </param>
/// <param name="walk_ancestors">
/// If %TRUE, also try to find a #GParamSpec with @param_name
///  owned by an ancestor of @owner_type.
/// </param>
/// <return>
/// The found #GParamSpec, or %NULL if no
/// matching #GParamSpec was found.
/// </return>

	public static MentorLake.GObject.GParamSpecHandle Lookup(this MentorLake.GObject.GParamSpecPoolHandle pool, string param_name, MentorLake.GObject.GType owner_type, bool walk_ancestors)
	{
		if (pool.IsInvalid) throw new Exception("Invalid handle (GParamSpecPool)");
		return GParamSpecPoolExterns.g_param_spec_pool_lookup(pool, param_name, owner_type, walk_ancestors);
	}

/// <summary>
/// <para>
/// Removes a #GParamSpec from the pool.
/// </para>
/// </summary>

/// <param name="pool">
/// a #GParamSpecPool
/// </param>
/// <param name="pspec">
/// the #GParamSpec to remove
/// </param>

	public static void Remove(this MentorLake.GObject.GParamSpecPoolHandle pool, MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (pool.IsInvalid) throw new Exception("Invalid handle (GParamSpecPool)");
		GParamSpecPoolExterns.g_param_spec_pool_remove(pool, pspec);
	}


	public static GParamSpecPool Dereference(this GParamSpecPoolHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GParamSpecPool>(x.DangerousGetHandle());
}
internal class GParamSpecPoolExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_param_spec_pool_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecPoolHandle>))] MentorLake.GObject.GParamSpecPoolHandle pool);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_param_spec_pool_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecPoolHandle>))] MentorLake.GObject.GParamSpecPoolHandle pool, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GObject.GType owner_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle[] g_param_spec_pool_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecPoolHandle>))] MentorLake.GObject.GParamSpecPoolHandle pool, MentorLake.GObject.GType owner_type, out uint n_pspecs_p);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_param_spec_pool_list_owned([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecPoolHandle>))] MentorLake.GObject.GParamSpecPoolHandle pool, MentorLake.GObject.GType owner_type);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_pool_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecPoolHandle>))] MentorLake.GObject.GParamSpecPoolHandle pool, string param_name, MentorLake.GObject.GType owner_type, bool walk_ancestors);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_param_spec_pool_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecPoolHandle>))] MentorLake.GObject.GParamSpecPoolHandle pool, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecPoolHandle>))]
	internal static extern MentorLake.GObject.GParamSpecPoolHandle g_param_spec_pool_new(bool type_prefixing);

}

/// <summary>
/// <para>
/// A #GParamSpecPool maintains a collection of #GParamSpecs which can be
/// quickly accessed by owner and name.
/// </para>
/// <para>
/// The implementation of the #GObject property system uses such a pool to
/// store the #GParamSpecs of the properties all object types.
/// </para>
/// </summary>

public struct GParamSpecPool
{
/// <summary>
/// <para>
/// Creates a new #GParamSpecPool.
/// </para>
/// <para>
/// If @type_prefixing is %TRUE, lookups in the newly created pool will
/// allow to specify the owner as a colon-separated prefix of the
/// property name, like &quot;GtkContainer:border-width&quot;. This feature is
/// deprecated, so you should always set @type_prefixing to %FALSE.
/// </para>
/// </summary>

/// <param name="type_prefixing">
/// Whether the pool will support type-prefixed property names.
/// </param>
/// <return>
/// a newly allocated #GParamSpecPool.
/// </return>

	public static MentorLake.GObject.GParamSpecPoolHandle New(bool type_prefixing)
	{
		return GParamSpecPoolExterns.g_param_spec_pool_new(type_prefixing);
	}

}
