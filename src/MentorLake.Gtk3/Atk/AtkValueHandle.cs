namespace MentorLake.Atk;

/// <summary>
/// <para>
/// The ATK interface implemented by valuators and components which display or select a value from a bounded range of values.
/// </para>
/// <para>
/// #AtkValue should be implemented for components which either display
/// a value from a bounded range, or which allow the user to specify a
/// value from a bounded range, or both. For instance, most sliders and
/// range controls, as well as dials, should have #AtkObject
/// representations which implement #AtkValue on the component&apos;s
/// behalf. #AtKValues may be read-only, in which case attempts to
/// alter the value return would fail.
/// </para>
/// <para>
/// &amp;lt;refsect1 id=&quot;current-value-text&quot;&amp;gt;
/// &amp;lt;title&amp;gt;On the subject of current value text&amp;lt;/title&amp;gt;
/// &amp;lt;para&amp;gt;
/// In addition to providing the current value, implementors can
/// optionally provide an end-user-consumable textual description
/// associated with this value. This description should be included
/// when the numeric value fails to convey the full, on-screen
/// representation seen by users.
/// &amp;lt;/para&amp;gt;
/// </para>
/// <para>
/// &amp;lt;example&amp;gt;
/// &amp;lt;title&amp;gt;Password strength&amp;lt;/title&amp;gt;
/// A password strength meter whose value changes as the user types
/// their new password. Red is used for values less than 4.0, yellow
/// for values between 4.0 and 7.0, and green for values greater than
/// 7.0. In this instance, value text should be provided by the
/// implementor. Appropriate value text would be &quot;weak&quot;, &quot;acceptable,&quot;
/// and &quot;strong&quot; respectively.
/// &amp;lt;/example&amp;gt;
/// </para>
/// <para>
/// A level bar whose value changes to reflect the battery charge. The
/// color remains the same regardless of the charge and there is no
/// on-screen text reflecting the fullness of the battery. In this
/// case, because the position within the bar is the only indication
/// the user has of the current charge, value text should not be
/// provided by the implementor.
/// </para>
/// <para>
/// &amp;lt;refsect2 id=&quot;implementor-notes&quot;&amp;gt;
/// &amp;lt;title&amp;gt;Implementor Notes&amp;lt;/title&amp;gt;
/// &amp;lt;para&amp;gt;
/// Implementors should bear in mind that assistive technologies will
/// likely prefer the value text provided over the numeric value when
/// presenting a widget&apos;s value. As a result, strings not intended for
/// end users should not be exposed in the value text, and strings
/// which are exposed should be localized. In the case of widgets which
/// display value text on screen, for instance through a separate label
/// in close proximity to the value-displaying widget, it is still
/// expected that implementors will expose the value text using the
/// above API.
/// &amp;lt;/para&amp;gt;
/// </para>
/// <para>
/// &amp;lt;para&amp;gt;
/// #AtkValue should NOT be implemented for widgets whose displayed
/// value is not reflective of a meaningful amount. For instance, a
/// progress pulse indicator whose value alternates between 0.0 and 1.0
/// to indicate that some process is still taking place should not
/// implement #AtkValue because the current value does not reflect
/// progress towards completion.
/// &amp;lt;/para&amp;gt;
/// &amp;lt;/refsect2&amp;gt;
/// &amp;lt;/refsect1&amp;gt;
/// </para>
/// <para>
/// &amp;lt;refsect1 id=&quot;ranges&quot;&amp;gt;
/// &amp;lt;title&amp;gt;On the subject of ranges&amp;lt;/title&amp;gt;
/// &amp;lt;para&amp;gt;
/// In addition to providing the minimum and maximum values,
/// implementors can optionally provide details about subranges
/// associated with the widget. These details should be provided by the
/// implementor when both of the following are communicated visually to
/// the end user:
/// &amp;lt;/para&amp;gt;
/// &amp;lt;itemizedlist&amp;gt;
///   &amp;lt;listitem&amp;gt;The existence of distinct ranges such as &quot;weak&quot;,
///   &quot;acceptable&quot;, and &quot;strong&quot; indicated by color, bar tick marks,
///   and/or on-screen text.&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;Where the current value stands within a given subrange,
///   for instance illustrating progression from very &quot;weak&quot; towards
///   nearly &quot;acceptable&quot; through changes in shade and/or position on
///   the bar within the &quot;weak&quot; subrange.&amp;lt;/listitem&amp;gt;
/// &amp;lt;/itemizedlist&amp;gt;
/// &amp;lt;para&amp;gt;
/// If both of the above do not apply to the widget, it should be
/// sufficient to expose the numeric value, along with the value text
/// if appropriate, to make the widget accessible.
/// &amp;lt;/para&amp;gt;
/// </para>
/// <para>
/// &amp;lt;refsect2 id=&quot;ranges-implementor-notes&quot;&amp;gt;
/// &amp;lt;title&amp;gt;Implementor Notes&amp;lt;/title&amp;gt;
/// &amp;lt;para&amp;gt;
/// If providing subrange details is deemed necessary, all possible
/// values of the widget are expected to fall within one of the
/// subranges defined by the implementor.
/// &amp;lt;/para&amp;gt;
/// &amp;lt;/refsect2&amp;gt;
/// &amp;lt;/refsect1&amp;gt;
/// </para>
/// <para>
/// &amp;lt;refsect1 id=&quot;localization&quot;&amp;gt;
/// &amp;lt;title&amp;gt;On the subject of localization of end-user-consumable text
/// values&amp;lt;/title&amp;gt;
/// &amp;lt;para&amp;gt;
/// Because value text and subrange descriptors are human-consumable,
/// implementors are expected to provide localized strings which can be
/// directly presented to end users via their assistive technology. In
/// order to simplify this for implementors, implementors can use
/// atk_value_type_get_localized_name() with the following
/// already-localized constants for commonly-needed values can be used:
/// &amp;lt;/para&amp;gt;
/// </para>
/// <para>
/// &amp;lt;itemizedlist&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_VERY_WEAK&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_WEAK&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_ACCEPTABLE&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_STRONG&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_VERY_STRONG&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_VERY_LOW&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_LOW&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_MEDIUM&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_HIGH&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_VERY_HIGH&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_VERY_BAD&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_BAD&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_GOOD&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_VERY_GOOD&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_BEST&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_SUBSUBOPTIMAL&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_SUBOPTIMAL&amp;lt;/listitem&amp;gt;
///   &amp;lt;listitem&amp;gt;ATK_VALUE_OPTIMAL&amp;lt;/listitem&amp;gt;
/// &amp;lt;/itemizedlist&amp;gt;
/// &amp;lt;para&amp;gt;
/// Proposals for additional constants, along with their use cases,
/// should be submitted to the GNOME Accessibility Team.
/// &amp;lt;/para&amp;gt;
/// &amp;lt;/refsect1&amp;gt;
/// </para>
/// <para>
/// &amp;lt;refsect1 id=&quot;changes&quot;&amp;gt;
/// &amp;lt;title&amp;gt;On the subject of changes&amp;lt;/title&amp;gt;
/// &amp;lt;para&amp;gt;
/// Note that if there is a textual description associated with the new
/// numeric value, that description should be included regardless of
/// whether or not it has also changed.
/// &amp;lt;/para&amp;gt;
/// &amp;lt;/refsect1&amp;gt;
/// </para>
/// </summary>

