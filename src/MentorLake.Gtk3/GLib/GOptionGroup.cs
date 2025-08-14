namespace MentorLake.GLib;

/// <summary>
/// <para>
/// A `GOptionGroup` struct defines the options in a single
/// group. The struct has only private fields and should not be directly accessed.
/// </para>
/// <para>
/// All options in a group share the same translation function. Libraries which
/// need to parse commandline options are expected to provide a function for
/// getting a `GOptionGroup` holding their options, which
/// the application can then add to its #GOptionContext.
/// </para>
/// </summary>

public class GOptionGroupHandle : BaseSafeHandle
{
/// <summary>
/// <para>
/// Creates a new #GOptionGroup.
/// </para>
/// <para>
/// @description is typically used to provide a title for the group. If so, it
/// is recommended that it’s written in title case, and has a trailing colon so
/// that it matches the style of built-in GLib group titles such as
/// ‘Application Options:’.
/// </para>
/// </summary>

/// <param name="name">
/// the name for the option group, this is used to provide
///   help for the options in this group with `--help-`@name
/// </param>
/// <param name="description">
/// a description for this group to be shown in
///   `--help`. This string is translated using the translation
///   domain or translation function of the group
/// </param>
/// <param name="help_description">
/// a description for the `--help-`@name option.
///   This string is translated using the translation domain or translation function
///   of the group
/// </param>
/// <param name="user_data">
/// user data that will be passed to the pre- and post-parse hooks,
///   the error hook and to callbacks of %G_OPTION_ARG_CALLBACK options, or %NULL
/// </param>
/// <param name="destroy">
/// a function that will be called to free @user_data, or %NULL
/// </param>
/// <return>
/// a newly created option group. It should be added
///   to a #GOptionContext or freed with g_option_group_unref().
/// </return>

	public static MentorLake.GLib.GOptionGroupHandle New(string name, string description, string help_description, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy)
	{
		return GOptionGroupExterns.g_option_group_new(name, description, help_description, user_data, destroy);
	}

}


public static class GOptionGroupExtensions
{
/// <summary>
/// <para>
/// Adds the options specified in @entries to @group.
/// </para>
/// </summary>

/// <param name="group">
/// a #GOptionGroup
/// </param>
/// <param name="entries">
/// a %NULL-terminated array of #GOptionEntrys
/// </param>

	public static void AddEntries(this MentorLake.GLib.GOptionGroupHandle group, MentorLake.GLib.GOptionEntry[] entries)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GOptionGroup)");
		GOptionGroupExterns.g_option_group_add_entries(group, entries);
	}

/// <summary>
/// <para>
/// Frees a #GOptionGroup. Note that you must not free groups
/// which have been added to a #GOptionContext.
/// </para>
/// </summary>

/// <param name="group">
/// a #GOptionGroup
/// </param>

	public static void Free(this MentorLake.GLib.GOptionGroupHandle group)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GOptionGroup)");
		GOptionGroupExterns.g_option_group_free(group);
	}

/// <summary>
/// <para>
/// Increments the reference count of @group by one.
/// </para>
/// </summary>

/// <param name="group">
/// a #GOptionGroup
/// </param>
/// <return>
/// a #GOptionGroup
/// </return>

	public static MentorLake.GLib.GOptionGroupHandle Ref(this MentorLake.GLib.GOptionGroupHandle group)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GOptionGroup)");
		return GOptionGroupExterns.g_option_group_ref(group);
	}

/// <summary>
/// <para>
/// Associates a function with @group which will be called
/// from g_option_context_parse() when an error occurs.
/// </para>
/// <para>
/// Note that the user data to be passed to @error_func can be
/// specified when constructing the group with g_option_group_new().
/// </para>
/// </summary>

/// <param name="group">
/// a #GOptionGroup
/// </param>
/// <param name="error_func">
/// a function to call when an error occurs
/// </param>

	public static void SetErrorHook(this MentorLake.GLib.GOptionGroupHandle group, MentorLake.GLib.GOptionErrorFunc error_func)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GOptionGroup)");
		GOptionGroupExterns.g_option_group_set_error_hook(group, error_func);
	}

