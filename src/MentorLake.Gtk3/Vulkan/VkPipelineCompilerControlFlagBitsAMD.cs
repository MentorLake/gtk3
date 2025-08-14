namespace MentorLake.Vulkan;


public class VkPipelineCompilerControlFlagBitsAMDHandle : BaseSafeHandle
{
}


public static class VkPipelineCompilerControlFlagBitsAMDExtensions
{

	public static VkPipelineCompilerControlFlagBitsAMD Dereference(this VkPipelineCompilerControlFlagBitsAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCompilerControlFlagBitsAMD>(x.DangerousGetHandle());
}
internal class VkPipelineCompilerControlFlagBitsAMDExterns
{
}


public struct VkPipelineCompilerControlFlagBitsAMD
{
}
