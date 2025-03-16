namespace MentorLake.Vulkan;

public class VkShaderCorePropertiesFlagBitsAMDHandle : BaseSafeHandle
{
}


public static class VkShaderCorePropertiesFlagBitsAMDExtensions
{

	public static VkShaderCorePropertiesFlagBitsAMD Dereference(this VkShaderCorePropertiesFlagBitsAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderCorePropertiesFlagBitsAMD>(x.DangerousGetHandle());
}
internal class VkShaderCorePropertiesFlagBitsAMDExterns
{
}

public struct VkShaderCorePropertiesFlagBitsAMD
{
}
