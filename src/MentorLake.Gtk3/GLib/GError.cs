namespace MentorLake.GLib;

/// <summary>
/// <para>
/// The `GError` structure contains information about
/// an error that has occurred.
/// </para>
/// </summary>

public class GErrorHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #GError with the given @domain and @code,
/// and a message formatted with @format.
/// </para>
/// </summary>

/// <param name="domain">
/// error domain
/// </param>
/// <param name="code">
/// error code
/// </param>
/// <param name="format">
/// printf()-style format for error message
/// </param>
/// <param name="@__arglist">
/// parameters for message format
/// </param>
/// <return>
/// a new #GError
/// </return>

	public static MentorLake.GLib.GErrorHandle New(MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist)
	{
		return GErrorExterns.g_error_new(domain, code, format, @__arglist);
	}

/// <summary>
/// <para>
/// Creates a new #GError; unlike g_error_new(), @message is
/// not a printf()-style format string. Use this function if
/// @message contains text you don't have control over,
/// that could include printf() escape sequences.
/// </para>
/// </summary>

/// <param name="domain">
/// error domain
/// </param>
/// <param name="code">
/// error code
/// </param>
/// <param name="message">
/// error message
/// </param>
/// <return>
/// a new #GError
/// </return>

	public static MentorLake.GLib.GErrorHandle NewLiteral(MentorLake.GLib.GQuark domain, int code, string message)
	{
		return GErrorExterns.g_error_new_literal(domain, code, message);
	}

/// <summary>
/// <para>
/// Creates a new #GError with the given @domain and @code,
/// and a message formatted with @format.
/// </para>
/// </summary>

/// <param name="domain">
/// error domain
/// </param>
/// <param name="code">
/// error code
/// </param>
/// <param name="format">
/// printf()-style format for error message
/// </param>
/// <param name="args">
/// #va_list of parameters for the message format
/// </param>
/// <return>
/// a new #GError
/// </return>

	public static MentorLake.GLib.GErrorHandle NewValist(MentorLake.GLib.GQuark domain, int code, string format, IntPtr args)
	{
		return GErrorExterns.g_error_new_valist(domain, code, format, args);
	}

}


public static class GErrorExtensions
{
/// <summary>
/// <para>
/// Makes a copy of @error.
/// </para>
/// </summary>

/// <param name="error">
/// a #GError
/// </param>
/// <return>
/// a new #GError
/// </return>

	public static MentorLake.GLib.GErrorHandle Copy(this MentorLake.GLib.GErrorHandle error)
	{
		if (error.IsInvalid) throw new Exception("Invalid handle (GError)");
		return GErrorExterns.g_error_copy(error);
	}

/// <summary>
/// <para>
/// Frees a #GError and associated resources.
/// </para>
/// </summary>

/// <param name="error">
/// a #GError
/// </param>

	public static void Free(this MentorLake.GLib.GErrorHandle error)
	{
		if (error.IsInvalid) throw new Exception("Invalid handle (GError)");
		GErrorExterns.g_error_free(error);
	}

/// <summary>
/// <para>
/// Returns %TRUE if @error matches @domain and @code, %FALSE
/// otherwise. In particular, when @error is %NULL, %FALSE will
/// be returned.
/// </para>
/// <para>
/// If @domain contains a `FAILED` (or otherwise generic) error code,
/// you should generally not check for it explicitly, but should
/// instead treat any not-explicitly-recognized error code as being
/// equivalent to the `FAILED` code. This way, if the domain is
/// extended in the future to provide a more specific error code for
/// a certain case, your code will still work.
/// </para>
/// </summary>

/// <param name="error">
/// a #GError
/// </param>
/// <param name="domain">
/// an error domain
/// </param>
/// <param name="code">
/// an error code
/// </param>
/// <return>
/// whether @error has @domain and @code
/// </return>

	public static bool Matches(this MentorLake.GLib.GErrorHandle error, MentorLake.GLib.GQuark domain, int code)
	{
		if (error.IsInvalid) throw new Exception("Invalid handle (GError)");
		return GErrorExterns.g_error_matches(error, domain, code);
	}


