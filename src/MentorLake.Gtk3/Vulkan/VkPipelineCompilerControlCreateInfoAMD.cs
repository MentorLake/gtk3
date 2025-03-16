namespace MentorLake.Vulkan;

public class VkPipelineCompilerControlCreateInfoAMDHandle : BaseSafeHandle
{
}


public static class VkPipelineCompilerControlCreateInfoAMDExtensions
{

	public static VkPipelineCompilerControlCreateInfoAMD Dereference(this VkPipelineCompilerControlCreateInfoAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCompilerControlCreateInfoAMD>(x.DangerousGetHandle());
}
internal class VkPipelineCompilerControlCreateInfoAMDExterns
{
}

public struct VkPipelineCompilerControlCreateInfoAMD
{
}
