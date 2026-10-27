namespace MentorLake.JavaScriptCore;

/// <summary>
/// <para>
/// JSCException represents a JavaScript exception.
/// </para>
/// </summary>

public class JSCExceptionHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Create a new #JSCException in @context with @message.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="message">
/// the error message
/// </param>
/// <return>
/// a new #JSCException.
/// </return>

	public static MentorLake.JavaScriptCore.JSCExceptionHandle New(MentorLake.JavaScriptCore.JSCContextHandle context, string message)
	{
		return JSCExceptionHandleExterns.jsc_exception_new(context, message);
	}

/// <summary>
/// <para>
/// Create a new #JSCException in @context using a formatted string
/// for the message.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="format">
/// the string format
/// </param>
/// <param name="@__arglist">
/// the parameters to insert into the format string
/// </param>
/// <return>
/// a new #JSCException.
/// </return>

	public static MentorLake.JavaScriptCore.JSCExceptionHandle NewPrintf(MentorLake.JavaScriptCore.JSCContextHandle context, string format, IntPtr @__arglist)
	{
		return JSCExceptionHandleExterns.jsc_exception_new_printf(context, format, @__arglist);
	}

/// <summary>
/// <para>
/// Create a new #JSCException in @context using a formatted string
/// for the message. This is similar to jsc_exception_new_printf()
/// except that the arguments to the format string are passed as a va_list.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="format">
/// the string format
/// </param>
/// <param name="args">
/// the parameters to insert into the format string
/// </param>
/// <return>
/// a new #JSCException.
/// </return>

	public static MentorLake.JavaScriptCore.JSCExceptionHandle NewVprintf(MentorLake.JavaScriptCore.JSCContextHandle context, string format, IntPtr args)
	{
		return JSCExceptionHandleExterns.jsc_exception_new_vprintf(context, format, args);
	}

/// <summary>
/// <para>
/// Create a new #JSCException in @context with @name and @message.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="name">
/// the error name
/// </param>
/// <param name="message">
/// the error message
/// </param>
/// <return>
/// a new #JSCException.
/// </return>

	public static MentorLake.JavaScriptCore.JSCExceptionHandle NewWithName(MentorLake.JavaScriptCore.JSCContextHandle context, string name, string message)
	{
		return JSCExceptionHandleExterns.jsc_exception_new_with_name(context, name, message);
	}

/// <summary>
/// <para>
/// Create a new #JSCException in @context with @name and using a formatted string
/// for the message.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="name">
/// the error name
/// </param>
/// <param name="format">
/// the string format
/// </param>
/// <param name="@__arglist">
/// the parameters to insert into the format string
/// </param>
/// <return>
/// a new #JSCException.
/// </return>

	public static MentorLake.JavaScriptCore.JSCExceptionHandle NewWithNamePrintf(MentorLake.JavaScriptCore.JSCContextHandle context, string name, string format, IntPtr @__arglist)
	{
		return JSCExceptionHandleExterns.jsc_exception_new_with_name_printf(context, name, format, @__arglist);
	}

/// <summary>
/// <para>
/// Create a new #JSCException in @context with @name and using a formatted string
/// for the message. This is similar to jsc_exception_new_with_name_printf()
/// except that the arguments to the format string are passed as a va_list.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="name">
/// the error name
/// </param>
/// <param name="format">
/// the string format
/// </param>
/// <param name="args">
/// the parameters to insert into the format string
/// </param>
/// <return>
/// a new #JSCException.
/// </return>

	public static MentorLake.JavaScriptCore.JSCExceptionHandle NewWithNameVprintf(MentorLake.JavaScriptCore.JSCContextHandle context, string name, string format, IntPtr args)
	{
		return JSCExceptionHandleExterns.jsc_exception_new_with_name_vprintf(context, name, format, args);
	}

}

public static class JSCExceptionHandleExtensions
{
/// <summary>
/// <para>
/// Get a string with the exception backtrace.
/// </para>
/// </summary>

/// <param name="exception">
/// a #JSCException
/// </param>
/// <return>
/// the exception backtrace string or %NULL.
/// </return>

	public static string GetBacktraceString(this MentorLake.JavaScriptCore.JSCExceptionHandle exception)
	{
		if (exception.IsInvalid) throw new Exception("Invalid handle (JSCExceptionHandle)");
		return JSCExceptionHandleExterns.jsc_exception_get_backtrace_string(exception);
	}

/// <summary>
/// <para>
/// Get the column number at which @exception happened.
/// </para>
/// </summary>

/// <param name="exception">
/// a #JSCException
/// </param>
/// <return>
/// the column number of @exception.
/// </return>

	public static uint GetColumnNumber(this MentorLake.JavaScriptCore.JSCExceptionHandle exception)
	{
		if (exception.IsInvalid) throw new Exception("Invalid handle (JSCExceptionHandle)");
		return JSCExceptionHandleExterns.jsc_exception_get_column_number(exception);
	}

/// <summary>
/// <para>
/// Get the line number at which @exception happened.
/// </para>
/// </summary>

/// <param name="exception">
/// a #JSCException
/// </param>
/// <return>
/// the line number of @exception.
/// </return>

