namespace MentorLake.Vulkan;


public class VkImageCreateInfoHandle : BaseSafeHandle
{
}


public static class VkImageCreateInfoExtensions
{

	public static VkImageCreateInfo Dereference(this VkImageCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkImageCreateInfo>(x.DangerousGetHandle());
}
internal class VkImageCreateInfoExterns
{
}


public struct VkImageCreateInfo
{
}