/// <summary>
/// <para>
/// Associates two functions with @group which will be called
/// from g_option_context_parse() before the first option is parsed
/// and after the last option has been parsed, respectively.
/// </para>
/// <para>
/// Note that the user data to be passed to @pre_parse_func and
/// @post_parse_func can be specified when constructing the group
/// with g_option_group_new().
/// </para>
/// </summary>

/// <param name="group">
/// a #GOptionGroup
/// </param>
/// <param name="pre_parse_func">
/// a function to call before parsing, or %NULL
/// </param>
/// <param name="post_parse_func">
/// a function to call after parsing, or %NULL
/// </param>

	public static void SetParseHooks(this MentorLake.GLib.GOptionGroupHandle group, MentorLake.GLib.GOptionParseFunc pre_parse_func, MentorLake.GLib.GOptionParseFunc post_parse_func)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GOptionGroup)");
		GOptionGroupExterns.g_option_group_set_parse_hooks(group, pre_parse_func, post_parse_func);
	}

/// <summary>
/// <para>
/// Sets the function which is used to translate user-visible strings,
/// for `--help` output. Different groups can use different
/// #GTranslateFuncs. If @func is %NULL, strings are not translated.
/// </para>
/// <para>
/// If you are using gettext(), you only need to set the translation
/// domain, see g_option_group_set_translation_domain().
/// </para>
/// </summary>

/// <param name="group">
/// a #GOptionGroup
/// </param>
/// <param name="func">
/// the #GTranslateFunc, or %NULL
/// </param>
/// <param name="data">
/// user data to pass to @func, or %NULL
/// </param>
/// <param name="destroy_notify">
/// a function which gets called to free @data, or %NULL
/// </param>

	public static void SetTranslateFunc(this MentorLake.GLib.GOptionGroupHandle group, MentorLake.GLib.GTranslateFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy_notify)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GOptionGroup)");
		GOptionGroupExterns.g_option_group_set_translate_func(group, func, data, destroy_notify);
	}

/// <summary>
/// <para>
/// A convenience function to use gettext() for translating
/// user-visible strings.
/// </para>
/// </summary>

/// <param name="group">
/// a #GOptionGroup
/// </param>
/// <param name="domain">
/// the domain to use
/// </param>

	public static void SetTranslationDomain(this MentorLake.GLib.GOptionGroupHandle group, string domain)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GOptionGroup)");
		GOptionGroupExterns.g_option_group_set_translation_domain(group, domain);
	}

/// <summary>
/// <para>
/// Decrements the reference count of @group by one.
/// If the reference count drops to 0, the @group will be freed.
/// and all memory allocated by the @group is released.
/// </para>
/// </summary>

/// <param name="group">
/// a #GOptionGroup
/// </param>

	public static void Unref(this MentorLake.GLib.GOptionGroupHandle group)
	{
		if (group.IsInvalid) throw new Exception("Invalid handle (GOptionGroup)");
		GOptionGroupExterns.g_option_group_unref(group);
	}


	public static GOptionGroup Dereference(this GOptionGroupHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GOptionGroup>(x.DangerousGetHandle());
}
internal class GOptionGroupExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))]
	internal static extern MentorLake.GLib.GOptionGroupHandle g_option_group_new(string name, string description, string help_description, IntPtr user_data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_group_add_entries([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group, MentorLake.GLib.GOptionEntry[] entries);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_group_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))]
	internal static extern MentorLake.GLib.GOptionGroupHandle g_option_group_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_group_set_error_hook([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group, MentorLake.GLib.GOptionErrorFunc error_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_group_set_parse_hooks([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group, MentorLake.GLib.GOptionParseFunc pre_parse_func, MentorLake.GLib.GOptionParseFunc post_parse_func);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_group_set_translate_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group, MentorLake.GLib.GTranslateFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy_notify);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_group_set_translation_domain([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group, string domain);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_option_group_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GOptionGroupHandle>))] MentorLake.GLib.GOptionGroupHandle group);

}

/// <summary>
/// <para>
/// A `GOptionGroup` struct defines the options in a single
/// group. The struct has only private fields and should not be directly accessed.
/// </para>
/// <para>
/// All options in a group share the same translation function. Libraries which
/// need to parse commandline options are expected to provide a function for
/// getting a `GOptionGroup` holding their options, which
/// the application can then add to its #GOptionContext.
/// </para>
/// </summary>

public struct GOptionGroup
{
}
