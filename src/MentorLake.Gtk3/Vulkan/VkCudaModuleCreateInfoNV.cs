namespace MentorLake.Vulkan;


public class VkCudaModuleCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkCudaModuleCreateInfoNVExtensions
{

	public static VkCudaModuleCreateInfoNV Dereference(this VkCudaModuleCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCudaModuleCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkCudaModuleCreateInfoNVExterns
{
}


public struct VkCudaModuleCreateInfoNV
{
}
