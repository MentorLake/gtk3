namespace MentorLake.Vulkan;


public class VkCuModuleCreateInfoNVXHandle : BaseSafeHandle
{
}


public static class VkCuModuleCreateInfoNVXExtensions
{

	public static VkCuModuleCreateInfoNVX Dereference(this VkCuModuleCreateInfoNVXHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCuModuleCreateInfoNVX>(x.DangerousGetHandle());
}
internal class VkCuModuleCreateInfoNVXExterns
{
}


public struct VkCuModuleCreateInfoNVX
{
}
