namespace MentorLake.Vulkan;


public class VkShaderGroupShaderKHRHandle : BaseSafeHandle
{
}


public static class VkShaderGroupShaderKHRExtensions
{

	public static VkShaderGroupShaderKHR Dereference(this VkShaderGroupShaderKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderGroupShaderKHR>(x.DangerousGetHandle());
}
internal class VkShaderGroupShaderKHRExterns
{
}


public struct VkShaderGroupShaderKHR
{
}
