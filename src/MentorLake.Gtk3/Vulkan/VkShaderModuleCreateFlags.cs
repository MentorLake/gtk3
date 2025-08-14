namespace MentorLake.Vulkan;


public class VkShaderModuleCreateFlagsHandle : BaseSafeHandle
{
}


public static class VkShaderModuleCreateFlagsExtensions
{

	public static VkShaderModuleCreateFlags Dereference(this VkShaderModuleCreateFlagsHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderModuleCreateFlags>(x.DangerousGetHandle());
}
internal class VkShaderModuleCreateFlagsExterns
{
}


public struct VkShaderModuleCreateFlags
{
}
