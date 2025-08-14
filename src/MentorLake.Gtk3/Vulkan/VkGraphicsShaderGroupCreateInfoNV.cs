namespace MentorLake.Vulkan;


public class VkGraphicsShaderGroupCreateInfoNVHandle : BaseSafeHandle
{
}


public static class VkGraphicsShaderGroupCreateInfoNVExtensions
{

	public static VkGraphicsShaderGroupCreateInfoNV Dereference(this VkGraphicsShaderGroupCreateInfoNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkGraphicsShaderGroupCreateInfoNV>(x.DangerousGetHandle());
}
internal class VkGraphicsShaderGroupCreateInfoNVExterns
{
}


public struct VkGraphicsShaderGroupCreateInfoNV
{
}
