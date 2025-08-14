namespace MentorLake.Vulkan;


public class VkBool32Handle : BaseSafeHandle
{
}


public static class VkBool32Extensions
{

	public static VkBool32 Dereference(this VkBool32Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkBool32>(x.DangerousGetHandle());
}
internal class VkBool32Externs
{
}


public struct VkBool32
{
}
