namespace MentorLake.Vulkan;


public class VkExternalMemoryImageCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryImageCreateInfoNVExtensions
{

	public static VkExternalMemoryImageCreateInfoNV Dereference(this VkExternalMemoryImageCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryImageCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkExternalMemoryImageCreateInfoNVExterns
{
}


public struct VkExternalMemoryImageCreateInfoNV
{
}
