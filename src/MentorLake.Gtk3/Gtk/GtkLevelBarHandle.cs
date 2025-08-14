namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkLevelBar is a bar widget that can be used
/// as a level indicator. Typical use cases are displaying the strength
/// of a password, or showing the charge level of a battery.
/// </para>
/// <para>
/// Use gtk_level_bar_set_value() to set the current value, and
/// gtk_level_bar_add_offset_value() to set the value offsets at which
/// the bar will be considered in a different state. GTK will add a few
/// offsets by default on the level bar: #GTK_LEVEL_BAR_OFFSET_LOW,
/// #GTK_LEVEL_BAR_OFFSET_HIGH and #GTK_LEVEL_BAR_OFFSET_FULL, with
/// values 0.25, 0.75 and 1.0 respectively.
/// </para>
/// <para>
/// Note that it is your responsibility to update preexisting offsets
/// when changing the minimum or maximum value. GTK+ will simply clamp
/// them to the new range.
/// </para>
/// <para>
/// ## Adding a custom offset on the bar
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// </para>
/// <para>
/// static GtkWidget *
/// create_level_bar (void)
/// {
///   GtkWidget *widget;
///   GtkLevelBar *bar;
/// </para>
/// <para>
///   widget = gtk_level_bar_new ();
///   bar = GTK_LEVEL_BAR (widget);
/// </para>
/// <para>
///   // This changes the value of the default low offset
/// </para>
/// <para>
///   gtk_level_bar_add_offset_value (bar,
///                                   GTK_LEVEL_BAR_OFFSET_LOW,
///                                   0.10);
/// </para>
/// <para>
///   // This adds a new offset to the bar; the application will
///   // be able to change its color CSS like this:
///   //
///   // levelbar block.my-offset {
///   //   background-color: magenta;
///   //   border-style: solid;
///   //   border-color: black;
///   //   border-style: 1px;
///   // }
/// </para>
/// <para>
///   gtk_level_bar_add_offset_value (bar, "my-offset", 0.60);
/// </para>
/// <para>
///   return widget;
/// }
/// ]|
/// </para>
/// <para>
/// The default interval of values is between zero and one, but it’s possible to
/// modify the interval using gtk_level_bar_set_min_value() and
/// gtk_level_bar_set_max_value(). The value will be always drawn in proportion to
/// the admissible interval, i.e. a value of 15 with a specified interval between
/// 10 and 20 is equivalent to a value of 0.5 with an interval between 0 and 1.
/// When #GTK_LEVEL_BAR_MODE_DISCRETE is used, the bar level is rendered
/// as a finite number of separated blocks instead of a single one. The number
/// of blocks that will be rendered is equal to the number of units specified by
/// the admissible interval.
/// </para>
/// <para>
/// For instance, to build a bar rendered with five blocks, it’s sufficient to
/// set the minimum value to 0 and the maximum value to 5 after changing the indicator
/// mode to discrete.
/// </para>
/// <para>
/// GtkLevelBar was introduced in GTK+ 3.6.
/// </para>
/// <para>
/// # GtkLevelBar as GtkBuildable
/// </para>
/// <para>
/// The GtkLevelBar implementation of the GtkBuildable interface supports a
/// custom `<offsets>` element, which can contain any number of `<offset>` elements,
/// each of which must have "name" and "value" attributes.
/// </para>
/// <para>
/// # CSS nodes
/// </para>
/// <para>
/// |[<!-- language="plain" -->
/// levelbar[.discrete]
/// ╰── trough
///     ├── block.filled.level-name
///     ┊
///     ├── block.empty
///     ┊
/// ]|
/// </para>
/// <para>
/// GtkLevelBar has a main CSS node with name levelbar and one of the style
/// classes .discrete or .continuous and a subnode with name trough. Below the
/// trough node are a number of nodes with name block and style class .filled
/// or .empty. In continuous mode, there is exactly one node of each, in discrete
/// mode, the number of filled and unfilled nodes corresponds to blocks that are
/// drawn. The block.filled nodes also get a style class .level-name corresponding
/// to the level for the current value.
/// </para>
/// <para>
/// In horizontal orientation, the nodes are always arranged from left to right,
/// regardless of text direction.
/// </para>
/// </summary>

public class GtkLevelBarHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkLevelBar.
/// </para>
/// </summary>

/// <return>
/// a #GtkLevelBar.
/// </return>

	public static MentorLake.Gtk.GtkLevelBarHandle New()
	{
		return GtkLevelBarHandleExterns.gtk_level_bar_new();
	}

/// <summary>
/// <para>
/// Utility constructor that creates a new #GtkLevelBar for the specified
/// interval.
/// </para>
/// </summary>

