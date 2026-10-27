namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Contains a set of toggle-able web engine features.
/// </para>
/// <para>
/// The list supports passing around a set of [struct@Feature] objects and
/// iterating over them:
/// </para>
/// <para>
/// ```c
/// g_autoptr(WebKitFeatureList) list = webkit_settings_get_experimental_features();
/// for (gsize i = 0; i &amp;lt; webkit_feature_list_get_length(list): i++) {
///     WebKitFeature *feature = webkit_feature_list_get(list, i);
///     // Do something with &quot;feature&quot;.
/// }
/// ```
/// </para>
/// <para>
/// Lists of features can be obtained with
/// [func@Settings.get_experimental_features],
/// [func@Settings.get_development_features], and
/// [func@Settings.get_all_features].
/// </para>
/// </summary>

public class WebKitFeatureListHandle : BaseSafeHandle
{
}


public static class WebKitFeatureListExtensions
{
/// <summary>
/// <para>
/// Gets a feature given its index.
/// </para>
/// </summary>

/// <param name="feature_list">
/// a #WebKitFeatureList
/// </param>
/// <param name="index">
/// index of the feature
/// </param>
/// <return>
/// The feature at @index.
/// </return>

	public static MentorLake.WebKit2.WebKitFeatureHandle Get(this MentorLake.WebKit2.WebKitFeatureListHandle feature_list, UIntPtr index)
	{
		if (feature_list.IsInvalid) throw new Exception("Invalid handle (WebKitFeatureList)");
		return WebKitFeatureListExterns.webkit_feature_list_get(feature_list, index);
	}

/// <summary>
/// <para>
/// Gets the number of elements in the feature list.
/// </para>
/// </summary>

/// <param name="feature_list">
/// a #WebKitFeatureList
/// </param>
/// <return>
/// number of elements.
/// 
/// Since 2.42
/// </return>

	public static UIntPtr GetLength(this MentorLake.WebKit2.WebKitFeatureListHandle feature_list)
	{
		if (feature_list.IsInvalid) throw new Exception("Invalid handle (WebKitFeatureList)");
		return WebKitFeatureListExterns.webkit_feature_list_get_length(feature_list);
	}

/// <summary>
/// <para>
/// Atomically acquires a reference on the given @feature_list.
/// </para>
/// <para>
/// This function is MT-safe and may be called from any thread.
/// </para>
/// </summary>

/// <param name="feature_list">
/// a #WebKitFeatureList
/// </param>
/// <return>
/// The same @feature_list with an additional reference.
/// </return>

	public static MentorLake.WebKit2.WebKitFeatureListHandle Ref(this MentorLake.WebKit2.WebKitFeatureListHandle feature_list)
	{
		if (feature_list.IsInvalid) throw new Exception("Invalid handle (WebKitFeatureList)");
		return WebKitFeatureListExterns.webkit_feature_list_ref(feature_list);
	}

/// <summary>
/// <para>
/// Atomically releases a reference on the given @feature_list.
/// </para>
/// <para>
/// If the reference was the last, the resources associated to the
/// @feature_list are freed. This function is MT-safe and may be called
/// from any thread.
/// </para>
/// </summary>

/// <param name="feature_list">
/// a #WebKitFeatureList
/// </param>

	public static void Unref(this MentorLake.WebKit2.WebKitFeatureListHandle feature_list)
	{
		if (feature_list.IsInvalid) throw new Exception("Invalid handle (WebKitFeatureList)");
		WebKitFeatureListExterns.webkit_feature_list_unref(feature_list);
	}


	public static WebKitFeatureList Dereference(this WebKitFeatureListHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<WebKitFeatureList>(x.DangerousGetHandle());
}
internal class WebKitFeatureListExterns
{
	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureHandle>))]
	internal static extern MentorLake.WebKit2.WebKitFeatureHandle webkit_feature_list_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureListHandle>))] MentorLake.WebKit2.WebKitFeatureListHandle feature_list, UIntPtr index);

	[DllImport(WebKit2Library.Name)]
	internal static extern UIntPtr webkit_feature_list_get_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureListHandle>))] MentorLake.WebKit2.WebKitFeatureListHandle feature_list);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureListHandle>))]
	internal static extern MentorLake.WebKit2.WebKitFeatureListHandle webkit_feature_list_ref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureListHandle>))] MentorLake.WebKit2.WebKitFeatureListHandle feature_list);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_feature_list_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFeatureListHandle>))] MentorLake.WebKit2.WebKitFeatureListHandle feature_list);

}

/// <summary>
/// <para>
/// Contains a set of toggle-able web engine features.
/// </para>
/// <para>
/// The list supports passing around a set of [struct@Feature] objects and
/// iterating over them:
/// </para>
/// <para>
/// ```c
/// g_autoptr(WebKitFeatureList) list = webkit_settings_get_experimental_features();
/// for (gsize i = 0; i &amp;lt; webkit_feature_list_get_length(list): i++) {
///     WebKitFeature *feature = webkit_feature_list_get(list, i);
///     // Do something with &quot;feature&quot;.
/// }
/// ```
/// </para>
/// <para>
/// Lists of features can be obtained with
/// [func@Settings.get_experimental_features],
/// [func@Settings.get_development_features], and
/// [func@Settings.get_all_features].
/// </para>
/// </summary>

public struct WebKitFeatureList
{
}
