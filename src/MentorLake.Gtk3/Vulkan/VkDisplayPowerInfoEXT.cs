namespace MentorLake.Vulkan;


public class VkDisplayPowerInfoEXTHandle : BaseSafeHandle
{
}


public static class VkDisplayPowerInfoEXTExtensions
{

	public static VkDisplayPowerInfoEXT Dereference(this VkDisplayPowerInfoEXTHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayPowerInfoEXT>(x.DangerousGetHandle());
}
internal class VkDisplayPowerInfoEXTExterns
{
}


public struct VkDisplayPowerInfoEXT
{
}
