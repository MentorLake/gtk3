namespace MentorLake.GLib;

public class GErrorHandle : BaseSafeHandle
{
	public static MentorLake.GLib.GErrorHandle New(MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist)
	{
		return GErrorExterns.g_error_new(domain, code, format, @__arglist);
	}

	public static MentorLake.GLib.GErrorHandle NewLiteral(MentorLake.GLib.GQuark domain, int code, string message)
	{
		return GErrorExterns.g_error_new_literal(domain, code, message);
	}

	public static MentorLake.GLib.GErrorHandle NewValist(MentorLake.GLib.GQuark domain, int code, string format, IntPtr args)
	{
		return GErrorExterns.g_error_new_valist(domain, code, format, args);
	}

}


public static class GErrorExtensions
{
	public static MentorLake.GLib.GErrorHandle Copy(this MentorLake.GLib.GErrorHandle error)
	{
		if (error.IsInvalid || error.IsClosed) throw new Exception("Invalid or closed handle (GError)");
		return GErrorExterns.g_error_copy(error);
	}

	public static void Free(this MentorLake.GLib.GErrorHandle error)
	{
		if (error.IsInvalid || error.IsClosed) throw new Exception("Invalid or closed handle (GError)");
		GErrorExterns.g_error_free(error);
	}

	public static bool Matches(this MentorLake.GLib.GErrorHandle error, MentorLake.GLib.GQuark domain, int code)
	{
		if (error.IsInvalid || error.IsClosed) throw new Exception("Invalid or closed handle (GError)");
		return GErrorExterns.g_error_matches(error, domain, code);
	}


	public static GError Dereference(this GErrorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GError>(x.DangerousGetHandle());
}
internal class GErrorExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GErrorHandle g_error_new(MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GErrorHandle g_error_new_literal(MentorLake.GLib.GQuark domain, int code, string message);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GErrorHandle g_error_new_valist(MentorLake.GLib.GQuark domain, int code, string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GErrorHandle g_error_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_error_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_error_matches([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))] MentorLake.GLib.GErrorHandle error, MentorLake.GLib.GQuark domain, int code);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_error_domain_register(string error_type_name, UIntPtr error_type_private_size, MentorLake.GLib.GErrorInitFunc error_type_init, MentorLake.GLib.GErrorCopyFunc error_type_copy, MentorLake.GLib.GErrorClearFunc error_type_clear);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_error_domain_register_static(string error_type_name, UIntPtr error_type_private_size, MentorLake.GLib.GErrorInitFunc error_type_init, MentorLake.GLib.GErrorCopyFunc error_type_copy, MentorLake.GLib.GErrorClearFunc error_type_clear);

}

public struct GError
{
	public GQuark domain;
	public int code;
	public string message;
	public static MentorLake.GLib.GQuark DomainRegister(string error_type_name, UIntPtr error_type_private_size, MentorLake.GLib.GErrorInitFunc error_type_init, MentorLake.GLib.GErrorCopyFunc error_type_copy, MentorLake.GLib.GErrorClearFunc error_type_clear)
	{
		return GErrorExterns.g_error_domain_register(error_type_name, error_type_private_size, error_type_init, error_type_copy, error_type_clear);
	}

	public static MentorLake.GLib.GQuark DomainRegisterStatic(string error_type_name, UIntPtr error_type_private_size, MentorLake.GLib.GErrorInitFunc error_type_init, MentorLake.GLib.GErrorCopyFunc error_type_copy, MentorLake.GLib.GErrorClearFunc error_type_clear)
	{
		return GErrorExterns.g_error_domain_register_static(error_type_name, error_type_private_size, error_type_init, error_type_copy, error_type_clear);
	}

}
