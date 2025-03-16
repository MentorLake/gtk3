namespace MentorLake.Vulkan;

public class VkCudaLaunchInfoNVHandle : BaseSafeHandle
{
}


public static class VkCudaLaunchInfoNVExtensions
{

	public static VkCudaLaunchInfoNV Dereference(this VkCudaLaunchInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCudaLaunchInfoNV>(x.DangerousGetHandle());
}
internal class VkCudaLaunchInfoNVExterns
{
}

public struct VkCudaLaunchInfoNV
{
}
