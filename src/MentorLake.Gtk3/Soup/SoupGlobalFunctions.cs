namespace MentorLake.Soup;

public class SoupGlobalFunctions
{
/// <summary>
/// <para>
/// Like [func@CHECK_VERSION], but the check for soup_check_version is
/// at runtime instead of compile time.
/// </para>
/// <para>
/// This is useful for compiling against older versions of libsoup, but using
/// features from newer versions.
/// </para>
/// </summary>

/// <param name="major">
/// the major version to check
/// </param>
/// <param name="minor">
/// the minor version to check
/// </param>
/// <param name="micro">
/// the micro version to check
/// </param>
/// <return>
/// %TRUE if the version of the libsoup currently loaded
///   is the same as or newer than the passed-in version.
/// </return>

	public static bool CheckVersion(uint major, uint minor, uint micro)
	{
		return SoupGlobalFunctionsExterns.soup_check_version(major, minor, micro);
	}

/// <summary>
/// <para>
/// Parses @header and returns a [struct@Cookie].
/// </para>
/// <para>
/// If @header contains multiple cookies, only the first one will be parsed.
/// </para>
/// <para>
/// If @header does not have &quot;path&quot; or &quot;domain&quot; attributes, they will
/// be defaulted from @origin. If @origin is %NULL, path will default
/// to &quot;/&quot;, but domain will be left as %NULL. Note that this is not a
/// valid state for a [struct@Cookie], and you will need to fill in some
/// appropriate string for the domain if you want to actually make use
/// of the cookie.
/// </para>
/// <para>
/// As of version 3.4.0 the default value of a cookie&apos;s same-site-policy
/// is %SOUP_SAME_SITE_POLICY_LAX.
/// </para>
/// </summary>

/// <param name="header">
/// a cookie string (eg, the value of a Set-Cookie header)
/// </param>
/// <param name="origin">
/// origin of the cookie
/// </param>
/// <return>
/// a new #SoupCookie, or %NULL if it could
///   not be parsed, or contained an illegal &quot;domain&quot; attribute for a
///   cookie originating from @origin.
/// </return>

	public static MentorLake.Soup.SoupCookieHandle CookieParse(string header, MentorLake.GLib.GUriHandle origin)
	{
		return SoupGlobalFunctionsExterns.soup_cookie_parse(header, origin);
	}

/// <summary>
/// <para>
/// Frees @cookies.
/// </para>
/// </summary>

/// <param name="cookies">
/// a #GSList of [struct@Cookie]
/// </param>

	public static void CookiesFree(MentorLake.GLib.GSListHandle cookies)
	{
		SoupGlobalFunctionsExterns.soup_cookies_free(cookies);
	}

/// <summary>
/// <para>
/// Parses @msg&apos;s Cookie request header and returns a [struct@GLib.SList] of
/// `SoupCookie`s.
/// </para>
/// <para>
/// As the &quot;Cookie&quot; header, unlike &quot;Set-Cookie&quot;, only contains cookie names and
/// values, none of the other [struct@Cookie] fields will be filled in. (Thus, you
/// can&apos;t generally pass a cookie returned from this method directly to
/// [func@cookies_to_response].)
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage containing a &quot;Cookie&quot; request header
/// </param>
/// <return>
/// a #GSList of
///   `SoupCookie`s, which can be freed with [method@Cookie.free].
/// </return>

	public static MentorLake.GLib.GSListHandle CookiesFromRequest(MentorLake.Soup.SoupMessageHandle msg)
	{
		return SoupGlobalFunctionsExterns.soup_cookies_from_request(msg);
	}

/// <summary>
/// <para>
/// Parses @msg&apos;s Set-Cookie response headers and returns a [struct@GLib.SList]
/// of `SoupCookie`s.
/// </para>
/// <para>
/// Cookies that do not specify &quot;path&quot; or &quot;domain&quot; attributes will have their
/// values defaulted from @msg.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage containing a &quot;Set-Cookie&quot; response header
/// </param>
/// <return>
/// a #GSList of
///   `SoupCookie`s, which can be freed with [method@Cookie.free].
/// </return>

	public static MentorLake.GLib.GSListHandle CookiesFromResponse(MentorLake.Soup.SoupMessageHandle msg)
	{
		return SoupGlobalFunctionsExterns.soup_cookies_from_response(msg);
	}

/// <summary>
/// <para>
/// Serializes a [struct@GLib.SList] of [struct@Cookie] into a string suitable for
/// setting as the value of the &quot;Cookie&quot; header.
/// </para>
/// </summary>

/// <param name="cookies">
/// a #GSList of [struct@Cookie]
/// </param>
/// <return>
/// the serialization of @cookies
/// </return>

	public static string CookiesToCookieHeader(MentorLake.GLib.GSListHandle cookies)
	{
		return SoupGlobalFunctionsExterns.soup_cookies_to_cookie_header(cookies);
	}

/// <summary>
/// <para>
/// Adds the name and value of each cookie in @cookies to @msg&apos;s
/// &quot;Cookie&quot; request.
/// </para>
/// <para>
/// If @msg already has a &quot;Cookie&quot; request header, these cookies will be appended
/// to the cookies already present. Be careful that you do not append the same
/// cookies twice, eg, when requeuing a message.
/// </para>
/// </summary>

/// <param name="cookies">
/// a #GSList of [struct@Cookie]
/// </param>
/// <param name="msg">
/// a #SoupMessage
/// </param>

	public static void CookiesToRequest(MentorLake.GLib.GSListHandle cookies, MentorLake.Soup.SoupMessageHandle msg)
	{
		SoupGlobalFunctionsExterns.soup_cookies_to_request(cookies, msg);
	}

/// <summary>
/// <para>
/// Appends a &quot;Set-Cookie&quot; response header to @msg for each cookie in
/// @cookies.
/// </para>
/// <para>
/// This is in addition to any other &quot;Set-Cookie&quot; headers
/// @msg may already have.
/// </para>
/// </summary>

/// <param name="cookies">
/// a #GSList of [struct@Cookie]
/// </param>
/// <param name="msg">
/// a #SoupMessage
/// </param>