public interface AtkValueHandle
{
	public bool IsInvalid { get; }
	public bool IsClosed { get; }
}

internal class AtkValueHandleImpl : BaseSafeHandle, AtkValueHandle
{
}

public static class AtkValueHandleExtensions
{
/// <summary>
/// <para>
/// Gets the value of this object.
/// </para>
/// </summary>

/// <param name="obj">
/// a GObject instance that implements AtkValueIface
/// </param>
/// <param name="value">
/// a #GValue representing the current accessible value
/// </param>

	public static T GetCurrentValue<T>(this T obj, out MentorLake.GObject.GValue value) where T : AtkValueHandle
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		AtkValueHandleExterns.atk_value_get_current_value(obj, out value);
		return obj;
	}

/// <summary>
/// <para>
/// Gets the minimum increment by which the value of this object may be
/// changed.  If zero, the minimum increment is undefined, which may
/// mean that it is limited only by the floating point precision of the
/// platform.
/// </para>
/// </summary>

/// <param name="obj">
/// a GObject instance that implements AtkValueIface
/// </param>
/// <return>
/// the minimum increment by which the value of this
/// object may be changed. zero if undefined.
/// </return>

	public static double GetIncrement(this MentorLake.Atk.AtkValueHandle obj)
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		return AtkValueHandleExterns.atk_value_get_increment(obj);
	}

/// <summary>
/// <para>
/// Gets the maximum value of this object.
/// </para>
/// </summary>

/// <param name="obj">
/// a GObject instance that implements AtkValueIface
/// </param>
/// <param name="value">
/// a #GValue representing the maximum accessible value
/// </param>

	public static T GetMaximumValue<T>(this T obj, out MentorLake.GObject.GValue value) where T : AtkValueHandle
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		AtkValueHandleExterns.atk_value_get_maximum_value(obj, out value);
		return obj;
	}

/// <summary>
/// <para>
/// Gets the minimum increment by which the value of this object may be changed.  If zero,
/// the minimum increment is undefined, which may mean that it is limited only by the
/// floating point precision of the platform.
/// </para>
/// </summary>

/// <param name="obj">
/// a GObject instance that implements AtkValueIface
/// </param>
/// <param name="value">
/// a #GValue representing the minimum increment by which the accessible value may be changed
/// </param>

	public static T GetMinimumIncrement<T>(this T obj, out MentorLake.GObject.GValue value) where T : AtkValueHandle
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		AtkValueHandleExterns.atk_value_get_minimum_increment(obj, out value);
		return obj;
	}

