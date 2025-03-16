namespace MentorLake.Vulkan;

public class VkPipelinePropertiesIdentifierEXTHandle : BaseSafeHandle
{
}


public static class VkPipelinePropertiesIdentifierEXTExtensions
{

	public static VkPipelinePropertiesIdentifierEXT Dereference(this VkPipelinePropertiesIdentifierEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkPipelinePropertiesIdentifierEXT>(x.DangerousGetHandle());
}
internal class VkPipelinePropertiesIdentifierEXTExterns
{
}

public struct VkPipelinePropertiesIdentifierEXT
{
}
