namespace MentorLake.Vulkan;

public class VkSamplerBlockMatchWindowCreateInfoQCOMHandle : BaseSafeHandle
{
}


public static class VkSamplerBlockMatchWindowCreateInfoQCOMExtensions
{

	public static VkSamplerBlockMatchWindowCreateInfoQCOM Dereference(this VkSamplerBlockMatchWindowCreateInfoQCOMHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSamplerBlockMatchWindowCreateInfoQCOM>(x.DangerousGetHandle());
}
internal class VkSamplerBlockMatchWindowCreateInfoQCOMExterns
{
}

public struct VkSamplerBlockMatchWindowCreateInfoQCOM
{
}
