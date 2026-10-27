namespace MentorLake.Soup;

/// <summary>
/// <para>
/// The HTTP message headers associated with a request or response.
/// </para>
/// </summary>

public class SoupMessageHeadersHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a [struct@MessageHeaders].
/// </para>
/// <para>
/// ([class@Message] does this automatically for its own headers. You would only
/// need to use this method if you are manually parsing or generating message
/// headers.)
/// </para>
/// </summary>

/// <param name="type">
/// the type of headers
/// </param>
/// <return>
/// a new #SoupMessageHeaders
/// </return>

	public static MentorLake.Soup.SoupMessageHeadersHandle New(MentorLake.Soup.SoupMessageHeadersType type)
	{
		return SoupMessageHeadersExterns.soup_message_headers_new(type);
	}

}


public static class SoupMessageHeadersExtensions
{
/// <summary>
/// <para>
/// Appends a new header with name @name and value @value to @hdrs.
/// </para>
/// <para>
/// (If there is an existing header with name @name, then this creates a second
/// one, which is only allowed for list-valued headers; see also
/// [method@MessageHeaders.replace].)
/// </para>
/// <para>
/// The caller is expected to make sure that @name and @value are
/// syntactically correct.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="name">
/// the header name to add
/// </param>
/// <param name="value">
/// the new value of @name
/// </param>

	public static void Append(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, string name, string value)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		SoupMessageHeadersExterns.soup_message_headers_append(hdrs, name, value);
	}

/// <summary>
/// <para>
/// Removes all the headers listed in the Connection header.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>

	public static void CleanConnectionHeaders(this MentorLake.Soup.SoupMessageHeadersHandle hdrs)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		SoupMessageHeadersExterns.soup_message_headers_clean_connection_headers(hdrs);
	}

/// <summary>
/// <para>
/// Clears @hdrs.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>

	public static void Clear(this MentorLake.Soup.SoupMessageHeadersHandle hdrs)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		SoupMessageHeadersExterns.soup_message_headers_clear(hdrs);
	}

/// <summary>
/// <para>
/// Calls @func once for each header value in @hdrs.
/// </para>
/// <para>
/// Beware that unlike [method@MessageHeaders.get_list], this processes the
/// headers in exactly the way they were added, rather than
/// concatenating multiple same-named headers into a single value.
/// (This is intentional; it ensures that if you call
/// [method@MessageHeaders.append] multiple times with the same name,
/// then the I/O code will output multiple copies of the header when
/// sending the message to the remote implementation, which may be
/// required for interoperability in some cases.)
/// </para>
/// <para>
/// You may not modify the headers from @func.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="func">
/// callback function to run for each header
/// </param>
/// <param name="user_data">
/// data to pass to @func
/// </param>

	public static void Foreach(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, MentorLake.Soup.SoupMessageHeadersForeachFunc func, IntPtr user_data)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		SoupMessageHeadersExterns.soup_message_headers_foreach(hdrs, func, user_data);
	}

/// <summary>
/// <para>
/// Frees the array of ranges returned from [method@MessageHeaders.get_ranges].
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="ranges">
/// an array of #SoupRange
/// </param>

	public static void FreeRanges(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, MentorLake.Soup.SoupRangeHandle ranges)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		SoupMessageHeadersExterns.soup_message_headers_free_ranges(hdrs, ranges);
	}

