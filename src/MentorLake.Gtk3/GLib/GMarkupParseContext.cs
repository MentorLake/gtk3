namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A parse context is used to parse a stream of bytes that
/// you expect to contain marked-up text.
/// </para>
/// <para>
/// See g_markup_parse_context_new(), #GMarkupParser, and so
/// on for more details.
/// </para>
/// </summary>

public class GMarkupParseContextHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new parse context. A parse context is used to parse
/// marked-up documents. You can feed any number of documents into
/// a context, as long as no errors occur; once an error occurs,
/// the parse context can&apos;t continue to parse text (you have to
/// free it and create a new parse context).
/// </para>
/// </summary>

/// <param name="parser">
/// a #GMarkupParser
/// </param>
/// <param name="flags">
/// one or more #GMarkupParseFlags
/// </param>
/// <param name="user_data">
/// user data to pass to #GMarkupParser functions
/// </param>
/// <param name="user_data_dnotify">
/// user data destroy notifier called when
///     the parse context is freed
/// </param>
/// <return>
/// a new #GMarkupParseContext
/// </return>

	public static MentorLake.GLib.GMarkupParseContextHandle New(MentorLake.GLib.GMarkupParserHandle parser, MentorLake.GLib.GMarkupParseFlags flags, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_dnotify)
	{
		return GMarkupParseContextExterns.g_markup_parse_context_new(parser, flags, user_data, user_data_dnotify);
	}

}


public static class GMarkupParseContextExtensions
{
/// <summary>
/// <para>
/// Signals to the #GMarkupParseContext that all data has been
/// fed into the parse context with g_markup_parse_context_parse().
/// </para>
/// <para>
/// This function reports an error if the document isn&apos;t complete,
/// for example if elements are still open.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMarkupParseContext
/// </param>
/// <return>
/// %TRUE on success, %FALSE if an error was set
/// </return>

	public static bool EndParse(this MentorLake.GLib.GMarkupParseContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMarkupParseContext)");
		var externCallResult = GMarkupParseContextExterns.g_markup_parse_context_end_parse(context, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Frees a #GMarkupParseContext.
/// </para>
/// <para>
/// This function can&apos;t be called from inside one of the
/// #GMarkupParser functions or while a subparser is pushed.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMarkupParseContext
/// </param>

	public static void Free(this MentorLake.GLib.GMarkupParseContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMarkupParseContext)");
		GMarkupParseContextExterns.g_markup_parse_context_free(context);
	}

/// <summary>
/// <para>
/// Retrieves the name of the currently open element.
/// </para>
/// <para>
/// If called from the start_element or end_element handlers this will
/// give the element_name as passed to those functions. For the parent
/// elements, see g_markup_parse_context_get_element_stack().
/// </para>
/// </summary>

/// <param name="context">
/// a #GMarkupParseContext
/// </param>
/// <return>
/// the name of the currently open element, or %NULL
/// </return>

	public static string GetElement(this MentorLake.GLib.GMarkupParseContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMarkupParseContext)");
		return GMarkupParseContextExterns.g_markup_parse_context_get_element(context);
	}

/// <summary>
/// <para>
/// Retrieves the element stack from the internal state of the parser.
/// </para>
/// <para>
/// The returned #GSList is a list of strings where the first item is
/// the currently open tag (as would be returned by
/// g_markup_parse_context_get_element()) and the next item is its
/// immediate parent.
/// </para>
/// <para>
/// This function is intended to be used in the start_element and
/// end_element handlers where g_markup_parse_context_get_element()
/// would merely return the name of the element that is being
/// processed.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMarkupParseContext
/// </param>
/// <return>
/// the element stack, which must not be modified
/// </return>

	public static MentorLake.GLib.GSListHandle GetElementStack(this MentorLake.GLib.GMarkupParseContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMarkupParseContext)");
		return GMarkupParseContextExterns.g_markup_parse_context_get_element_stack(context);
	}

/// <summary>
/// <para>
/// Retrieves the current line number and the number of the character on
/// that line. Intended for use in error messages; there are no strict
/// semantics for what constitutes the &quot;current&quot; line number other than
/// &quot;the best number we could come up with for error messages.&quot;
/// </para>
/// </summary>

/// <param name="context">
/// a #GMarkupParseContext
/// </param>
/// <param name="line_number">
/// return location for a line number, or %NULL
/// </param>
/// <param name="char_number">
/// return location for a char-on-line number, or %NULL
/// </param>

	public static void GetPosition(this MentorLake.GLib.GMarkupParseContextHandle context, out int line_number, out int char_number)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMarkupParseContext)");
		GMarkupParseContextExterns.g_markup_parse_context_get_position(context, out line_number, out char_number);
	}