	public static GError Dereference(this GErrorHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GError>(x.DangerousGetHandle());
}
internal class GErrorExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))]
	internal static extern MentorLake.GLib.GErrorHandle g_error_new(MentorLake.GLib.GQuark domain, int code, string format, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))]
	internal static extern MentorLake.GLib.GErrorHandle g_error_new_literal(MentorLake.GLib.GQuark domain, int code, string message);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))]
	internal static extern MentorLake.GLib.GErrorHandle g_error_new_valist(MentorLake.GLib.GQuark domain, int code, string format, IntPtr args);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GErrorHandle>))]
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

/// <summary>
/// <para>
/// The `GError` structure contains information about
/// an error that has occurred.
/// </para>
/// </summary>

public struct GError
{
	/// <summary>
/// <para>
/// error domain, e.g. %G_FILE_ERROR
/// </para>
/// </summary>

public GQuark domain;
	/// <summary>
/// <para>
/// error code, e.g. %G_FILE_ERROR_NOENT
/// </para>
/// </summary>

public int code;
	/// <summary>
/// <para>
/// human-readable informative error message
/// </para>
/// </summary>

public string message;
/// <summary>
/// <para>
/// This function registers an extended #GError domain.
/// @error_type_name will be duplicated. Otherwise does the same as
/// g_error_domain_register_static().
/// </para>
/// </summary>

/// <param name="error_type_name">
/// string to create a #GQuark from
/// </param>
/// <param name="error_type_private_size">
/// size of the private error data in bytes
/// </param>
/// <param name="error_type_init">
/// function initializing fields of the private error data
/// </param>
/// <param name="error_type_copy">
/// function copying fields of the private error data
/// </param>
/// <param name="error_type_clear">
/// function freeing fields of the private error data
/// </param>
/// <return>
/// #GQuark representing the error domain
/// </return>

	public static MentorLake.GLib.GQuark DomainRegister(string error_type_name, UIntPtr error_type_private_size, MentorLake.GLib.GErrorInitFunc error_type_init, MentorLake.GLib.GErrorCopyFunc error_type_copy, MentorLake.GLib.GErrorClearFunc error_type_clear)
	{
		return GErrorExterns.g_error_domain_register(error_type_name, error_type_private_size, error_type_init, error_type_copy, error_type_clear);
	}

/// <summary>
/// <para>
/// This function registers an extended #GError domain.
/// </para>
/// <para>
/// @error_type_name should not be freed. @error_type_private_size must
/// be greater than 0.
/// </para>
/// <para>
/// @error_type_init receives an initialized #GError and should then initialize
/// the private data.
/// </para>
/// <para>
/// @error_type_copy is a function that receives both original and a copy
/// #GError and should copy the fields of the private error data. The standard
/// #GError fields are already handled.
/// </para>
/// <para>
/// @error_type_clear receives the pointer to the error, and it should free the
/// fields of the private error data. It should not free the struct itself though.
/// </para>
/// <para>
/// Normally, it is better to use G_DEFINE_EXTENDED_ERROR(), as it
/// already takes care of passing valid information to this function.
/// </para>
/// </summary>

/// <param name="error_type_name">
/// static string to create a #GQuark from
/// </param>
/// <param name="error_type_private_size">
/// size of the private error data in bytes
/// </param>
/// <param name="error_type_init">
/// function initializing fields of the private error data
/// </param>
/// <param name="error_type_copy">
/// function copying fields of the private error data
/// </param>
/// <param name="error_type_clear">
/// function freeing fields of the private error data
/// </param>
/// <return>
/// #GQuark representing the error domain
/// </return>

	public static MentorLake.GLib.GQuark DomainRegisterStatic(string error_type_name, UIntPtr error_type_private_size, MentorLake.GLib.GErrorInitFunc error_type_init, MentorLake.GLib.GErrorCopyFunc error_type_copy, MentorLake.GLib.GErrorClearFunc error_type_clear)
	{
		return GErrorExterns.g_error_domain_register_static(error_type_name, error_type_private_size, error_type_init, error_type_copy, error_type_clear);
	}

}
