namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A type in the [type@GLib.Variant] type system.
/// </para>
/// <para>
/// This section introduces the [type@GLib.Variant] type system. It is based, in
/// large part, on the D-Bus type system, with two major changes and
/// some minor lifting of restrictions. The
/// [D-Bus specification](http://dbus.freedesktop.org/doc/dbus-specification.html),
/// therefore, provides a significant amount of
/// information that is useful when working with [type@GLib.Variant].
/// </para>
/// <para>
/// The first major change with respect to the D-Bus type system is the
/// introduction of maybe (or ‘nullable’) types.  Any type in [type@GLib.Variant]
/// can be converted to a maybe type, in which case, `nothing` (or `null`)
/// becomes a valid value.  Maybe types have been added by introducing the
/// character `m` to type strings.
/// </para>
/// <para>
/// The second major change is that the [type@GLib.Variant] type system supports
/// the concept of ‘indefinite types’ — types that are less specific than
/// the normal types found in D-Bus.  For example, it is possible to speak
/// of ‘an array of any type’ in [type@GLib.Variant], where the D-Bus type system
/// would require you to speak of ‘an array of integers’ or ‘an array of
/// strings’.  Indefinite types have been added by introducing the
/// characters `*`, `?` and `r` to type strings.
/// </para>
/// <para>
/// Finally, all arbitrary restrictions relating to the complexity of
/// types are lifted along with the restriction that dictionary entries
/// may only appear nested inside of arrays.
/// </para>
/// <para>
/// Just as in D-Bus, [type@GLib.Variant] types are described with strings (‘type
/// strings’).  Subject to the differences mentioned above, these strings
/// are of the same form as those found in D-Bus.  Note, however: D-Bus
/// always works in terms of messages and therefore individual type
/// strings appear nowhere in its interface.  Instead, ‘signatures’
/// are a concatenation of the strings of the type of each argument in a
/// message.  [type@GLib.Variant] deals with single values directly so
/// [type@GLib.Variant] type strings always describe the type of exactly one
/// value.  This means that a D-Bus signature string is generally not a valid
/// [type@GLib.Variant] type string — except in the case that it is the signature
/// of a message containing exactly one argument.
/// </para>
/// <para>
/// An indefinite type is similar in spirit to what may be called an
/// abstract type in other type systems.  No value can exist that has an
/// indefinite type as its type, but values can exist that have types
/// that are subtypes of indefinite types.  That is to say,
/// [method@GLib.Variant.get_type] will never return an indefinite type, but
/// calling [method@GLib.Variant.is_of_type] with an indefinite type may return
/// true.  For example, you cannot have a value that represents ‘an
/// array of no particular type’, but you can have an ‘array of integers’
/// which certainly matches the type of ‘an array of no particular type’,
/// since ‘array of integers’ is a subtype of ‘array of no particular
/// type’.
/// </para>
/// <para>
/// This is similar to how instances of abstract classes may not
/// directly exist in other type systems, but instances of their
/// non-abstract subtypes may.  For example, in GTK, no object that has
/// the type of &amp;lt;see href=&quot;https://docs.gtk.org/gtk4/class.Widget.html&quot;&amp;gt;GtkWidget&amp;lt;/see&amp;gt; can
/// exist (since `GtkWidget` is an abstract class), but a &amp;lt;see href=&quot;https://docs.gtk.org/gtk4/class.Window.html&quot;&amp;gt;GtkWindow&amp;lt;/see&amp;gt;
/// can certainly be instantiated, and you would say that a `GtkWindow` is a
/// `GtkWidget` (since `GtkWindow` is a subclass of `GtkWidget`).
/// </para>
/// <para>
/// Two types may not be compared by value; use [method@GLib.VariantType.equal]
/// or [method@GLib.VariantType.is_subtype_of]  May be copied using
/// [method@GLib.VariantType.copy] and freed using [method@GLib.VariantType.free].
/// </para>
/// <para>
/// ## GVariant Type Strings
/// </para>
/// <para>
/// A [type@GLib.Variant] type string can be any of the following:
/// </para>
/// <para>
/// - any basic type string (listed below)
/// - `v`, `r` or `*`
/// - one of the characters `a` or `m`, followed by another type string
/// - the character `(`, followed by a concatenation of zero or more other
///   type strings, followed by the character `)`
/// - the character `{`, followed by a basic type string (see below),
///   followed by another type string, followed by the character `}`
/// </para>
/// <para>
/// A basic type string describes a basic type (as per
/// [method@GLib.VariantType.is_basic]) and is always a single character in
/// length. The valid basic type strings are `b`, `y`, `n`, `q`, `i`, `u`, `x`,
/// `t`, `h`, `d`, `s`, `o`, `g` and `?`.
/// </para>
/// <para>
/// The above definition is recursive to arbitrary depth. `aaaaai` and
/// `(ui(nq((y)))s)` are both valid type strings, as is
/// `a(aa(ui)(qna{ya(yd)}))`. In order to not hit memory limits,
/// [type@GLib.Variant] imposes a limit on recursion depth of 65 nested
/// containers. This is the limit in the D-Bus specification (64) plus one to
/// allow a &amp;lt;see href=&quot;../gio/class.DBusMessage.html&quot;&amp;gt;GDBusMessage&amp;lt;/see&amp;gt; to be nested in
/// a top-level tuple.
/// </para>
/// <para>
/// The meaning of each of the characters is as follows:
/// </para>
/// <para>
/// - `b`: the type string of `G_VARIANT_TYPE_BOOLEAN`; a boolean value.
/// - `y`: the type string of `G_VARIANT_TYPE_BYTE`; a byte.
/// - `n`: the type string of `G_VARIANT_TYPE_INT16`; a signed 16 bit integer.
/// - `q`: the type string of `G_VARIANT_TYPE_UINT16`; an unsigned 16 bit integer.
/// - `i`: the type string of `G_VARIANT_TYPE_INT32`; a signed 32 bit integer.
/// - `u`: the type string of `G_VARIANT_TYPE_UINT32`; an unsigned 32 bit integer.
/// - `x`: the type string of `G_VARIANT_TYPE_INT64`; a signed 64 bit integer.
/// - `t`: the type string of `G_VARIANT_TYPE_UINT64`; an unsigned 64 bit integer.
/// - `h`: the type string of `G_VARIANT_TYPE_HANDLE`; a signed 32 bit value
///   that, by convention, is used as an index into an array of file
///   descriptors that are sent alongside a D-Bus message.
/// - `d`: the type string of `G_VARIANT_TYPE_DOUBLE`; a double precision
///   floating point value.
/// - `s`: the type string of `G_VARIANT_TYPE_STRING`; a string.
/// - `o`: the type string of `G_VARIANT_TYPE_OBJECT_PATH`; a string in the form
///   of a D-Bus object path.
/// - `g`: the type string of `G_VARIANT_TYPE_SIGNATURE`; a string in the form of
///   a D-Bus type signature.
/// - `?`: the type string of `G_VARIANT_TYPE_BASIC`; an indefinite type that
///   is a supertype of any of the basic types.
/// - `v`: the type string of `G_VARIANT_TYPE_VARIANT`; a container type that
///   contain any other type of value.
/// - `a`: used as a prefix on another type string to mean an array of that
///   type; the type string `ai`, for example, is the type of an array of
///   signed 32-bit integers.
/// - `m`: used as a prefix on another type string to mean a ‘maybe’, or
///   ‘nullable’, version of that type; the type string `ms`, for example,
///   is the type of a value that maybe contains a string, or maybe contains
///   nothing.
/// - `()`: used to enclose zero or more other concatenated type strings to
///   create a tuple type; the type string `(is)`, for example, is the type of
///   a pair of an integer and a string.
/// - `r`: the type string of `G_VARIANT_TYPE_TUPLE`; an indefinite type that is
///   a supertype of any tuple type, regardless of the number of items.
/// - `{}`: used to enclose a basic type string concatenated with another type
///   string to create a dictionary entry type, which usually appears inside of
///   an array to form a dictionary; the type string `a{sd}`, for example, is
///   the type of a dictionary that maps strings to double precision floating
///   point values.
/// </para>
/// <para>
///   The first type (the basic type) is the key type and the second type is
///   the value type. The reason that the first type is restricted to being a
///   basic type is so that it can easily be hashed.
/// - `*`: the type string of `G_VARIANT_TYPE_ANY`; the indefinite type that is
///   a supertype of all types.  Note that, as with all type strings, this
///   character represents exactly one type. It cannot be used inside of tuples
///   to mean ‘any number of items’.
/// </para>
/// <para>
/// Any type string of a container that contains an indefinite type is,
/// itself, an indefinite type. For example, the type string `a*`
/// (corresponding to `G_VARIANT_TYPE_ARRAY`) is an indefinite type
/// that is a supertype of every array type. `(*s)` is a supertype
/// of all tuples that contain exactly two items where the second
/// item is a string.
/// </para>
/// <para>
/// `a{?*}` is an indefinite type that is a supertype of all arrays
/// containing dictionary entries where the key is any basic type and
/// the value is any type at all.  This is, by definition, a dictionary,
/// so this type string corresponds to `G_VARIANT_TYPE_DICTIONARY`. Note
/// that, due to the restriction that the key of a dictionary entry must
/// be a basic type, `{**}` is not a valid type string.
/// </para>
/// </summary>