/// <summary>
/// <para>
/// Returns the user_data associated with @context.
/// </para>
/// <para>
/// This will either be the user_data that was provided to
/// g_markup_parse_context_new() or to the most recent call
/// of g_markup_parse_context_push().
/// </para>
/// </summary>

/// <param name="context">
/// a #GMarkupParseContext
/// </param>
/// <return>
/// the provided user_data. The returned data belongs to
///     the markup context and will be freed when
///     g_markup_parse_context_free() is called.
/// </return>

	public static IntPtr GetUserData(this MentorLake.GLib.GMarkupParseContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMarkupParseContext)");
		return GMarkupParseContextExterns.g_markup_parse_context_get_user_data(context);
	}

/// <summary>
/// <para>
/// Feed some data to the #GMarkupParseContext.
/// </para>
/// <para>
/// The data need not be valid UTF-8; an error will be signaled if
/// it&apos;s invalid. The data need not be an entire document; you can
/// feed a document into the parser incrementally, via multiple calls
/// to this function. Typically, as you receive data from a network
/// connection or file, you feed each received chunk of data into this
/// function, aborting the process if an error occurs. Once an error
/// is reported, no further data may be fed to the #GMarkupParseContext;
/// all errors are fatal.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMarkupParseContext
/// </param>
/// <param name="text">
/// chunk of text to parse
/// </param>
/// <param name="text_len">
/// length of @text in bytes
/// </param>
/// <return>
/// %FALSE if an error occurred, %TRUE on success
/// </return>

	public static bool Parse(this MentorLake.GLib.GMarkupParseContextHandle context, string text, UIntPtr text_len)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMarkupParseContext)");
		var externCallResult = GMarkupParseContextExterns.g_markup_parse_context_parse(context, text, text_len, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Completes the process of a temporary sub-parser redirection.
/// </para>
/// <para>
/// This function exists to collect the user_data allocated by a
/// matching call to g_markup_parse_context_push(). It must be called
/// in the end_element handler corresponding to the start_element
/// handler during which g_markup_parse_context_push() was called.
/// You must not call this function from the error callback -- the
/// @user_data is provided directly to the callback in that case.
/// </para>
/// <para>
/// This function is not intended to be directly called by users
/// interested in invoking subparsers. Instead, it is intended to
/// be used by the subparsers themselves to implement a higher-level
/// interface.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMarkupParseContext
/// </param>
/// <return>
/// the user data passed to g_markup_parse_context_push()
/// </return>

	public static IntPtr Pop(this MentorLake.GLib.GMarkupParseContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMarkupParseContext)");
		return GMarkupParseContextExterns.g_markup_parse_context_pop(context);
	}

/// <summary>
/// <para>
/// Temporarily redirects markup data to a sub-parser.
/// </para>
/// <para>
/// This function may only be called from the start_element handler of
/// a #GMarkupParser. It must be matched with a corresponding call to
/// g_markup_parse_context_pop() in the matching end_element handler
/// (except in the case that the parser aborts due to an error).
/// </para>
/// <para>
/// All tags, text and other data between the matching tags is
/// redirected to the subparser given by @parser. @user_data is used
/// as the user_data for that parser. @user_data is also passed to the
/// error callback in the event that an error occurs. This includes
/// errors that occur in subparsers of the subparser.
/// </para>
/// <para>
/// The end tag matching the start tag for which this call was made is
/// handled by the previous parser (which is given its own user_data)
/// which is why g_markup_parse_context_pop() is provided to allow &quot;one
/// last access&quot; to the @user_data provided to this function. In the
/// case of error, the @user_data provided here is passed directly to
/// the error callback of the subparser and g_markup_parse_context_pop()
/// should not be called. In either case, if @user_data was allocated
/// then it ought to be freed from both of these locations.
/// </para>
/// <para>
/// This function is not intended to be directly called by users
/// interested in invoking subparsers. Instead, it is intended to be
/// used by the subparsers themselves to implement a higher-level
/// interface.
/// </para>
/// <para>
/// As an example, see the following implementation of a simple
/// parser that counts the number of tags encountered.
/// </para>
/// <code>
/// typedef struct
/// typedef struct
/// {
///   gint tag_count;
/// } CounterData;
/// 
/// static void
/// counter_start_element (GMarkupParseContext  *context,
///                        const gchar          *element_name,
///                        const gchar         **attribute_names,
///                        const gchar         **attribute_values,
///                        gpointer              user_data,
///                        GError              **error)
/// {
///   CounterData *data = user_data;
/// 
///   data-&amp;gt;tag_count++;
/// }
/// 
/// static void
/// counter_error (GMarkupParseContext *context,
///                GError              *error,
///                gpointer             user_data)
/// {
///   CounterData *data = user_data;
/// 
///   g_slice_free (CounterData, data);
/// }
/// 
/// static GMarkupParser counter_subparser =
/// {
///   counter_start_element,
///   NULL,
///   NULL,
///   NULL,
///   counter_error
/// };
/// </code>
/// <para>
/// In order to allow this parser to be easily used as a subparser, the
/// following interface is provided:
/// </para>
/// <code>
/// void
/// void
/// start_counting (GMarkupParseContext *context)
/// {
///   CounterData *data = g_slice_new (CounterData);
/// 
///   data-&amp;gt;tag_count = 0;
///   g_markup_parse_context_push (context, &amp;counter_subparser, data);
/// }
/// 
/// gint
/// end_counting (GMarkupParseContext *context)
/// {
///   CounterData *data = g_markup_parse_context_pop (context);
///   int result;
/// 
///   result = data-&amp;gt;tag_count;
///   g_slice_free (CounterData, data);
/// 
///   return result;
/// }
/// </code>
/// <para>
/// The subparser would then be used as follows:
/// </para>
/// <code>
/// static void start_element (context, element_name, ...)
/// static void start_element (context, element_name, ...)
/// {
///   if (strcmp (element_name, &quot;count-these&quot;) == 0)
///     start_counting (context);
/// 
///   // else, handle other tags...
/// }
/// 
/// static void end_element (context, element_name, ...)
/// {
///   if (strcmp (element_name, &quot;count-these&quot;) == 0)
///     g_print (&quot;Counted %d tags\n&quot;, end_counting (context));
/// 
///   // else, handle other tags...
/// }
/// </code>
/// </summary>