/// <summary>
/// <para>
/// Gets the minimum value of this object.
/// </para>
/// </summary>

/// <param name="obj">
/// a GObject instance that implements AtkValueIface
/// </param>
/// <param name="value">
/// a #GValue representing the minimum accessible value
/// </param>

	public static T GetMinimumValue<T>(this T obj, out MentorLake.GObject.GValue value) where T : AtkValueHandle
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		AtkValueHandleExterns.atk_value_get_minimum_value(obj, out value);
		return obj;
	}

/// <summary>
/// <para>
/// Gets the range of this object.
/// </para>
/// </summary>

/// <param name="obj">
/// a GObject instance that implements AtkValueIface
/// </param>
/// <return>
/// a newly allocated #AtkRange
/// that represents the minimum, maximum and descriptor (if available)
/// of @obj. NULL if that range is not defined.
/// </return>

	public static MentorLake.Atk.AtkRangeHandle GetRange(this MentorLake.Atk.AtkValueHandle obj)
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		return AtkValueHandleExterns.atk_value_get_range(obj);
	}

/// <summary>
/// <para>
/// Gets the list of subranges defined for this object. See #AtkValue
/// introduction for examples of subranges and when to expose them.
/// </para>
/// </summary>

/// <param name="obj">
/// a GObject instance that implements AtkValueIface
/// </param>
/// <return>
/// an #GSList of
/// #AtkRange which each of the subranges defined for this object. Free
/// the returns list with g_slist_free().
/// </return>

	public static MentorLake.GLib.GSListHandle GetSubRanges(this MentorLake.Atk.AtkValueHandle obj)
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		return AtkValueHandleExterns.atk_value_get_sub_ranges(obj);
	}

/// <summary>
/// <para>
/// Gets the current value and the human readable text alternative of
/// @obj. @text is a newly created string, that must be freed by the
/// caller. Can be NULL if no descriptor is available.
/// </para>
/// </summary>

/// <param name="obj">
/// a GObject instance that implements AtkValueIface
/// </param>
/// <param name="value">
/// address of #gdouble to put the current value of @obj
/// </param>
/// <param name="text">
/// address of #gchar to put the human
/// readable text alternative for @value
/// </param>

	public static T GetValueAndText<T>(this T obj, out double value, out string text) where T : AtkValueHandle
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		AtkValueHandleExterns.atk_value_get_value_and_text(obj, out value, out text);
		return obj;
	}

/// <summary>
/// <para>
/// Sets the value of this object.
/// </para>
/// </summary>

/// <param name="obj">
/// a GObject instance that implements AtkValueIface
/// </param>
/// <param name="value">
/// a #GValue which is the desired new accessible value.
/// </param>
/// <return>
/// %TRUE if new value is successfully set, %FALSE otherwise.
/// </return>

	public static bool SetCurrentValue(this MentorLake.Atk.AtkValueHandle obj, MentorLake.GObject.GValueHandle value)
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		return AtkValueHandleExterns.atk_value_set_current_value(obj, value);
	}

/// <summary>
/// <para>
/// Sets the value of this object.
/// </para>
/// <para>
/// This method is intended to provide a way to change the value of the
/// object. In any case, it is possible that the value can&apos;t be
/// modified (ie: a read-only component). If the value changes due this
/// call, it is possible that the text could change, and will trigger
/// an #AtkValue::value-changed signal emission.
/// </para>
/// <para>
/// Note for implementors: the deprecated atk_value_set_current_value()
/// method returned TRUE or FALSE depending if the value was assigned
/// or not. In the practice several implementors were not able to
/// decide it, and returned TRUE in any case. For that reason it is not
/// required anymore to return if the value was properly assigned or
/// not.
/// </para>
/// </summary>

/// <param name="obj">
/// a GObject instance that implements AtkValueIface
/// </param>
/// <param name="new_value">
/// a double which is the desired new accessible value.
/// </param>

	public static T SetValue<T>(this T obj, double new_value) where T : AtkValueHandle
	{
		if (obj.IsInvalid) throw new Exception("Invalid handle (AtkValueHandle)");
		AtkValueHandleExterns.atk_value_set_value(obj, new_value);
		return obj;
	}

}

internal class AtkValueHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_value_get_current_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj, out MentorLake.GObject.GValue value);

	[DllImport(AtkLibrary.Name)]
	internal static extern double atk_value_get_increment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_value_get_maximum_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj, out MentorLake.GObject.GValue value);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_value_get_minimum_increment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj, out MentorLake.GObject.GValue value);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_value_get_minimum_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj, out MentorLake.GObject.GValue value);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRangeHandle>))]
	internal static extern MentorLake.Atk.AtkRangeHandle atk_value_get_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSListHandle>))]
	internal static extern MentorLake.GLib.GSListHandle atk_value_get_sub_ranges([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_value_get_value_and_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj, out double value, out string text);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_value_set_current_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GValueHandle>))] MentorLake.GObject.GValueHandle value);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_value_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle obj, double new_value);

}
