namespace MentorLake.Vulkan;

public class VkPipelineCompilerControlFlagsAMDHandle : BaseSafeHandle
{
}


public static class VkPipelineCompilerControlFlagsAMDExtensions
{

	public static VkPipelineCompilerControlFlagsAMD Dereference(this VkPipelineCompilerControlFlagsAMDHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelineCompilerControlFlagsAMD>(x.DangerousGetHandle());
}
internal class VkPipelineCompilerControlFlagsAMDExterns
{
}

public struct VkPipelineCompilerControlFlagsAMD
{
}
