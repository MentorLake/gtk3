namespace MentorLake.Vulkan;


public class VkShaderCorePropertiesFlagsAMDHandle : BaseSafeHandle
{
}


public static class VkShaderCorePropertiesFlagsAMDExtensions
{

	public static VkShaderCorePropertiesFlagsAMD Dereference(this VkShaderCorePropertiesFlagsAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderCorePropertiesFlagsAMD>(x.DangerousGetHandle());
}
internal class VkShaderCorePropertiesFlagsAMDExterns
{
}


public struct VkShaderCorePropertiesFlagsAMD
{
}