public class GVariantTypeHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new [type@GLib.VariantType] corresponding to the type string given
/// by @type_string.
/// </para>
/// <para>
/// It is appropriate to call [method@GLib.VariantType.free] on the return value.
/// </para>
/// <para>
/// It is a programmer error to call this function with an invalid type
/// string.  Use [func@GLib.VariantType.string_is_valid] if you are unsure.
/// </para>
/// </summary>

/// <param name="type_string">
/// a valid [GVariant type string](./struct.VariantType.html#gvariant-type-strings)
/// </param>
/// <return>
/// a new [type@GLib.VariantType]
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle New(string type_string)
	{
		return GVariantTypeExterns.g_variant_type_new(type_string);
	}

/// <summary>
/// <para>
/// Constructs the type corresponding to an array of elements of the
/// type @type.
/// </para>
/// <para>
/// It is appropriate to call [method@GLib.VariantType.first] on the return value.
/// </para>
/// </summary>

/// <param name="element">
/// an element type
/// </param>
/// <return>
/// a new array type
/// Since 2.24
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle NewArray(MentorLake.GLib.GVariantTypeHandle element)
	{
		return GVariantTypeExterns.g_variant_type_new_array(element);
	}

/// <summary>
/// <para>
/// Constructs the type corresponding to a dictionary entry with a key
/// of type @key and a value of type @value.
/// </para>
/// <para>
/// It is appropriate to call [method@GLib.VariantType.free] on the return value.
/// </para>
/// </summary>

