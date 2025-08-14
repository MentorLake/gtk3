namespace MentorLake.Atk;

/// <summary>
/// <para>
/// A set of AtkRelations, normally the set of
///  AtkRelations which an AtkObject has.
/// </para>
/// <para>
/// The AtkRelationSet held by an object establishes its relationships
/// with objects beyond the normal "parent/child" hierarchical
/// relationships that all user interface objects have.
/// AtkRelationSets establish whether objects are labelled or
/// controlled by other components, share group membership with other
/// components (for instance within a radio-button group), or share
/// content which "flows" between them, among other types of possible
/// relationships.
/// </para>
/// </summary>

public class AtkRelationSetHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new empty relation set.
/// </para>
/// </summary>

/// <return>
/// a new #AtkRelationSet
/// </return>

	public static MentorLake.Atk.AtkRelationSetHandle New()
	{
		return AtkRelationSetHandleExterns.atk_relation_set_new();
	}

}

public static class AtkRelationSetHandleExtensions
{
/// <summary>
/// <para>
/// Add a new relation to the current relation set if it is not already
/// present.
/// This function ref's the AtkRelation so the caller of this function
/// should unref it to ensure that it will be destroyed when the AtkRelationSet
/// is destroyed.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkRelationSet
/// </param>
/// <param name="relation">
/// an #AtkRelation
/// </param>

	public static T Add<T>(this T set, MentorLake.Atk.AtkRelationHandle relation) where T : AtkRelationSetHandle
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkRelationSetHandle)");
		AtkRelationSetHandleExterns.atk_relation_set_add(set, relation);
		return set;
	}

/// <summary>
/// <para>
/// Add a new relation of the specified type with the specified target to
/// the current relation set if the relation set does not contain a relation
/// of that type. If it is does contain a relation of that typea the target
/// is added to the relation.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkRelationSet
/// </param>
/// <param name="relationship">
/// an #AtkRelationType
/// </param>
/// <param name="target">
/// an #AtkObject
/// </param>

	public static T AddRelationByType<T>(this T set, MentorLake.Atk.AtkRelationType relationship, MentorLake.Atk.AtkObjectHandle target) where T : AtkRelationSetHandle
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkRelationSetHandle)");
		AtkRelationSetHandleExterns.atk_relation_set_add_relation_by_type(set, relationship, target);
		return set;
	}

/// <summary>
/// <para>
/// Determines whether the relation set contains a relation that matches the
/// specified type.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkRelationSet
/// </param>
/// <param name="relationship">
/// an #AtkRelationType
/// </param>
/// <return>
/// %TRUE if @relationship is the relationship type of a relation
/// in @set, %FALSE otherwise
/// </return>

	public static bool Contains(this MentorLake.Atk.AtkRelationSetHandle set, MentorLake.Atk.AtkRelationType relationship)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkRelationSetHandle)");
		return AtkRelationSetHandleExterns.atk_relation_set_contains(set, relationship);
	}

/// <summary>
/// <para>
/// Determines whether the relation set contains a relation that
/// matches the specified pair formed by type @relationship and object
/// @target.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkRelationSet
/// </param>
/// <param name="relationship">
/// an #AtkRelationType
/// </param>
/// <param name="target">
/// an #AtkObject
/// </param>
/// <return>
/// %TRUE if @set contains a relation with the relationship
/// type @relationship with an object @target, %FALSE otherwise
/// </return>

	public static bool ContainsTarget(this MentorLake.Atk.AtkRelationSetHandle set, MentorLake.Atk.AtkRelationType relationship, MentorLake.Atk.AtkObjectHandle target)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkRelationSetHandle)");
		return AtkRelationSetHandleExterns.atk_relation_set_contains_target(set, relationship, target);
	}

/// <summary>
/// <para>
/// Determines the number of relations in a relation set.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkRelationSet
/// </param>
/// <return>
/// an integer representing the number of relations in the set.
/// </return>

	public static int GetNRelations(this MentorLake.Atk.AtkRelationSetHandle set)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkRelationSetHandle)");
		return AtkRelationSetHandleExterns.atk_relation_set_get_n_relations(set);
	}

/// <summary>
/// <para>
/// Determines the relation at the specified position in the relation set.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkRelationSet
/// </param>
/// <param name="i">
/// a gint representing a position in the set, starting from 0.
/// </param>
/// <return>
/// a #AtkRelation, which is the relation at
/// position i in the set.
/// </return>

	public static MentorLake.Atk.AtkRelationHandle GetRelation(this MentorLake.Atk.AtkRelationSetHandle set, int i)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkRelationSetHandle)");
		return AtkRelationSetHandleExterns.atk_relation_set_get_relation(set, i);
	}

/// <summary>
/// <para>
/// Finds a relation that matches the specified type.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkRelationSet
/// </param>
/// <param name="relationship">
/// an #AtkRelationType
/// </param>
/// <return>
/// an #AtkRelation, which is a relation matching the
/// specified type.
/// </return>

	public static MentorLake.Atk.AtkRelationHandle GetRelationByType(this MentorLake.Atk.AtkRelationSetHandle set, MentorLake.Atk.AtkRelationType relationship)
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkRelationSetHandle)");
		return AtkRelationSetHandleExterns.atk_relation_set_get_relation_by_type(set, relationship);
	}

/// <summary>
/// <para>
/// Removes a relation from the relation set.
/// This function unref's the #AtkRelation so it will be deleted unless there
/// is another reference to it.
/// </para>
/// </summary>

/// <param name="set">
/// an #AtkRelationSet
/// </param>
/// <param name="relation">
/// an #AtkRelation
/// </param>

	public static T Remove<T>(this T set, MentorLake.Atk.AtkRelationHandle relation) where T : AtkRelationSetHandle
	{
		if (set.IsInvalid) throw new Exception("Invalid handle (AtkRelationSetHandle)");
		AtkRelationSetHandleExterns.atk_relation_set_remove(set, relation);
		return set;
	}

}

internal class AtkRelationSetHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))]
	internal static extern MentorLake.Atk.AtkRelationSetHandle atk_relation_set_new();

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_relation_set_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationHandle>))] MentorLake.Atk.AtkRelationHandle relation);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_relation_set_add_relation_by_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle set, MentorLake.Atk.AtkRelationType relationship, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle target);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_relation_set_contains([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle set, MentorLake.Atk.AtkRelationType relationship);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_relation_set_contains_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle set, MentorLake.Atk.AtkRelationType relationship, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle target);

	[DllImport(AtkLibrary.Name)]
	internal static extern int atk_relation_set_get_n_relations([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle set);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationHandle>))]
	internal static extern MentorLake.Atk.AtkRelationHandle atk_relation_set_get_relation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle set, int i);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationHandle>))]
	internal static extern MentorLake.Atk.AtkRelationHandle atk_relation_set_get_relation_by_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle set, MentorLake.Atk.AtkRelationType relationship);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_relation_set_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationSetHandle>))] MentorLake.Atk.AtkRelationSetHandle set, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationHandle>))] MentorLake.Atk.AtkRelationHandle relation);

}
