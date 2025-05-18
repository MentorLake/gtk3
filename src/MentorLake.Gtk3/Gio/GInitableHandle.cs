namespace MentorLake.Gio;

public interface GInitableHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class GInitableHandleImpl : BaseSafeHandle, GInitableHandle
{
}

public static class GInitableHandleExtensions
{
	public static bool Init(this MentorLake.Gio.GInitableHandle initable, MentorLake.Gio.GCancellableHandle cancellable)
	{
		if (initable.IsInvalid) throw new Exception("Invalid handle (GInitableHandle)");
		var externCallResult = GInitableHandleExterns.g_initable_init(initable, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GObject.GObjectHandle New(MentorLake.GObject.GType object_type, MentorLake.Gio.GCancellableHandle cancellable, IntPtr error, string first_property_name, IntPtr @__arglist)
	{
		return GInitableHandleExterns.g_initable_new(object_type, cancellable, error, first_property_name, @__arglist);
	}

	public static MentorLake.GObject.GObjectHandle NewValist(MentorLake.GObject.GType object_type, string first_property_name, IntPtr var_args, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GInitableHandleExterns.g_initable_new_valist(object_type, first_property_name, var_args, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GObject.GObjectHandle Newv(MentorLake.GObject.GType object_type, uint n_parameters, MentorLake.GObject.GParameter[] parameters, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GInitableHandleExterns.g_initable_newv(object_type, n_parameters, parameters, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GInitableHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern bool g_initable_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GInitableHandleImpl>))] MentorLake.Gio.GInitableHandle initable, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_initable_new(MentorLake.GObject.GType object_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, IntPtr error, string first_property_name, IntPtr @__arglist);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_initable_new_valist(MentorLake.GObject.GType object_type, string first_property_name, IntPtr var_args, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_initable_newv(MentorLake.GObject.GType object_type, uint n_parameters, MentorLake.GObject.GParameter[] parameters, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

}