/// <param name="key">
/// a basic type to use for the key
/// </param>
/// <param name="value">
/// a type to use for the value
/// </param>
/// <return>
/// a new dictionary entry type
/// Since 2.24
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle NewDictEntry(MentorLake.GLib.GVariantTypeHandle key, MentorLake.GLib.GVariantTypeHandle value)
	{
		return GVariantTypeExterns.g_variant_type_new_dict_entry(key, value);
	}

/// <summary>
/// <para>
/// Constructs the type corresponding to a ‘maybe’ instance containing
/// type @type or `Nothing`.
/// </para>
/// <para>
/// It is appropriate to call [method@GLib.VariantType.free] on the return value.
/// </para>
/// </summary>

/// <param name="element">
/// an element type
/// </param>
/// <return>
/// a new ‘maybe’ type
/// Since 2.24
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle NewMaybe(MentorLake.GLib.GVariantTypeHandle element)
	{
		return GVariantTypeExterns.g_variant_type_new_maybe(element);
	}

/// <summary>
/// <para>
/// Constructs a new tuple type, from @items.
/// </para>
/// <para>
/// @length is the number of items in @items, or `-1` to indicate that
/// @items is `NULL`-terminated.
/// </para>
/// <para>
/// It is appropriate to call [method@GLib.VariantType.free] on the return value.
/// </para>
/// </summary>

/// <param name="items">
/// an array of types, one for each item
/// </param>
/// <param name="length">
/// the length of @items, or `-1`
/// </param>
/// <return>
/// a new tuple type
/// Since 2.24
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle NewTuple(MentorLake.GLib.GVariantTypeHandle[] items, int length)
	{
		return GVariantTypeExterns.g_variant_type_new_tuple(items, length);
	}

}


public static class GVariantTypeExtensions
{
/// <summary>
/// <para>
/// Makes a copy of a [type@GLib.VariantType].
/// </para>
/// <para>
/// It is appropriate to call [method@GLib.VariantType.free] on the return value.
/// @type may not be `NULL`.
/// </para>
/// </summary>

/// <param name="type">
/// type to copy
/// </param>
/// <return>
/// a new [type@GLib.VariantType]
/// Since 2.24
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle Copy(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_copy(type);
	}

/// <summary>
/// <para>
/// Returns a newly-allocated copy of the type string corresponding to @type.
/// </para>
/// <para>
/// The returned string is nul-terminated.  It is appropriate to call
/// [func@GLib.free] on the return value.
/// </para>
/// </summary>

/// <param name="type">
/// type to copy
/// </param>
/// <return>
/// the corresponding type string
/// Since 2.24
/// </return>

	public static string DupString(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_dup_string(type);
	}

/// <summary>
/// <para>
/// Determines the element type of an array or ‘maybe’ type.
/// </para>
/// <para>
/// This function may only be used with array or ‘maybe’ types.
/// </para>
/// </summary>

/// <param name="type">
/// an array or ‘maybe’ type
/// </param>
/// <return>
/// the element type of @type
/// Since 2.24
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle Element(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_element(type);
	}

/// <summary>
/// <para>
/// Compares @type1 and @type2 for equality.
/// </para>
/// <para>
/// Only returns true if the types are exactly equal.  Even if one type
/// is an indefinite type and the other is a subtype of it, false will
/// be returned if they are not exactly equal.  If you want to check for
/// subtypes, use [method@GLib.VariantType.is_subtype_of].
/// </para>
/// <para>
/// The argument types of @type1 and @type2 are only `gconstpointer` to
/// allow use with [type@GLib.HashTable] without function pointer casting.  For
/// both arguments, a valid [type@GLib.VariantType] must be provided.
/// </para>
/// </summary>

/// <param name="type1">
/// type to compare
/// </param>
/// <param name="type2">
/// another type to compare
/// </param>
/// <return>
/// true if @type1 and @type2 are exactly equal
/// Since 2.24
/// </return>