	public static void CookiesToResponse(MentorLake.GLib.GSListHandle cookies, MentorLake.Soup.SoupMessageHandle msg)
	{
		SoupGlobalFunctionsExterns.soup_cookies_to_response(cookies, msg);
	}

/// <summary>
/// <para>
/// Parses @date_string and tries to extract a date from it.
/// </para>
/// <para>
/// This recognizes all of the &quot;HTTP-date&quot; formats from RFC 2616, RFC 2822 dates,
/// and reasonable approximations thereof. (Eg, it is lenient about whitespace,
/// leading &quot;0&quot;s, etc.)
/// </para>
/// </summary>

/// <param name="date_string">
/// The date as a string
/// </param>
/// <return>
/// a new #GDateTime, or %NULL if @date_string
///   could not be parsed.
/// </return>

	public static MentorLake.GLib.GDateTimeHandle DateTimeNewFromHttpString(string date_string)
	{
		return SoupGlobalFunctionsExterns.soup_date_time_new_from_http_string(date_string);
	}

/// <summary>
/// <para>
/// Converts @date to a string in the format described by @format.
/// </para>
/// </summary>

/// <param name="date">
/// a #GDateTime
/// </param>
/// <param name="format">
/// the format to generate the date in
/// </param>
/// <return>
/// @date as a string or %NULL
/// </return>

	public static string DateTimeToString(MentorLake.GLib.GDateTimeHandle date, MentorLake.Soup.SoupDateFormat format)
	{
		return SoupGlobalFunctionsExterns.soup_date_time_to_string(date, format);
	}

/// <summary>
/// <para>
/// Decodes @form.
/// </para>
/// <para>
/// which is an urlencoded dataset as defined in the HTML 4.01 spec.
/// </para>
/// </summary>

/// <param name="encoded_form">
/// data of type &quot;application/x-www-form-urlencoded&quot;
/// </param>
/// <return>
/// a hash
///   table containing the name/value pairs from @encoded_form, which you
///   can free with [func@GLib.HashTable.destroy].
/// </return>

	public static MentorLake.GLib.GHashTableHandle FormDecode(string encoded_form)
	{
		return SoupGlobalFunctionsExterns.soup_form_decode(encoded_form);
	}

/// <summary>
/// <para>
/// Decodes the &quot;multipart/form-data&quot; request in @multipart.
/// </para>
/// <para>
/// this is a convenience method for the case when you have a single file upload
/// control in a form. (Or when you don&apos;t have any file upload controls, but are
/// still using &quot;multipart/form-data&quot; anyway.) Pass the name of the file upload
/// control in @file_control_name, and [func@form_decode_multipart] will extract
/// the uploaded file data into @filename, @content_type, and @file. All of the
/// other form control data will be returned (as strings, as with
/// [func@form_decode] in the returned [struct@GLib.HashTable].
/// </para>
/// <para>
/// You may pass %NULL for @filename, @content_type and/or @file if you do not
/// care about those fields. [func@form_decode_multipart] may also
/// return %NULL in those fields if the client did not provide that
/// information. You must free the returned filename and content-type
/// with [func@GLib.free], and the returned file data with [method@Glib.Bytes.unref].
/// </para>
/// <para>
/// If you have a form with more than one file upload control, you will
/// need to decode it manually, using [ctor@Multipart.new_from_message]
/// and [method@Multipart.get_part].
/// </para>
/// </summary>

/// <param name="multipart">
/// a #SoupMultipart
/// </param>
/// <param name="file_control_name">
/// the name of the HTML file upload control
/// </param>
/// <param name="filename">
/// return location for the name of the uploaded file
/// </param>
/// <param name="content_type">
/// return location for the MIME type of the uploaded file
/// </param>
/// <param name="file">
/// return location for the uploaded file data
/// </param>
/// <return>
/// 
///   a hash table containing the name/value pairs (other than
///   @file_control_name) from @msg, which you can free with
///   [func@GLib.HashTable.destroy]. On error, it will return %NULL.
/// </return>

	public static MentorLake.GLib.GHashTableHandle FormDecodeMultipart(MentorLake.Soup.SoupMultipartHandle multipart, string file_control_name, out string filename, out string content_type, out MentorLake.GLib.GBytesHandle file)
	{
		return SoupGlobalFunctionsExterns.soup_form_decode_multipart(multipart, file_control_name, out filename, out content_type, out file);
	}

/// <summary>
/// <para>
/// Encodes the given field names and values into a value of type
/// &quot;application/x-www-form-urlencoded&quot;.
/// </para>
/// <para>
/// Encodes as defined in the HTML 4.01 spec.
/// </para>
/// <para>
/// This method requires you to know the names of the form fields (or
/// at the very least, the total number of fields) at compile time; for
/// working with dynamic forms, use [func@form_encode_hash] or
/// [func@form_encode_datalist].
/// </para>
/// <para>
/// See also: [ctor@Message.new_from_encoded_form].
/// </para>
/// </summary>

/// <param name="first_field">
/// name of the first form field
/// </param>
/// <param name="@__arglist">
/// value of @first_field, followed by additional field names
///   and values, terminated by %NULL.
/// </param>
/// <return>
/// the encoded form
/// </return>

	public static string FormEncode(string first_field, IntPtr @__arglist)
	{
		return SoupGlobalFunctionsExterns.soup_form_encode(first_field, @__arglist);
	}

/// <summary>
/// <para>
/// Encodes @form_data_set into a value of type
/// &quot;application/x-www-form-urlencoded&quot;.
/// </para>
/// <para>
/// Encodes as defined in the HTML 4.01 spec. Unlike [func@form_encode_hash],
/// this preserves the ordering of the form elements, which may be required in
/// some situations.
/// </para>
/// <para>
/// See also: [ctor@Message.new_from_encoded_form].
/// </para>
/// </summary>

/// <param name="form_data_set">
/// a datalist containing name/value pairs
/// </param>
/// <return>
/// the encoded form
/// </return>

