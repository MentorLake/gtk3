namespace MentorLake.Vulkan;


public class VkExternalMemoryImageCreateInfoHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryImageCreateInfoExtensions
{

	public static VkExternalMemoryImageCreateInfo Dereference(this VkExternalMemoryImageCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryImageCreateInfo>(x.DangerousGetHandle());
}
internal class VkExternalMemoryImageCreateInfoExterns
{
}


public struct VkExternalMemoryImageCreateInfo
{
}