	public static bool Equal(this MentorLake.GLib.GVariantTypeHandle type1, MentorLake.GLib.GVariantTypeHandle type2)
	{
		if (type1.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_equal(type1, type2);
	}

/// <summary>
/// <para>
/// Determines the first item type of a tuple or dictionary entry
/// type.
/// </para>
/// <para>
/// This function may only be used with tuple or dictionary entry types,
/// but must not be used with the generic tuple type
/// `G_VARIANT_TYPE_TUPLE`.
/// </para>
/// <para>
/// In the case of a dictionary entry type, this returns the type of
/// the key.
/// </para>
/// <para>
/// `NULL` is returned in case of @type being `G_VARIANT_TYPE_UNIT`.
/// </para>
/// <para>
/// This call, together with [method@GLib.VariantType.next] provides an iterator
/// interface over tuple and dictionary entry types.
/// </para>
/// </summary>

/// <param name="type">
/// a tuple or dictionary entry type
/// </param>
/// <return>
/// the first item type of @type, or `NULL`
///   if the type has no item types
/// Since 2.24
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle First(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_first(type);
	}

/// <summary>
/// <para>
/// Frees a [type@GLib.VariantType] that was allocated with
/// [method@GLib.VariantType.copy], [ctor@GLib.VariantType.new] or one of the
/// container type constructor functions.
/// </para>
/// <para>
/// In the case that @type is `NULL`, this function does nothing.
/// </para>
/// <para>
/// Since 2.24
/// </para>
/// </summary>

/// <param name="type">
/// type to free
/// </param>

	public static void Free(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		GVariantTypeExterns.g_variant_type_free(type);
	}

/// <summary>
/// <para>
/// Returns the length of the type string corresponding to the given @type.
/// </para>
/// <para>
/// This function must be used to determine the valid extent of
/// the memory region returned by [method@GLib.VariantType.peek_string].
/// </para>
/// </summary>

/// <param name="type">
/// type to measure
/// </param>
/// <return>
/// the length of the corresponding type string
/// Since 2.24
/// </return>

	public static UIntPtr GetStringLength(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_get_string_length(type);
	}

/// <summary>
/// <para>
/// Hashes @type.
/// </para>
/// <para>
/// The argument type of @type is only `gconstpointer` to allow use with
/// [type@GLib.HashTable] without function pointer casting.  A valid
/// [type@GLib.VariantType] must be provided.
/// </para>
/// </summary>

/// <param name="type">
/// type to hash
/// </param>
/// <return>
/// the hash value
/// Since 2.24
/// </return>

	public static uint Hash(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_hash(type);
	}

/// <summary>
/// <para>
/// Determines if the given @type is an array type.
/// </para>
/// <para>
/// This is true if the type string for @type starts with an `a`.
/// </para>
/// <para>
/// This function returns true for any indefinite type for which every
/// definite subtype is an array type — `G_VARIANT_TYPE_ARRAY`, for
/// example.
/// </para>
/// </summary>

/// <param name="type">
/// type to check
/// </param>
/// <return>
/// true if @type is an array type
/// Since 2.24
/// </return>

	public static bool IsArray(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_is_array(type);
	}

/// <summary>
/// <para>
/// Determines if the given @type is a basic type.
/// </para>
/// <para>
/// Basic types are booleans, bytes, integers, doubles, strings, object
/// paths and signatures.
/// </para>
/// <para>
/// Only a basic type may be used as the key of a dictionary entry.
/// </para>
/// <para>
/// This function returns `FALSE` for all indefinite types except
/// `G_VARIANT_TYPE_BASIC`.
/// </para>
/// </summary>

/// <param name="type">
/// type to check
/// </param>
/// <return>
/// true if @type is a basic type
/// Since 2.24
/// </return>

	public static bool IsBasic(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_is_basic(type);
	}

/// <summary>
/// <para>
/// Determines if the given @type is a container type.
/// </para>
/// <para>
/// Container types are any array, maybe, tuple, or dictionary
/// entry types plus the variant type.
/// </para>
/// <para>
/// This function returns true for any indefinite type for which every
/// definite subtype is a container — `G_VARIANT_TYPE_ARRAY`, for
/// example.
/// </para>
/// </summary>

/// <param name="type">
/// type to check
/// </param>
/// <return>
/// true if @type is a container type
/// Since 2.24
/// </return>

	public static bool IsContainer(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_is_container(type);
	}

/// <summary>
/// <para>
/// Determines if the given @type is definite (ie: not indefinite).
/// </para>
/// <para>
/// A type is definite if its type string does not contain any indefinite
/// type characters (`*`, `?`, or `r`).
/// </para>
/// <para>
/// A [type@GLib.Variant] instance may not have an indefinite type, so calling
/// this function on the result of [method@GLib.Variant.get_type] will always
/// result in true being returned.  Calling this function on an
/// indefinite type like `G_VARIANT_TYPE_ARRAY`, however, will result in
/// `FALSE` being returned.
/// </para>
/// </summary>

/// <param name="type">
/// type to check
/// </param>
/// <return>
/// true if @type is definite
/// Since 2.24
/// </return>

	public static bool IsDefinite(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_is_definite(type);
	}

/// <summary>
/// <para>
/// Determines if the given @type is a dictionary entry type.
/// </para>
/// <para>
/// This is true if the type string for @type starts with a `{`.
/// </para>
/// <para>
/// This function returns true for any indefinite type for which every
/// definite subtype is a dictionary entry type —
/// `G_VARIANT_TYPE_DICT_ENTRY`, for example.
/// </para>
/// </summary>

/// <param name="type">
/// type to check
/// </param>
/// <return>
/// true if @type is a dictionary entry type
/// Since 2.24
/// </return>

	public static bool IsDictEntry(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_is_dict_entry(type);
	}

/// <summary>
/// <para>
/// Determines if the given @type is a ‘maybe’ type.
/// </para>
/// <para>
/// This is true if the type string for @type starts with an `m`.
/// </para>
/// <para>
/// This function returns true for any indefinite type for which every
/// definite subtype is a ‘maybe’ type — `G_VARIANT_TYPE_MAYBE`, for
/// example.
/// </para>
/// </summary>

/// <param name="type">
/// type to check
/// </param>
/// <return>
/// true if @type is a ‘maybe’ type
/// Since 2.24
/// </return>

	public static bool IsMaybe(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_is_maybe(type);
	}

/// <summary>
/// <para>
/// Checks if @type is a subtype of @supertype.
/// </para>
/// <para>
/// This function returns true if @type is a subtype of @supertype.  All
/// types are considered to be subtypes of themselves.  Aside from that,
/// only indefinite types can have subtypes.
/// </para>
/// </summary>

/// <param name="type">
/// type to check
/// </param>
/// <param name="supertype">
/// type of potential supertype
/// </param>
/// <return>
/// true if @type is a subtype of @supertype
/// Since 2.24
/// </return>

	public static bool IsSubtypeOf(this MentorLake.GLib.GVariantTypeHandle type, MentorLake.GLib.GVariantTypeHandle supertype)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_is_subtype_of(type, supertype);
	}

/// <summary>
/// <para>
/// Determines if the given @type is a tuple type.
/// </para>
/// <para>
/// This is true if the type string for @type starts with a `(` or if @type is
/// `G_VARIANT_TYPE_TUPLE`.
/// </para>
/// <para>
/// This function returns true for any indefinite type for which every
/// definite subtype is a tuple type — `G_VARIANT_TYPE_TUPLE`, for
/// example.
/// </para>
/// </summary>

/// <param name="type">
/// type to check
/// </param>
/// <return>
/// true if @type is a tuple type
/// Since 2.24
/// </return>