	public static string FormEncodeDatalist(IntPtr form_data_set)
	{
		return SoupGlobalFunctionsExterns.soup_form_encode_datalist(form_data_set);
	}

/// <summary>
/// <para>
/// Encodes @form_data_set into a value of type
/// &quot;application/x-www-form-urlencoded&quot;.
/// </para>
/// <para>
/// Encodes as defined in the HTML 4.01 spec.
/// </para>
/// <para>
/// Note that the HTML spec states that &quot;The control names/values are
/// listed in the order they appear in the document.&quot; Since this method
/// takes a hash table, it cannot enforce that; if you care about the
/// ordering of the form fields, use [func@form_encode_datalist].
/// </para>
/// <para>
/// See also: [ctor@Message.new_from_encoded_form].
/// </para>
/// </summary>

/// <param name="form_data_set">
/// a hash table containing
///   name/value pairs (as strings)
/// </param>
/// <return>
/// the encoded form
/// </return>

	public static string FormEncodeHash(MentorLake.GLib.GHashTableHandle form_data_set)
	{
		return SoupGlobalFunctionsExterns.soup_form_encode_hash(form_data_set);
	}

/// <summary>
/// <para>
/// See [func@form_encode].
/// </para>
/// <para>
/// This is mostly an internal method, used by various other methods such as
/// [func@form_encode].
/// </para>
/// <para>
/// See also: [ctor@Message.new_from_encoded_form].
/// </para>
/// </summary>

/// <param name="first_field">
/// name of the first form field
/// </param>
/// <param name="args">
/// pointer to additional values, as in [func@form_encode]
/// </param>
/// <return>
/// the encoded form
/// </return>

	public static string FormEncodeValist(string first_field, IntPtr args)
	{
		return SoupGlobalFunctionsExterns.soup_form_encode_valist(first_field, args);
	}

/// <summary>
/// <para>
/// Returns the major version number of the libsoup library.
/// </para>
/// <para>
/// e.g. in libsoup version 2.42.0 this is 2.
/// </para>
/// <para>
/// This function is in the library, so it represents the libsoup library
/// your code is running against. Contrast with the #SOUP_MAJOR_VERSION
/// macro, which represents the major version of the libsoup headers you
/// have included when compiling your code.
/// </para>
/// </summary>

/// <return>
/// the major version number of the libsoup library
/// </return>

	public static uint GetMajorVersion()
	{
		return SoupGlobalFunctionsExterns.soup_get_major_version();
	}

/// <summary>
/// <para>
/// Returns the micro version number of the libsoup library.
/// </para>
/// <para>
/// e.g. in libsoup version 2.42.0 this is 0.
/// </para>
/// <para>
/// This function is in the library, so it represents the libsoup library
/// your code is running against. Contrast with the #SOUP_MICRO_VERSION
/// macro, which represents the micro version of the libsoup headers you
/// have included when compiling your code.
/// </para>
/// </summary>

/// <return>
/// the micro version number of the libsoup library
/// </return>

	public static uint GetMicroVersion()
	{
		return SoupGlobalFunctionsExterns.soup_get_micro_version();
	}

/// <summary>
/// <para>
/// Returns the minor version number of the libsoup library.
/// </para>
/// <para>
/// e.g. in libsoup version 2.42.0 this is 42.
/// </para>
/// <para>
/// This function is in the library, so it represents the libsoup library
/// your code is running against. Contrast with the #SOUP_MINOR_VERSION
/// macro, which represents the minor version of the libsoup headers you
/// have included when compiling your code.
/// </para>
/// </summary>

/// <return>
/// the minor version number of the libsoup library
/// </return>

	public static uint GetMinorVersion()
	{
		return SoupGlobalFunctionsExterns.soup_get_minor_version();
	}

/// <summary>
/// <para>
/// Parses @header to see if it contains the token @token (matched
/// case-insensitively).
/// </para>
/// <para>
/// Note that this can&apos;t be used with lists that have qvalues.
/// </para>
/// </summary>

/// <param name="header">
/// An HTTP header suitable for parsing with
///   [func@header_parse_list]
/// </param>
/// <param name="token">
/// a token
/// </param>
/// <return>
/// whether or not @header contains @token
/// </return>

	public static bool HeaderContains(string header, string token)
	{
		return SoupGlobalFunctionsExterns.soup_header_contains(header, token);
	}

/// <summary>
/// <para>
/// Frees @list.
/// </para>
/// </summary>

/// <param name="list">
/// a #GSList returned from [func@header_parse_list] or
/// [func@header_parse_quality_list]
/// </param>

	public static void HeaderFreeList(MentorLake.GLib.GSListHandle list)
	{
		SoupGlobalFunctionsExterns.soup_header_free_list(list);
	}

/// <summary>
/// <para>
/// Frees @param_list.
/// </para>
/// </summary>

/// <param name="param_list">
/// a #GHashTable returned from
///   [func@header_parse_param_list] or [func@header_parse_semi_param_list]
/// </param>

	public static void HeaderFreeParamList(MentorLake.GLib.GHashTableHandle param_list)
	{
		SoupGlobalFunctionsExterns.soup_header_free_param_list(param_list);
	}

/// <summary>
/// <para>
/// Appends something like `name=value` to @string, taking care to quote @value
/// if needed, and if so, to escape any quotes or backslashes in @value.
/// </para>
/// <para>
/// Alternatively, if @value is a non-ASCII UTF-8 string, it will be
/// appended using RFC5987 syntax. Although in theory this is supposed
/// to work anywhere in HTTP that uses this style of parameter, in
/// reality, it can only be used portably with the Content-Disposition
/// &quot;filename&quot; parameter.
/// </para>
/// <para>
/// If @value is %NULL, this will just append @name to @string.
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString being used to construct an HTTP header value
/// </param>
/// <param name="name">
/// a parameter name
/// </param>
/// <param name="value">
/// a parameter value, or %NULL
/// </param>

