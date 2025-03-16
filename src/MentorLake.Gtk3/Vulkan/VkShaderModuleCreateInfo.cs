namespace MentorLake.Vulkan;

public class VkShaderModuleCreateInfoHandle : BaseSafeHandle
{
}


public static class VkShaderModuleCreateInfoExtensions
{

	public static VkShaderModuleCreateInfo Dereference(this VkShaderModuleCreateInfoHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderModuleCreateInfo>(x.DangerousGetHandle());
}
internal class VkShaderModuleCreateInfoExterns
{
}

public struct VkShaderModuleCreateInfo
{
}
