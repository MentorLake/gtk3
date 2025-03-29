namespace MentorLake.GObject;

public class GParamSpecPoolHandle : BaseSafeHandle
{
}


public static class GParamSpecPoolExtensions
{
	public static void Free(this MentorLake.GObject.GParamSpecPoolHandle pool)
	{
		if (pool.IsInvalid || pool.IsClosed) throw new Exception("Invalid or closed handle (GParamSpecPool)");
		GParamSpecPoolExterns.g_param_spec_pool_free(pool);
	}

	public static void Insert(this MentorLake.GObject.GParamSpecPoolHandle pool, MentorLake.GObject.GParamSpecHandle pspec, MentorLake.GObject.GType owner_type)
	{
		if (pool.IsInvalid || pool.IsClosed) throw new Exception("Invalid or closed handle (GParamSpecPool)");
		GParamSpecPoolExterns.g_param_spec_pool_insert(pool, pspec, owner_type);
	}

	public static MentorLake.GObject.GParamSpecHandle[] List(this MentorLake.GObject.GParamSpecPoolHandle pool, MentorLake.GObject.GType owner_type, out uint n_pspecs_p)
	{
		if (pool.IsInvalid || pool.IsClosed) throw new Exception("Invalid or closed handle (GParamSpecPool)");
		return GParamSpecPoolExterns.g_param_spec_pool_list(pool, owner_type, out n_pspecs_p);
	}

	public static MentorLake.GLib.GListHandle ListOwned(this MentorLake.GObject.GParamSpecPoolHandle pool, MentorLake.GObject.GType owner_type)
	{
		if (pool.IsInvalid || pool.IsClosed) throw new Exception("Invalid or closed handle (GParamSpecPool)");
		return GParamSpecPoolExterns.g_param_spec_pool_list_owned(pool, owner_type);
	}

	public static MentorLake.GObject.GParamSpecHandle Lookup(this MentorLake.GObject.GParamSpecPoolHandle pool, string param_name, MentorLake.GObject.GType owner_type, bool walk_ancestors)
	{
		if (pool.IsInvalid || pool.IsClosed) throw new Exception("Invalid or closed handle (GParamSpecPool)");
		return GParamSpecPoolExterns.g_param_spec_pool_lookup(pool, param_name, owner_type, walk_ancestors);
	}

	public static void Remove(this MentorLake.GObject.GParamSpecPoolHandle pool, MentorLake.GObject.GParamSpecHandle pspec)
	{
		if (pool.IsInvalid || pool.IsClosed) throw new Exception("Invalid or closed handle (GParamSpecPool)");
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
	internal static extern MentorLake.GLib.GListHandle g_param_spec_pool_list_owned([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecPoolHandle>))] MentorLake.GObject.GParamSpecPoolHandle pool, MentorLake.GObject.GType owner_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecHandle g_param_spec_pool_lookup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecPoolHandle>))] MentorLake.GObject.GParamSpecPoolHandle pool, string param_name, MentorLake.GObject.GType owner_type, bool walk_ancestors);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_param_spec_pool_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecPoolHandle>))] MentorLake.GObject.GParamSpecPoolHandle pool, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle pspec);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GParamSpecPoolHandle g_param_spec_pool_new(bool type_prefixing);

}

public struct GParamSpecPool
{
	public static MentorLake.GObject.GParamSpecPoolHandle New(bool type_prefixing)
	{
		return GParamSpecPoolExterns.g_param_spec_pool_new(type_prefixing);
	}

}