/// <summary>
/// <para>
/// Looks up the &quot;Content-Disposition&quot; header in @hdrs, parses it, and
/// returns its value in *@disposition and *@params.
/// </para>
/// <para>
/// @params can be %NULL if you are only interested in the disposition-type.
/// </para>
/// <para>
/// In HTTP, the most common use of this header is to set a
/// disposition-type of &quot;attachment&quot;, to suggest to the browser that a
/// response should be saved to disk rather than displayed in the
/// browser. If @params contains a &quot;filename&quot; parameter, this is a
/// suggestion of a filename to use. (If the parameter value in the
/// header contains an absolute or relative path, libsoup will truncate
/// it down to just the final path component, so you do not need to
/// test this yourself.)
/// </para>
/// <para>
/// Content-Disposition is also used in &quot;multipart/form-data&quot;, however
/// this is handled automatically by [struct@Multipart] and the associated
/// form methods.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="disposition">
/// return location for the
///   disposition-type, or %NULL
/// </param>
/// <param name="@params">
/// return
///   location for the Content-Disposition parameters, or %NULL
/// </param>
/// <return>
/// %TRUE if @hdrs contains a &quot;Content-Disposition&quot;
///   header, %FALSE if not (in which case *@disposition and *@params
///   will be unchanged).
/// </return>

	public static bool GetContentDisposition(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, out string disposition, out MentorLake.GLib.GHashTableHandle @params)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		return SoupMessageHeadersExterns.soup_message_headers_get_content_disposition(hdrs, out disposition, out @params);
	}

/// <summary>
/// <para>
/// Gets the message body length that @hdrs declare.
/// </para>
/// <para>
/// This will only be non-0 if [method@MessageHeaders.get_encoding] returns
/// %SOUP_ENCODING_CONTENT_LENGTH.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <return>
/// the message body length declared by @hdrs.
/// </return>

	public static int GetContentLength(this MentorLake.Soup.SoupMessageHeadersHandle hdrs)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		return SoupMessageHeadersExterns.soup_message_headers_get_content_length(hdrs);
	}

/// <summary>
/// <para>
/// Parses @hdrs&apos;s Content-Range header and returns it in @start,
/// @end, and @total_length. If the total length field in the header
/// was specified as &quot;*&quot;, then @total_length will be set to -1.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="start">
/// return value for the start of the range
/// </param>
/// <param name="end">
/// return value for the end of the range
/// </param>
/// <param name="total_length">
/// return value for the total length of the
///   resource, or %NULL if you don&apos;t care.
/// </param>
/// <return>
/// %TRUE if @hdrs contained a &quot;Content-Range&quot; header
///   containing a byte range which could be parsed, %FALSE otherwise.
/// </return>

	public static bool GetContentRange(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, out int start, out int end, out int total_length)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		return SoupMessageHeadersExterns.soup_message_headers_get_content_range(hdrs, out start, out end, out total_length);
	}

/// <summary>
/// <para>
/// Looks up the &quot;Content-Type&quot; header in @hdrs, parses it, and returns
/// its value in *@content_type and *@params.
/// </para>
/// <para>
/// @params can be %NULL if you are only interested in the content type itself.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="@params">
/// 
///   return location for the Content-Type parameters (eg, &quot;charset&quot;), or
///   %NULL
/// </param>
/// <return>
/// a string with the value of the
///   &quot;Content-Type&quot; header or %NULL if @hdrs does not contain that
///   header or it cannot be parsed (in which case *@params will be
///   unchanged).
/// </return>

	public static string GetContentType(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, out MentorLake.GLib.GHashTableHandle @params)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		return SoupMessageHeadersExterns.soup_message_headers_get_content_type(hdrs, out @params);
	}

/// <summary>
/// <para>
/// Gets the message body encoding that @hdrs declare.
/// </para>
/// <para>
/// This may not always correspond to the encoding used on the wire; eg, a HEAD
/// response may declare a Content-Length or Transfer-Encoding, but it will never
/// actually include a body.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <return>
/// the encoding declared by @hdrs.
/// </return>

	public static MentorLake.Soup.SoupEncoding GetEncoding(this MentorLake.Soup.SoupMessageHeadersHandle hdrs)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		return SoupMessageHeadersExterns.soup_message_headers_get_encoding(hdrs);
	}

