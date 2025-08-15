namespace MentorLake.GLib;

/// <summary>
/// <para>
/// `GKeyFile` parses .ini-like config files.
/// </para>
/// <para>
/// `GKeyFile` lets you parse, edit or create files containing groups of
/// key-value pairs, which we call &quot;key files&quot; for lack of a better name.
/// Several freedesktop.org specifications use key files now, e.g the
/// [Desktop Entry Specification](http://freedesktop.org/Standards/desktop-entry-spec)
/// and the [Icon Theme Specification](http://freedesktop.org/Standards/icon-theme-spec).
/// </para>
/// <para>
/// The syntax of key files is described in detail in the
/// [Desktop Entry Specification](http://freedesktop.org/Standards/desktop-entry-spec),
/// here is a quick summary: Key files consists of groups of key-value pairs, interspersed
/// with comments.
/// </para>
/// <para>
/// ```txt
/// # this is just an example
/// # there can be comments before the first group
/// </para>
/// <para>
/// [First Group]
/// </para>
/// <para>
/// Name=Key File Example\tthis value shows\nescaping
/// </para>
/// <para>
/// # localized strings are stored in multiple key-value pairs
/// Welcome=Hello
/// Welcome[de]=Hallo
/// Welcome[fr_FR]=Bonjour
/// Welcome[it]=Ciao
/// </para>
/// <para>
/// [Another Group]
/// </para>
/// <para>
/// Numbers=2;20;-200;0
/// </para>
/// <para>
/// Booleans=true;false;true;true
/// ```
/// </para>
/// <para>
/// Lines beginning with a &apos;#&apos; and blank lines are considered comments.
/// </para>
/// <para>
/// Groups are started by a header line containing the group name enclosed
/// in &apos;[&apos; and &apos;]&apos;, and ended implicitly by the start of the next group or
/// the end of the file. Each key-value pair must be contained in a group.
/// </para>
/// <para>
/// Key-value pairs generally have the form `key=value`, with the exception
/// of localized strings, which have the form `key[locale]=value`, with a
/// locale identifier of the form `lang_COUNTRY@MODIFIER` where `COUNTRY`
/// and `MODIFIER` are optional. Space before and after the &apos;=&apos; character
/// are ignored. Newline, tab, carriage return and backslash characters in
/// value are escaped as `\n`, `\t`, `\r`, and `\\\\`, respectively. To preserve
/// leading spaces in values, these can also be escaped as `\s`.
/// </para>
/// <para>
/// Key files can store strings (possibly with localized variants), integers,
/// booleans and lists of these. Lists are separated by a separator character,
/// typically &apos;;&apos; or &apos;,&apos;. To use the list separator character in a value in
/// a list, it has to be escaped by prefixing it with a backslash.
/// </para>
/// <para>
/// This syntax is obviously inspired by the .ini files commonly met
/// on Windows, but there are some important differences:
/// </para>
/// <para>
/// - .ini files use the &apos;;&apos; character to begin comments,
///   key files use the &apos;#&apos; character.
/// </para>
/// <para>
/// - Key files do not allow for ungrouped keys meaning only
///   comments can precede the first group.
/// </para>
/// <para>
/// - Key files are always encoded in UTF-8.
/// </para>
/// <para>
/// - Key and Group names are case-sensitive. For example, a group called
///   [GROUP] is a different from [group].
/// </para>
/// <para>
/// - .ini files don&apos;t have a strongly typed boolean entry type,
///    they only have GetProfileInt(). In key files, only
///    true and false (in lower case) are allowed.
/// </para>
/// <para>
/// Note that in contrast to the
/// [Desktop Entry Specification](http://freedesktop.org/Standards/desktop-entry-spec),
/// groups in key files may contain the same key multiple times; the last entry wins.
/// Key files may also contain multiple groups with the same name; they are merged
/// together. Another difference is that keys and group names in key files are not
/// restricted to ASCII characters.
/// </para>
/// <para>
/// Here is an example of loading a key file and reading a value:
/// </para>
/// <para>
/// ```c
/// g_autoptr(GError) error = NULL;
/// g_autoptr(GKeyFile) key_file = g_key_file_new ();
/// </para>
/// <para>
/// if (!g_key_file_load_from_file (key_file, &quot;key-file.ini&quot;, flags, &amp;error))
///   {
///     if (!g_error_matches (error, G_FILE_ERROR, G_FILE_ERROR_NOENT))
///       g_warning (&quot;Error loading key file: %s&quot;, error-&amp;gt;message);
///     return;
///   }
/// </para>
/// <para>
/// g_autofree gchar *val = g_key_file_get_string (key_file, &quot;Group Name&quot;, &quot;SomeKey&quot;, &amp;error);
/// if (val == NULL &amp;&amp;
///     !g_error_matches (error, G_KEY_FILE_ERROR, G_KEY_FILE_ERROR_KEY_NOT_FOUND))
///   {
///     g_warning (&quot;Error finding key in key file: %s&quot;, error-&amp;gt;message);
///     return;
///   }
/// else if (val == NULL)
///   {
///     // Fall back to a default value.
///     val = g_strdup (&quot;default-value&quot;);
///   }
/// ```
/// </para>
/// <para>
/// Here is an example of creating and saving a key file:
/// </para>
/// <para>
/// ```c
/// g_autoptr(GKeyFile) key_file = g_key_file_new ();
/// const gchar *val = …;
/// g_autoptr(GError) error = NULL;
/// </para>
/// <para>
/// g_key_file_set_string (key_file, &quot;Group Name&quot;, &quot;SomeKey&quot;, val);
/// </para>
/// <para>
/// // Save as a file.
/// if (!g_key_file_save_to_file (key_file, &quot;key-file.ini&quot;, &amp;error))
///   {
///     g_warning (&quot;Error saving key file: %s&quot;, error-&amp;gt;message);
///     return;
///   }
/// </para>
/// <para>
/// // Or store to a GBytes for use elsewhere.
/// gsize data_len;
/// g_autofree guint8 *data = (guint8 *) g_key_file_to_data (key_file, &amp;data_len, &amp;error);
/// if (data == NULL)
///   {
///     g_warning (&quot;Error saving key file: %s&quot;, error-&amp;gt;message);
///     return;
///   }
/// g_autoptr(GBytes) bytes = g_bytes_new_take (g_steal_pointer (&amp;data), data_len);
/// ```
/// </para>
/// </summary>

