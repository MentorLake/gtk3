namespace MentorLake.Vulkan;


public class VkSamplerAddressModeHandle : BaseSafeHandle
{
}


public static class VkSamplerAddressModeExtensions
{

	public static VkSamplerAddressMode Dereference(this VkSamplerAddressModeHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerAddressMode>(x.DangerousGetHandle());
}
internal class VkSamplerAddressModeExterns
{
}


public struct VkSamplerAddressMode
{
}