/// <summary>
/// <para>
/// Gets the expectations declared by @hdrs&apos;s &quot;Expect&quot; header.
/// </para>
/// <para>
/// Currently this will either be %SOUP_EXPECTATION_CONTINUE or
/// %SOUP_EXPECTATION_UNRECOGNIZED.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <return>
/// the contents of @hdrs&apos;s &quot;Expect&quot; header
/// </return>

	public static MentorLake.Soup.SoupExpectation GetExpectations(this MentorLake.Soup.SoupMessageHeadersHandle hdrs)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		return SoupMessageHeadersExterns.soup_message_headers_get_expectations(hdrs);
	}

/// <summary>
/// <para>
/// Gets the type of headers.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <return>
/// the header&apos;s type.
/// </return>

	public static MentorLake.Soup.SoupMessageHeadersType GetHeadersType(this MentorLake.Soup.SoupMessageHeadersHandle hdrs)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		return SoupMessageHeadersExterns.soup_message_headers_get_headers_type(hdrs);
	}

/// <summary>
/// <para>
/// Gets the value of header @name in @hdrs.
/// </para>
/// <para>
/// Use this for headers whose values are comma-delimited lists, and which are
/// therefore allowed to appear multiple times in the headers. For
/// non-list-valued headers, use [method@MessageHeaders.get_one].
/// </para>
/// <para>
/// If @name appears multiple times in @hdrs,
/// [method@MessageHeaders.get_list] will concatenate all of the values
/// together, separated by commas. This is sometimes awkward to parse
/// (eg, WWW-Authenticate, Set-Cookie), but you have to be able to deal
/// with it anyway, because the HTTP spec explicitly states that this
/// transformation is allowed, and so an upstream proxy could do the
/// same thing.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="name">
/// header name
/// </param>
/// <return>
/// the header&apos;s value or %NULL if not found.
/// </return>

	public static string GetList(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, string name)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		return SoupMessageHeadersExterns.soup_message_headers_get_list(hdrs, name);
	}

/// <summary>
/// <para>
/// Gets the value of header @name in @hdrs.
/// </para>
/// <para>
/// Use this for headers whose values are *not* comma-delimited lists, and which
/// therefore can only appear at most once in the headers. For list-valued
/// headers, use [method@MessageHeaders.get_list].
/// </para>
/// <para>
/// If @hdrs does erroneously contain multiple copies of the header, it
/// is not defined which one will be returned. (Ideally, it will return
/// whichever one makes libsoup most compatible with other HTTP
/// implementations.)
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="name">
/// header name
/// </param>
/// <return>
/// the header&apos;s value or %NULL if not found.
/// </return>

	public static string GetOne(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, string name)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		return SoupMessageHeadersExterns.soup_message_headers_get_one(hdrs, name);
	}

/// <summary>
/// <para>
/// Parses @hdrs&apos;s Range header and returns an array of the requested
/// byte ranges.
/// </para>
/// <para>
/// The returned array must be freed with [method@MessageHeaders.free_ranges].
/// </para>
/// <para>
/// If @total_length is non-0, its value will be used to adjust the
/// returned ranges to have explicit start and end values, and the
/// returned ranges will be sorted and non-overlapping. If
/// @total_length is 0, then some ranges may have an end value of -1,
/// as described under [struct@Range], and some of the ranges may be
/// redundant.
/// </para>
/// <para>
/// Beware that even if given a @total_length, this function does not
/// check that the ranges are satisfiable.
/// </para>
/// <para>
/// A Range header requesting more than 200 ranges is rejected, since serving
/// that many ranges costs far more than the request asking for them.
/// [class@Server] answers such a request with
/// %SOUP_STATUS_REQUESTED_RANGE_NOT_SATISFIABLE.
/// </para>
/// <para>
/// [class@Server] has built-in handling for range requests. If your
/// server handler returns a %SOUP_STATUS_OK response containing the
/// complete response body (rather than pausing the message and
/// returning some of the response body later), and there is a Range
/// header in the request, then libsoup will automatically convert the
/// response to a %SOUP_STATUS_PARTIAL_CONTENT response containing only
/// the range(s) requested by the client.
/// </para>
/// <para>
/// The only time you need to process the Range header yourself is if
/// either you need to stream the response body rather than returning
/// it all at once, or you do not already have the complete response
/// body available, and only want to generate the parts that were
/// actually requested by the client.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="total_length">
/// the total_length of the response body
/// </param>
/// <param name="ranges">
/// return location for an array
///   of #SoupRange
/// </param>
/// <param name="length">
/// the length of the returned array
/// </param>
/// <return>
/// %TRUE if @hdrs contained a syntactically-valid
///   &quot;Range&quot; header, %FALSE otherwise (in which case @range and @length
///   will not be set).
/// </return>

	public static bool GetRanges(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, int total_length, out MentorLake.Soup.SoupRange[] ranges, out int length)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		return SoupMessageHeadersExterns.soup_message_headers_get_ranges(hdrs, total_length, out ranges, out length);
	}

