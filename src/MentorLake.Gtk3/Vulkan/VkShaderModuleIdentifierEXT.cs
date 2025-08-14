namespace MentorLake.Vulkan;


public class VkShaderModuleIdentifierEXTHandle : BaseSafeHandle
{
}


public static class VkShaderModuleIdentifierEXTExtensions
{

	public static VkShaderModuleIdentifierEXT Dereference(this VkShaderModuleIdentifierEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkShaderModuleIdentifierEXT>(x.DangerousGetHandle());
}
internal class VkShaderModuleIdentifierEXTExterns
{
}


public struct VkShaderModuleIdentifierEXT
{
}
