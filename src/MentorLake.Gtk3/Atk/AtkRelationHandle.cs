namespace MentorLake.Atk;

/// <summary>
/// <para>
/// An object used to describe a relation between a
///  object and one or more other objects.
/// </para>
/// <para>
/// An AtkRelation describes a relation between an object and one or
/// more other objects. The actual relations that an object has with
/// other objects are defined as an AtkRelationSet, which is a set of
/// AtkRelations.
/// </para>
/// </summary>

public class AtkRelationHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Create a new relation for the specified key and the specified list
/// of targets.  See also atk_object_add_relationship().
/// </para>
/// </summary>

/// <param name="targets">
/// an array of pointers to
///  #AtkObjects
/// </param>
/// <param name="n_targets">
/// number of #AtkObjects pointed to by @targets
/// </param>
/// <param name="relationship">
/// an #AtkRelationType with which to create the new
///  #AtkRelation
/// </param>
/// <return>
/// a pointer to a new #AtkRelation
/// </return>

	public static MentorLake.Atk.AtkRelationHandle New(MentorLake.Atk.AtkObjectHandle[] targets, int n_targets, MentorLake.Atk.AtkRelationType relationship)
	{
		return AtkRelationHandleExterns.atk_relation_new(targets, n_targets, relationship);
	}

}

public static class AtkRelationHandleExtensions
{
/// <summary>
/// <para>
/// Adds the specified AtkObject to the target for the relation, if it is
/// not already present.  See also atk_object_add_relationship().
/// </para>
/// </summary>

/// <param name="relation">
/// an #AtkRelation
/// </param>
/// <param name="target">
/// an #AtkObject
/// </param>

	public static T AddTarget<T>(this T relation, MentorLake.Atk.AtkObjectHandle target) where T : AtkRelationHandle
	{
		if (relation.IsInvalid) throw new Exception("Invalid handle (AtkRelationHandle)");
		AtkRelationHandleExterns.atk_relation_add_target(relation, target);
		return relation;
	}

/// <summary>
/// <para>
/// Gets the type of @relation
/// </para>
/// </summary>

/// <param name="relation">
/// an #AtkRelation
/// </param>
/// <return>
/// the type of @relation
/// </return>

	public static MentorLake.Atk.AtkRelationType GetRelationType(this MentorLake.Atk.AtkRelationHandle relation)
	{
		if (relation.IsInvalid) throw new Exception("Invalid handle (AtkRelationHandle)");
		return AtkRelationHandleExterns.atk_relation_get_relation_type(relation);
	}

/// <summary>
/// <para>
/// Gets the target list of @relation
/// </para>
/// </summary>

/// <param name="relation">
/// an #AtkRelation
/// </param>
/// <return>
/// the target list of @relation
/// </return>

	public static MentorLake.GLib.GPtrArrayHandle GetTarget(this MentorLake.Atk.AtkRelationHandle relation)
	{
		if (relation.IsInvalid) throw new Exception("Invalid handle (AtkRelationHandle)");
		return AtkRelationHandleExterns.atk_relation_get_target(relation);
	}

/// <summary>
/// <para>
/// Remove the specified AtkObject from the target for the relation.
/// </para>
/// </summary>

/// <param name="relation">
/// an #AtkRelation
/// </param>
/// <param name="target">
/// an #AtkObject
/// </param>
/// <return>
/// TRUE if the removal is successful.
/// </return>

	public static bool RemoveTarget(this MentorLake.Atk.AtkRelationHandle relation, MentorLake.Atk.AtkObjectHandle target)
	{
		if (relation.IsInvalid) throw new Exception("Invalid handle (AtkRelationHandle)");
		return AtkRelationHandleExterns.atk_relation_remove_target(relation, target);
	}

}

internal class AtkRelationHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkRelationHandle>))]
	internal static extern MentorLake.Atk.AtkRelationHandle atk_relation_new([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.Struct, SizeParamIndex = 1, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle[] targets, int n_targets, MentorLake.Atk.AtkRelationType relationship);

	[DllImport(AtkLibrary.Name)]
	internal static extern void atk_relation_add_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationHandle>))] MentorLake.Atk.AtkRelationHandle relation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle target);

	[DllImport(AtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkRelationType atk_relation_get_relation_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationHandle>))] MentorLake.Atk.AtkRelationHandle relation);

	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GPtrArrayHandle>))]
	internal static extern MentorLake.GLib.GPtrArrayHandle atk_relation_get_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationHandle>))] MentorLake.Atk.AtkRelationHandle relation);

	[DllImport(AtkLibrary.Name)]
	internal static extern bool atk_relation_remove_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRelationHandle>))] MentorLake.Atk.AtkRelationHandle relation, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkObjectHandle>))] MentorLake.Atk.AtkObjectHandle target);

}