/// <summary>
/// <para>
/// Checks whether the list-valued header @name is present in @hdrs,
/// and contains a case-insensitive match for @token.
/// </para>
/// <para>
/// (If @name is present in @hdrs, then this is equivalent to calling
/// [func@header_contains] on its value.)
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="name">
/// header name
/// </param>
/// <param name="token">
/// token to look for
/// </param>
/// <return>
/// %TRUE if the header is present and contains @token,
///   %FALSE otherwise.
/// </return>

	public static bool HeaderContains(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, string name, string token)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		return SoupMessageHeadersExterns.soup_message_headers_header_contains(hdrs, name, token);
	}

/// <summary>
/// <para>
/// Checks whether the header @name is present in @hdrs and is
/// (case-insensitively) equal to @value.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="name">
/// header name
/// </param>
/// <param name="value">
/// expected value
/// </param>
/// <return>
/// %TRUE if the header is present and its value is
///   @value, %FALSE otherwise.
/// </return>

	public static bool HeaderEquals(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, string name, string value)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		return SoupMessageHeadersExterns.soup_message_headers_header_equals(hdrs, name, value);
	}

/// <summary>
/// <para>
/// Atomically increments the reference count of @hdrs by one.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <return>
/// the passed in #SoupMessageHeaders
/// </return>

	public static MentorLake.Soup.SoupMessageHeadersHandle Ref(this MentorLake.Soup.SoupMessageHeadersHandle hdrs)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		return SoupMessageHeadersExterns.soup_message_headers_ref(hdrs);
	}

/// <summary>
/// <para>
/// Removes @name from @hdrs.
/// </para>
/// <para>
/// If there are multiple values for @name, they are all removed.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="name">
/// the header name to remove
/// </param>

	public static void Remove(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, string name)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		SoupMessageHeadersExterns.soup_message_headers_remove(hdrs, name);
	}

/// <summary>
/// <para>
/// Replaces the value of the header @name in @hdrs with @value.
/// </para>
/// <para>
/// See also [method@MessageHeaders.append].
/// </para>
/// <para>
/// The caller is expected to make sure that @name and @value are
/// syntactically correct.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="name">
/// the header name to replace
/// </param>
/// <param name="value">
/// the new value of @name
/// </param>

	public static void Replace(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, string name, string value)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		SoupMessageHeadersExterns.soup_message_headers_replace(hdrs, name, value);
	}

/// <summary>
/// <para>
/// Sets the &quot;Content-Disposition&quot; header in @hdrs to @disposition,
/// optionally with additional parameters specified in @params.
/// </para>
/// <para>
/// See [method@MessageHeaders.get_content_disposition] for a discussion
/// of how Content-Disposition is used in HTTP.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="disposition">
/// the disposition-type
/// </param>
/// <param name="@params">
/// additional parameters
/// </param>

	public static void SetContentDisposition(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, string disposition, MentorLake.GLib.GHashTableHandle @params)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		SoupMessageHeadersExterns.soup_message_headers_set_content_disposition(hdrs, disposition, @params);
	}

