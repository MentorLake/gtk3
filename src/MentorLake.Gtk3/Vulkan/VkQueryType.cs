namespace MentorLake.Vulkan;


public class VkQueryTypeHandle : BaseSafeHandle
{
}


public static class VkQueryTypeExtensions
{

	public static VkQueryType Dereference(this VkQueryTypeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueryType>(x.DangerousGetHandle());
}
internal class VkQueryTypeExterns
{
}


public struct VkQueryType
{
}