	public static void HeaderGStringAppendParam(MentorLake.GLib.GStringHandle @string, string name, string value)
	{
		SoupGlobalFunctionsExterns.soup_header_g_string_append_param(@string, name, value);
	}

/// <summary>
/// <para>
/// Appends something like `name=&quot;value&quot;` to
/// @string, taking care to escape any quotes or backslashes in @value.
/// </para>
/// <para>
/// If @value is (non-ASCII) UTF-8, this will instead use RFC 5987
/// encoding, just like [func@header_g_string_append_param].
/// </para>
/// </summary>

/// <param name="@string">
/// a #GString being used to construct an HTTP header value
/// </param>
/// <param name="name">
/// a parameter name
/// </param>
/// <param name="value">
/// a parameter value
/// </param>

	public static void HeaderGStringAppendParamQuoted(MentorLake.GLib.GStringHandle @string, string name, string value)
	{
		SoupGlobalFunctionsExterns.soup_header_g_string_append_param_quoted(@string, name, value);
	}

/// <summary>
/// <para>
/// Parses a header whose content is described by RFC2616 as `#something`.
/// </para>
/// <para>
/// &quot;something&quot; does not itself contain commas, except as part of quoted-strings.
/// </para>
/// </summary>

/// <param name="header">
/// a header value
/// </param>
/// <return>
/// a #GSList of
///   list elements, as allocated strings
/// </return>

	public static MentorLake.GLib.GSListHandle HeaderParseList(string header)
	{
		return SoupGlobalFunctionsExterns.soup_header_parse_list(header);
	}

/// <summary>
/// <para>
/// Parses a header which is a comma-delimited list of something like:
/// `token [ &quot;=&quot; ( token | quoted-string ) ]`.
/// </para>
/// <para>
/// Tokens that don&apos;t have an associated value will still be added to
/// the resulting hash table, but with a %NULL value.
/// </para>
/// <para>
/// This also handles RFC5987 encoding (which in HTTP is mostly used
/// for giving UTF8-encoded filenames in the Content-Disposition
/// header).
/// </para>
/// </summary>

/// <param name="header">
/// a header value
/// </param>
/// <return>
/// a
///   #GHashTable of list elements, which can be freed with
///   [func@header_free_param_list].
/// </return>

	public static MentorLake.GLib.GHashTableHandle HeaderParseParamList(string header)
	{
		return SoupGlobalFunctionsExterns.soup_header_parse_param_list(header);
	}

/// <summary>
/// <para>
/// A strict version of [func@header_parse_param_list]
/// that bails out if there are duplicate parameters.
/// </para>
/// <para>
/// Note that this function will treat RFC5987-encoded
/// parameters as duplicated if an ASCII version is also
/// present. For header fields that might contain
/// RFC5987-encoded parameters, use
/// [func@header_parse_param_list] instead.
/// </para>
/// </summary>

/// <param name="header">
/// a header value
/// </param>
/// <return>
/// 
///   a #GHashTable of list elements, which can be freed with
///   [func@header_free_param_list] or %NULL if there are duplicate
///   elements.
/// </return>

	public static MentorLake.GLib.GHashTableHandle HeaderParseParamListStrict(string header)
	{
		return SoupGlobalFunctionsExterns.soup_header_parse_param_list_strict(header);
	}

/// <summary>
/// <para>
/// Parses a header whose content is a list of items with optional
/// &quot;qvalue&quot;s (eg, Accept, Accept-Charset, Accept-Encoding,
/// Accept-Language, TE).
/// </para>
/// <para>
/// If @unacceptable is not %NULL, then on return, it will contain the
/// items with qvalue 0. Either way, those items will be removed from
/// the main list.
/// </para>
/// </summary>

/// <param name="header">
/// a header value
/// </param>
/// <param name="unacceptable">
/// on
///   return, will contain a list of unacceptable values
/// </param>
/// <return>
/// a #GSList of
///   acceptable values (as allocated strings), highest-qvalue first.
/// </return>

	public static MentorLake.GLib.GSListHandle HeaderParseQualityList(string header, out MentorLake.GLib.GSListHandle unacceptable)
	{
		return SoupGlobalFunctionsExterns.soup_header_parse_quality_list(header, out unacceptable);
	}

/// <summary>
/// <para>
/// Parses a header which is a semicolon-delimited list of something
/// like: `token [ &quot;=&quot; ( token | quoted-string ) ]`.
/// </para>
/// <para>
/// Tokens that don&apos;t have an associated value will still be added to
/// the resulting hash table, but with a %NULL value.
/// </para>
/// <para>
/// This also handles RFC5987 encoding (which in HTTP is mostly used
/// for giving UTF8-encoded filenames in the Content-Disposition
/// header).
/// </para>
/// </summary>

/// <param name="header">
/// a header value
/// </param>
/// <return>
/// a
///   #GHashTable of list elements, which can be freed with
///   [func@header_free_param_list].
/// </return>

	public static MentorLake.GLib.GHashTableHandle HeaderParseSemiParamList(string header)
	{
		return SoupGlobalFunctionsExterns.soup_header_parse_semi_param_list(header);
	}

/// <summary>
/// <para>
/// A strict version of [func@header_parse_semi_param_list]
/// that bails out if there are duplicate parameters.
/// </para>
/// <para>
/// Note that this function will treat RFC5987-encoded
/// parameters as duplicated if an ASCII version is also
/// present. For header fields that might contain
/// RFC5987-encoded parameters, use
/// [func@header_parse_semi_param_list] instead.
/// </para>
/// </summary>

/// <param name="header">
/// a header value
/// </param>
/// <return>
/// 
///   a #GHashTable of list elements, which can be freed with
///   [func@header_free_param_list] or %NULL if there are duplicate
///   elements.
/// </return>