public class GKeyFileHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new empty #GKeyFile object. Use
/// g_key_file_load_from_file(), g_key_file_load_from_data(),
/// g_key_file_load_from_dirs() or g_key_file_load_from_data_dirs() to
/// read an existing key file.
/// </para>
/// </summary>

/// <return>
/// an empty #GKeyFile.
/// </return>

	public static MentorLake.GLib.GKeyFileHandle New()
	{
		return GKeyFileExterns.g_key_file_new();
	}

}


public static class GKeyFileExtensions
{
/// <summary>
/// <para>
/// Clears all keys and groups from @key_file, and decreases the
/// reference count by 1. If the reference count reaches zero,
/// frees the key file and all its allocated memory.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>

	public static void Free(this MentorLake.GLib.GKeyFileHandle key_file)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		GKeyFileExterns.g_key_file_free(key_file);
	}

/// <summary>
/// <para>
/// Returns the value associated with @key under @group_name as a
/// boolean.
/// </para>
/// <para>
/// If @key cannot be found then %FALSE is returned and @error is set
/// to %G_KEY_FILE_ERROR_KEY_NOT_FOUND. Likewise, if the value
/// associated with @key cannot be interpreted as a boolean then %FALSE
/// is returned and @error is set to %G_KEY_FILE_ERROR_INVALID_VALUE.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <return>
/// the value associated with the key as a boolean,
///    or %FALSE if the key was not found or could not be parsed.
/// </return>

	public static bool GetBoolean(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_get_boolean(key_file, group_name, key, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns the values associated with @key under @group_name as
/// booleans.
/// </para>
/// <para>
/// If @key cannot be found then %NULL is returned and @error is set to
/// %G_KEY_FILE_ERROR_KEY_NOT_FOUND. Likewise, if the values associated
/// with @key cannot be interpreted as booleans then %NULL is returned
/// and @error is set to %G_KEY_FILE_ERROR_INVALID_VALUE.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="length">
/// the number of booleans returned
/// </param>
/// <return>
/// 
///    the values associated with the key as a list of booleans, or %NULL if the
///    key was not found or could not be parsed. The returned list of booleans
///    should be freed with g_free() when no longer needed.
/// </return>

	public static bool[] GetBooleanList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out UIntPtr length)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_get_boolean_list(key_file, group_name, key, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Retrieves a comment above @key from @group_name.
/// If @key is %NULL then @comment will be read from above
/// @group_name. If both @key and @group_name are %NULL, then
/// @comment will be read from above the first group in the file.
/// </para>
/// <para>
/// Note that the returned string does not include the &apos;#&apos; comment markers,
/// but does include any whitespace after them (on each line). It includes
/// the line breaks between lines, but does not include the final line break.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name, or %NULL
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <return>
/// a comment that should be freed with g_free()
/// </return>

	public static string GetComment(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_get_comment(key_file, group_name, key, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns the value associated with @key under @group_name as a
/// double. If @group_name is %NULL, the start_group is used.
/// </para>
/// <para>
/// If @key cannot be found then 0.0 is returned and @error is set to
/// %G_KEY_FILE_ERROR_KEY_NOT_FOUND. Likewise, if the value associated
/// with @key cannot be interpreted as a double then 0.0 is returned
/// and @error is set to %G_KEY_FILE_ERROR_INVALID_VALUE.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <return>
/// the value associated with the key as a double, or
///     0.0 if the key was not found or could not be parsed.
/// </return>

	public static double GetDouble(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_get_double(key_file, group_name, key, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns the values associated with @key under @group_name as
/// doubles.
/// </para>
/// <para>
/// If @key cannot be found then %NULL is returned and @error is set to
/// %G_KEY_FILE_ERROR_KEY_NOT_FOUND. Likewise, if the values associated
/// with @key cannot be interpreted as doubles then %NULL is returned
/// and @error is set to %G_KEY_FILE_ERROR_INVALID_VALUE.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="length">
/// the number of doubles returned
/// </param>
/// <return>
/// 
///     the values associated with the key as a list of doubles, or %NULL if the
///     key was not found or could not be parsed. The returned list of doubles
///     should be freed with g_free() when no longer needed.
/// </return>

	public static double[] GetDoubleList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out UIntPtr length)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_get_double_list(key_file, group_name, key, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns all groups in the key file loaded with @key_file.
/// The array of returned groups will be %NULL-terminated, so
/// @length may optionally be %NULL.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="length">
/// return location for the number of returned groups, or %NULL
/// </param>
/// <return>
/// a newly-allocated %NULL-terminated array of strings.
///   Use g_strfreev() to free it.
/// </return>

	public static string[] GetGroups(this MentorLake.GLib.GKeyFileHandle key_file, out UIntPtr length)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		return GKeyFileExterns.g_key_file_get_groups(key_file, out length);
	}

/// <summary>
/// <para>
/// Returns the value associated with @key under @group_name as a signed
/// 64-bit integer. This is similar to g_key_file_get_integer() but can return
/// 64-bit results without truncation.
/// </para>
/// </summary>

/// <param name="key_file">
/// a non-%NULL #GKeyFile
/// </param>
/// <param name="group_name">
/// a non-%NULL group name
/// </param>
/// <param name="key">
/// a non-%NULL key
/// </param>
/// <return>
/// the value associated with the key as a signed 64-bit integer, or
/// 0 if the key was not found or could not be parsed.
/// </return>

	public static long GetInt64(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_get_int64(key_file, group_name, key, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns the value associated with @key under @group_name as an
/// integer.
/// </para>
/// <para>
/// If @key cannot be found then 0 is returned and @error is set to
/// %G_KEY_FILE_ERROR_KEY_NOT_FOUND. Likewise, if the value associated
/// with @key cannot be interpreted as an integer, or is out of range
/// for a #gint, then 0 is returned
/// and @error is set to %G_KEY_FILE_ERROR_INVALID_VALUE.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <return>
/// the value associated with the key as an integer, or
///     0 if the key was not found or could not be parsed.
/// </return>

	public static int GetInteger(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_get_integer(key_file, group_name, key, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns the values associated with @key under @group_name as
/// integers.
/// </para>
/// <para>
/// If @key cannot be found then %NULL is returned and @error is set to
/// %G_KEY_FILE_ERROR_KEY_NOT_FOUND. Likewise, if the values associated
/// with @key cannot be interpreted as integers, or are out of range for
/// #gint, then %NULL is returned
/// and @error is set to %G_KEY_FILE_ERROR_INVALID_VALUE.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="length">
/// the number of integers returned
/// </param>
/// <return>
/// 
///     the values associated with the key as a list of integers, or %NULL if
///     the key was not found or could not be parsed. The returned list of
///     integers should be freed with g_free() when no longer needed.
/// </return>

	public static int[] GetIntegerList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out UIntPtr length)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_get_integer_list(key_file, group_name, key, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns all keys for the group name @group_name.  The array of
/// returned keys will be %NULL-terminated, so @length may
/// optionally be %NULL. In the event that the @group_name cannot
/// be found, %NULL is returned and @error is set to
/// %G_KEY_FILE_ERROR_GROUP_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="length">
/// return location for the number of keys returned, or %NULL
/// </param>
/// <return>
/// a newly-allocated %NULL-terminated array of strings.
///     Use g_strfreev() to free it.
/// </return>

	public static string[] GetKeys(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, out UIntPtr length)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_get_keys(key_file, group_name, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns the actual locale which the result of
/// g_key_file_get_locale_string() or g_key_file_get_locale_string_list()
/// came from.
/// </para>
/// <para>
/// If calling g_key_file_get_locale_string() or
/// g_key_file_get_locale_string_list() with exactly the same @key_file,
/// @group_name, @key and @locale, the result of those functions will
/// have originally been tagged with the locale that is the result of
/// this function.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="locale">
/// a locale identifier or %NULL
/// </param>
/// <return>
/// the locale from the file, or %NULL if the key was not
///   found or the entry in the file was was untranslated
/// </return>

	public static string GetLocaleForKey(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		return GKeyFileExterns.g_key_file_get_locale_for_key(key_file, group_name, key, locale);
	}

/// <summary>
/// <para>
/// Returns the value associated with @key under @group_name
/// translated in the given @locale if available.  If @locale is
/// %NULL then the current locale is assumed.
/// </para>
/// <para>
/// If @locale is to be non-%NULL, or if the current locale will change over
/// the lifetime of the #GKeyFile, it must be loaded with
/// %G_KEY_FILE_KEEP_TRANSLATIONS in order to load strings for all locales.
/// </para>
/// <para>
/// If @key cannot be found then %NULL is returned and @error is set
/// to %G_KEY_FILE_ERROR_KEY_NOT_FOUND. If the value associated
/// with @key cannot be interpreted or no suitable translation can
/// be found then the untranslated value is returned.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="locale">
/// a locale identifier or %NULL
/// </param>
/// <return>
/// a newly allocated string or %NULL if the specified
///   key cannot be found.
/// </return>

	public static string GetLocaleString(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_get_locale_string(key_file, group_name, key, locale, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns the values associated with @key under @group_name
/// translated in the given @locale if available.  If @locale is
/// %NULL then the current locale is assumed.
/// </para>
/// <para>
/// If @locale is to be non-%NULL, or if the current locale will change over
/// the lifetime of the #GKeyFile, it must be loaded with
/// %G_KEY_FILE_KEEP_TRANSLATIONS in order to load strings for all locales.
/// </para>
/// <para>
/// If @key cannot be found then %NULL is returned and @error is set
/// to %G_KEY_FILE_ERROR_KEY_NOT_FOUND. If the values associated
/// with @key cannot be interpreted or no suitable translations
/// can be found then the untranslated values are returned. The
/// returned array is %NULL-terminated, so @length may optionally
/// be %NULL.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="locale">
/// a locale identifier or %NULL
/// </param>
/// <param name="length">
/// return location for the number of returned strings or %NULL
/// </param>
/// <return>
/// a newly allocated %NULL-terminated string array
///   or %NULL if the key isn&apos;t found. The string array should be freed
///   with g_strfreev().
/// </return>

	public static string[] GetLocaleStringList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale, out UIntPtr length)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_get_locale_string_list(key_file, group_name, key, locale, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns the name of the start group of the file.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <return>
/// The start group of the key file.
/// </return>

	public static string GetStartGroup(this MentorLake.GLib.GKeyFileHandle key_file)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		return GKeyFileExterns.g_key_file_get_start_group(key_file);
	}

/// <summary>
/// <para>
/// Returns the string value associated with @key under @group_name.
/// Unlike g_key_file_get_value(), this function handles escape sequences
/// like \s.
/// </para>
/// <para>
/// In the event the key cannot be found, %NULL is returned and
/// @error is set to %G_KEY_FILE_ERROR_KEY_NOT_FOUND.  In the
/// event that the @group_name cannot be found, %NULL is returned
/// and @error is set to %G_KEY_FILE_ERROR_GROUP_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <return>
/// a newly allocated string or %NULL if the specified
///   key cannot be found.
/// </return>

	public static string GetString(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_get_string(key_file, group_name, key, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns the values associated with @key under @group_name.
/// </para>
/// <para>
/// In the event the key cannot be found, %NULL is returned and
/// @error is set to %G_KEY_FILE_ERROR_KEY_NOT_FOUND.  In the
/// event that the @group_name cannot be found, %NULL is returned
/// and @error is set to %G_KEY_FILE_ERROR_GROUP_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="length">
/// return location for the number of returned strings, or %NULL
/// </param>
/// <return>
/// 
///  a %NULL-terminated string array or %NULL if the specified
///  key cannot be found. The array should be freed with g_strfreev().
/// </return>

	public static string[] GetStringList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out UIntPtr length)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_get_string_list(key_file, group_name, key, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns the value associated with @key under @group_name as an unsigned
/// 64-bit integer. This is similar to g_key_file_get_integer() but can return
/// large positive results without truncation.
/// </para>
/// </summary>

/// <param name="key_file">
/// a non-%NULL #GKeyFile
/// </param>
/// <param name="group_name">
/// a non-%NULL group name
/// </param>
/// <param name="key">
/// a non-%NULL key
/// </param>
/// <return>
/// the value associated with the key as an unsigned 64-bit integer,
/// or 0 if the key was not found or could not be parsed.
/// </return>

	public static ulong GetUint64(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_get_uint64(key_file, group_name, key, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Returns the raw value associated with @key under @group_name.
/// Use g_key_file_get_string() to retrieve an unescaped UTF-8 string.
/// </para>
/// <para>
/// In the event the key cannot be found, %NULL is returned and
/// @error is set to %G_KEY_FILE_ERROR_KEY_NOT_FOUND.  In the
/// event that the @group_name cannot be found, %NULL is returned
/// and @error is set to %G_KEY_FILE_ERROR_GROUP_NOT_FOUND.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <return>
/// a newly allocated string or %NULL if the specified
///  key cannot be found.
/// </return>

	public static string GetValue(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_get_value(key_file, group_name, key, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Looks whether the key file has the group @group_name.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <return>
/// %TRUE if @group_name is a part of @key_file, %FALSE
/// otherwise.
/// </return>

	public static bool HasGroup(this MentorLake.GLib.GKeyFileHandle key_file, string group_name)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		return GKeyFileExterns.g_key_file_has_group(key_file, group_name);
	}

/// <summary>
/// <para>
/// Looks whether the key file has the key @key in the group
/// @group_name.
/// </para>
/// <para>
/// Note that this function does not follow the rules for #GError strictly;
/// the return value both carries meaning and signals an error.  To use
/// this function, you must pass a #GError pointer in @error, and check
/// whether it is not %NULL to see if an error occurred.
/// </para>
/// <para>
/// Language bindings should use g_key_file_get_value() to test whether
/// or not a key exists.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key name
/// </param>
/// <return>
/// %TRUE if @key is a part of @group_name, %FALSE otherwise
/// </return>

	public static bool HasKey(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_has_key(key_file, group_name, key, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Loads a key file from the data in @bytes into an empty #GKeyFile structure.
/// If the object cannot be created then %error is set to a #GKeyFileError.
/// </para>
/// </summary>

/// <param name="key_file">
/// an empty #GKeyFile struct
/// </param>
/// <param name="bytes">
/// a #GBytes
/// </param>
/// <param name="flags">
/// flags from #GKeyFileFlags
/// </param>
/// <return>
/// %TRUE if a key file could be loaded, %FALSE otherwise
/// </return>

	public static bool LoadFromBytes(this MentorLake.GLib.GKeyFileHandle key_file, MentorLake.GLib.GBytesHandle bytes, MentorLake.GLib.GKeyFileFlags flags)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_load_from_bytes(key_file, bytes, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Loads a key file from memory into an empty #GKeyFile structure.
/// If the object cannot be created then %error is set to a #GKeyFileError.
/// </para>
/// </summary>

/// <param name="key_file">
/// an empty #GKeyFile struct
/// </param>
/// <param name="data">
/// key file loaded in memory
/// </param>
/// <param name="length">
/// the length of @data in bytes (or (gsize)-1 if data is nul-terminated)
/// </param>
/// <param name="flags">
/// flags from #GKeyFileFlags
/// </param>
/// <return>
/// %TRUE if a key file could be loaded, %FALSE otherwise
/// </return>

	public static bool LoadFromData(this MentorLake.GLib.GKeyFileHandle key_file, string data, UIntPtr length, MentorLake.GLib.GKeyFileFlags flags)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_load_from_data(key_file, data, length, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This function looks for a key file named @file in the paths
/// returned from g_get_user_data_dir() and g_get_system_data_dirs(),
/// loads the file into @key_file and returns the file&apos;s full path in
/// @full_path.  If the file could not be loaded then an %error is
/// set to either a #GFileError or #GKeyFileError.
/// </para>
/// </summary>

/// <param name="key_file">
/// an empty #GKeyFile struct
/// </param>
/// <param name="file">
/// a relative path to a filename to open and parse
/// </param>
/// <param name="full_path">
/// return location for a string containing the full path
///   of the file, or %NULL
/// </param>
/// <param name="flags">
/// flags from #GKeyFileFlags
/// </param>
/// <return>
/// %TRUE if a key file could be loaded, %FALSE otherwise
/// </return>

	public static bool LoadFromDataDirs(this MentorLake.GLib.GKeyFileHandle key_file, string file, out string full_path, MentorLake.GLib.GKeyFileFlags flags)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_load_from_data_dirs(key_file, file, out full_path, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// This function looks for a key file named @file in the paths
/// specified in @search_dirs, loads the file into @key_file and
/// returns the file&apos;s full path in @full_path.
/// </para>
/// <para>
/// If the file could not be found in any of the @search_dirs,
/// %G_KEY_FILE_ERROR_NOT_FOUND is returned. If
/// the file is found but the OS returns an error when opening or reading the
/// file, a %G_FILE_ERROR is returned. If there is a problem parsing the file, a
/// %G_KEY_FILE_ERROR is returned.
/// </para>
/// </summary>

/// <param name="key_file">
/// an empty #GKeyFile struct
/// </param>
/// <param name="file">
/// a relative path to a filename to open and parse
/// </param>
/// <param name="search_dirs">
/// %NULL-terminated array of directories to search
/// </param>
/// <param name="full_path">
/// return location for a string containing the full path
///   of the file, or %NULL
/// </param>
/// <param name="flags">
/// flags from #GKeyFileFlags
/// </param>
/// <return>
/// %TRUE if a key file could be loaded, %FALSE otherwise
/// </return>

	public static bool LoadFromDirs(this MentorLake.GLib.GKeyFileHandle key_file, string file, string[] search_dirs, out string full_path, MentorLake.GLib.GKeyFileFlags flags)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_load_from_dirs(key_file, file, search_dirs, out full_path, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Loads a key file into an empty #GKeyFile structure.
/// </para>
/// <para>
/// If the OS returns an error when opening or reading the file, a
/// %G_FILE_ERROR is returned. If there is a problem parsing the file, a
/// %G_KEY_FILE_ERROR is returned.
/// </para>
/// <para>
/// This function will never return a %G_KEY_FILE_ERROR_NOT_FOUND error. If the
/// @file is not found, %G_FILE_ERROR_NOENT is returned.
/// </para>
/// </summary>

/// <param name="key_file">
/// an empty #GKeyFile struct
/// </param>
/// <param name="file">
/// the path of a filename to load, in the GLib filename encoding
/// </param>
/// <param name="flags">
/// flags from #GKeyFileFlags
/// </param>
/// <return>
/// %TRUE if a key file could be loaded, %FALSE otherwise
/// </return>

	public static bool LoadFromFile(this MentorLake.GLib.GKeyFileHandle key_file, string file, MentorLake.GLib.GKeyFileFlags flags)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_load_from_file(key_file, file, flags, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Increases the reference count of @key_file.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <return>
/// the same @key_file.
/// </return>

	public static MentorLake.GLib.GKeyFileHandle Ref(this MentorLake.GLib.GKeyFileHandle key_file)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		return GKeyFileExterns.g_key_file_ref(key_file);
	}

/// <summary>
/// <para>
/// Removes a comment above @key from @group_name.
/// If @key is %NULL then @comment will be removed above @group_name.
/// If both @key and @group_name are %NULL, then @comment will
/// be removed above the first group in the file.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name, or %NULL
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <return>
/// %TRUE if the comment was removed, %FALSE otherwise
/// </return>

	public static bool RemoveComment(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_remove_comment(key_file, group_name, key, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Removes the specified group, @group_name,
/// from the key file.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <return>
/// %TRUE if the group was removed, %FALSE otherwise
/// </return>

	public static bool RemoveGroup(this MentorLake.GLib.GKeyFileHandle key_file, string group_name)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_remove_group(key_file, group_name, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Removes @key in @group_name from the key file.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key name to remove
/// </param>
/// <return>
/// %TRUE if the key was removed, %FALSE otherwise
/// </return>

	public static bool RemoveKey(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_remove_key(key_file, group_name, key, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Writes the contents of @key_file to @filename using
/// g_file_set_contents(). If you need stricter guarantees about durability of
/// the written file than are provided by g_file_set_contents(), use
/// g_file_set_contents_full() with the return value of g_key_file_to_data().
/// </para>
/// <para>
/// This function can fail for any of the reasons that
/// g_file_set_contents() may fail.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="filename">
/// the name of the file to write to
/// </param>
/// <return>
/// %TRUE if successful, else %FALSE with @error set
/// </return>

	public static bool SaveToFile(this MentorLake.GLib.GKeyFileHandle key_file, string filename)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_save_to_file(key_file, filename, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Associates a new boolean value with @key under @group_name.
/// If @key cannot be found then it is created.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="value">
/// %TRUE or %FALSE
/// </param>

	public static void SetBoolean(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, bool value)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		GKeyFileExterns.g_key_file_set_boolean(key_file, group_name, key, value);
	}

/// <summary>
/// <para>
/// Associates a list of boolean values with @key under @group_name.
/// If @key cannot be found then it is created.
/// If @group_name is %NULL, the start_group is used.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="list">
/// an array of boolean values
/// </param>
/// <param name="length">
/// length of @list
/// </param>

	public static void SetBooleanList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, bool[] list, UIntPtr length)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		GKeyFileExterns.g_key_file_set_boolean_list(key_file, group_name, key, list, length);
	}

/// <summary>
/// <para>
/// Places a comment above @key from @group_name.
/// </para>
/// <para>
/// If @key is %NULL then @comment will be written above @group_name.
/// If both @key and @group_name  are %NULL, then @comment will be
/// written above the first group in the file.
/// </para>
/// <para>
/// Note that this function prepends a &apos;#&apos; comment marker to
/// each line of @comment.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name, or %NULL
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="comment">
/// a comment
/// </param>
/// <return>
/// %TRUE if the comment was written, %FALSE otherwise
/// </return>

	public static bool SetComment(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string comment)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_set_comment(key_file, group_name, key, comment, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Associates a new double value with @key under @group_name.
/// If @key cannot be found then it is created.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="value">
/// a double value
/// </param>

	public static void SetDouble(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, double value)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		GKeyFileExterns.g_key_file_set_double(key_file, group_name, key, value);
	}

/// <summary>
/// <para>
/// Associates a list of double values with @key under
/// @group_name.  If @key cannot be found then it is created.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="list">
/// an array of double values
/// </param>
/// <param name="length">
/// number of double values in @list
/// </param>

	public static void SetDoubleList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, double[] list, UIntPtr length)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		GKeyFileExterns.g_key_file_set_double_list(key_file, group_name, key, list, length);
	}

/// <summary>
/// <para>
/// Associates a new integer value with @key under @group_name.
/// If @key cannot be found then it is created.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="value">
/// an integer value
/// </param>

	public static void SetInt64(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, long value)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		GKeyFileExterns.g_key_file_set_int64(key_file, group_name, key, value);
	}

/// <summary>
/// <para>
/// Associates a new integer value with @key under @group_name.
/// If @key cannot be found then it is created.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="value">
/// an integer value
/// </param>

	public static void SetInteger(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, int value)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		GKeyFileExterns.g_key_file_set_integer(key_file, group_name, key, value);
	}

/// <summary>
/// <para>
/// Associates a list of integer values with @key under @group_name.
/// If @key cannot be found then it is created.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="list">
/// an array of integer values
/// </param>
/// <param name="length">
/// number of integer values in @list
/// </param>

	public static void SetIntegerList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, int[] list, UIntPtr length)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		GKeyFileExterns.g_key_file_set_integer_list(key_file, group_name, key, list, length);
	}

/// <summary>
/// <para>
/// Sets the character which is used to separate
/// values in lists. Typically &apos;;&apos; or &apos;,&apos; are used
/// as separators. The default list separator is &apos;;&apos;.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="separator">
/// the separator
/// </param>

	public static void SetListSeparator(this MentorLake.GLib.GKeyFileHandle key_file, char separator)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		GKeyFileExterns.g_key_file_set_list_separator(key_file, separator);
	}

/// <summary>
/// <para>
/// Associates a string value for @key and @locale under @group_name.
/// If the translation for @key cannot be found then it is created.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="locale">
/// a locale identifier
/// </param>
/// <param name="@string">
/// a string
/// </param>

	public static void SetLocaleString(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale, string @string)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		GKeyFileExterns.g_key_file_set_locale_string(key_file, group_name, key, locale, @string);
	}

/// <summary>
/// <para>
/// Associates a list of string values for @key and @locale under
/// @group_name.  If the translation for @key cannot be found then
/// it is created.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="locale">
/// a locale identifier
/// </param>
/// <param name="list">
/// a %NULL-terminated array of locale string values
/// </param>
/// <param name="length">
/// the length of @list
/// </param>

	public static void SetLocaleStringList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale, string[] list, UIntPtr length)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		GKeyFileExterns.g_key_file_set_locale_string_list(key_file, group_name, key, locale, list, length);
	}

/// <summary>
/// <para>
/// Associates a new string value with @key under @group_name.
/// If @key cannot be found then it is created.
/// If @group_name cannot be found then it is created.
/// Unlike g_key_file_set_value(), this function handles characters
/// that need escaping, such as newlines.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="@string">
/// a string
/// </param>

	public static void SetString(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string @string)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		GKeyFileExterns.g_key_file_set_string(key_file, group_name, key, @string);
	}

/// <summary>
/// <para>
/// Associates a list of string values for @key under @group_name.
/// If @key cannot be found then it is created.
/// If @group_name cannot be found then it is created.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="list">
/// an array of string values
/// </param>
/// <param name="length">
/// number of string values in @list
/// </param>

	public static void SetStringList(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string[] list, UIntPtr length)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		GKeyFileExterns.g_key_file_set_string_list(key_file, group_name, key, list, length);
	}

/// <summary>
/// <para>
/// Associates a new integer value with @key under @group_name.
/// If @key cannot be found then it is created.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="value">
/// an integer value
/// </param>

	public static void SetUint64(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, ulong value)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		GKeyFileExterns.g_key_file_set_uint64(key_file, group_name, key, value);
	}

/// <summary>
/// <para>
/// Associates a new value with @key under @group_name.
/// </para>
/// <para>
/// If @key cannot be found then it is created. If @group_name cannot
/// be found then it is created. To set an UTF-8 string which may contain
/// characters that need escaping (such as newlines or spaces), use
/// g_key_file_set_string().
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="group_name">
/// a group name
/// </param>
/// <param name="key">
/// a key
/// </param>
/// <param name="value">
/// a string
/// </param>

	public static void SetValue(this MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string value)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		GKeyFileExterns.g_key_file_set_value(key_file, group_name, key, value);
	}

/// <summary>
/// <para>
/// This function outputs @key_file as a string.
/// </para>
/// <para>
/// Note that this function never reports an error,
/// so it is safe to pass %NULL as @error.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>
/// <param name="length">
/// return location for the length of the
///   returned string, or %NULL
/// </param>
/// <return>
/// a newly allocated string holding
///   the contents of the #GKeyFile
/// </return>

	public static string ToData(this MentorLake.GLib.GKeyFileHandle key_file, out UIntPtr length)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		var externCallResult = GKeyFileExterns.g_key_file_to_data(key_file, out length, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

/// <summary>
/// <para>
/// Decreases the reference count of @key_file by 1. If the reference count
/// reaches zero, frees the key file and all its allocated memory.
/// </para>
/// </summary>

/// <param name="key_file">
/// a #GKeyFile
/// </param>

	public static void Unref(this MentorLake.GLib.GKeyFileHandle key_file)
	{
		if (key_file.IsInvalid) throw new Exception("Invalid handle (GKeyFile)");
		GKeyFileExterns.g_key_file_unref(key_file);
	}


	public static GKeyFile Dereference(this GKeyFileHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GKeyFile>(x.DangerousGetHandle());
}
internal class GKeyFileExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))]
	internal static extern MentorLake.GLib.GKeyFileHandle g_key_file_new();

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_get_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool[] g_key_file_get_boolean_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_key_file_get_comment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern double g_key_file_get_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern double[] g_key_file_get_double_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_key_file_get_groups([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, out UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern long g_key_file_get_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_key_file_get_integer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern int[] g_key_file_get_integer_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_key_file_get_keys([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_key_file_get_locale_for_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_key_file_get_locale_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_key_file_get_locale_string_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_key_file_get_start_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_key_file_get_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] g_key_file_get_string_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern ulong g_key_file_get_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_key_file_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_has_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_has_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_load_from_bytes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GBytesHandle>))] MentorLake.GLib.GBytesHandle bytes, MentorLake.GLib.GKeyFileFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_load_from_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string data, UIntPtr length, MentorLake.GLib.GKeyFileFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_load_from_data_dirs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string file, out string full_path, MentorLake.GLib.GKeyFileFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_load_from_dirs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string file, string[] search_dirs, out string full_path, MentorLake.GLib.GKeyFileFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_load_from_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string file, MentorLake.GLib.GKeyFileFlags flags, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))]
	internal static extern MentorLake.GLib.GKeyFileHandle g_key_file_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_remove_comment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_remove_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_remove_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_save_to_file([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string filename, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_boolean([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, bool value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_boolean_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, bool[] list, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_key_file_set_comment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string comment, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_double([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, double value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_double_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, double[] list, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_int64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, long value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_integer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, int value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_integer_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, int[] list, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_list_separator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, char separator);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_locale_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale, string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_locale_string_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string locale, string[] list, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string @string);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_string_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string[] list, UIntPtr length);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_uint64([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, ulong value);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, string group_name, string key, string value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_key_file_to_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file, out UIntPtr length, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_key_file_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GKeyFileHandle>))] MentorLake.GLib.GKeyFileHandle key_file);

	[DllImport(GLibLibrary.Name)]
	internal static extern MentorLake.GLib.GQuark g_key_file_error_quark();

}

/// <summary>
/// <para>
/// `GKeyFile` parses .ini-like config files.
/// </para>
/// <para>
/// `GKeyFile` lets you parse, edit or create files containing groups of
/// key-value pairs, which we call &quot;key files&quot; for lack of a better name.
/// Several freedesktop.org specifications use key files now, e.g the
/// [Desktop Entry Specification](http://freedesktop.org/Standards/desktop-entry-spec)
/// and the [Icon Theme Specification](http://freedesktop.org/Standards/icon-theme-spec).
/// </para>
/// <para>
/// The syntax of key files is described in detail in the
/// [Desktop Entry Specification](http://freedesktop.org/Standards/desktop-entry-spec),
/// here is a quick summary: Key files consists of groups of key-value pairs, interspersed
/// with comments.
/// </para>
/// <para>
/// ```txt
/// # this is just an example
/// # there can be comments before the first group
/// </para>
/// <para>
/// [First Group]
/// </para>
/// <para>
/// Name=Key File Example\tthis value shows\nescaping
/// </para>
/// <para>
/// # localized strings are stored in multiple key-value pairs
/// Welcome=Hello
/// Welcome[de]=Hallo
/// Welcome[fr_FR]=Bonjour
/// Welcome[it]=Ciao
/// </para>
/// <para>
/// [Another Group]
/// </para>
/// <para>
/// Numbers=2;20;-200;0
/// </para>
/// <para>
/// Booleans=true;false;true;true
/// ```
/// </para>
/// <para>
/// Lines beginning with a &apos;#&apos; and blank lines are considered comments.
/// </para>
/// <para>
/// Groups are started by a header line containing the group name enclosed
/// in &apos;[&apos; and &apos;]&apos;, and ended implicitly by the start of the next group or
/// the end of the file. Each key-value pair must be contained in a group.
/// </para>
/// <para>
/// Key-value pairs generally have the form `key=value`, with the exception
/// of localized strings, which have the form `key[locale]=value`, with a
/// locale identifier of the form `lang_COUNTRY@MODIFIER` where `COUNTRY`
/// and `MODIFIER` are optional. Space before and after the &apos;=&apos; character
/// are ignored. Newline, tab, carriage return and backslash characters in
/// value are escaped as `\n`, `\t`, `\r`, and `\\\\`, respectively. To preserve
/// leading spaces in values, these can also be escaped as `\s`.
/// </para>
/// <para>
/// Key files can store strings (possibly with localized variants), integers,
/// booleans and lists of these. Lists are separated by a separator character,
/// typically &apos;;&apos; or &apos;,&apos;. To use the list separator character in a value in
/// a list, it has to be escaped by prefixing it with a backslash.
/// </para>
/// <para>
/// This syntax is obviously inspired by the .ini files commonly met
/// on Windows, but there are some important differences:
/// </para>
/// <para>
/// - .ini files use the &apos;;&apos; character to begin comments,
///   key files use the &apos;#&apos; character.
/// </para>
/// <para>
/// - Key files do not allow for ungrouped keys meaning only
///   comments can precede the first group.
/// </para>
/// <para>
/// - Key files are always encoded in UTF-8.
/// </para>
/// <para>
/// - Key and Group names are case-sensitive. For example, a group called
///   [GROUP] is a different from [group].
/// </para>
/// <para>
/// - .ini files don&apos;t have a strongly typed boolean entry type,
///    they only have GetProfileInt(). In key files, only
///    true and false (in lower case) are allowed.
/// </para>
/// <para>
/// Note that in contrast to the
/// [Desktop Entry Specification](http://freedesktop.org/Standards/desktop-entry-spec),
/// groups in key files may contain the same key multiple times; the last entry wins.
/// Key files may also contain multiple groups with the same name; they are merged
/// together. Another difference is that keys and group names in key files are not
/// restricted to ASCII characters.
/// </para>
/// <para>
/// Here is an example of loading a key file and reading a value:
/// </para>
/// <para>
/// ```c
/// g_autoptr(GError) error = NULL;
/// g_autoptr(GKeyFile) key_file = g_key_file_new ();
/// </para>
/// <para>
/// if (!g_key_file_load_from_file (key_file, &quot;key-file.ini&quot;, flags, &amp;error))
///   {
///     if (!g_error_matches (error, G_FILE_ERROR, G_FILE_ERROR_NOENT))
///       g_warning (&quot;Error loading key file: %s&quot;, error-&amp;gt;message);
///     return;
///   }
/// </para>
/// <para>
/// g_autofree gchar *val = g_key_file_get_string (key_file, &quot;Group Name&quot;, &quot;SomeKey&quot;, &amp;error);
/// if (val == NULL &amp;&amp;
///     !g_error_matches (error, G_KEY_FILE_ERROR, G_KEY_FILE_ERROR_KEY_NOT_FOUND))
///   {
///     g_warning (&quot;Error finding key in key file: %s&quot;, error-&amp;gt;message);
///     return;
///   }
/// else if (val == NULL)
///   {
///     // Fall back to a default value.
///     val = g_strdup (&quot;default-value&quot;);
///   }
/// ```
/// </para>
/// <para>
/// Here is an example of creating and saving a key file:
/// </para>
/// <para>
/// ```c
/// g_autoptr(GKeyFile) key_file = g_key_file_new ();
/// const gchar *val = …;
/// g_autoptr(GError) error = NULL;
/// </para>
/// <para>
/// g_key_file_set_string (key_file, &quot;Group Name&quot;, &quot;SomeKey&quot;, val);
/// </para>
/// <para>
/// // Save as a file.
/// if (!g_key_file_save_to_file (key_file, &quot;key-file.ini&quot;, &amp;error))
///   {
///     g_warning (&quot;Error saving key file: %s&quot;, error-&amp;gt;message);
///     return;
///   }
/// </para>
/// <para>
/// // Or store to a GBytes for use elsewhere.
/// gsize data_len;
/// g_autofree guint8 *data = (guint8 *) g_key_file_to_data (key_file, &amp;data_len, &amp;error);
/// if (data == NULL)
///   {
///     g_warning (&quot;Error saving key file: %s&quot;, error-&amp;gt;message);
///     return;
///   }
/// g_autoptr(GBytes) bytes = g_bytes_new_take (g_steal_pointer (&amp;data), data_len);
/// ```
/// </para>
/// </summary>

public struct GKeyFile
{


	public static MentorLake.GLib.GQuark ErrorQuark()
	{
		return GKeyFileExterns.g_key_file_error_quark();
	}

}
