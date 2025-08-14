namespace MentorLake.Atk;

/// <summary>
/// <para>
/// An AtkStateSet contains the states of an object.
/// </para>
/// <para>
/// An AtkStateSet is a read-only representation of the full set of #AtkStates
/// that apply to an object at a given time. This set is not meant to be
/// modified, but rather created when #atk_object_ref_state_set() is called.
/// </para>
/// </summary>

public class AtkStateSetHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new empty state set.
/// </para>
/// </summary>

/// <return>
/// a new #AtkStateSet
/// </return>

	public static MentorLake.Atk.AtkStateSetHandle New()
	{
		return AtkStateSetHandleExterns.atk_state_set_new();
	}

}

public static class AtkStateSetHandleExtensions
{
/// <summary>
/// <para>
/// Adds the state of the specified type to the state set if it is not already
/// present.
/// </para>
/// <para>
/// Note that because an #AtkStateSet is a read-only object, this method should
/// be used to add a state to a newly-created set which will then be returned by
/// #atk_object_ref_state_set. It should not be used to modify the existing state
/// of an object. See also #atk_object_notify_state_change.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkStateSet
/// </param>
/// <param name="type">
/// an #AtkStateType
/// </param>
/// <return>
/// %TRUE if  the state for @type is not already in @set.
/// </return>

	public static bool AddState(this MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType type)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		return AtkStateSetHandleExterns.atk_state_set_add_state(set, type);
	}

/// <summary>
/// <para>
/// Adds the states of the specified types to the state set.
/// </para>
/// <para>
/// Note that because an #AtkStateSet is a read-only object, this method should
/// be used to add states to a newly-created set which will then be returned by
/// #atk_object_ref_state_set. It should not be used to modify the existing state
/// of an object. See also #atk_object_notify_state_change.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkStateSet
/// </param>
/// <param name="types">
/// an array of #AtkStateType
/// </param>
/// <param name="n_types">
/// The number of elements in the array
/// </param>

	public static T AddStates<T>(this T set, MentorLake.Atk.AtkStateType[] types, int n_types) where T : AtkStateSetHandle
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		AtkStateSetHandleExterns.atk_state_set_add_states(set, types, n_types);
		return set;
	}

/// <summary>
/// <para>
/// Constructs the intersection of the two sets, returning %NULL if the
/// intersection is empty.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkStateSet
/// </param>
/// <param name="compare_set">
/// another #AtkStateSet
/// </param>
/// <return>
/// a new #AtkStateSet which is the intersection of
/// the two sets.
/// </return>

	public static MentorLake.Atk.AtkStateSetHandle AndSets(this MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateSetHandle compare_set)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		return AtkStateSetHandleExterns.atk_state_set_and_sets(set, compare_set);
	}

/// <summary>
/// <para>
/// Removes all states from the state set.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkStateSet
/// </param>

	public static T ClearStates<T>(this T set) where T : AtkStateSetHandle
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		AtkStateSetHandleExterns.atk_state_set_clear_states(set);
		return set;
	}

/// <summary>
/// <para>
/// Checks whether the state for the specified type is in the specified set.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkStateSet
/// </param>
/// <param name="type">
/// an #AtkStateType
/// </param>
/// <return>
/// %TRUE if @type is the state type is in @set.
/// </return>

	public static bool ContainsState(this MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType type)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		return AtkStateSetHandleExterns.atk_state_set_contains_state(set, type);
	}

/// <summary>
/// <para>
/// Checks whether the states for all the specified types are in the
/// specified set.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkStateSet
/// </param>
/// <param name="types">
/// an array of #AtkStateType
/// </param>
/// <param name="n_types">
/// The number of elements in the array
/// </param>
/// <return>
/// %TRUE if all the states for @type are in @set.
/// </return>

	public static bool ContainsStates(this MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType[] types, int n_types)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		return AtkStateSetHandleExterns.atk_state_set_contains_states(set, types, n_types);
	}

/// <summary>
/// <para>
/// Checks whether the state set is empty, i.e. has no states set.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkStateType
/// </param>
/// <return>
/// %TRUE if @set has no states set, otherwise %FALSE
/// </return>

	public static bool IsEmpty(this MentorLake.Atk.AtkStateSetHandle set)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		return AtkStateSetHandleExterns.atk_state_set_is_empty(set);
	}

/// <summary>
/// <para>
/// Constructs the union of the two sets.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkStateSet
/// </param>
/// <param name="compare_set">
/// another #AtkStateSet
/// </param>
/// <return>
/// a new #AtkStateSet which is
/// the union of the two sets, returning %NULL is empty.
/// </return>

	public static MentorLake.Atk.AtkStateSetHandle OrSets(this MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateSetHandle compare_set)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		return AtkStateSetHandleExterns.atk_state_set_or_sets(set, compare_set);
	}

/// <summary>
/// <para>
/// Removes the state for the specified type from the state set.
/// </para>
/// <para>
/// Note that because an #AtkStateSet is a read-only object, this method should
/// be used to remove a state to a newly-created set which will then be returned
/// by #atk_object_ref_state_set. It should not be used to modify the existing
/// state of an object. See also #atk_object_notify_state_change.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkStateSet
/// </param>
/// <param name="type">
/// an #AtkType
/// </param>
/// <return>
/// %TRUE if @type was the state type is in @set.
/// </return>

	public static bool RemoveState(this MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType type)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		return AtkStateSetHandleExterns.atk_state_set_remove_state(set, type);
	}

/// <summary>
/// <para>
/// Constructs the exclusive-or of the two sets, returning %NULL is empty.
/// The set returned by this operation contains the states in exactly
/// one of the two sets.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkStateSet
/// </param>
/// <param name="compare_set">
/// another #AtkStateSet
/// </param>
/// <return>
/// a new #AtkStateSet which contains the states
/// which are in exactly one of the two sets.
/// </return>

	public static MentorLake.Atk.AtkStateSetHandle XorSets(this MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateSetHandle compare_set)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkStateSetHandle)");
		return AtkStateSetHandleExterns.atk_state_set_xor_sets(set, compare_set);
	}

}

internal class AtkStateSetHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))]
	internal static extern MentorLake.Atk.AtkStateSetHandle atk_state_set_new();

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_state_set_add_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType type);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_state_set_add_states([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType[] types, int n_types);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))]
	internal static extern MentorLake.Atk.AtkStateSetHandle atk_state_set_and_sets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle compare_set);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_state_set_clear_states([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_state_set_contains_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType type);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_state_set_contains_states([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType[] types, int n_types);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_state_set_is_empty([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))]
	internal static extern MentorLake.Atk.AtkStateSetHandle atk_state_set_or_sets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle compare_set);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_state_set_remove_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set, MentorLake.Atk.AtkStateType type);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))]
	internal static extern MentorLake.Atk.AtkStateSetHandle atk_state_set_xor_sets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkStateSetHandle>))] MentorLake.Atk.AtkStateSetHandle compare_set);

}