	public static uint GetLineNumber(this MentorLake.JavaScriptCore.JSCExceptionHandle exception)
	{
		if (exception.IsInvalid) throw new Exception("Invalid handle (JSCExceptionHandle)");
		return JSCExceptionHandleExterns.jsc_exception_get_line_number(exception);
	}

/// <summary>
/// <para>
/// Get the error message of @exception.
/// </para>
/// </summary>

/// <param name="exception">
/// a #JSCException
/// </param>
/// <return>
/// the @exception error message.
/// </return>

	public static string GetMessage(this MentorLake.JavaScriptCore.JSCExceptionHandle exception)
	{
		if (exception.IsInvalid) throw new Exception("Invalid handle (JSCExceptionHandle)");
		return JSCExceptionHandleExterns.jsc_exception_get_message(exception);
	}

/// <summary>
/// <para>
/// Get the error name of @exception
/// </para>
/// </summary>

/// <param name="exception">
/// a #JSCException
/// </param>
/// <return>
/// the @exception error name.
/// </return>

	public static string GetName(this MentorLake.JavaScriptCore.JSCExceptionHandle exception)
	{
		if (exception.IsInvalid) throw new Exception("Invalid handle (JSCExceptionHandle)");
		return JSCExceptionHandleExterns.jsc_exception_get_name(exception);
	}

/// <summary>
/// <para>
/// Get the source URI of @exception.
/// </para>
/// </summary>

/// <param name="exception">
/// a #JSCException
/// </param>
/// <return>
/// the the source URI of @exception, or %NULL.
/// </return>

	public static string GetSourceUri(this MentorLake.JavaScriptCore.JSCExceptionHandle exception)
	{
		if (exception.IsInvalid) throw new Exception("Invalid handle (JSCExceptionHandle)");
		return JSCExceptionHandleExterns.jsc_exception_get_source_uri(exception);
	}

/// <summary>
/// <para>
/// Return a report message of @exception, containing all the possible details such us
/// source URI, line, column and backtrace, and formatted to be printed.
/// </para>
/// </summary>

/// <param name="exception">
/// a #JSCException
/// </param>
/// <return>
/// a new string with the exception report
/// </return>

	public static string Report(this MentorLake.JavaScriptCore.JSCExceptionHandle exception)
	{
		if (exception.IsInvalid) throw new Exception("Invalid handle (JSCExceptionHandle)");
		return JSCExceptionHandleExterns.jsc_exception_report(exception);
	}

/// <summary>
/// <para>
/// Get the string representation of @exception error.
/// </para>
/// </summary>

/// <param name="exception">
/// a #JSCException
/// </param>
/// <return>
/// the string representation of @exception.
/// </return>

	public static string ToString(this MentorLake.JavaScriptCore.JSCExceptionHandle exception)
	{
		if (exception.IsInvalid) throw new Exception("Invalid handle (JSCExceptionHandle)");
		return JSCExceptionHandleExterns.jsc_exception_to_string(exception);
	}

}

internal class JSCExceptionHandleExterns
{
	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCExceptionHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCExceptionHandle jsc_exception_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, string message);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCExceptionHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCExceptionHandle jsc_exception_new_printf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, string format, IntPtr @__arglist);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCExceptionHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCExceptionHandle jsc_exception_new_vprintf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, string format, IntPtr args);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCExceptionHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCExceptionHandle jsc_exception_new_with_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, string name, string message);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCExceptionHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCExceptionHandle jsc_exception_new_with_name_printf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, string name, string format, IntPtr @__arglist);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCExceptionHandle>))]
	internal static extern MentorLake.JavaScriptCore.JSCExceptionHandle jsc_exception_new_with_name_vprintf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, string name, string format, IntPtr args);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string jsc_exception_get_backtrace_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCExceptionHandle>))] MentorLake.JavaScriptCore.JSCExceptionHandle exception);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern uint jsc_exception_get_column_number([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCExceptionHandle>))] MentorLake.JavaScriptCore.JSCExceptionHandle exception);

	[DllImport(JavaScriptCoreLibrary.Name)]
	internal static extern uint jsc_exception_get_line_number([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCExceptionHandle>))] MentorLake.JavaScriptCore.JSCExceptionHandle exception);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string jsc_exception_get_message([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCExceptionHandle>))] MentorLake.JavaScriptCore.JSCExceptionHandle exception);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string jsc_exception_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCExceptionHandle>))] MentorLake.JavaScriptCore.JSCExceptionHandle exception);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string jsc_exception_get_source_uri([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCExceptionHandle>))] MentorLake.JavaScriptCore.JSCExceptionHandle exception);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string jsc_exception_report([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCExceptionHandle>))] MentorLake.JavaScriptCore.JSCExceptionHandle exception);

	[DllImport(JavaScriptCoreLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string jsc_exception_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCExceptionHandle>))] MentorLake.JavaScriptCore.JSCExceptionHandle exception);

}
