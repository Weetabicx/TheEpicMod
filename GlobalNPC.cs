using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace TheEpicMod.NPCs

{
    public class TheEpicModNPC : GlobalNPC
    {
        public override void OnKill(NPC npc)
        {   
            if (npc.netID == NPCID.Bunny)
            {
                Main.NewText("WHY DID YOU KILL THE BUNNY!!");
            }
            else if (npc.netID == NPCID.Worm)
            {
                Main.NewText("mmm wormm");
            }
        }
    }
}