	public static MentorLake.GLib.GHashTableHandle HeaderParseSemiParamListStrict(string header)
	{
		return SoupGlobalFunctionsExterns.soup_header_parse_semi_param_list_strict(header);
	}

/// <summary>
/// <para>
/// Parses the headers of an HTTP request or response in @str and
/// stores the results in @dest.
/// </para>
/// <para>
/// Beware that @dest may be modified even on failure.
/// </para>
/// <para>
/// This is a low-level method; normally you would use
/// [func@headers_parse_request] or [func@headers_parse_response].
/// </para>
/// </summary>

/// <param name="str">
/// the header string (including the Request-Line or Status-Line,
///   but not the trailing blank line)
/// </param>
/// <param name="len">
/// length of @str
/// </param>
/// <param name="dest">
/// #SoupMessageHeaders to store the header values in
/// </param>
/// <return>
/// success or failure
/// </return>

	public static bool HeadersParse(string str, int len, MentorLake.Soup.SoupMessageHeadersHandle dest)
	{
		return SoupGlobalFunctionsExterns.soup_headers_parse(str, len, dest);
	}

/// <summary>
/// <para>
/// Parses the headers of an HTTP request in @str and stores the
/// results in @req_method, @req_path, @ver, and @req_headers.
/// </para>
/// <para>
/// Beware that @req_headers may be modified even on failure.
/// </para>
/// </summary>

/// <param name="str">
/// the headers (up to, but not including, the trailing blank line)
/// </param>
/// <param name="len">
/// length of @str
/// </param>
/// <param name="req_headers">
/// #SoupMessageHeaders to store the header values in
/// </param>
/// <param name="req_method">
/// if non-%NULL, will be filled in with the
///   request method
/// </param>
/// <param name="req_path">
/// if non-%NULL, will be filled in with the
///   request path
/// </param>
/// <param name="ver">
/// if non-%NULL, will be filled in with the HTTP
///   version
/// </param>
/// <return>
/// %SOUP_STATUS_OK if the headers could be parsed, or an
///   HTTP error to be returned to the client if they could not be.
/// </return>

	public static uint HeadersParseRequest(string str, int len, MentorLake.Soup.SoupMessageHeadersHandle req_headers, out string req_method, out string req_path, out MentorLake.Soup.SoupHTTPVersion ver)
	{
		return SoupGlobalFunctionsExterns.soup_headers_parse_request(str, len, req_headers, out req_method, out req_path, out ver);
	}

/// <summary>
/// <para>
/// Parses the headers of an HTTP response in @str and stores the
/// results in @ver, @status_code, @reason_phrase, and @headers.
/// </para>
/// <para>
/// Beware that @headers may be modified even on failure.
/// </para>
/// </summary>

/// <param name="str">
/// the headers (up to, but not including, the trailing blank line)
/// </param>
/// <param name="len">
/// length of @str
/// </param>
/// <param name="headers">
/// #SoupMessageHeaders to store the header values in
/// </param>
/// <param name="ver">
/// if non-%NULL, will be filled in with the HTTP
///   version
/// </param>
/// <param name="status_code">
/// if non-%NULL, will be filled in with
///   the status code
/// </param>
/// <param name="reason_phrase">
/// if non-%NULL, will be filled in with
///   the reason phrase
/// </param>
/// <return>
/// success or failure.
/// </return>

	public static bool HeadersParseResponse(string str, int len, MentorLake.Soup.SoupMessageHeadersHandle headers, out MentorLake.Soup.SoupHTTPVersion ver, out uint status_code, out string reason_phrase)
	{
		return SoupGlobalFunctionsExterns.soup_headers_parse_response(str, len, headers, out ver, out status_code, out reason_phrase);
	}

/// <summary>
/// <para>
/// Parses the HTTP Status-Line string in @status_line into @ver,
/// @status_code, and @reason_phrase.
/// </para>
/// <para>
/// @status_line must be terminated by either &quot;\0&quot; or &quot;\r\n&quot;.
/// </para>
/// </summary>

/// <param name="status_line">
/// an HTTP Status-Line
/// </param>
/// <param name="ver">
/// if non-%NULL, will be filled in with the HTTP
///   version
/// </param>
/// <param name="status_code">
/// if non-%NULL, will be filled in with
///   the status code
/// </param>
/// <param name="reason_phrase">
/// if non-%NULL, will be filled in with
///   the reason phrase
/// </param>
/// <return>
/// %TRUE if @status_line was parsed successfully.
/// </return>

	public static bool HeadersParseStatusLine(string status_line, out MentorLake.Soup.SoupHTTPVersion ver, out uint status_code, out string reason_phrase)
	{
		return SoupGlobalFunctionsExterns.soup_headers_parse_status_line(status_line, out ver, out status_code, out reason_phrase);
	}

/// <summary>
/// <para>
/// Initializes @iter for iterating @hdrs.
/// </para>
/// </summary>

/// <param name="iter">
/// a pointer to a #SoupMessageHeadersIter structure
/// </param>
/// <param name="hdrs">
/// a #SoupMessageHeaders
/// </param>

	public static void MessageHeadersIterInit(out MentorLake.Soup.SoupMessageHeadersIter iter, MentorLake.Soup.SoupMessageHeadersHandle hdrs)
	{
		SoupGlobalFunctionsExterns.soup_message_headers_iter_init(out iter, hdrs);
	}

/// <summary>
/// <para>
/// Yields the next name/value pair in the [struct@MessageHeaders] being
/// iterated by @iter.
/// </para>
/// <para>
/// If @iter has already yielded the last header, then
/// [func@MessageHeadersIter.next] will return %FALSE and @name and @value
/// will be unchanged.
/// </para>
/// </summary>

/// <param name="iter">
/// a #SoupMessageHeadersIter
/// </param>
/// <param name="name">
/// pointer to a variable to return
///   the header name in
/// </param>
/// <param name="value">
/// pointer to a variable to return
///   the header value in
/// </param>
/// <return>
/// %TRUE if another name and value were returned, %FALSE
///   if the end of the headers has been reached.
/// </return>

