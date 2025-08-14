namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// A #GdkKeymap defines the translation from keyboard state
/// (including a hardware key, a modifier mask, and active keyboard group)
/// to a keyval. This translation has two phases. The first phase is
/// to determine the effective keyboard group and level for the keyboard
/// state; the second phase is to look up the keycode/group/level triplet
/// in the keymap and see what keyval it corresponds to.
/// </para>
/// </summary>

public class GdkKeymapHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Returns the #GdkKeymap attached to the default display.
/// </para>
/// </summary>

/// <return>
/// the #GdkKeymap attached to the default display.
/// </return>

	public static MentorLake.Gdk.GdkKeymapHandle GetDefault()
	{
		return GdkKeymapHandleExterns.gdk_keymap_get_default();
	}

/// <summary>
/// <para>
/// Returns the #GdkKeymap attached to @display.
/// </para>
/// </summary>

/// <param name="display">
/// the #GdkDisplay.
/// </param>
/// <return>
/// the #GdkKeymap attached to @display.
/// </return>

	public static MentorLake.Gdk.GdkKeymapHandle GetForDisplay(MentorLake.Gdk.GdkDisplayHandle display)
	{
		return GdkKeymapHandleExterns.gdk_keymap_get_for_display(display);
	}

}
public static class GdkKeymapHandleSignalExtensions
{
/// <summary>
/// <para>
/// The ::direction-changed signal gets emitted when the direction of
/// the keymap changes.
/// </para>
/// </summary>

