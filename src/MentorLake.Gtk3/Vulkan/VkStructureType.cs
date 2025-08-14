namespace MentorLake.Vulkan;


public class VkStructureTypeHandle : BaseSafeHandle
{
}


public static class VkStructureTypeExtensions
{

	public static VkStructureType Dereference(this VkStructureTypeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkStructureType>(x.DangerousGetHandle());
}
internal class VkStructureTypeExterns
{
}


public struct VkStructureType
{
}