	public static bool MessageHeadersIterNext(ref MentorLake.Soup.SoupMessageHeadersIter iter, out string name, out string value)
	{
		return SoupGlobalFunctionsExterns.soup_message_headers_iter_next(ref iter, out name, out value);
	}

/// <summary>
/// <para>
/// Registers error quark for SoupSession if needed.
/// </para>
/// </summary>

/// <return>
/// Error quark for SoupSession.
/// </return>

	public static MentorLake.GLib.GQuark SessionErrorQuark()
	{
		return SoupGlobalFunctionsExterns.soup_session_error_quark();
	}

/// <summary>
/// <para>
/// Looks up the stock HTTP description of @status_code.
/// </para>
/// <para>
/// *There is no reason for you to ever use this
/// function.* If you wanted the textual description for the
/// [property@Message:status-code] of a given [class@Message], you should just
/// look at the message&apos;s [property@Message:reason-phrase]. However, you
/// should only do that for use in debugging messages; HTTP reason
/// phrases are not localized, and are not generally very descriptive
/// anyway, and so they should never be presented to the user directly.
/// Instead, you should create you own error messages based on the
/// status code, and on what you were trying to do.
/// </para>
/// </summary>

/// <param name="status_code">
/// an HTTP status code
/// </param>
/// <return>
/// the (terse, English) description of @status_code
/// </return>

	public static string StatusGetPhrase(uint status_code)
	{
		return SoupGlobalFunctionsExterns.soup_status_get_phrase(status_code);
	}

/// <summary>
/// <para>
/// Looks whether the @domain passed as argument is a public domain
/// suffix (.org, .com, .co.uk, etc) or not.
/// </para>
/// <para>
/// Prior to libsoup 2.46, this function required that @domain be in
/// UTF-8 if it was an IDN. From 2.46 on, the name can be in either
/// UTF-8 or ASCII format.
/// </para>
/// </summary>

/// <param name="domain">
/// a domain name
/// </param>
/// <return>
/// %TRUE if it is a public domain, %FALSE otherwise.
/// </return>

	public static bool TldDomainIsPublicSuffix(string domain)
	{
		return SoupGlobalFunctionsExterns.soup_tld_domain_is_public_suffix(domain);
	}

/// <summary>
/// <para>
/// Registers error quark for soup_tld_get_base_domain() if needed.
/// </para>
/// </summary>

/// <return>
/// Error quark for Soup TLD functions.
/// </return>

	public static MentorLake.GLib.GQuark TldErrorQuark()
	{
		return SoupGlobalFunctionsExterns.soup_tld_error_quark();
	}

/// <summary>
/// <para>
/// Finds the base domain for a given @hostname
/// </para>
/// <para>
/// The base domain is composed by the top level domain (such as .org, .com,
/// .co.uk, etc) plus the second level domain, for example for
/// myhost.mydomain.com it will return mydomain.com.
/// </para>
/// <para>
/// Note that %NULL will be returned for private URLs (those not ending
/// with any well known TLD) because choosing a base domain for them
/// would be totally arbitrary.
/// </para>
/// <para>
/// Prior to libsoup 2.46, this function required that @hostname be in
/// UTF-8 if it was an IDN. From 2.46 on, the name can be in either
/// UTF-8 or ASCII format (and the return value will be in the same
/// format).
/// </para>
/// </summary>

/// <param name="hostname">
/// a hostname
/// </param>
/// <return>
/// a pointer to the start of the base domain in @hostname. If
///   an error occurs, %NULL will be returned and @error set.
/// </return>

