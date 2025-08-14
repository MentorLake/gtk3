namespace MentorLake.Vulkan;


public class VkShaderFloatControlsIndependenceKHRHandle : BaseSafeHandle
{
}


public static class VkShaderFloatControlsIndependenceKHRExtensions
{

	public static VkShaderFloatControlsIndependenceKHR Dereference(this VkShaderFloatControlsIndependenceKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderFloatControlsIndependenceKHR>(x.DangerousGetHandle());
}
internal class VkShaderFloatControlsIndependenceKHRExterns
{
}


public struct VkShaderFloatControlsIndependenceKHR
{
}
