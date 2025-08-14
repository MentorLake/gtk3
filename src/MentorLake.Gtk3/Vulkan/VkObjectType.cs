namespace MentorLake.Vulkan;


public class VkObjectTypeHandle : BaseSafeHandle
{
}


public static class VkObjectTypeExtensions
{

	public static VkObjectType Dereference(this VkObjectTypeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkObjectType>(x.DangerousGetHandle());
}
internal class VkObjectTypeExterns
{
}


public struct VkObjectType
{
}