	public static IObservable<GdkKeymapHandleSignalStructs.DirectionChangedSignal> Signal_DirectionChanged(this GdkKeymapHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkKeymapHandleSignalStructs.DirectionChangedSignal> obs) =>
		{
			GdkKeymapHandleSignalDelegates.direction_changed handler = ( MentorLake.Gdk.GdkKeymapHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkKeymapHandleSignalStructs.DirectionChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "direction-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// The ::keys-changed signal is emitted when the mapping represented by
/// @keymap changes.
/// </para>
/// </summary>

	public static IObservable<GdkKeymapHandleSignalStructs.KeysChangedSignal> Signal_KeysChanged(this GdkKeymapHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkKeymapHandleSignalStructs.KeysChangedSignal> obs) =>
		{
			GdkKeymapHandleSignalDelegates.keys_changed handler = ( MentorLake.Gdk.GdkKeymapHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkKeymapHandleSignalStructs.KeysChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "keys-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
/// <summary>
/// <para>
/// The ::state-changed signal is emitted when the state of the
/// keyboard changes, e.g when Caps Lock is turned on or off.
/// See gdk_keymap_get_caps_lock_state().
/// </para>
/// </summary>

	public static IObservable<GdkKeymapHandleSignalStructs.StateChangedSignal> Signal_StateChanged(this GdkKeymapHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GdkKeymapHandleSignalStructs.StateChangedSignal> obs) =>
		{
			GdkKeymapHandleSignalDelegates.state_changed handler = ( MentorLake.Gdk.GdkKeymapHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GdkKeymapHandleSignalStructs.StateChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "state-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GdkKeymapHandleSignalStructs
{

public class DirectionChangedSignal
{

	public MentorLake.Gdk.GdkKeymapHandle Self;

	public IntPtr UserData;
}

public class KeysChangedSignal
{

	public MentorLake.Gdk.GdkKeymapHandle Self;

	public IntPtr UserData;
}

public class StateChangedSignal
{

	public MentorLake.Gdk.GdkKeymapHandle Self;

	public IntPtr UserData;
}
}

public static class GdkKeymapHandleSignalDelegates
{

/// <summary>
/// <para>
/// The ::direction-changed signal gets emitted when the direction of
/// the keymap changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void direction_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::keys-changed signal is emitted when the mapping represented by
/// @keymap changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void keys_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The ::state-changed signal is emitted when the state of the
/// keyboard changes, e.g when Caps Lock is turned on or off.
/// See gdk_keymap_get_caps_lock_state().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle self, IntPtr user_data);

}


public static class GdkKeymapHandleExtensions
{
/// <summary>
/// <para>
/// Maps the non-virtual modifiers (i.e Mod2, Mod3, ...) which are set
/// in @state to the virtual modifiers (i.e. Super, Hyper and Meta) and
/// set the corresponding bits in @state.
/// </para>
/// <para>
/// GDK already does this before delivering key events, but for
/// compatibility reasons, it only sets the first virtual modifier
/// it finds, whereas this function sets all matching virtual modifiers.
/// </para>
/// <para>
/// This function is useful when matching key events against
/// accelerators.
/// </para>
/// </summary>

/// <param name="keymap">
/// a #GdkKeymap
/// </param>
/// <param name="state">
/// pointer to the modifier mask to change
/// </param>

	public static T AddVirtualModifiers<T>(this T keymap, ref MentorLake.Gdk.GdkModifierType state) where T : GdkKeymapHandle
	{
		if (keymap.IsInvalid) throw new Exception("Invalid handle (GdkKeymapHandle)");
		GdkKeymapHandleExterns.gdk_keymap_add_virtual_modifiers(keymap, ref state);
		return keymap;
	}

/// <summary>
/// <para>
/// Returns whether the Caps Lock modifer is locked.
/// </para>
/// </summary>

/// <param name="keymap">
/// a #GdkKeymap
/// </param>
/// <return>
/// %TRUE if Caps Lock is on
/// </return>

	public static bool GetCapsLockState(this MentorLake.Gdk.GdkKeymapHandle keymap)
	{
		if (keymap.IsInvalid) throw new Exception("Invalid handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_get_caps_lock_state(keymap);
	}

/// <summary>
/// <para>
/// Returns the direction of effective layout of the keymap.
/// </para>
/// </summary>

/// <param name="keymap">
/// a #GdkKeymap
/// </param>
/// <return>
/// %PANGO_DIRECTION_LTR or %PANGO_DIRECTION_RTL
///   if it can determine the direction. %PANGO_DIRECTION_NEUTRAL
///   otherwise.
/// </return>

	public static MentorLake.Pango.PangoDirection GetDirection(this MentorLake.Gdk.GdkKeymapHandle keymap)
	{
		if (keymap.IsInvalid) throw new Exception("Invalid handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_get_direction(keymap);
	}

/// <summary>
/// <para>
/// Returns the keyvals bound to @hardware_keycode.
/// The Nth #GdkKeymapKey in @keys is bound to the Nth
/// keyval in @keyvals. Free the returned arrays with g_free().
/// When a keycode is pressed by the user, the keyval from
/// this list of entries is selected by considering the effective
/// keyboard group and level. See gdk_keymap_translate_keyboard_state().
/// </para>
/// </summary>

/// <param name="keymap">
/// a #GdkKeymap
/// </param>
/// <param name="hardware_keycode">
/// a keycode
/// </param>
/// <param name="keys">
/// return
///     location for array of #GdkKeymapKey, or %NULL
/// </param>
/// <param name="keyvals">
/// return
///     location for array of keyvals, or %NULL
/// </param>
/// <param name="n_entries">
/// length of @keys and @keyvals
/// </param>
/// <return>
/// %TRUE if there were any entries
/// </return>

	public static bool GetEntriesForKeycode(this MentorLake.Gdk.GdkKeymapHandle keymap, uint hardware_keycode, out MentorLake.Gdk.GdkKeymapKey[] keys, out uint[] keyvals, out int n_entries)
	{
		if (keymap.IsInvalid) throw new Exception("Invalid handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_get_entries_for_keycode(keymap, hardware_keycode, out keys, out keyvals, out n_entries);
	}

/// <summary>
/// <para>
/// Obtains a list of keycode/group/level combinations that will
/// generate @keyval. Groups and levels are two kinds of keyboard mode;
/// in general, the level determines whether the top or bottom symbol
/// on a key is used, and the group determines whether the left or
/// right symbol is used. On US keyboards, the shift key changes the
/// keyboard level, and there are no groups. A group switch key might
/// convert a keyboard between Hebrew to English modes, for example.
/// #GdkEventKey contains a %group field that indicates the active
/// keyboard group. The level is computed from the modifier mask.
/// The returned array should be freed
/// with g_free().
/// </para>
/// </summary>

/// <param name="keymap">
/// a #GdkKeymap
/// </param>
/// <param name="keyval">
/// a keyval, such as %GDK_KEY_a, %GDK_KEY_Up, %GDK_KEY_Return, etc.
/// </param>
/// <param name="keys">
/// return location
///     for an array of #GdkKeymapKey
/// </param>
/// <param name="n_keys">
/// return location for number of elements in returned array
/// </param>
/// <return>
/// %TRUE if keys were found and returned
/// </return>

	public static bool GetEntriesForKeyval(this MentorLake.Gdk.GdkKeymapHandle keymap, uint keyval, out MentorLake.Gdk.GdkKeymapKey[] keys, out int n_keys)
	{
		if (keymap.IsInvalid) throw new Exception("Invalid handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_get_entries_for_keyval(keymap, keyval, out keys, out n_keys);
	}

/// <summary>
/// <para>
/// Returns the modifier mask the @keymap’s windowing system backend
/// uses for a particular purpose.
/// </para>
/// <para>
/// Note that this function always returns real hardware modifiers, not
/// virtual ones (e.g. it will return #GDK_MOD1_MASK rather than
/// #GDK_META_MASK if the backend maps MOD1 to META), so there are use
/// cases where the return value of this function has to be transformed
/// by gdk_keymap_add_virtual_modifiers() in order to contain the
/// expected result.
/// </para>
/// </summary>

/// <param name="keymap">
/// a #GdkKeymap
/// </param>
/// <param name="intent">
/// the use case for the modifier mask
/// </param>
/// <return>
/// the modifier mask used for @intent.
/// </return>

	public static MentorLake.Gdk.GdkModifierType GetModifierMask(this MentorLake.Gdk.GdkKeymapHandle keymap, MentorLake.Gdk.GdkModifierIntent intent)
	{
		if (keymap.IsInvalid) throw new Exception("Invalid handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_get_modifier_mask(keymap, intent);
	}

/// <summary>
/// <para>
/// Returns the current modifier state.
/// </para>
/// </summary>

/// <param name="keymap">
/// a #GdkKeymap
/// </param>
/// <return>
/// the current modifier state.
/// </return>

	public static uint GetModifierState(this MentorLake.Gdk.GdkKeymapHandle keymap)
	{
		if (keymap.IsInvalid) throw new Exception("Invalid handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_get_modifier_state(keymap);
	}

/// <summary>
/// <para>
/// Returns whether the Num Lock modifer is locked.
/// </para>
/// </summary>

/// <param name="keymap">
/// a #GdkKeymap
/// </param>
/// <return>
/// %TRUE if Num Lock is on
/// </return>

	public static bool GetNumLockState(this MentorLake.Gdk.GdkKeymapHandle keymap)
	{
		if (keymap.IsInvalid) throw new Exception("Invalid handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_get_num_lock_state(keymap);
	}

/// <summary>
/// <para>
/// Returns whether the Scroll Lock modifer is locked.
/// </para>
/// </summary>

/// <param name="keymap">
/// a #GdkKeymap
/// </param>
/// <return>
/// %TRUE if Scroll Lock is on
/// </return>

	public static bool GetScrollLockState(this MentorLake.Gdk.GdkKeymapHandle keymap)
	{
		if (keymap.IsInvalid) throw new Exception("Invalid handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_get_scroll_lock_state(keymap);
	}

/// <summary>
/// <para>
/// Determines if keyboard layouts for both right-to-left and left-to-right
/// languages are in use.
/// </para>
/// </summary>

/// <param name="keymap">
/// a #GdkKeymap
/// </param>
/// <return>
/// %TRUE if there are layouts in both directions, %FALSE otherwise
/// </return>

	public static bool HaveBidiLayouts(this MentorLake.Gdk.GdkKeymapHandle keymap)
	{
		if (keymap.IsInvalid) throw new Exception("Invalid handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_have_bidi_layouts(keymap);
	}

/// <summary>
/// <para>
/// Looks up the keyval mapped to a keycode/group/level triplet.
/// If no keyval is bound to @key, returns 0. For normal user input,
/// you want to use gdk_keymap_translate_keyboard_state() instead of
/// this function, since the effective group/level may not be
/// the same as the current keyboard state.
/// </para>
/// </summary>

/// <param name="keymap">
/// a #GdkKeymap
/// </param>
/// <param name="key">
/// a #GdkKeymapKey with keycode, group, and level initialized
/// </param>
/// <return>
/// a keyval, or 0 if none was mapped to the given @key
/// </return>

	public static uint LookupKey(this MentorLake.Gdk.GdkKeymapHandle keymap, MentorLake.Gdk.GdkKeymapKeyHandle key)
	{
		if (keymap.IsInvalid) throw new Exception("Invalid handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_lookup_key(keymap, key);
	}

/// <summary>
/// <para>
/// Maps the virtual modifiers (i.e. Super, Hyper and Meta) which
/// are set in @state to their non-virtual counterparts (i.e. Mod2,
/// Mod3,...) and set the corresponding bits in @state.
/// </para>
/// <para>
/// This function is useful when matching key events against
/// accelerators.
/// </para>
/// </summary>

/// <param name="keymap">
/// a #GdkKeymap
/// </param>
/// <param name="state">
/// pointer to the modifier state to map
/// </param>
/// <return>
/// %FALSE if two virtual modifiers were mapped to the
///     same non-virtual modifier. Note that %FALSE is also returned
///     if a virtual modifier is mapped to a non-virtual modifier that
///     was already set in @state.
/// </return>

	public static bool MapVirtualModifiers(this MentorLake.Gdk.GdkKeymapHandle keymap, ref MentorLake.Gdk.GdkModifierType state)
	{
		if (keymap.IsInvalid) throw new Exception("Invalid handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_map_virtual_modifiers(keymap, ref state);
	}

/// <summary>
/// <para>
/// Translates the contents of a #GdkEventKey into a keyval, effective
/// group, and level. Modifiers that affected the translation and
/// are thus unavailable for application use are returned in
/// @consumed_modifiers.
/// See [Groups][key-group-explanation] for an explanation of
/// groups and levels. The @effective_group is the group that was
/// actually used for the translation; some keys such as Enter are not
/// affected by the active keyboard group. The @level is derived from
/// @state. For convenience, #GdkEventKey already contains the translated
/// keyval, so this function isn’t as useful as you might think.
/// </para>
/// <para>
/// @consumed_modifiers gives modifiers that should be masked outfrom @state
/// when comparing this key press to a hot key. For instance, on a US keyboard,
/// the `plus` symbol is shifted, so when comparing a key press to a
/// `<Control>plus` accelerator `<Shift>` should be masked out.
/// </para>
/// <para>
/// |[<!-- language="C" -->
/// // We want to ignore irrelevant modifiers like ScrollLock
/// #define ALL_ACCELS_MASK (GDK_CONTROL_MASK | GDK_SHIFT_MASK | GDK_MOD1_MASK)
/// gdk_keymap_translate_keyboard_state (keymap, event->hardware_keycode,
///                                      event->state, event->group,
///                                      &keyval, NULL, NULL, &consumed);
/// if (keyval == GDK_PLUS &&
///     (event->state & ~consumed & ALL_ACCELS_MASK) == GDK_CONTROL_MASK)
///   // Control was pressed
/// ]|
/// </para>
/// <para>
/// An older interpretation @consumed_modifiers was that it contained
/// all modifiers that might affect the translation of the key;
/// this allowed accelerators to be stored with irrelevant consumed
/// modifiers, by doing:
/// |[<!-- language="C" -->
/// // XXX Don’t do this XXX
/// if (keyval == accel_keyval &&
///     (event->state & ~consumed & ALL_ACCELS_MASK) == (accel_mods & ~consumed))
///   // Accelerator was pressed
/// ]|
/// </para>
/// <para>
/// However, this did not work if multi-modifier combinations were
/// used in the keymap, since, for instance, `<Control>` would be
/// masked out even if only `<Control><Alt>` was used in the keymap.
/// To support this usage as well as well as possible, all single
/// modifier combinations that could affect the key for any combination
/// of modifiers will be returned in @consumed_modifiers; multi-modifier
/// combinations are returned only when actually found in @state. When
/// you store accelerators, you should always store them with consumed
/// modifiers removed. Store `<Control>plus`, not `<Control><Shift>plus`,
/// </para>
/// </summary>

/// <param name="keymap">
/// a #GdkKeymap
/// </param>
/// <param name="hardware_keycode">
/// a keycode
/// </param>
/// <param name="state">
/// a modifier state
/// </param>
/// <param name="group">
/// active keyboard group
/// </param>
/// <param name="keyval">
/// return location for keyval, or %NULL
/// </param>
/// <param name="effective_group">
/// return location for effective
///     group, or %NULL
/// </param>
/// <param name="level">
/// return location for level, or %NULL
/// </param>
/// <param name="consumed_modifiers">
/// return location for modifiers
///     that were used to determine the group or level, or %NULL
/// </param>
/// <return>
/// %TRUE if there was a keyval bound to the keycode/state/group
/// </return>

	public static bool TranslateKeyboardState(this MentorLake.Gdk.GdkKeymapHandle keymap, uint hardware_keycode, MentorLake.Gdk.GdkModifierType state, int group, out uint keyval, out int effective_group, out int level, out MentorLake.Gdk.GdkModifierType consumed_modifiers)
	{
		if (keymap.IsInvalid) throw new Exception("Invalid handle (GdkKeymapHandle)");
		return GdkKeymapHandleExterns.gdk_keymap_translate_keyboard_state(keymap, hardware_keycode, state, group, out keyval, out effective_group, out level, out consumed_modifiers);
	}

}

internal class GdkKeymapHandleExterns
{
	[DllImport(GdkLibrary.Name)]
	internal static extern void gdk_keymap_add_virtual_modifiers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap, ref MentorLake.Gdk.GdkModifierType state);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keymap_get_caps_lock_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoDirection gdk_keymap_get_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keymap_get_entries_for_keycode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap, uint hardware_keycode, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out MentorLake.Gdk.GdkKeymapKey[] keys, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 4)] out uint[] keyvals, out int n_entries);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keymap_get_entries_for_keyval([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap, uint keyval, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 3)] out MentorLake.Gdk.GdkKeymapKey[] keys, out int n_keys);

	[DllImport(GdkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkModifierType gdk_keymap_get_modifier_mask([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap, MentorLake.Gdk.GdkModifierIntent intent);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_keymap_get_modifier_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keymap_get_num_lock_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keymap_get_scroll_lock_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keymap_have_bidi_layouts([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap);

	[DllImport(GdkLibrary.Name)]
	internal static extern uint gdk_keymap_lookup_key([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapKeyHandle>))] MentorLake.Gdk.GdkKeymapKeyHandle key);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keymap_map_virtual_modifiers([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap, ref MentorLake.Gdk.GdkModifierType state);

	[DllImport(GdkLibrary.Name)]
	internal static extern bool gdk_keymap_translate_keyboard_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))] MentorLake.Gdk.GdkKeymapHandle keymap, uint hardware_keycode, MentorLake.Gdk.GdkModifierType state, int group, out uint keyval, out int effective_group, out int level, out MentorLake.Gdk.GdkModifierType consumed_modifiers);

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))]
	internal static extern MentorLake.Gdk.GdkKeymapHandle gdk_keymap_get_default();

	[DllImport(GdkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkKeymapHandle>))]
	internal static extern MentorLake.Gdk.GdkKeymapHandle gdk_keymap_get_for_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDisplayHandle>))] MentorLake.Gdk.GdkDisplayHandle display);

}
