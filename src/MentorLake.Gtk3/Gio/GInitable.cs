namespace MentorLake.Gtk3.Gio;

public interface GInitableHandle
{
}

internal class GInitableHandleImpl : BaseSafeHandle, GInitableHandle
{
}

public static class GInitableHandleExtensions
{
	public static bool Init(this GInitableHandle initable, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GInitableExterns.g_initable_init(initable, cancellable, out error);
	}

	public static GObjectHandle New(GType object_type, GCancellableHandle cancellable, out GErrorHandle error, string first_property_name, IntPtr @__arglist)
	{
		return GInitableExterns.g_initable_new(object_type, cancellable, out error, first_property_name, @__arglist);
	}

	public static GObjectHandle NewValist(GType object_type, string first_property_name, IntPtr var_args, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GInitableExterns.g_initable_new_valist(object_type, first_property_name, var_args, cancellable, out error);
	}

	public static GObjectHandle Newv(GType object_type, uint n_parameters, GParameter[] parameters, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GInitableExterns.g_initable_newv(object_type, n_parameters, parameters, cancellable, out error);
	}

}

internal class GInitableExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern bool g_initable_init(GInitableHandle initable, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GObjectHandle g_initable_new(GType object_type, GCancellableHandle cancellable, out GErrorHandle error, string first_property_name, IntPtr @__arglist);

	[DllImport(Libraries.Gio)]
	internal static extern GObjectHandle g_initable_new_valist(GType object_type, string first_property_name, IntPtr var_args, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GObjectHandle g_initable_newv(GType object_type, uint n_parameters, GParameter[] parameters, GCancellableHandle cancellable, out GErrorHandle error);

}