	public static string TldGetBaseDomain(string hostname)
	{
		var externCallResult = SoupGlobalFunctionsExterns.soup_tld_get_base_domain(hostname, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// As of 3.4.0 this will detect the default ports of HTTP(s) and WS(S)
/// URIs when copying and set it to the default port of the new scheme.
/// So for example copying `http://localhost:80` while changing the scheme to https
/// will result in `https://localhost:443`.
/// </para>
/// <para>
/// Return a copy of @uri with the given components updated.
/// </para>
/// </summary>

/// <param name="uri">
/// the #GUri to copy
/// </param>
/// <param name="first_component">
/// first #SoupURIComponent to update
/// </param>
/// <param name="@__arglist">
/// value of @first_component  followed by additional
///    components and values, terminated by %SOUP_URI_NONE
/// </param>
/// <return>
/// a new #GUri
/// </return>

	public static MentorLake.GLib.GUriHandle UriCopy(MentorLake.GLib.GUriHandle uri, MentorLake.Soup.SoupURIComponent first_component, IntPtr @__arglist)
	{
		return SoupGlobalFunctionsExterns.soup_uri_copy(uri, first_component, @__arglist);
	}

/// <summary>
/// <para>
/// Decodes the given data URI and returns its contents and @content_type.
/// </para>
/// </summary>

/// <param name="uri">
/// a data URI, in string form
/// </param>
/// <param name="content_type">
/// location to store content type
/// </param>
/// <return>
/// a #GBytes with the contents of @uri,
///    or %NULL if @uri is not a valid data URI
/// </return>

	public static MentorLake.GLib.GBytesHandle UriDecodeDataUri(string uri, out string content_type)
	{
		return SoupGlobalFunctionsExterns.soup_uri_decode_data_uri(uri, out content_type);
	}

/// <summary>
/// <para>
/// Tests whether or not @uri1 and @uri2 are equal in all parts.
/// </para>
/// </summary>

/// <param name="uri1">
/// a #GUri
/// </param>
/// <param name="uri2">
/// another #GUri
/// </param>
/// <return>
/// %TRUE if equal otherwise %FALSE
/// </return>

	public static bool UriEqual(MentorLake.GLib.GUriHandle uri1, MentorLake.GLib.GUriHandle uri2)
	{
		return SoupGlobalFunctionsExterns.soup_uri_equal(uri1, uri2);
	}

/// <summary>
/// <para>
/// Adds the necessary headers to @msg to request a WebSocket
/// handshake including supported WebSocket extensions.
/// </para>
/// <para>
/// The message body and non-WebSocket-related headers are
/// not modified.
/// </para>
/// <para>
/// This is a low-level function; if you use
/// [method@Session.websocket_connect_async] to create a WebSocket connection, it
/// will call this for you.
/// </para>
/// </summary>

/// <param name="msg">
/// a #SoupMessage
/// </param>
/// <param name="origin">
/// the &quot;Origin&quot; header to set
/// </param>
/// <param name="protocols">
/// list of
///   protocols to offer
/// </param>
/// <param name="supported_extensions">
/// list
///   of supported extension types
/// </param>

	public static void WebsocketClientPrepareHandshake(MentorLake.Soup.SoupMessageHandle msg, string origin, string[] protocols, MentorLake.GLib.GPtrArrayHandle supported_extensions)
	{
		SoupGlobalFunctionsExterns.soup_websocket_client_prepare_handshake(msg, origin, protocols, supported_extensions);
	}

/// <summary>
/// <para>
/// Looks at the response status code and headers in @msg and
/// determines if they contain a valid WebSocket handshake response
/// (given the handshake request in @msg&apos;s request headers).
/// </para>
/// <para>
/// If @supported_extensions is non-%NULL, extensions included in the
/// response &quot;Sec-WebSocket-Extensions&quot; are verified too. Accepted
/// extensions are returned in @accepted_extensions parameter if non-%NULL.
/// </para>
/// <para>
/// This is a low-level function; if you use
/// [method@Session.websocket_connect_async] to create a WebSocket
/// connection, it will call this for you.
/// </para>
/// </summary>

/// <param name="msg">
/// #SoupMessage containing both client and server sides of a
///   WebSocket handshake
/// </param>
/// <param name="supported_extensions">
/// list
///   of supported extension types
/// </param>
/// <param name="accepted_extensions">
/// a
///   #GList of [class@WebsocketExtension] objects
/// </param>
/// <return>
/// %TRUE if @msg contains a completed valid WebSocket
///   handshake, %FALSE and an error if not.
/// </return>

	public static bool WebsocketClientVerifyHandshake(MentorLake.Soup.SoupMessageHandle msg, MentorLake.GLib.GPtrArrayHandle supported_extensions, out MentorLake.GLib.GListHandle accepted_extensions)
	{
		var externCallResult = SoupGlobalFunctionsExterns.soup_websocket_client_verify_handshake(msg, supported_extensions, out accepted_extensions, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Registers error quark for SoupWebsocket if needed.
/// </para>
/// </summary>

/// <return>
/// Error quark for SoupWebsocket.
/// </return>

	public static MentorLake.GLib.GQuark WebsocketErrorQuark()
	{
		return SoupGlobalFunctionsExterns.soup_websocket_error_quark();
	}

/// <summary>
/// <para>
/// Examines the method and request headers in @msg and determines
/// whether @msg contains a valid handshake request.
/// </para>
/// <para>
/// If @origin is non-%NULL, then only requests containing a matching
/// &quot;Origin&quot; header will be accepted. If @protocols is non-%NULL, then
/// only requests containing a compatible &quot;Sec-WebSocket-Protocols&quot;
/// header will be accepted. If @supported_extensions is non-%NULL, then
/// only requests containing valid supported extensions in
/// &quot;Sec-WebSocket-Extensions&quot; header will be accepted.
/// </para>
/// <para>
/// Normally [func@websocket_server_process_handshake]
/// will take care of this for you, and if you use
/// [method@Server.add_websocket_handler] to handle accepting WebSocket
/// connections, it will call that for you. However, this function may
/// be useful if you need to perform more complicated validation; eg,
/// accepting multiple different Origins, or handling different protocols
/// depending on the path.
/// </para>
/// </summary>

/// <param name="msg">
/// #SoupServerMessage containing the client side of a WebSocket handshake
/// </param>
/// <param name="origin">
/// expected Origin header
/// </param>
/// <param name="protocols">
/// allowed WebSocket
///   protocols.
/// </param>
/// <param name="supported_extensions">
/// list
///   of supported extension types
/// </param>
/// <return>
/// %TRUE if @msg contained a valid WebSocket handshake,
///   %FALSE and an error if not.
/// </return>

	public static bool WebsocketServerCheckHandshake(MentorLake.Soup.SoupServerMessageHandle msg, string origin, string[] protocols, MentorLake.GLib.GPtrArrayHandle supported_extensions)
	{
		var externCallResult = SoupGlobalFunctionsExterns.soup_websocket_server_check_handshake(msg, origin, protocols, supported_extensions, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Examines the method and request headers in @msg and (assuming @msg
/// contains a valid handshake request), fills in the handshake
/// response.
/// </para>
/// <para>
/// If @expected_origin is non-%NULL, then only requests containing a matching
/// &quot;Origin&quot; header will be accepted. If @protocols is non-%NULL, then
/// only requests containing a compatible &quot;Sec-WebSocket-Protocols&quot;
/// header will be accepted. If @supported_extensions is non-%NULL, then
/// only requests containing valid supported extensions in
/// &quot;Sec-WebSocket-Extensions&quot; header will be accepted. The accepted extensions
/// will be returned in @accepted_extensions parameter if non-%NULL.
/// </para>
/// <para>
/// This is a low-level function; if you use
/// [method@Server.add_websocket_handler] to handle accepting WebSocket
/// connections, it will call this for you.
/// </para>
/// </summary>

/// <param name="msg">
/// #SoupServerMessage containing the client side of a WebSocket handshake
/// </param>
/// <param name="expected_origin">
/// expected Origin header
/// </param>
/// <param name="protocols">
/// allowed WebSocket
///   protocols.
/// </param>
/// <param name="supported_extensions">
/// list
///   of supported extension types
/// </param>
/// <param name="accepted_extensions">
/// a
///   #GList of [class@WebsocketExtension] objects
/// </param>
/// <return>
/// %TRUE if @msg contained a valid WebSocket handshake
///   request and was updated to contain a handshake response. %FALSE if not.
/// </return>

	public static bool WebsocketServerProcessHandshake(MentorLake.Soup.SoupServerMessageHandle msg, string expected_origin, string[] protocols, MentorLake.GLib.GPtrArrayHandle supported_extensions, out MentorLake.GLib.GListHandle accepted_extensions)
	{
		return SoupGlobalFunctionsExterns.soup_websocket_server_process_handshake(msg, expected_origin, protocols, supported_extensions, out accepted_extensions);
	}

}

internal class SoupGlobalFunctionsExterns
{
	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_check_version(uint major, uint minor, uint micro);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupCookieHandle>))]
	internal static extern MentorLake.Soup.SoupCookieHandle soup_cookie_parse(string header, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle origin);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookies_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle cookies);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle soup_cookies_from_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle soup_cookies_from_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_cookies_to_cookie_header([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle cookies);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookies_to_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle cookies, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_cookies_to_response([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle cookies, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))]
	internal static extern MentorLake.GLib.GDateTimeHandle soup_date_time_new_from_http_string(string date_string);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_date_time_to_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GDateTimeHandle>))] MentorLake.GLib.GDateTimeHandle date, MentorLake.Soup.SoupDateFormat format);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
	internal static extern MentorLake.GLib.GHashTableHandle soup_form_decode(string encoded_form);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
	internal static extern MentorLake.GLib.GHashTableHandle soup_form_decode_multipart([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMultipartHandle>))] MentorLake.Soup.SoupMultipartHandle multipart, string file_control_name, out string filename, out string content_type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] out MentorLake.GLib.GBytesHandle file);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_form_encode(string first_field, IntPtr @__arglist);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_form_encode_datalist(IntPtr form_data_set);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_form_encode_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle form_data_set);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_form_encode_valist(string first_field, IntPtr args);

	[DllImport(SoupLibrary.Name)]
	internal static extern uint soup_get_major_version();

	[DllImport(SoupLibrary.Name)]
	internal static extern uint soup_get_micro_version();

	[DllImport(SoupLibrary.Name)]
	internal static extern uint soup_get_minor_version();

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_header_contains(string header, string token);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_header_free_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] MentorLake.GLib.GSListHandle list);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_header_free_param_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))] MentorLake.GLib.GHashTableHandle param_list);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_header_g_string_append_param([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string name, string value);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_header_g_string_append_param_quoted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GStringHandle>))] MentorLake.GLib.GStringHandle @string, string name, string value);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle soup_header_parse_list(string header);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
	internal static extern MentorLake.GLib.GHashTableHandle soup_header_parse_param_list(string header);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
	internal static extern MentorLake.GLib.GHashTableHandle soup_header_parse_param_list_strict(string header);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle soup_header_parse_quality_list(string header, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))] out MentorLake.GLib.GSListHandle unacceptable);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
	internal static extern MentorLake.GLib.GHashTableHandle soup_header_parse_semi_param_list(string header);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GHashTableHandle>))]
	internal static extern MentorLake.GLib.GHashTableHandle soup_header_parse_semi_param_list_strict(string header);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_headers_parse(string str, int len, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle dest);

	[DllImport(SoupLibrary.Name)]
	internal static extern uint soup_headers_parse_request(string str, int len, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle req_headers, out string req_method, out string req_path, out MentorLake.Soup.SoupHTTPVersion ver);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_headers_parse_response(string str, int len, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle headers, out MentorLake.Soup.SoupHTTPVersion ver, out uint status_code, out string reason_phrase);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_headers_parse_status_line(string status_line, out MentorLake.Soup.SoupHTTPVersion ver, out uint status_code, out string reason_phrase);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_message_headers_iter_init(out MentorLake.Soup.SoupMessageHeadersIter iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHeadersHandle>))] MentorLake.Soup.SoupMessageHeadersHandle hdrs);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_message_headers_iter_next(ref MentorLake.Soup.SoupMessageHeadersIter iter, out string name, out string value);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark soup_session_error_quark();

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_status_get_phrase(uint status_code);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_tld_domain_is_public_suffix(string domain);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark soup_tld_error_quark();

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string soup_tld_get_base_domain(string hostname, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))]
	internal static extern MentorLake.GLib.GUriHandle soup_uri_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri, MentorLake.Soup.SoupURIComponent first_component, IntPtr @__arglist);

	[DllImport(SoupLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))]
	internal static extern MentorLake.GLib.GBytesHandle soup_uri_decode_data_uri(string uri, out string content_type);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_uri_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GUriHandle>))] MentorLake.GLib.GUriHandle uri2);

	[DllImport(SoupLibrary.Name)]
	internal static extern void soup_websocket_client_prepare_handshake([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, string origin, string[] protocols, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle supported_extensions);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_websocket_client_verify_handshake([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupMessageHandle>))] MentorLake.Soup.SoupMessageHandle msg, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle supported_extensions, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] out MentorLake.GLib.GListHandle accepted_extensions, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark soup_websocket_error_quark();

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_websocket_server_check_handshake([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg, string origin, string[] protocols, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle supported_extensions, out MentorLake.GLib.GErrorHandle error);

	[DllImport(SoupLibrary.Name)]
	internal static extern bool soup_websocket_server_process_handshake([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Soup.SoupServerMessageHandle>))] MentorLake.Soup.SoupServerMessageHandle msg, string expected_origin, string[] protocols, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))] MentorLake.GLib.GPtrArrayHandle supported_extensions, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] out MentorLake.GLib.GListHandle accepted_extensions);

}