/// <param name="min_value">
/// a positive value
/// </param>
/// <param name="max_value">
/// a positive value
/// </param>
/// <return>
/// a #GtkLevelBar
/// </return>

	public static MentorLake.Gtk.GtkLevelBarHandle NewForInterval(double min_value, double max_value)
	{
		return GtkLevelBarHandleExterns.gtk_level_bar_new_for_interval(min_value, max_value);
	}

}
public static class GtkLevelBarHandleSignalExtensions
{
/// <summary>
/// <para>
/// Emitted when an offset specified on the bar changes value as an
/// effect to gtk_level_bar_add_offset_value() being called.
/// </para>
/// <para>
/// The signal supports detailed connections; you can connect to the
/// detailed signal "changed::x" in order to only receive callbacks when
/// the value of offset "x" changes.
/// </para>
/// </summary>

	public static IObservable<GtkLevelBarHandleSignalStructs.OffsetChangedSignal> Signal_OffsetChanged(this GtkLevelBarHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkLevelBarHandleSignalStructs.OffsetChangedSignal> obs) =>
		{
			GtkLevelBarHandleSignalDelegates.offset_changed handler = ( MentorLake.Gtk.GtkLevelBarHandle self,  string name,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkLevelBarHandleSignalStructs.OffsetChangedSignal()
				{
					Self = self, Name = name, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "offset-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkLevelBarHandleSignalStructs
{

public class OffsetChangedSignal
{

	public MentorLake.Gtk.GtkLevelBarHandle Self;
/// <summary>
/// <para>
/// the name of the offset that changed value
/// </para>
/// </summary>

	public string Name;

	public IntPtr UserData;
}
}

public static class GtkLevelBarHandleSignalDelegates
{

/// <summary>
/// <para>
/// Emitted when an offset specified on the bar changes value as an
/// effect to gtk_level_bar_add_offset_value() being called.
/// </para>
/// <para>
/// The signal supports detailed connections; you can connect to the
/// detailed signal "changed::x" in order to only receive callbacks when
/// the value of offset "x" changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="name">
/// the name of the offset that changed value
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void offset_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, string name, IntPtr user_data);

}


public static class GtkLevelBarHandleExtensions
{
/// <summary>
/// <para>
/// Adds a new offset marker on @self at the position specified by @value.
/// When the bar value is in the interval topped by @value (or between @value
/// and #GtkLevelBar:max-value in case the offset is the last one on the bar)
/// a style class named `level-`@name will be applied
/// when rendering the level bar fill.
/// If another offset marker named @name exists, its value will be
/// replaced by @value.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkLevelBar
/// </param>
/// <param name="name">
/// the name of the new offset
/// </param>
/// <param name="value">
/// the value for the new offset
/// </param>

	public static T AddOffsetValue<T>(this T self, string name, double value) where T : GtkLevelBarHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkLevelBarHandle)");
		GtkLevelBarHandleExterns.gtk_level_bar_add_offset_value(self, name, value);
		return self;
	}

/// <summary>
/// <para>
/// Return the value of the #GtkLevelBar:inverted property.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkLevelBar
/// </param>
/// <return>
/// %TRUE if the level bar is inverted
/// </return>

	public static bool GetInverted(this MentorLake.Gtk.GtkLevelBarHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkLevelBarHandle)");
		return GtkLevelBarHandleExterns.gtk_level_bar_get_inverted(self);
	}

/// <summary>
/// <para>
/// Returns the value of the #GtkLevelBar:max-value property.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkLevelBar
/// </param>
/// <return>
/// a positive value
/// </return>

	public static double GetMaxValue(this MentorLake.Gtk.GtkLevelBarHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkLevelBarHandle)");
		return GtkLevelBarHandleExterns.gtk_level_bar_get_max_value(self);
	}

/// <summary>
/// <para>
/// Returns the value of the #GtkLevelBar:min-value property.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkLevelBar
/// </param>
/// <return>
/// a positive value
/// </return>

	public static double GetMinValue(this MentorLake.Gtk.GtkLevelBarHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkLevelBarHandle)");
		return GtkLevelBarHandleExterns.gtk_level_bar_get_min_value(self);
	}

/// <summary>
/// <para>
/// Returns the value of the #GtkLevelBar:mode property.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkLevelBar
/// </param>
/// <return>
/// a #GtkLevelBarMode
/// </return>

	public static MentorLake.Gtk.GtkLevelBarMode GetMode(this MentorLake.Gtk.GtkLevelBarHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkLevelBarHandle)");
		return GtkLevelBarHandleExterns.gtk_level_bar_get_mode(self);
	}