	public static bool IsTuple(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_is_tuple(type);
	}

/// <summary>
/// <para>
/// Determines if the given @type is the variant type.
/// </para>
/// </summary>

/// <param name="type">
/// type to check
/// </param>
/// <return>
/// true if @type is the variant type
/// Since 2.24
/// </return>

	public static bool IsVariant(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_is_variant(type);
	}

/// <summary>
/// <para>
/// Determines the key type of a dictionary entry type.
/// </para>
/// <para>
/// This function may only be used with a dictionary entry type.  Other
/// than the additional restriction, this call is equivalent to
/// [method@GLib.VariantType.first].
/// </para>
/// </summary>

/// <param name="type">
/// a dictionary entry type
/// </param>
/// <return>
/// the key type of the dictionary entry
/// Since 2.24
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle Key(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_key(type);
	}

/// <summary>
/// <para>
/// Determines the number of items contained in a tuple or
/// dictionary entry type.
/// </para>
/// <para>
/// This function may only be used with tuple or dictionary entry types,
/// but must not be used with the generic tuple type
/// `G_VARIANT_TYPE_TUPLE`.
/// </para>
/// <para>
/// In the case of a dictionary entry type, this function will always
/// return `2`.
/// </para>
/// </summary>

/// <param name="type">
/// a tuple or dictionary entry type
/// </param>
/// <return>
/// the number of items in @type
/// Since 2.24
/// </return>

