using Terraria.ModLoader;
using Terraria;
namespace uniquemusicboxes
{
    public class uniquemusicboxes : Mod
    {
		public override void Load()
		{
			if (!Main.dedServ) {
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Tunak"), ItemType("dngs"), TileType("dngsTile"));
			}
		}
	}
}