/// <summary>
/// <para>
/// Sets the message body length that @hdrs will declare, and sets
/// @hdrs&apos;s encoding to %SOUP_ENCODING_CONTENT_LENGTH.
/// </para>
/// <para>
/// You do not normally need to call this; if @hdrs is set to use
/// Content-Length encoding, libsoup will automatically set its
/// Content-Length header for you immediately before sending the
/// headers. One situation in which this method is useful is when
/// generating the response to a HEAD request; Calling
/// [method@MessageHeaders.set_content_length] allows you to put the
/// correct content length into the response without needing to waste
/// memory by filling in a response body which won&apos;t actually be sent.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="content_length">
/// the message body length
/// </param>

	public static void SetContentLength(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, int content_length)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		SoupMessageHeadersExterns.soup_message_headers_set_content_length(hdrs, content_length);
	}

/// <summary>
/// <para>
/// Sets @hdrs&apos;s Content-Range header according to the given values.
/// </para>
/// <para>
/// (Note that @total_length is the total length of the entire resource
/// that this is a range of, not simply @end - @start + 1.)
/// </para>
/// <para>
/// [class@Server] has built-in handling for range requests, and you do
/// not normally need to call this function youself. See
/// [method@MessageHeaders.get_ranges] for more details.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="start">
/// the start of the range
/// </param>
/// <param name="end">
/// the end of the range
/// </param>
/// <param name="total_length">
/// the total length of the resource, or -1 if unknown
/// </param>

	public static void SetContentRange(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, int start, int end, int total_length)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		SoupMessageHeadersExterns.soup_message_headers_set_content_range(hdrs, start, end, total_length);
	}

/// <summary>
/// <para>
/// Sets the &quot;Content-Type&quot; header in @hdrs to @content_type.
/// </para>
/// <para>
/// Accepts additional parameters specified in @params.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="content_type">
/// the MIME type
/// </param>
/// <param name="@params">
/// additional parameters
/// </param>

	public static void SetContentType(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, string content_type, MentorLake.GLib.GHashTableHandle @params)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		SoupMessageHeadersExterns.soup_message_headers_set_content_type(hdrs, content_type, @params);
	}

/// <summary>
/// <para>
/// Sets the message body encoding that @hdrs will declare.
/// </para>
/// <para>
/// In particular, you should use this if you are going to send a request or
/// response in chunked encoding.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="encoding">
/// a #SoupEncoding
/// </param>

	public static void SetEncoding(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, MentorLake.Soup.SoupEncoding encoding)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		SoupMessageHeadersExterns.soup_message_headers_set_encoding(hdrs, encoding);
	}

/// <summary>
/// <para>
/// Sets @hdrs&apos;s &quot;Expect&quot; header according to @expectations.
/// </para>
/// <para>
/// Currently %SOUP_EXPECTATION_CONTINUE is the only known expectation
/// value. You should set this value on a request if you are sending a
/// large message body (eg, via POST or PUT), and want to give the
/// server a chance to reject the request after seeing just the headers
/// (eg, because it will require authentication before allowing you to
/// post, or because you&apos;re POSTing to a URL that doesn&apos;t exist). This
/// saves you from having to transmit the large request body when the
/// server is just going to ignore it anyway.
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="expectations">
/// the expectations to set
/// </param>

	public static void SetExpectations(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, MentorLake.Soup.SoupExpectation expectations)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		SoupMessageHeadersExterns.soup_message_headers_set_expectations(hdrs, expectations);
	}