	public static UIntPtr NItems(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_n_items(type);
	}

/// <summary>
/// <para>
/// Determines the next item type of a tuple or dictionary entry
/// type.
/// </para>
/// <para>
/// @type must be the result of a previous call to
/// [method@GLib.VariantType.first] or [method@GLib.VariantType.next].
/// </para>
/// <para>
/// If called on the key type of a dictionary entry then this call
/// returns the value type.  If called on the value type of a dictionary
/// entry then this call returns `NULL`.
/// </para>
/// <para>
/// For tuples, `NULL` is returned when @type is the last item in the tuple.
/// </para>
/// </summary>

/// <param name="type">
/// a type from a previous call
/// </param>
/// <return>
/// the next type after @type, or `NULL` if
///   there are no further types
/// Since 2.24
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle Next(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_next(type);
	}

/// <summary>
/// <para>
/// Returns the type string corresponding to the given @type.
/// </para>
/// <para>
/// The result is not nul-terminated; in order to determine its length you
/// must call [method@GLib.VariantType.get_string_length].
/// </para>
/// <para>
/// To get a nul-terminated string, see [method@GLib.VariantType.dup_string].
/// </para>
/// </summary>

/// <param name="type">
/// type to peek at
/// </param>
/// <return>
/// the corresponding type string (not nul-terminated)
/// Since 2.24
/// </return>

	public static string PeekString(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_peek_string(type);
	}

/// <summary>
/// <para>
/// Determines the value type of a dictionary entry type.
/// </para>
/// <para>
/// This function may only be used with a dictionary entry type.
/// </para>
/// </summary>

/// <param name="type">
/// a dictionary entry type
/// </param>
/// <return>
/// the value type of the dictionary entry
/// Since 2.24
/// </return>

	public static MentorLake.GLib.GVariantTypeHandle Value(this MentorLake.GLib.GVariantTypeHandle type)
	{
		if (type.IsInvalid) throw new Exception("Invalid handle (GVariantType)");
		return GVariantTypeExterns.g_variant_type_value(type);
	}