/// <param name="context">
/// a #GMarkupParseContext
/// </param>
/// <param name="parser">
/// a #GMarkupParser
/// </param>
/// <param name="user_data">
/// user data to pass to #GMarkupParser functions
/// </param>

	public static void Push(this MentorLake.GLib.GMarkupParseContextHandle context, MentorLake.GLib.GMarkupParserHandle parser, IntPtr user_data)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMarkupParseContext)");
		GMarkupParseContextExterns.g_markup_parse_context_push(context, parser, user_data);
	}

/// <summary>
/// <para>
/// Increases the reference count of @context.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMarkupParseContext
/// </param>
/// <return>
/// the same @context
/// </return>

	public static MentorLake.GLib.GMarkupParseContextHandle Ref(this MentorLake.GLib.GMarkupParseContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMarkupParseContext)");
		return GMarkupParseContextExterns.g_markup_parse_context_ref(context);
	}

/// <summary>
/// <para>
/// Decreases the reference count of @context.  When its reference count
/// drops to 0, it is freed.
/// </para>
/// </summary>

/// <param name="context">
/// a #GMarkupParseContext
/// </param>

	public static void Unref(this MentorLake.GLib.GMarkupParseContextHandle context)
	{
		if (context.IsInvalid) throw new Exception("Invalid handle (GMarkupParseContext)");
		GMarkupParseContextExterns.g_markup_parse_context_unref(context);
	}


	public static GMarkupParseContext Dereference(this GMarkupParseContextHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMarkupParseContext>(x.DangerousGetHandle());
}
internal class GMarkupParseContextExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))]
	internal static extern MentorLake.GLib.GMarkupParseContextHandle g_markup_parse_context_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParserHandle>))] MentorLake.GLib.GMarkupParserHandle parser, MentorLake.GLib.GMarkupParseFlags flags, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_dnotify);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_markup_parse_context_end_parse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_markup_parse_context_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_markup_parse_context_get_element([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle g_markup_parse_context_get_element_stack([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_markup_parse_context_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context, out int line_number, out int char_number);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_markup_parse_context_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_markup_parse_context_parse([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context, string text, UIntPtr text_len, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern IntPtr g_markup_parse_context_pop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_markup_parse_context_push([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParserHandle>))] MentorLake.GLib.GMarkupParserHandle parser, IntPtr user_data);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))]
	internal static extern MentorLake.GLib.GMarkupParseContextHandle g_markup_parse_context_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_markup_parse_context_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GMarkupParseContextHandle>))] MentorLake.GLib.GMarkupParseContextHandle context);

}

/// <summary>
/// <para>
/// A parse context is used to parse a stream of bytes that
/// you expect to contain marked-up text.
/// </para>
/// <para>
/// See g_markup_parse_context_new(), #GMarkupParser, and so
/// on for more details.
/// </para>
/// </summary>

public struct GMarkupParseContext
{
}