/// <summary>
/// <para>
/// Sets @hdrs&apos;s Range header to request the indicated range.
/// </para>
/// <para>
/// @start and @end are interpreted as in a [struct@Range].
/// </para>
/// <para>
/// If you need to request multiple ranges, use
/// [method@MessageHeaders.set_ranges].
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="start">
/// the start of the range to request
/// </param>
/// <param name="end">
/// the end of the range to request
/// </param>

	public static void SetRange(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, int start, int end)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		SoupMessageHeadersExterns.soup_message_headers_set_range(hdrs, start, end);
	}

/// <summary>
/// <para>
/// Sets @hdrs&apos;s Range header to request the indicated ranges.
/// </para>
/// <para>
/// If you only want to request a single range, you can use
/// [method@MessageHeaders.set_range].
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>
/// <param name="ranges">
/// an array of #SoupRange
/// </param>
/// <param name="length">
/// the length of @range
/// </param>

	public static void SetRanges(this MentorLake.Soup.SoupMessageHeadersHandle hdrs, MentorLake.Soup.SoupRangeHandle ranges, int length)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		SoupMessageHeadersExterns.soup_message_headers_set_ranges(hdrs, ranges, length);
	}

/// <summary>
/// <para>
/// Atomically decrements the reference count of @hdrs by one.
/// </para>
/// <para>
/// When the reference count reaches zero, the resources allocated by
/// @hdrs are freed
/// </para>
/// </summary>

/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>

	public static void Unref(this MentorLake.Soup.SoupMessageHeadersHandle hdrs)
	{
		if (hdrs.IsInvalid) throw new Exception("Invalid handle (SoupMessageHeaders)");
		SoupMessageHeadersExterns.soup_message_headers_unref(hdrs);
	}


	public static SoupMessageHeaders Dereference(this SoupMessageHeadersHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<SoupMessageHeaders>(x.DangerousGetHandle());
}
internal class SoupMessageHeadersExterns
{
	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))]
	internal static extern MentorLake.Soup.SoupMessageHeadersHandle soup_message_headers_new(MentorLake.Soup.SoupMessageHeadersType type);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_append([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, string name, string value);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_clean_connection_headers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, MentorLake.Soup.SoupMessageHeadersForeachFunc func, IntPtr user_data);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_free_ranges([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupRangeHandle>))] MentorLake.Soup.SoupRangeHandle ranges);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_message_headers_get_content_disposition([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, out string disposition, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] out MentorLake.GLib.GHashTableHandle @params);

	[DllImport(SoupLibrary.Name)]
	internal static extern int soup_message_headers_get_content_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_message_headers_get_content_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, out int start, out int end, out int total_length);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_message_headers_get_content_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] out MentorLake.GLib.GHashTableHandle @params);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.Soup.SoupEncoding soup_message_headers_get_encoding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.Soup.SoupExpectation soup_message_headers_get_expectations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.Soup.SoupMessageHeadersType soup_message_headers_get_headers_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_message_headers_get_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, string name);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_message_headers_get_one([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, string name);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_message_headers_get_ranges([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, int total_length, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out MentorLake.Soup.SoupRange[] ranges, out int length);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_message_headers_header_contains([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, string name, string token);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_message_headers_header_equals([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, string name, string value);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))]
	internal static extern MentorLake.Soup.SoupMessageHeadersHandle soup_message_headers_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, string name);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_replace([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, string name, string value);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_set_content_disposition([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, string disposition, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle @params);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_set_content_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, int content_length);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_set_content_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, int start, int end, int total_length);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_set_content_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, string content_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle @params);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_set_encoding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, MentorLake.Soup.SoupEncoding encoding);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_set_expectations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, MentorLake.Soup.SoupExpectation expectations);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_set_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, int start, int end);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_set_ranges([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupRangeHandle>))] MentorLake.Soup.SoupRangeHandle ranges, int length);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs);

}

/// <summary>
/// <para>
/// The HTTP message headers associated with a request or response.
/// </para>
/// </summary>

public struct SoupMessageHeaders
{
}