	public static GVariantType Dereference(this GVariantTypeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GVariantType>(x.DangerousGetHandle());
}
internal class GVariantTypeExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_new(string type_string);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_new_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle element);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_new_dict_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle key, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle value);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_new_maybe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle element);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_new_tuple([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle[] items, int length);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_variant_type_dup_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_element([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_equal([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type1, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type2);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_first([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_type_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_variant_type_get_string_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern uint g_variant_type_hash([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_array([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_basic([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_container([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_definite([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_dict_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_maybe([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_subtype_of([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle supertype);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_tuple([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_is_variant([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_variant_type_n_items([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_variant_type_peek_string([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))] MentorLake.GLib.GVariantTypeHandle type);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantTypeHandle>))]
	internal static extern MentorLake.GLib.GVariantTypeHandle g_variant_type_checked_(string type_string);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_variant_type_string_get_depth_(string type_string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_string_is_valid(string type_string);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_type_string_scan(string @string, string limit, out string endptr);

}

/// <summary>
/// <para>
/// A type in the [type@GLib.Variant] type system.
/// </para>
/// <para>
/// This section introduces the [type@GLib.Variant] type system. It is based, in
/// large part, on the D-Bus type system, with two major changes and
/// some minor lifting of restrictions. The
/// [D-Bus specification](http://dbus.freedesktop.org/doc/dbus-specification.html),
/// therefore, provides a significant amount of
/// information that is useful when working with [type@GLib.Variant].
/// </para>
/// <para>
/// The first major change with respect to the D-Bus type system is the
/// introduction of maybe (or ‘nullable’) types.  Any type in [type@GLib.Variant]
/// can be converted to a maybe type, in which case, `nothing` (or `null`)
/// becomes a valid value.  Maybe types have been added by introducing the
/// character `m` to type strings.
/// </para>
/// <para>
/// The second major change is that the [type@GLib.Variant] type system supports
/// the concept of ‘indefinite types’ — types that are less specific than
/// the normal types found in D-Bus.  For example, it is possible to speak
/// of ‘an array of any type’ in [type@GLib.Variant], where the D-Bus type system
/// would require you to speak of ‘an array of integers’ or ‘an array of
/// strings’.  Indefinite types have been added by introducing the
/// characters `*`, `?` and `r` to type strings.
/// </para>
/// <para>
/// Finally, all arbitrary restrictions relating to the complexity of
/// types are lifted along with the restriction that dictionary entries
/// may only appear nested inside of arrays.
/// </para>
/// <para>
/// Just as in D-Bus, [type@GLib.Variant] types are described with strings (‘type
/// strings’).  Subject to the differences mentioned above, these strings
/// are of the same form as those found in D-Bus.  Note, however: D-Bus
/// always works in terms of messages and therefore individual type
/// strings appear nowhere in its interface.  Instead, ‘signatures’
/// are a concatenation of the strings of the type of each argument in a
/// message.  [type@GLib.Variant] deals with single values directly so
/// [type@GLib.Variant] type strings always describe the type of exactly one
/// value.  This means that a D-Bus signature string is generally not a valid
/// [type@GLib.Variant] type string — except in the case that it is the signature
/// of a message containing exactly one argument.
/// </para>
/// <para>
/// An indefinite type is similar in spirit to what may be called an
/// abstract type in other type systems.  No value can exist that has an
/// indefinite type as its type, but values can exist that have types
/// that are subtypes of indefinite types.  That is to say,
/// [method@GLib.Variant.get_type] will never return an indefinite type, but
/// calling [method@GLib.Variant.is_of_type] with an indefinite type may return
/// true.  For example, you cannot have a value that represents ‘an
/// array of no particular type’, but you can have an ‘array of integers’
/// which certainly matches the type of ‘an array of no particular type’,
/// since ‘array of integers’ is a subtype of ‘array of no particular
/// type’.
/// </para>
/// <para>
/// This is similar to how instances of abstract classes may not
/// directly exist in other type systems, but instances of their
/// non-abstract subtypes may.  For example, in GTK, no object that has
/// the type of &amp;lt;see href=&quot;https://docs.gtk.org/gtk4/class.Widget.html&quot;&amp;gt;GtkWidget&amp;lt;/see&amp;gt; can
/// exist (since `GtkWidget` is an abstract class), but a &amp;lt;see href=&quot;https://docs.gtk.org/gtk4/class.Window.html&quot;&amp;gt;GtkWindow&amp;lt;/see&amp;gt;
/// can certainly be instantiated, and you would say that a `GtkWindow` is a
/// `GtkWidget` (since `GtkWindow` is a subclass of `GtkWidget`).
/// </para>
/// <para>
/// Two types may not be compared by value; use [method@GLib.VariantType.equal]
/// or [method@GLib.VariantType.is_subtype_of]  May be copied using
/// [method@GLib.VariantType.copy] and freed using [method@GLib.VariantType.free].
/// </para>
/// <para>
/// ## GVariant Type Strings
/// </para>
/// <para>
/// A [type@GLib.Variant] type string can be any of the following:
/// </para>
/// <para>
/// - any basic type string (listed below)
/// - `v`, `r` or `*`
/// - one of the characters `a` or `m`, followed by another type string
/// - the character `(`, followed by a concatenation of zero or more other
///   type strings, followed by the character `)`
/// - the character `{`, followed by a basic type string (see below),
///   followed by another type string, followed by the character `}`
/// </para>
/// <para>
/// A basic type string describes a basic type (as per
/// [method@GLib.VariantType.is_basic]) and is always a single character in
/// length. The valid basic type strings are `b`, `y`, `n`, `q`, `i`, `u`, `x`,
/// `t`, `h`, `d`, `s`, `o`, `g` and `?`.
/// </para>
/// <para>
/// The above definition is recursive to arbitrary depth. `aaaaai` and
/// `(ui(nq((y)))s)` are both valid type strings, as is
/// `a(aa(ui)(qna{ya(yd)}))`. In order to not hit memory limits,
/// [type@GLib.Variant] imposes a limit on recursion depth of 65 nested
/// containers. This is the limit in the D-Bus specification (64) plus one to
/// allow a &amp;lt;see href=&quot;../gio/class.DBusMessage.html&quot;&amp;gt;GDBusMessage&amp;lt;/see&amp;gt; to be nested in
/// a top-level tuple.
/// </para>
/// <para>
/// The meaning of each of the characters is as follows:
/// </para>
/// <para>
/// - `b`: the type string of `G_VARIANT_TYPE_BOOLEAN`; a boolean value.
/// - `y`: the type string of `G_VARIANT_TYPE_BYTE`; a byte.
/// - `n`: the type string of `G_VARIANT_TYPE_INT16`; a signed 16 bit integer.
/// - `q`: the type string of `G_VARIANT_TYPE_UINT16`; an unsigned 16 bit integer.
/// - `i`: the type string of `G_VARIANT_TYPE_INT32`; a signed 32 bit integer.
/// - `u`: the type string of `G_VARIANT_TYPE_UINT32`; an unsigned 32 bit integer.
/// - `x`: the type string of `G_VARIANT_TYPE_INT64`; a signed 64 bit integer.
/// - `t`: the type string of `G_VARIANT_TYPE_UINT64`; an unsigned 64 bit integer.
/// - `h`: the type string of `G_VARIANT_TYPE_HANDLE`; a signed 32 bit value
///   that, by convention, is used as an index into an array of file
///   descriptors that are sent alongside a D-Bus message.
/// - `d`: the type string of `G_VARIANT_TYPE_DOUBLE`; a double precision
///   floating point value.
/// - `s`: the type string of `G_VARIANT_TYPE_STRING`; a string.
/// - `o`: the type string of `G_VARIANT_TYPE_OBJECT_PATH`; a string in the form
///   of a D-Bus object path.
/// - `g`: the type string of `G_VARIANT_TYPE_SIGNATURE`; a string in the form of
///   a D-Bus type signature.
/// - `?`: the type string of `G_VARIANT_TYPE_BASIC`; an indefinite type that
///   is a supertype of any of the basic types.
/// - `v`: the type string of `G_VARIANT_TYPE_VARIANT`; a container type that
///   contain any other type of value.
/// - `a`: used as a prefix on another type string to mean an array of that
///   type; the type string `ai`, for example, is the type of an array of
///   signed 32-bit integers.
/// - `m`: used as a prefix on another type string to mean a ‘maybe’, or
///   ‘nullable’, version of that type; the type string `ms`, for example,
///   is the type of a value that maybe contains a string, or maybe contains
///   nothing.
/// - `()`: used to enclose zero or more other concatenated type strings to
///   create a tuple type; the type string `(is)`, for example, is the type of
///   a pair of an integer and a string.
/// - `r`: the type string of `G_VARIANT_TYPE_TUPLE`; an indefinite type that is
///   a supertype of any tuple type, regardless of the number of items.
/// - `{}`: used to enclose a basic type string concatenated with another type
///   string to create a dictionary entry type, which usually appears inside of
///   an array to form a dictionary; the type string `a{sd}`, for example, is
///   the type of a dictionary that maps strings to double precision floating
///   point values.
/// </para>
/// <para>
///   The first type (the basic type) is the key type and the second type is
///   the value type. The reason that the first type is restricted to being a
///   basic type is so that it can easily be hashed.
/// - `*`: the type string of `G_VARIANT_TYPE_ANY`; the indefinite type that is
///   a supertype of all types.  Note that, as with all type strings, this
///   character represents exactly one type. It cannot be used inside of tuples
///   to mean ‘any number of items’.
/// </para>
/// <para>
/// Any type string of a container that contains an indefinite type is,
/// itself, an indefinite type. For example, the type string `a*`
/// (corresponding to `G_VARIANT_TYPE_ARRAY`) is an indefinite type
/// that is a supertype of every array type. `(*s)` is a supertype
/// of all tuples that contain exactly two items where the second
/// item is a string.
/// </para>
/// <para>
/// `a{?*}` is an indefinite type that is a supertype of all arrays
/// containing dictionary entries where the key is any basic type and
/// the value is any type at all.  This is, by definition, a dictionary,
/// so this type string corresponds to `G_VARIANT_TYPE_DICTIONARY`. Note
/// that, due to the restriction that the key of a dictionary entry must
/// be a basic type, `{**}` is not a valid type string.
/// </para>
/// </summary>

public struct GVariantType
{

/// <param name="type_string">
/// </param>

	public static MentorLake.GLib.GVariantTypeHandle Checked(string type_string)
	{
		return GVariantTypeExterns.g_variant_type_checked_(type_string);
	}


/// <param name="type_string">
/// </param>

	public static UIntPtr StringGetDepth(string type_string)
	{
		return GVariantTypeExterns.g_variant_type_string_get_depth_(type_string);
	}

/// <summary>
/// <para>
/// Checks if @type_string is a valid
/// [GVariant type string](./struct.VariantType.html#gvariant-type-strings).
/// </para>
/// <para>
/// This call is equivalent to calling [func@GLib.VariantType.string_scan] and
/// confirming that the following character is a nul terminator.
/// </para>
/// </summary>

/// <param name="type_string">
/// a pointer to any string
/// </param>
/// <return>
/// true if @type_string is exactly one valid type string
/// Since 2.24
/// </return>

	public static bool StringIsValid(string type_string)
	{
		return GVariantTypeExterns.g_variant_type_string_is_valid(type_string);
	}

/// <summary>
/// <para>
/// Scan for a single complete and valid GVariant type string in @string.
/// </para>
/// <para>
/// The memory pointed to by @limit (or bytes beyond it) is never
/// accessed.
/// </para>
/// <para>
/// If a valid type string is found, @endptr is updated to point to the
/// first character past the end of the string that was found and %TRUE
/// is returned.
/// </para>
/// <para>
/// If there is no valid type string starting at @string, or if the type
/// string does not end before @limit then %FALSE is returned.
/// </para>
/// <para>
/// For the simple case of checking if a string is a valid type string,
/// see [func@GLib.VariantType.string_is_valid].
/// </para>
/// </summary>

/// <param name="@string">
/// a pointer to any string
/// </param>
/// <param name="limit">
/// the end of @string
/// </param>
/// <param name="endptr">
/// location to store the end pointer
/// </param>
/// <return>
/// true if a valid type string was found
/// </return>

	public static bool StringScan(string @string, string limit, out string endptr)
	{
		return GVariantTypeExterns.g_variant_type_string_scan(@string, limit, out endptr);
	}

}