/// <summary>
/// <para>
/// Fetches the value specified for the offset marker @name in @self,
/// returning %TRUE in case an offset named @name was found.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkLevelBar
/// </param>
/// <param name="name">
/// the name of an offset in the bar
/// </param>
/// <param name="value">
/// location where to store the value
/// </param>
/// <return>
/// %TRUE if the specified offset is found
/// </return>

	public static bool GetOffsetValue(this MentorLake.Gtk.GtkLevelBarHandle self, string name, out double value)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkLevelBarHandle)");
		return GtkLevelBarHandleExterns.gtk_level_bar_get_offset_value(self, name, out value);
	}

/// <summary>
/// <para>
/// Returns the value of the #GtkLevelBar:value property.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkLevelBar
/// </param>
/// <return>
/// a value in the interval between
///     #GtkLevelBar:min-value and #GtkLevelBar:max-value
/// </return>

	public static double GetValue(this MentorLake.Gtk.GtkLevelBarHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkLevelBarHandle)");
		return GtkLevelBarHandleExterns.gtk_level_bar_get_value(self);
	}

/// <summary>
/// <para>
/// Removes an offset marker previously added with
/// gtk_level_bar_add_offset_value().
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkLevelBar
/// </param>
/// <param name="name">
/// the name of an offset in the bar
/// </param>

	public static T RemoveOffsetValue<T>(this T self, string name) where T : GtkLevelBarHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkLevelBarHandle)");
		GtkLevelBarHandleExterns.gtk_level_bar_remove_offset_value(self, name);
		return self;
	}

/// <summary>
/// <para>
/// Sets the value of the #GtkLevelBar:inverted property.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkLevelBar
/// </param>
/// <param name="inverted">
/// %TRUE to invert the level bar
/// </param>

	public static T SetInverted<T>(this T self, bool inverted) where T : GtkLevelBarHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkLevelBarHandle)");
		GtkLevelBarHandleExterns.gtk_level_bar_set_inverted(self, inverted);
		return self;
	}

/// <summary>
/// <para>
/// Sets the value of the #GtkLevelBar:max-value property.
/// </para>
/// <para>
/// You probably want to update preexisting level offsets after calling
/// this function.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkLevelBar
/// </param>
/// <param name="value">
/// a positive value
/// </param>

	public static T SetMaxValue<T>(this T self, double value) where T : GtkLevelBarHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkLevelBarHandle)");
		GtkLevelBarHandleExterns.gtk_level_bar_set_max_value(self, value);
		return self;
	}

/// <summary>
/// <para>
/// Sets the value of the #GtkLevelBar:min-value property.
/// </para>
/// <para>
/// You probably want to update preexisting level offsets after calling
/// this function.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkLevelBar
/// </param>
/// <param name="value">
/// a positive value
/// </param>

	public static T SetMinValue<T>(this T self, double value) where T : GtkLevelBarHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkLevelBarHandle)");
		GtkLevelBarHandleExterns.gtk_level_bar_set_min_value(self, value);
		return self;
	}

/// <summary>
/// <para>
/// Sets the value of the #GtkLevelBar:mode property.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkLevelBar
/// </param>
/// <param name="mode">
/// a #GtkLevelBarMode
/// </param>

	public static T SetMode<T>(this T self, MentorLake.Gtk.GtkLevelBarMode mode) where T : GtkLevelBarHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkLevelBarHandle)");
		GtkLevelBarHandleExterns.gtk_level_bar_set_mode(self, mode);
		return self;
	}

/// <summary>
/// <para>
/// Sets the value of the #GtkLevelBar:value property.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkLevelBar
/// </param>
/// <param name="value">
/// a value in the interval between
///     #GtkLevelBar:min-value and #GtkLevelBar:max-value
/// </param>

	public static T SetValue<T>(this T self, double value) where T : GtkLevelBarHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkLevelBarHandle)");
		GtkLevelBarHandleExterns.gtk_level_bar_set_value(self, value);
		return self;
	}

}

internal class GtkLevelBarHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))]
	internal static extern MentorLake.Gtk.GtkLevelBarHandle gtk_level_bar_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))]
	internal static extern MentorLake.Gtk.GtkLevelBarHandle gtk_level_bar_new_for_interval(double min_value, double max_value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_level_bar_add_offset_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, string name, double value);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_level_bar_get_inverted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_level_bar_get_max_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_level_bar_get_min_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkLevelBarMode gtk_level_bar_get_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_level_bar_get_offset_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, string name, out double value);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_level_bar_get_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_level_bar_remove_offset_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_level_bar_set_inverted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, bool inverted);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_level_bar_set_max_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, double value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_level_bar_set_min_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, double value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_level_bar_set_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, MentorLake.Gtk.GtkLevelBarMode mode);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_level_bar_set_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkLevelBarHandle>))] MentorLake.Gtk.GtkLevelBarHandle self, double value);

}
